using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNKWindowsForms.Forms {
    public partial class FrmNavigation : Form {
        public FrmNavigation() {
            InitializeComponent();
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, 
                Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
        }

        private void NavigatoButton_Click(object sender, EventArgs e) {
            if (this.NaviContainer.Visible == true) {
                this.NaviContainer.Visible = false;
            }
            else {
                this.NaviContainer.Visible = true;
            }
        }

        private void LockScreenButton_Click(object sender, EventArgs e) {
            this.NavigatoButton.Enabled = false;
        }

        private void CalculatorButton_Click(object sender, EventArgs e) {

        }

        private void LogoutButton_Click(object sender, EventArgs e) {
            this.NavigatoButton.Enabled = false;
        }
    }
}
