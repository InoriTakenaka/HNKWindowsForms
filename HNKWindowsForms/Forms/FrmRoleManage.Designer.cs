namespace HNKWindowsForms.Forms {
    partial class FrmRoleManage {
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddRoleButton = new System.Windows.Forms.Button();
            this.DeleteRoleButton = new System.Windows.Forms.Button();
            this.RoleDataGrid = new System.Windows.Forms.DataGridView();
            this.EditRoleButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色管理";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 1;
            // 
            // AddRoleButton
            // 
            this.AddRoleButton.AutoSize = true;
            this.AddRoleButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddRoleButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoleButton.Location = new System.Drawing.Point(12, 400);
            this.AddRoleButton.Name = "AddRoleButton";
            this.AddRoleButton.Size = new System.Drawing.Size(133, 38);
            this.AddRoleButton.TabIndex = 1;
            this.AddRoleButton.Text = "添加角色";
            this.AddRoleButton.UseVisualStyleBackColor = false;
            this.AddRoleButton.Click += new System.EventHandler(this.AddRoleButton_Click);
            // 
            // DeleteRoleButton
            // 
            this.DeleteRoleButton.AutoSize = true;
            this.DeleteRoleButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteRoleButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRoleButton.Location = new System.Drawing.Point(165, 400);
            this.DeleteRoleButton.Name = "DeleteRoleButton";
            this.DeleteRoleButton.Size = new System.Drawing.Size(133, 38);
            this.DeleteRoleButton.TabIndex = 2;
            this.DeleteRoleButton.Text = "删除角色";
            this.DeleteRoleButton.UseVisualStyleBackColor = false;
            this.DeleteRoleButton.Click += new System.EventHandler(this.DeleteRoleButton_Click);
            // 
            // RoleDataGrid
            // 
            this.RoleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoleDataGrid.Location = new System.Drawing.Point(0, 46);
            this.RoleDataGrid.Name = "RoleDataGrid";
            this.RoleDataGrid.ReadOnly = true;
            this.RoleDataGrid.Size = new System.Drawing.Size(800, 348);
            this.RoleDataGrid.TabIndex = 3;
            this.RoleDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleDataGrid_CellDoubleClick);
            // 
            // EditRoleButton
            // 
            this.EditRoleButton.AutoSize = true;
            this.EditRoleButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.EditRoleButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRoleButton.Location = new System.Drawing.Point(316, 400);
            this.EditRoleButton.Name = "EditRoleButton";
            this.EditRoleButton.Size = new System.Drawing.Size(133, 38);
            this.EditRoleButton.TabIndex = 4;
            this.EditRoleButton.Text = "编辑角色";
            this.EditRoleButton.UseVisualStyleBackColor = false;
            this.EditRoleButton.Click += new System.EventHandler(this.EditRoleButton_Click);
            // 
            // FrmRoleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.EditRoleButton);
            this.Controls.Add(this.RoleDataGrid);
            this.Controls.Add(this.DeleteRoleButton);
            this.Controls.Add(this.AddRoleButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoleManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRoleManage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddRoleButton;
        private System.Windows.Forms.Button DeleteRoleButton;
        private System.Windows.Forms.DataGridView RoleDataGrid;
        private System.Windows.Forms.Button EditRoleButton;
    }
}