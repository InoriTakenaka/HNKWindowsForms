using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNKControls {
    public partial class IconGroup : Panel {
        public IconGroup() {
            InitializeComponent();
        }
        public IconGroup(IContainer container) {
            container.Add(this);
            InitializeComponent();
        }
        public IconGroup(string caption,int groupWidth) {
            CaptionButton_.Text = caption;
            Width = groupWidth;
            Height = kCapationButtonHeight_;
            BackColor = Color.Gray;
            InitializeComponent();
            InitialControl();
        }

        private void InitialControl() {
            CaptionButton_.Cursor = Cursors.Hand;
            CaptionButton_.FlatStyle = FlatStyle.Standard;
            CaptionButton_.BackColor = Color.FromArgb(
                ((int)(((byte)(239)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            CaptionButton_.Location = new Point(0, 0);
            CaptionButton_.Size = new Size(Width, kCapationButtonHeight_);
            CaptionButton_.Click += OnCaptionButtionClick;
            Controls.Add(CaptionButton_);
            Controls.Add(IconPanel_);
        }

        public event EventHandler OnCaptionButtionClick;
        public event EventHandler OnIconButtonClick;
        public List<IconButton> IconButtons { get; set; }
        public int GroupIndex{get;set;}
        private Button CaptionButton_ = new Button();
        private const int kCapationButtonHeight_ = 30;
        private Panel IconPanel_ = new Panel();
        

    }//class IconGroup
}//namespace HNKControls
