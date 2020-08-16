using HNKWindowsForms.Auxiliary;
using HNKInfrastructure.Api;
using HNKCore.Proto;
using System;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HNKWindowsForms.Forms {
    public partial class FrmMenuManager : Form {
        public FrmMenuManager() {
            InitializeComponent();
            serializer_ = new JavaScriptSerializer();
            service_ = new MenuServiceClient(AppManager.GetInstance().ApiUrl + "menuservices/");
            Init();
        }
        public void Init() {
            int i = 1;
            Assembly current = Assembly.GetExecutingAssembly();
            current.GetExportedTypes()
                .Where(p => p.FullName.Contains("Application"))
                .ToList()
                ?.ForEach((type) => {
                    TargetClassPath.Items.Add(new ComboItem(type.FullName, i++));
                });
            TargetClassPath.Items.Add(new ComboItem("添加作为1级菜单", 0));

            ResponseModel response = service_.GetMenus();
            if (response.Code == 1 && response.DataCount >= 1) {
                menus_ = serializer_.Deserialize<List<Menus>>(serializer_.Serialize(response.Data));
                //必须先把1级菜单全部添加完毕,否则
                //下面根据ParentName字段寻找父节点时可能找不到正确的父节点
                foreach (Menus menu in menus_.Where(p => p.ParentId == 0)){
                    MenusTree.Nodes.Add(menu.MenuName);
                }
                foreach(Menus menu in menus_.Where(p => p.ParentId != 0)) {
                    TreeNode parentNode = MenusTree.Nodes[menu.ParentName];
                    parentNode.Nodes.Add(menu.MenuName);
                }
            }
            else {
                MessageBox.Show($"取回{response.DataCount}个菜单,{response.Message}");
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            ComboItem selectedItem = (ComboItem)TargetClassPath.SelectedItem;
            if (menus_ == null) {
                MessageBox.Show("未取回任何菜单,将按照初次使用进行配置");
                menus_ = new List<Menus>();
            }
            var exist = menus_.FirstOrDefault(m => m.MenuName == txtMenuName.Text.Trim());
            if (exist != null) {
                MessageBox.Show("同名菜单已存在");
                return;
            }
            if (selectedItem.Value == 0) {
                Menus targetMenu = new Menus {
                    MenuName = txtMenuName.Text.Trim(),
                    MenuPath = string.Empty,
                    ParentId = 0,
                    ParentName = string.Empty,
                    Index = int.Parse(txtIndex.Text.Trim()),
                    MenuId = menus_.Count+1
                };
                MenusTree.Nodes.Add(targetMenu.MenuName);
                menus_.Add(targetMenu);
            }
            else {
                TreeNode parentNode = MenusTree.SelectedNode;
                if (parentNode == null) {
                    MessageBox.Show("添加2级菜单之前请先选择要添加的根节点位置");
                    return;
                }
                Menus parentMenu = menus_.Find(p => p.ParentName == parentNode.Text);
                if (parentMenu!=null && parentMenu.ParentId != 0) {
                    MessageBox.Show("不能使用2级菜单作为根节点");
                    return;
                }
                Menus targetMenu = new Menus {
                    MenuName = txtMenuName.Text.Trim(),
                    MenuPath = selectedItem.ToString(),
                    ParentId = menus_.Find(p=>p.MenuName==parentNode.Text).Id,
                    ParentName = parentNode.Text,
                    Index = int.Parse(txtIndex.Text.Trim()),
                    MenuId = menus_.Count+1
                };
                parentNode.Nodes.Add(targetMenu.MenuName);
                menus_.Add(targetMenu);
            }
            MenusTree.ExpandAll();
        }
        private void SaveAndExitButton_Click(object sender, EventArgs e) {
            ResponseModel response = service_.SaveMenus(menus_);
            if (response.Code == 1) {
                if (MessageBox.Show("保存成功", "是否重启应用", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes) {
                    System.Windows.Forms.Application.Exit();
                    System.Diagnostics.Process.Start(Assembly.GetExecutingAssembly().Location);
                }
                else {
                    Close();
                }
            }
            else {
                MessageBox.Show($"保存失败:{response.Message}");
            }
        }
        private void ExitButton_Click(object sender, EventArgs e) {
            Close();
        }
        public struct ComboItem {
            public string Text { get; set; }
            public int Value { get; set; }
            public ComboItem(string text,int value) {
                Text = text;
                Value = value;
            }
            public override string ToString() {
                return Text;
            }
        }

        private List<Menus> menus_;
        private JavaScriptSerializer serializer_;
        private MenuServiceClient service_;
    }
}
