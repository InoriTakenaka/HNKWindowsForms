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
    public partial class FrmRoleSetup : Form {
        public FrmRoleSetup(RbacServiceClient rbacService, MenuServiceClient menuService) {
            InitializeComponent();
            serializer_ = new JavaScriptSerializer();
            rbacService_ = rbacService;
            menuService_ = menuService;
            targetRole_ = null;
            Init();
        }
        public FrmRoleSetup(Roles role, RbacServiceClient rbacService, MenuServiceClient menuService) {
            InitializeComponent();
            serializer_ = new JavaScriptSerializer();
            rbacService_ = rbacService;
            menuService_ = menuService;
            targetRole_ = role;
            Init();
        }
        private void Init() {
            ResponseModel response = rbacService_.GetRoles();
            if (response.Code == 1 && response.DataCount >= 1) {
                List<Menus> menus_ = serializer_.Deserialize<List<Menus>>(serializer_.Serialize(response.Data));
                foreach(Menus menu in menus_.Where(p => p.ParentId == 0)) {
                    MenuTree.Nodes.Add(menu.MenuName);
                }
                foreach(Menus menu in menus_.Where(p => p.ParentId > 0)) {
                    TreeNode targetNode = MenuTree.Nodes[menu.ParentName];
                    targetNode.Nodes.Add(menu.MenuName);
                }
                MenuTree.ExpandAll();
            }
            else {
                MessageBox.Show(response.Message);
            }
            response = menuService_.GetMenu(AppManager.GetInstance().User.user_id.SafeParse());
            if (response.Code == 1 && response.DataCount >= 1) {
                currentUserMenus_ = serializer_.Deserialize<List<Menus>>(serializer_.Serialize(response.Data));
            }
            else {
                MessageBox.Show("权限验证失败,当前登录账户无权限");
            }
        }
        private void SaveButton_Click(object sender, EventArgs e) {
            if (!SaveRole(out Roles role)) { 
                MessageBox.Show("创建角色异常");
                return;
            }
            if (SaveRoleMenuMaps(role)) {
                MessageBox.Show("保存成功");
                DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("保存失败");
            }
        }

        private void AbortButton_Click(object sender, EventArgs e) {
            Close();
            DialogResult = DialogResult.Cancel;
        }
        private bool SaveRole(out Roles savedRole) {
            if (targetRole_ == null) {
                //新建角色
                targetRole_ = new Roles() { RoleName = RoleNameEdit.Text };
            }
            else {
                //更新现有角色
                targetRole_.RoleName = RoleNameEdit.Text;
            }
            ResponseModel response = rbacService_.SaveRole(targetRole_);
            if(response.Code ==1) {
                savedRole = serializer_.Deserialize<Roles>(serializer_.Serialize(response.Data));
                return true;
            }
            else {
                savedRole = null;
                return false;
            }
        }
        private bool SaveRoleMenuMaps(Roles role) {
            var AssignedRight = (MenuTree.Nodes as IEnumerable<TreeNode>)
                                .Where(node => node.Checked)
                                .ToList();
            bool assign = true;
            foreach(var node in AssignedRight) {
                var menu = currentUserMenus_.FirstOrDefault(p => p.MenuName == node.Name);
                if (menu == null) {
                    assign = false;
                    break;
                }
            }
            if (!assign) {
                MessageBox.Show("不能将当前登录账户不具有的权限授予他人");
                return false;
            }
            List<RoleMenuMaps> roleMenuMaps = new List<RoleMenuMaps>();
            AssignedRight.ForEach((right) => {
                roleMenuMaps.Add(new RoleMenuMaps() {
                    RoleId = role.Id,
                    MenuId = menus_.First(p => p.MenuName == right.Name).MenuId
                }); 
            });
            ResponseModel response = rbacService_.SaveRoleMenuMap(roleMenuMaps.ToArray());
            return response.Code == 1;
        }
        //private List<Menus> menus_;
        private Roles targetRole_;
        //private List<Roles> roles_;
        private List<Menus> menus_;
        private List<Menus> currentUserMenus_;
        private RbacServiceClient rbacService_;
        private MenuServiceClient menuService_;
        private JavaScriptSerializer serializer_;
    }
}
