namespace HNKControls {
    partial class PageTab {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.DlgContainer = new System.Windows.Forms.TabControl();
            this.InnerForm = new System.Windows.Forms.TabPage();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.BoxSelector = new System.Windows.Forms.PictureBox();
            this.DropDownDialogMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DlgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // DlgContainer
            // 
            this.DlgContainer.Controls.Add(this.InnerForm);
            this.DlgContainer.Location = new System.Drawing.Point(4, 0);
            this.DlgContainer.Name = "DlgContainer";
            this.DlgContainer.SelectedIndex = 0;
            this.DlgContainer.Size = new System.Drawing.Size(639, 439);
            this.DlgContainer.TabIndex = 0;
            // 
            // InnerForm
            // 
            this.InnerForm.Location = new System.Drawing.Point(4, 22);
            this.InnerForm.Name = "InnerForm";
            this.InnerForm.Padding = new System.Windows.Forms.Padding(3);
            this.InnerForm.Size = new System.Drawing.Size(631, 413);
            this.InnerForm.TabIndex = 1;
            this.InnerForm.Text = "欢迎页";
            this.InnerForm.UseVisualStyleBackColor = true;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::HNKControls.Properties.Resources.tab_panel_close;
            this.CloseBox.Location = new System.Drawing.Point(623, 5);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(16, 15);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 1;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            this.CloseBox.MouseLeave += new System.EventHandler(this.CloseBox_MouseLeave);
            this.CloseBox.MouseHover += new System.EventHandler(this.CloseBox_MouseHover);
            // 
            // BoxSelector
            // 
            this.BoxSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxSelector.Image = global::HNKControls.Properties.Resources.tab_panel_selector;
            this.BoxSelector.Location = new System.Drawing.Point(601, 5);
            this.BoxSelector.Name = "BoxSelector";
            this.BoxSelector.Size = new System.Drawing.Size(16, 15);
            this.BoxSelector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BoxSelector.TabIndex = 2;
            this.BoxSelector.TabStop = false;
            this.BoxSelector.Click += new System.EventHandler(this.BoxSelector_Click);
            this.BoxSelector.MouseLeave += new System.EventHandler(this.BoxSelector_MouseLeave);
            this.BoxSelector.MouseHover += new System.EventHandler(this.BoxSelector_MouseHover);
            // 
            // DropDownDialogMenu
            // 
            this.DropDownDialogMenu.Name = "DropDownDialogMenu";
            this.DropDownDialogMenu.Size = new System.Drawing.Size(181, 26);
            // 
            // PageTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoxSelector);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.DlgContainer);
            this.Name = "PageTab";
            this.Size = new System.Drawing.Size(643, 442);
            this.DlgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl DlgContainer;
        private System.Windows.Forms.TabPage InnerForm;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.PictureBox BoxSelector;
        private System.Windows.Forms.ContextMenuStrip DropDownDialogMenu;
    }
}
