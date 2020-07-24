using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNKControls {
    public partial class BorderlessDlg : Form {
        public BorderlessDlg() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}
