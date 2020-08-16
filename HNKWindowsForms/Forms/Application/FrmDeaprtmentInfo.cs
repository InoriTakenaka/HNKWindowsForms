using HNKCore.Proto;
using HNKInfrastructure.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNKWindowsForms.Forms.Application {
    public partial class FrmDeaprtmentInfo : Form {
        public FrmDeaprtmentInfo(DepartmentServiceClient client) {
            InitializeComponent();
            DepartmentService_ = client;
        }
        private void SaveButton_Click(object sender, EventArgs e) {
            ResponseModel result = SaveEntity();
            if (result.Code==1) {
                MessageBox.Show("保存成功");
                DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show(result.Message);
                DialogResult = DialogResult.Abort;
            }
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private ResponseModel SaveEntity() {
            Department department = new Department();
            return DepartmentService_.InsertDepartment(department);
        }

        private DepartmentServiceClient DepartmentService_;
    }
}
