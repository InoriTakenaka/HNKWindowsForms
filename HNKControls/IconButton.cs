using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HNKControls.Properties;

namespace HNKControls {
    public partial class IconButton : UserControl {

        public event EventHandler EventIconClick;
        public string IconText { get; set; }        
        public string TargetForm { get; set; }        
        public Image IconImage { get; set; }
        public Point ControlLocation {
            get { return Location; }
            set { Location = value; }
        }

        public IconButton() {
            InitializeComponent();
        }

        public IconButton(Image iconImage,string iconText,string targetForm) {
            IconImage = iconImage;
            IconText = iconText;
            TargetForm = targetForm;
            InitializeComponent();
            IconImageBox.Image = IconImage;
            laIconText.Text = IconText;
        }
        private void OnIconImageBox_Click(object sender,EventArgs e) {
            EventIconClick?.Invoke(this, e);
        }
    }//class IconButton
}//namespace HNKControls
