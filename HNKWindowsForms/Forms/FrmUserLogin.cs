using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using HNKCore.Proto;
using HNKInfrastructure.Api;
using HNKWindowsForms.Auxiliary;

namespace HNKWindowsForms.Forms {
    public partial class FrmUserLogin : Form {
        public FrmUserLogin(RbacServiceClient RbacServiceClient) {
            InitializeComponent();
            RbacService_ = RbacServiceClient;
            Serializer_ = new JavaScriptSerializer();
        }

        public void UserLogin() {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("user name/password cannot be empty.");
                return;
            }
            ResponseModel response = RbacService_.UserLogin(userName,password);
            if (response.Code == 1) {
                AppManager.GetInstance().User = Serializer_.Deserialize<Users>(Serializer_.Serialize(response.Data));
                AppManager.GetInstance().UserLoginState = AppManager.UserState.LOGIN;
                DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show($"login fail,{response?.Message}");
                DialogResult = DialogResult.Abort;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            UserLogin();
        }


        private RbacServiceClient RbacService_;
        private JavaScriptSerializer Serializer_;
    }
}
