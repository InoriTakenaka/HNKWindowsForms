using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace HNKControls {
    public partial class NavBar : Control {
        public List<IconGroup> Groups { get; set; } = new List<IconGroup>();
        public event EventHandler OnItemClick;
        public NavBar(string[] CaptionTexts) {
            this.CaptionTexts_ = CaptionTexts;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }
        public void InitNavBar() {
            if (this.Parent != null) {
                this.Parent.SizeChanged += ParentSizeChanged;
            }
            for (int i = 0; i < this.CaptionTexts_.Length; i++) {
                IconGroup group = new IconGroup(CaptionTexts_[i], this.Size.Width);
                group.OnIconButtonClick += OnItemClick;
                group.GroupIndex = i;
                group.OnCaptionButtionClick += GroupCaptionButtonClick;
                this.Groups.Add(group);
            }
        }
        public void Show() {
            for (int i = 0; i < this.Groups.Count; i++) {
                this.Controls.Add(Groups[i]);
            }
            this.CurrentIndex_ = 0;
            ResetNavBar();
        }
        private void ParentSizeChanged(object sender, EventArgs e) {
            this.Size = new Size(Size.Width, ((Control)sender).ClientRectangle.Size.Height);
            ResetNavBar();
        }
        private void GroupCaptionButtonClick(object sender, EventArgs e) {
            if (sender is IconGroup) {
                IconGroup group = sender as IconGroup;
                this.CurrentIndex_ = group.GroupIndex;
                ResetNavBar();
            }
        }
        private void ResetNavBar() {

            for (int i = 0; i < this.Groups.Count; i++) {
                //处理每个导航栏目的定位
                Groups[i].Top = i <= CurrentIndex_ ? i * CaptionButtonHeight_ : this.Height - (this.Groups.Count - i) * CaptionButtonHeight_;
                //处理每个导航栏目的高度
                Groups[i].Height = i == CurrentIndex_ ? this.Height - (this.Groups.Count - 1) * 29 : CaptionButtonHeight_;
            }

        }
        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
        }

        private string[] CaptionTexts_;
        private int CurrentIndex_ = 0;
        private const int CaptionButtonHeight_ = 29;
    }//class NavBar
}//namespace HNKControls
