namespace UI
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbRegiter = new System.Windows.Forms.TextBox();
            this.btnRigiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRegiter
            // 
            this.tbRegiter.Location = new System.Drawing.Point(12, 12);
            this.tbRegiter.Name = "tbRegiter";
            this.tbRegiter.Size = new System.Drawing.Size(360, 21);
            this.tbRegiter.TabIndex = 0;
            // 
            // btnRigiter
            // 
            this.btnRigiter.Location = new System.Drawing.Point(297, 39);
            this.btnRigiter.Name = "btnRigiter";
            this.btnRigiter.Size = new System.Drawing.Size(75, 23);
            this.btnRigiter.TabIndex = 1;
            this.btnRigiter.Text = "注册";
            this.btnRigiter.UseVisualStyleBackColor = true;
            this.btnRigiter.Click += new System.EventHandler(this.btnRigiter_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 67);
            this.Controls.Add(this.btnRigiter);
            this.Controls.Add(this.tbRegiter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbRegiter;
        private System.Windows.Forms.Button btnRigiter;
    }
}