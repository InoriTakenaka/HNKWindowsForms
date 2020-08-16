namespace HNKWindowsForms.Forms {
    partial class FrmMenuManager {
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("菜单");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetClassPath = new System.Windows.Forms.ComboBox();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.MenusTree = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.SaveAndExitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择您的菜单与对应的程序集";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择菜单路径";
            // 
            // TargetClassPath
            // 
            this.TargetClassPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetClassPath.FormattingEnabled = true;
            this.TargetClassPath.Location = new System.Drawing.Point(302, 106);
            this.TargetClassPath.Name = "TargetClassPath";
            this.TargetClassPath.Size = new System.Drawing.Size(370, 21);
            this.TargetClassPath.TabIndex = 2;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuName.Location = new System.Drawing.Point(302, 53);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(188, 28);
            this.txtMenuName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "菜单名称";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(183, 339);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(168, 39);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "添        加";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MenusTree
            // 
            this.MenusTree.Location = new System.Drawing.Point(6, 49);
            this.MenusTree.Name = "MenusTree";
            treeNode1.Name = "Node0";
            treeNode1.Text = "菜单";
            this.MenusTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.MenusTree.Size = new System.Drawing.Size(167, 329);
            this.MenusTree.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "序号(数字)";
            // 
            // txtIndex
            // 
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.Location = new System.Drawing.Point(619, 53);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(43, 28);
            this.txtIndex.TabIndex = 9;
            // 
            // SaveAndExitButton
            // 
            this.SaveAndExitButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SaveAndExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndExitButton.Location = new System.Drawing.Point(357, 339);
            this.SaveAndExitButton.Name = "SaveAndExitButton";
            this.SaveAndExitButton.Size = new System.Drawing.Size(168, 39);
            this.SaveAndExitButton.TabIndex = 10;
            this.SaveAndExitButton.Text = "保 存 并 退 出";
            this.SaveAndExitButton.UseVisualStyleBackColor = false;
            this.SaveAndExitButton.Click += new System.EventHandler(this.SaveAndExitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(533, 339);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(168, 39);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "退        出";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FrmMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 390);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveAndExitButton);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MenusTree);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.TargetClassPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMenuManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TargetClassPath;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TreeView MenusTree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button SaveAndExitButton;
        private System.Windows.Forms.Button ExitButton;
    }
}