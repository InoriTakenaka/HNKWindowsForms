namespace HNKWindowsForms {
    partial class Frm_ControlTest {
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
            this.FunctionArea = new HNKControls.PageTab();
            this.TestAddDlg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionArea
            // 
            this.FunctionArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.FunctionArea.Location = new System.Drawing.Point(206, 0);
            this.FunctionArea.Name = "FunctionArea";
            this.FunctionArea.Size = new System.Drawing.Size(851, 682);
            this.FunctionArea.TabIndex = 0;
            // 
            // TestAddDlg
            // 
            this.TestAddDlg.Location = new System.Drawing.Point(31, 37);
            this.TestAddDlg.Name = "TestAddDlg";
            this.TestAddDlg.Size = new System.Drawing.Size(75, 23);
            this.TestAddDlg.TabIndex = 1;
            this.TestAddDlg.Text = "Add";
            this.TestAddDlg.UseVisualStyleBackColor = true;
            this.TestAddDlg.Click += new System.EventHandler(this.TestAddDlg_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TestAddDlg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 682);
            this.panel1.TabIndex = 2;
            // 
            // Frm_ControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FunctionArea);
            this.Name = "Frm_ControlTest";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HNKControls.PageTab FunctionArea;
        private System.Windows.Forms.Button TestAddDlg;
        private System.Windows.Forms.Panel panel1;
    }
}

