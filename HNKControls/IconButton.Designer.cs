namespace HNKControls {
    partial class IconButton {
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
            this.IconImageBox = new System.Windows.Forms.PictureBox();
            this.laIconText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconImageBox
            // 
            this.IconImageBox.Location = new System.Drawing.Point(3, 4);
            this.IconImageBox.Name = "IconImageBox";
            this.IconImageBox.Size = new System.Drawing.Size(144, 108);
            this.IconImageBox.TabIndex = 0;
            this.IconImageBox.TabStop = false;
            // 
            // laIconText
            // 
            this.laIconText.AutoSize = true;
            this.laIconText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.laIconText.Location = new System.Drawing.Point(3, 115);
            this.laIconText.Name = "laIconText";
            this.laIconText.Size = new System.Drawing.Size(60, 24);
            this.laIconText.TabIndex = 1;
            this.laIconText.Text = "label1";
            // 
            // IconButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.laIconText);
            this.Controls.Add(this.IconImageBox);
            this.Name = "IconButton";
            this.Click += new System.EventHandler(this.OnIconImageBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.IconImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconImageBox;
        private System.Windows.Forms.Label laIconText;
    }
}
