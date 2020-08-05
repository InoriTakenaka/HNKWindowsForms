namespace HNKWindowsForms.Forms {
    partial class FrmNavigation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.SystemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NavigatoButton = new System.Windows.Forms.ToolStripButton();
            this.LockScreenButton = new System.Windows.Forms.ToolStripButton();
            this.CalculatorButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutButton = new System.Windows.Forms.ToolStripButton();
            this.NaviContainer = new System.Windows.Forms.Panel();
            this.pageTab1 = new HNKControls.PageTab();
            this.MenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemMenu,
            this.HelpMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1341, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // SystemMenu
            // 
            this.SystemMenu.Name = "SystemMenu";
            this.SystemMenu.Size = new System.Drawing.Size(59, 20);
            this.SystemMenu.Text = "系统(&S)";
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(62, 20);
            this.HelpMenu.Text = "帮助(&H)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NavigatoButton,
            this.LockScreenButton,
            this.CalculatorButton,
            this.LogoutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1341, 50);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NavigatoButton
            // 
            this.NavigatoButton.AutoSize = false;
            this.NavigatoButton.Image = global::HNKWindowsForms.Properties.Resources.AlignVerticalLeft_32x32;
            this.NavigatoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NavigatoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavigatoButton.Name = "NavigatoButton";
            this.NavigatoButton.Size = new System.Drawing.Size(80, 50);
            this.NavigatoButton.Text = "菜单";
            this.NavigatoButton.Click += new System.EventHandler(this.NavigatoButton_Click);
            // 
            // LockScreenButton
            // 
            this.LockScreenButton.Image = global::HNKWindowsForms.Properties.Resources.screenlock;
            this.LockScreenButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LockScreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LockScreenButton.Name = "LockScreenButton";
            this.LockScreenButton.Size = new System.Drawing.Size(69, 47);
            this.LockScreenButton.Text = "锁屏";
            this.LockScreenButton.Click += new System.EventHandler(this.LockScreenButton_Click);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Image = global::HNKWindowsForms.Properties.Resources.compute1;
            this.CalculatorButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(82, 47);
            this.CalculatorButton.Text = "计算器";
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Image = global::HNKWindowsForms.Properties.Resources.exit;
            this.LogoutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(69, 47);
            this.LogoutButton.Text = "登出";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // NaviContainer
            // 
            this.NaviContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.NaviContainer.Location = new System.Drawing.Point(0, 74);
            this.NaviContainer.Name = "NaviContainer";
            this.NaviContainer.Size = new System.Drawing.Size(200, 716);
            this.NaviContainer.TabIndex = 2;
            // 
            // pageTab1
            // 
            this.pageTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageTab1.Location = new System.Drawing.Point(200, 74);
            this.pageTab1.Name = "pageTab1";
            this.pageTab1.Size = new System.Drawing.Size(1141, 716);
            this.pageTab1.TabIndex = 3;
            // 
            // FrmNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 790);
            this.ControlBox = false;
            this.Controls.Add(this.pageTab1);
            this.Controls.Add(this.NaviContainer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FrmNavigation";
            this.Text = "Frm_Navigation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SystemMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NavigatoButton;
        private System.Windows.Forms.ToolStripButton LockScreenButton;
        private System.Windows.Forms.ToolStripButton CalculatorButton;
        private System.Windows.Forms.ToolStripButton LogoutButton;
        private System.Windows.Forms.Panel NaviContainer;
        private HNKControls.PageTab pageTab1;
    }
}