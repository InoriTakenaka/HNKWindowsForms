using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNKWindowsForms {
    public partial class Frm_ControlTest : Form {
        public Frm_ControlTest() {
            InitializeComponent();
        }

        private void TestAddDlg_Click(object sender, EventArgs e) {
            FunctionArea.AddPages(new TestDialog() { Tag ="测试页1"});
        }
    }
}
