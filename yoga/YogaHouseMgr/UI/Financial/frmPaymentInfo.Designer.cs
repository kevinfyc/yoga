namespace UI.Financial
{
    partial class frmPaymentInfo
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
            this.lblPro = new System.Windows.Forms.Label();
            this.lvlTime = new System.Windows.Forms.Label();
            this.tbSysInfo = new System.Windows.Forms.TextBox();
            this.lvlSysInfo = new System.Windows.Forms.Label();
            this.lblMach = new System.Windows.Forms.Label();
            this.tbMTips = new System.Windows.Forms.TextBox();
            this.lvlTips = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numMach = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(248, 49);
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
            // lblPro
            // 
            this.lblPro.Location = new System.Drawing.Point(188, 26);
            this.lblPro.Name = "lblPro";
            this.lblPro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPro.Size = new System.Drawing.Size(53, 12);
            this.lblPro.TabIndex = 41;
            this.lblPro.Text = "项目";
            // 
            // lvlTime
            // 
            this.lvlTime.Location = new System.Drawing.Point(188, 55);
            this.lvlTime.Name = "lvlTime";
            this.lvlTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlTime.Size = new System.Drawing.Size(53, 12);
            this.lvlTime.TabIndex = 39;
            this.lvlTime.Text = "时间";
            // 
            // tbSysInfo
            // 
            this.tbSysInfo.Location = new System.Drawing.Point(67, 20);
            this.tbSysInfo.Name = "tbSysInfo";
            this.tbSysInfo.ReadOnly = true;
            this.tbSysInfo.Size = new System.Drawing.Size(100, 21);
            this.tbSysInfo.TabIndex = 13;
            // 
            // lvlSysInfo
            // 
            this.lvlSysInfo.Location = new System.Drawing.Point(8, 23);
            this.lvlSysInfo.Name = "lvlSysInfo";
            this.lvlSysInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlSysInfo.Size = new System.Drawing.Size(53, 12);
            this.lvlSysInfo.TabIndex = 12;
            this.lvlSysInfo.Text = "系统单据";
            // 
            // lblMach
            // 
            this.lblMach.Location = new System.Drawing.Point(8, 48);
            this.lblMach.Name = "lblMach";
            this.lblMach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMach.Size = new System.Drawing.Size(53, 12);
            this.lblMach.TabIndex = 8;
            this.lblMach.Text = "金额";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("KaiTi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(105, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "付款单信息登记";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 47);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numMach);
            this.groupBox1.Controls.Add(this.dataTime);
            this.groupBox1.Controls.Add(this.cbPro);
            this.groupBox1.Controls.Add(this.lblPro);
            this.groupBox1.Controls.Add(this.lvlTime);
            this.groupBox1.Controls.Add(this.tbSysInfo);
            this.groupBox1.Controls.Add(this.lvlSysInfo);
            this.groupBox1.Controls.Add(this.lblMach);
            this.groupBox1.Controls.Add(this.tbMTips);
            this.groupBox1.Controls.Add(this.lvlTips);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "付款单";
            // 
            // numMach
            // 
            this.numMach.Location = new System.Drawing.Point(67, 49);
            this.numMach.Name = "numMach";
            this.numMach.ReadOnly = true;
            this.numMach.Size = new System.Drawing.Size(100, 21);
            this.numMach.TabIndex = 46;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPaymentInfo
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
            this.Name = "frmPaymentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "付款单信息";
            this.Activated += new System.EventHandler(this.frmPaymentInfo_Activated);
            this.Deactivate += new System.EventHandler(this.frmPaymentInfo_Deactivate);
            this.Load += new System.EventHandler(this.frmPaymentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataTime;
        private System.Windows.Forms.ComboBox cbPro;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Label lvlTime;
        private System.Windows.Forms.TextBox tbSysInfo;
        private System.Windows.Forms.Label lvlSysInfo;
        private System.Windows.Forms.Label lblMach;
        private System.Windows.Forms.TextBox tbMTips;
        private System.Windows.Forms.Label lvlTips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox numMach;
    }
}