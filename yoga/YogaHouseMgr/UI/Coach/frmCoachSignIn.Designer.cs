namespace UI.Coach
{
    partial class frmCoachSignIn
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
            this.dataTime = new System.Windows.Forms.DateTimePicker();
            this.cbPro = new System.Windows.Forms.ComboBox();
            this.lblClassKind = new System.Windows.Forms.Label();
            this.lvlTime = new System.Windows.Forms.Label();
            this.lvlNo = new System.Windows.Forms.Label();
            this.tbMTips = new System.Windows.Forms.TextBox();
            this.lvlTips = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(67, 49);
            this.dataTime.Name = "dataTime";
            this.dataTime.Size = new System.Drawing.Size(105, 21);
            this.dataTime.TabIndex = 45;
            // 
            // cbPro
            // 
            this.cbPro.FormattingEnabled = true;
            this.cbPro.Location = new System.Drawing.Point(247, 23);
            this.cbPro.Name = "cbPro";
            this.cbPro.Size = new System.Drawing.Size(106, 20);
            this.cbPro.TabIndex = 42;
            // 
            // lblClassKind
            // 
            this.lblClassKind.Location = new System.Drawing.Point(188, 26);
            this.lblClassKind.Name = "lblClassKind";
            this.lblClassKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClassKind.Size = new System.Drawing.Size(53, 12);
            this.lblClassKind.TabIndex = 41;
            this.lblClassKind.Text = "课程内容";
            // 
            // lvlTime
            // 
            this.lvlTime.Location = new System.Drawing.Point(7, 55);
            this.lvlTime.Name = "lvlTime";
            this.lvlTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlTime.Size = new System.Drawing.Size(53, 12);
            this.lvlTime.TabIndex = 39;
            this.lvlTime.Text = "课程时间";
            // 
            // lvlNo
            // 
            this.lvlNo.Location = new System.Drawing.Point(8, 23);
            this.lvlNo.Name = "lvlNo";
            this.lvlNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlNo.Size = new System.Drawing.Size(53, 12);
            this.lvlNo.TabIndex = 12;
            this.lvlNo.Text = "编号";
            // 
            // tbMTips
            // 
            this.tbMTips.Location = new System.Drawing.Point(67, 76);
            this.tbMTips.Multiline = true;
            this.tbMTips.Name = "tbMTips";
            this.tbMTips.Size = new System.Drawing.Size(286, 74);
            this.tbMTips.TabIndex = 5;
            // 
            // lvlTips
            // 
            this.lvlTips.Location = new System.Drawing.Point(8, 76);
            this.lvlTips.Name = "lvlTips";
            this.lvlTips.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlTips.Size = new System.Drawing.Size(53, 12);
            this.lvlTips.TabIndex = 4;
            this.lvlTips.Text = "备注";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("KaiTi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "教练签到";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 47);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numNo);
            this.groupBox1.Controls.Add(this.dataTime);
            this.groupBox1.Controls.Add(this.cbPro);
            this.groupBox1.Controls.Add(this.lblClassKind);
            this.groupBox1.Controls.Add(this.lvlTime);
            this.groupBox1.Controls.Add(this.lvlNo);
            this.groupBox1.Controls.Add(this.tbMTips);
            this.groupBox1.Controls.Add(this.lvlTips);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "教练操课签到";
            // 
            // numNo
            // 
            this.numNo.Location = new System.Drawing.Point(67, 22);
            this.numNo.Name = "numNo";
            this.numNo.Size = new System.Drawing.Size(105, 21);
            this.numNo.TabIndex = 46;
            // 
            // frmCoachSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCoachSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "教练签到";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataTime;
        private System.Windows.Forms.ComboBox cbPro;
        private System.Windows.Forms.Label lblClassKind;
        private System.Windows.Forms.Label lvlTime;
        private System.Windows.Forms.Label lvlNo;
        private System.Windows.Forms.TextBox tbMTips;
        private System.Windows.Forms.Label lvlTips;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numNo;
    }
}