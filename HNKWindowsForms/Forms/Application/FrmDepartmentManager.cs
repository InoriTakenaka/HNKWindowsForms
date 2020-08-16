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
using System.Threading.Tasks;

namespace HNKWindowsForms.Forms.Application {
    public partial class FrmDepartmentManager : Form {
        public FrmDepartmentManager() {
            InitializeComponent();
            DepartmentService_ = new DepartmentServiceClient("api/departservice/");
        }

        private void AddDepartmentButton_Click(object sender, EventArgs e) {
            ShowDepartmentEditDialog();
        }

        private void EditButton_Click(object sender, EventArgs e) {
            ShowDepartmentEditDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {

        }
        /// <summary>
        /// Occurs whenever the Form first show;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDepartmentManager_Shown(object sender, EventArgs e) {
            InitDepartmentTree();
        }
        private void InitDepartmentTree() {
            ResponseModel response = DepartmentService_.GetDepartments();
            if (response.Code == 1) {
                if (response.DataCount >= 1) {
                    List<Department> departments =
                        Serializer_.Deserialize<List<Department>>(Serializer_.Serialize(response.Data));
                    BindToTreeView(departments);
                }
                else {
                    MessageBox.Show("尚未有任何部门被创建");
                }
            }
            else {
                MessageBox.Show(response.Message);
            }
        }
        private void BindToTreeView(List<Department> departments) {
            TreeNode root = DepartmentTree.Nodes["Node0"];
            departments.ForEach((department) => {
                TreeNode node = new TreeNode(department.DepartName);
                root.Nodes.Add(node);
            });
            root.ExpandAll();
        }
        private void ShowDepartmentEditDialog() {
            FrmDeaprtmentInfo frmDeaprtment = new FrmDeaprtmentInfo(DepartmentService_);
            DialogResult dialogResult = frmDeaprtment.ShowDialog();
            if(dialogResult == DialogResult.OK) {
                InitDepartmentTree();
            }
        }
        private DepartmentServiceClient DepartmentService_;
        private JavaScriptSerializer Serializer_;

    }
}
