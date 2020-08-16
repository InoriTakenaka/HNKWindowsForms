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
    public partial class FrmRoleManage : Form {
        public FrmRoleManage() {
            InitializeComponent();
            serializer_ = new JavaScriptSerializer();
            menuService_ = new MenuServiceClient("menuservices/");
            rbacService_ = new RbacServiceClient("rbacservices/");
            Init();
        }
        private void Init() {
            ResponseModel response = rbacService_.GetRoles();
            if (response.Code == 1 && response.DataCount >= 1) {
                roles_ = serializer_.Deserialize<List<Roles>>(serializer_.Serialize(response.Data));
                RoleDataGrid.DataSource = roles_;
                RoleDataGrid.Refresh();
            }
            else {
                MessageBox.Show(response.Message);
            }
        }
        private void AddRoleButton_Click(object sender, EventArgs e) {
            FrmRoleSetup dlgRoleAdd = new FrmRoleSetup(rbacService_, menuService_);
            if (dlgRoleAdd.ShowDialog() == DialogResult.OK) {
                Init();
            };
        }

        private void DeleteRoleButton_Click(object sender, EventArgs e) {
            if (RoleDataGrid.CurrentRow == null || RoleDataGrid.CurrentRow.Index < 0) {
                MessageBox.Show("未选中任何行！");
                return;
            }
            Users targetUser = RoleDataGrid.CurrentRow.DataBoundItem as Users;
            DialogResult result = MessageBox.Show($"确定删除用户【{targetUser.user_name}】?", 
                "请确认", MessageBoxButtons.YesNo);
            if (result == DialogResult.OK) {
                ResponseModel response = rbacService_.DeleteUserById(targetUser.id);
                if(response.Code == 1) {
                    MessageBox.Show("用户已删除");
                }
            }
        }
        private void EditRoleButton_Click(object sender, EventArgs e) {
            EditRole();
        }
        private void RoleDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            EditRole();
        }
        private void EditRole() {
            Roles targetRole = RoleDataGrid.CurrentRow.DataBoundItem as Roles;
            FrmRoleSetup dlgRoleEdit = new FrmRoleSetup(targetRole, rbacService_, menuService_);
            if (dlgRoleEdit.ShowDialog() == DialogResult.OK) {
                Init();
            }
        }
        //private List<Menus> menus_;
        private List<Roles> roles_;
        private RbacServiceClient rbacService_;
        private MenuServiceClient menuService_;
        private JavaScriptSerializer serializer_;


    }
}
