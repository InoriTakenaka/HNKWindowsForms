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
    public partial class FrmUserRoleSetup : Form {
        public FrmUserRoleSetup(RbacServiceClient rbacServiceClient) {
            InitializeComponent();
            rbacService_ = rbacServiceClient;
            serializer_ = new JavaScriptSerializer();
            targetUser_ = null;
            InitRolesTree();
        }
        public FrmUserRoleSetup(Users user,
            RbacServiceClient rbacServiceClient) {
            InitializeComponent();
            targetUser_ = user;
            rbacService_ = rbacServiceClient;
            serializer_ = new JavaScriptSerializer();
            InitRolesTree();
            InitUserInfo();
        }
        private void InitRolesTree() {
            ResponseModel response = rbacService_.GetRoles();
            if (response.Code == 1 && response.DataCount >= 1) {
                roles_ = serializer_.Deserialize<List<Roles>>(
                    serializer_.Serialize(response.Data));
                roles_.ForEach(role => {
                    TreeNode node = new TreeNode {
                        Name = role.Id.ToString(),
                        Text = role.RoleName
                    };
                    RolesTree.Nodes.Add(node);
                });
            }
            else {
                MessageBox.Show($"取回{response.DataCount}个实体,{response.Message}");
            }
        }
        private void InitUserInfo() {
            if (targetUser_ != null) {
                UserCodeEdit.Text = targetUser_.user_code;
                UserNameEdit.Text = targetUser_.user_name;
                UserPwdEdit.Text = targetUser_.user_password;
                UserIdEdit.Text = targetUser_.user_id;
                UserCodeEdit.Enabled = false;
                ResponseModel response = rbacService_.GetUserRole(targetUser_.id);
                if (response.Code == 1 && response.DataCount >= 1) {
                    List<Roles> roles = serializer_.Deserialize<List<Roles>>(
                        serializer_.Serialize(response.Data));
                    List<int> roleIds = roles.Select(role => role.Id).ToList();
                    CheckRolesTreeNodes(RolesTree.Nodes, roleIds);
                }
            }
        }
        private void CheckRolesTreeNodes(TreeNodeCollection nodes, List<int> roleIds) {
            foreach (TreeNode node in nodes) {
                if (roleIds.Contains(node.Name.SafeParse())) {
                    node.Checked = true;
                }
                CheckRolesTreeNodes(node.Nodes, roleIds);
            }
        }
        private void AddButton_Click(object sender, EventArgs e) {
            ResponseModel response = new ResponseModel();
            if (targetUser_ != null) {
                //update user
                targetUser_.user_name = UserNameEdit.Text;
                targetUser_.user_password = UserPwdEdit.Text;
                targetUser_.user_id = UserIdEdit.Text;
                response = rbacService_.ModifyUser(targetUser_);
            }
            else {
                Users newUser = new Users() {
                    user_code = UserCodeEdit.Text,
                    user_name =UserNameEdit.Text,
                    user_password = UserPwdEdit.Text,
                    user_id = UserPwdEdit.Text,
                };
                response = rbacService_.AddUser(newUser);
            }
            if (response.Code == 1) {
                Users user = serializer_.Deserialize<Users>(
                    serializer_.Serialize(response.Data));

                List<int> roleIds = GetCheckedMenuIds(RolesTree.Nodes);
                List<UserRoleMaps> userRoleMaps = new List<UserRoleMaps>();
                roleIds.ForEach((rId) => {
                    UserRoleMaps userRoleMap = new UserRoleMaps() {
                        RoleId = rId,
                        UserId = user.id,
                        AurthorizeId = AppManager.GetInstance().User.id
                    };
                    userRoleMaps.Add(userRoleMap);
                });
                if(userRoleMaps.Count==0) {
                    MessageBox.Show("保存成功");
                    return;
                }
                response = rbacService_.SaveUserRoleMap(userRoleMaps.ToArray());
                if (response.Code == 1) {
                    MessageBox.Show("用户信息保存成功");
                }
                else {
                    MessageBox.Show(response.Message);
                }
            }
        }
        private List<int> GetCheckedMenuIds(TreeNodeCollection nodes) {
            List<int> roleIds = new List<int>();
            foreach (TreeNode tn in nodes) {
                if (tn.Checked) {
                    int Id = tn.Name.SafeParse();
                    if (!roleIds.Contains(Id))
                        roleIds.Add(Id);
                }
                GetCheckedMenuIds(tn.Nodes);
            }

            return roleIds;
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private Users targetUser_;
        private List<Roles> roles_;
        private RbacServiceClient rbacService_;
        private JavaScriptSerializer serializer_;
    }
}
