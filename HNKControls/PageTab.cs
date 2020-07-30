using System;
using System.Drawing;
using System.Windows.Forms;
using HNKControls.Properties;

namespace HNKControls {
    public partial class PageTab : UserControl {
        public PageTab() {
            InitializeComponent();
        }
        public void AddPages(BorderlessDlg Dialog) {
            BackgroundImage = null;
            string DialogTitile = Dialog.Tag.ToString();
            if (DropDownDialogMenu.Items.Find(DialogTitile, false).Length != 0) {
                DlgContainer.SelectTab(DialogTitile);
                return;
            }

            Dialog.TopLevel = false;
            Dialog.Dock = DockStyle.Fill;
            TabPage tabPage = new TabPage();
            tabPage.AutoScroll = true;
            tabPage.Name = DialogTitile;
            tabPage.Text = DialogTitile;
            Dialog.Show();
            tabPage.Controls.Add(Dialog);
            DlgContainer.TabPages.Add(tabPage);

            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Click += StripMenuClick;
            item.Text = DialogTitile;
            item.Name = DialogTitile;
            item.Size = new Size(117, 24);
            DropDownDialogMenu.Items.Add(item);
            TabShow();
            DlgContainer.SelectTab(DialogTitile);
        }
        private void TabShow() {
            BackgroundImage = null;
            bool IsEmpty = DlgContainer.TabPages.Count == 0;
            DlgContainer.Visible = !IsEmpty;
            CloseBox.Visible = !IsEmpty;
            BoxSelector.Visible = !IsEmpty;

        }
        private void StripMenuClick(object sender,EventArgs e) {
            string currentDialog = ((ToolStripMenuItem)sender).Text;
            DlgContainer.SelectTab(currentDialog);
        }

        private void BoxSelector_MouseHover(object sender, EventArgs e) {
            BoxSelector.Image = Resources.h_tab_panel_selector;
            Cursor = Cursors.Hand;
        }

        private void BoxSelector_MouseLeave(object sender, EventArgs e) {
            BoxSelector.Image = Resources.tab_panel_selector;
            Cursor = Cursors.Default;
        }

        private void BoxSelector_Click(object sender, EventArgs e) {
            DropDownDialogMenu.Show(BoxSelector, new Point(-120, 20));
        }

        private void CloseBox_MouseHover(object sender, EventArgs e) {
            CloseBox.Image = Resources.h_tab_panel_close;
            Cursor = Cursors.Hand;
        }

        private void CloseBox_MouseLeave(object sender, EventArgs e) {
            CloseBox.Image = Resources.tab_panel_close;
            Cursor = Cursors.Default;
        }

        private void CloseBox_Click(object sender, EventArgs e) {
            string deleteKey = DlgContainer.SelectedTab.Name;
            if (deleteKey == "欢迎页") { return; }
            DlgContainer.TabPages[deleteKey].Dispose();
            DlgContainer.TabPages.RemoveByKey(deleteKey);
            DlgContainer.SelectedIndex = DlgContainer.TabPages.Count - 1;
            DropDownDialogMenu.Items.RemoveByKey(deleteKey);
            TabShow();
        }
    }
}
