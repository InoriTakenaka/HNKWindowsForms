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
            this.SuspendLayout();
            // 
            // FunctionArea
            // 
            this.FunctionArea.Location = new System.Drawing.Point(154, 12);
            this.FunctionArea.Name = "FunctionArea";
            this.FunctionArea.Size = new System.Drawing.Size(643, 442);
            this.FunctionArea.TabIndex = 0;
            // 
            // TestAddDlg
            // 
            this.TestAddDlg.Location = new System.Drawing.Point(30, 45);
            this.TestAddDlg.Name = "TestAddDlg";
            this.TestAddDlg.Size = new System.Drawing.Size(75, 23);
            this.TestAddDlg.TabIndex = 1;
            this.TestAddDlg.Text = "Add";
            this.TestAddDlg.UseVisualStyleBackColor = true;
            this.TestAddDlg.Click += new System.EventHandler(this.TestAddDlg_Click);
            // 
            // Frm_ControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestAddDlg);
            this.Controls.Add(this.FunctionArea);
            this.Name = "Frm_ControlTest";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HNKControls.PageTab FunctionArea;
        private System.Windows.Forms.Button TestAddDlg;
    }
}

