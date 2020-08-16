using HNKCore.Proto;
using HNKInfrastructure.Api;
using HNKWindowsForms.Auxiliary;
using HNKControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace HNKWindowsForms.Forms {
    public partial class FrmNavigation : Form {
        public FrmNavigation() {
            InitializeComponent();
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, 
                Screen.PrimaryScreen.WorkingArea.Height);
            WindowState = FormWindowState.Maximized;
            NaviContainer.Visible = false;
            NavigatoButton.Enabled = false;
            MenuMgrButton.Enabled = false;
            UserManageButton.Enabled = false;
            RoleManageButton.Enabled = false;
            Serializer_ = new JavaScriptSerializer();
        }

        private void NavigatoButton_Click(object sender, EventArgs e) {
            if (NaviContainer.Visible == true) {
                NaviContainer.Visible = false;
            }
            else {
                NaviContainer.Visible = true;
            }
        }

        private void LockScreenButton_Click(object sender, EventArgs e) {
            if (NavigatoButton.Enabled) {
                NavigatoButton.Enabled = false;
            }
        }

        private void CalculatorButton_Click(object sender, EventArgs e) {

        }

        private void LogoutButton_Click(object sender, EventArgs e) {
            if (NavigatoButton.Enabled) {
                NavigatoButton.Enabled = false;
            }
        }

        private void SystemMenuLoginItem_Click(object sender, EventArgs e) {
            if (AppManager.GetInstance().UserLoginState == AppManager.UserState.LOGIN) {
                return;
            }
            RbacServiceClient rbacService = 
                new RbacServiceClient(AppManager.GetInstance().ApiUrl + "rbacservices/");
            FrmUserLogin frmUserLogin = new FrmUserLogin(rbacService);
            var loginResult = frmUserLogin.ShowDialog();
            if (loginResult == DialogResult.OK) {                
                //设置导航菜单可用
                NavigatoButton.Enabled = true;
                //系统管理员才能操作菜单设置对话框
                if (AppManager.GetInstance().User.id == -1) {
                    MenuMgrButton.Enabled = true;
                }
                //设置菜单栏里登录按钮不可用
                SystemMenuLoginItem.Enabled = false;
                //从API获取用户权限及菜单
                MenuServiceClient menuService_ =                             
                new MenuServiceClient(AppManager.GetInstance().ApiUrl + "menuservices/");
                ResponseModel response;
                if (AppManager.GetInstance().User.id != -1) {
                    //一般操作员默认根据用户ID获取菜单
                    response = menuService_.GetMenu(int.Parse(AppManager.GetInstance().User.user_id));
                }else {
                    //系统内置管理员默认获取所有菜单
                    response = menuService_.GetMenus();
                }
                if (response.Code == 1) {
                    List<Menus> menus = Serializer_.Deserialize<List<Menus>>(Serializer_.Serialize(response.Data));
                    InitMenus(menus);
                }
                else {
                    MessageBox.Show($"获取权限异常:{response.Message}");
                }
            }
        }

        private void InitMenus(List<Menus> menus) {
            //1级菜单
            Dictionary<string, int> captionsText = new Dictionary<string, int>();
            foreach (var menu in menus.Where(p => p.ParentId == 0)) {
                captionsText.Add(menu.MenuName,menu.Id);
            }
            NavBar navbar = new NavBar(captionsText);
            NaviContainer.Controls.Add(navbar);
            navbar.OnItemClick += Navbar_OnItemClick;
            navbar.InitNavBar();
            //2级菜单
            var groups = navbar.Groups;
            foreach(var icongroup in groups) {
                foreach (var menu in menus.Where(p => p.ParentId == icongroup.OrderId))
                    icongroup.AddIcons(new IconButton(null, menu.MenuName, menu.MenuPath));
            }
            navbar.Show();
        }
        private void Navbar_OnItemClick(object sender, EventArgs e) {
            if(sender is IconButton) {
                string targetForm = ((IconButton)sender).TargetForm;
                Form targetDialog = (Form)Activator.CreateInstance(Type.GetType(targetForm));
                targetDialog.Tag = ((IconButton)sender).IconText;
                FunctionArea.AddPages(targetDialog);
            }
        }
        private void MenuMgrButton_Click(object sender, EventArgs e) {
            FrmMenuManager MenuManageDialog = new FrmMenuManager();
            MenuManageDialog.ShowDialog();
        }
        private void RoleManageButton_Click(object sender, EventArgs e) {

        }
        private JavaScriptSerializer Serializer_;

        private void UserManageButton_Click(object sender, EventArgs e) {
            FrmUserManage frmUserManage = new FrmUserManage();
            frmUserManage.StartPosition = FormStartPosition.CenterScreen;
            frmUserManage.ShowDialog();
        }
    }
}
