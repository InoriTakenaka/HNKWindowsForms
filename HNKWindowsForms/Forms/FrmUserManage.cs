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
    public partial class FrmUserManage : Form {
        public FrmUserManage() {
            InitializeComponent();
            serializer_ = new JavaScriptSerializer();
            rbacService_ = new RbacServiceClient("rbacservices/");
            Init();
        }
        private void Init() {
            ResponseModel response = rbacService_.GetRoles();
            if (response.Code == 1 && response.DataCount >= 1) {
                roles_ = serializer_.Deserialize<List<Users>>(serializer_.Serialize(response.Data));
                UserDataGrid.DataSource = roles_;
                UserDataGrid.Refresh();
            }
            else {
                MessageBox.Show(response.Message);
            }
        }
        private void AddRoleButton_Click(object sender, EventArgs e) {
            FrmUserRoleSetup dlgRoleAdd = new FrmUserRoleSetup(rbacService_);
            if (dlgRoleAdd.ShowDialog() == DialogResult.OK) {
                Init();
            };
        }

        private void DeleteRoleButton_Click(object sender, EventArgs e) {
            if (UserDataGrid.CurrentRow == null || UserDataGrid.CurrentRow.Index < 0) {
                MessageBox.Show("未选中任何行！");
                return;
            }
            Users targetUser = UserDataGrid.CurrentRow.DataBoundItem as Users;
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
            Users targetUser = UserDataGrid.CurrentRow.DataBoundItem as Users;
            FrmUserRoleSetup dlgRoleEdit = new FrmUserRoleSetup(targetUser, rbacService_);
            if (dlgRoleEdit.ShowDialog() == DialogResult.OK) {
                Init();
            }
        }
        //private List<Menus> menus_;
        private List<Users> roles_;
        private RbacServiceClient rbacService_;
        private JavaScriptSerializer serializer_;


    }
}
