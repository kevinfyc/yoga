﻿namespace UI.Vip
{
    partial class frmVipPrepaid
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvlMach = new System.Windows.Forms.Label();
            this.numMach = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCost = new System.Windows.Forms.Button();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbCardType = new System.Windows.Forms.TextBox();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.tbMPhone = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.numRemain = new System.Windows.Forms.NumericUpDown();
            this.numHowMach = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataEnd = new System.Windows.Forms.DateTimePicker();
            this.pVideo = new System.Windows.Forms.Panel();
            this.dataBgn = new System.Windows.Forms.DateTimePicker();
            this.lblRemain = new System.Windows.Forms.Label();
            this.lvlHowMach = new System.Windows.Forms.Label();
            this.lblCardKind = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblBgnTime = new System.Windows.Forms.Label();
            this.lblMPhone = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbNo2 = new System.Windows.Forms.TextBox();
            this.lvlNo2 = new System.Windows.Forms.Label();
            this.tbnational = new System.Windows.Forms.TextBox();
            this.lblNational = new System.Windows.Forms.Label();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblNeedNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbNeedName = new System.Windows.Forms.TextBox();
            this.lblNeedName = new System.Windows.Forms.Label();
            this.tbCardNoQ = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHowMach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvlMach);
            this.groupBox3.Controls.Add(this.numMach);
            this.groupBox3.Location = new System.Drawing.Point(7, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 42);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // lvlMach
            // 
            this.lvlMach.Location = new System.Drawing.Point(177, 17);
            this.lvlMach.Name = "lvlMach";
            this.lvlMach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlMach.Size = new System.Drawing.Size(53, 12);
            this.lvlMach.TabIndex = 50;
            this.lvlMach.Text = "金额";
            // 
            // numMach
            // 
            this.numMach.DecimalPlaces = 2;
            this.numMach.Location = new System.Drawing.Point(238, 13);
            this.numMach.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numMach.Name = "numMach";
            this.numMach.Size = new System.Drawing.Size(98, 21);
            this.numMach.TabIndex = 72;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(502, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消(&E)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(421, 327);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(75, 23);
            this.btnCost.TabIndex = 8;
            this.btnCost.Text = "冲值(&S)";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(67, 47);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(100, 21);
            this.tbGender.TabIndex = 71;
            // 
            // tbCardType
            // 
            this.tbCardType.Location = new System.Drawing.Point(67, 153);
            this.tbCardType.Name = "tbCardType";
            this.tbCardType.Size = new System.Drawing.Size(100, 21);
            this.tbCardType.TabIndex = 70;
            // 
            // tbCardNo
            // 
            this.tbCardNo.Location = new System.Drawing.Point(67, 20);
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(100, 21);
            this.tbCardNo.TabIndex = 69;
            // 
            // tbMPhone
            // 
            this.tbMPhone.Location = new System.Drawing.Point(236, 103);
            this.tbMPhone.Name = "tbMPhone";
            this.tbMPhone.Size = new System.Drawing.Size(100, 21);
            this.tbMPhone.TabIndex = 68;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(67, 101);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 21);
            this.tbPhone.TabIndex = 67;
            // 
            // numRemain
            // 
            this.numRemain.DecimalPlaces = 2;
            this.numRemain.Location = new System.Drawing.Point(67, 181);
            this.numRemain.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numRemain.Name = "numRemain";
            this.numRemain.Size = new System.Drawing.Size(100, 21);
            this.numRemain.TabIndex = 66;
            // 
            // numHowMach
            // 
            this.numHowMach.DecimalPlaces = 2;
            this.numHowMach.Location = new System.Drawing.Point(237, 154);
            this.numHowMach.Maximum = new decimal(new int[] {
            -62924560,
            804571906,
            542643,
            0});
            this.numHowMach.Name = "numHowMach";
            this.numHowMach.Size = new System.Drawing.Size(100, 21);
            this.numHowMach.TabIndex = 65;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbGender);
            this.groupBox2.Controls.Add(this.tbCardType);
            this.groupBox2.Controls.Add(this.tbCardNo);
            this.groupBox2.Controls.Add(this.tbMPhone);
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Controls.Add(this.numRemain);
            this.groupBox2.Controls.Add(this.numHowMach);
            this.groupBox2.Controls.Add(this.dataEnd);
            this.groupBox2.Controls.Add(this.pVideo);
            this.groupBox2.Controls.Add(this.dataBgn);
            this.groupBox2.Controls.Add(this.lblRemain);
            this.groupBox2.Controls.Add(this.lvlHowMach);
            this.groupBox2.Controls.Add(this.lblCardKind);
            this.groupBox2.Controls.Add(this.lblEndTime);
            this.groupBox2.Controls.Add(this.lblBgnTime);
            this.groupBox2.Controls.Add(this.lblMPhone);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.tbNo2);
            this.groupBox2.Controls.Add(this.lvlNo2);
            this.groupBox2.Controls.Add(this.tbnational);
            this.groupBox2.Controls.Add(this.lblNational);
            this.groupBox2.Controls.Add(this.tbNationality);
            this.groupBox2.Controls.Add(this.lblNationality);
            this.groupBox2.Controls.Add(this.lblSex);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.lblNo);
            this.groupBox2.Location = new System.Drawing.Point(7, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 214);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员信息资料";
            // 
            // dataEnd
            // 
            this.dataEnd.Location = new System.Drawing.Point(236, 128);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.Size = new System.Drawing.Size(100, 21);
            this.dataEnd.TabIndex = 40;
            // 
            // pVideo
            // 
            this.pVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pVideo.Location = new System.Drawing.Point(347, 23);
            this.pVideo.Name = "pVideo";
            this.pVideo.Size = new System.Drawing.Size(213, 156);
            this.pVideo.TabIndex = 61;
            // 
            // dataBgn
            // 
            this.dataBgn.Location = new System.Drawing.Point(67, 128);
            this.dataBgn.Name = "dataBgn";
            this.dataBgn.Size = new System.Drawing.Size(100, 21);
            this.dataBgn.TabIndex = 39;
            // 
            // lblRemain
            // 
            this.lblRemain.Location = new System.Drawing.Point(8, 185);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRemain.Size = new System.Drawing.Size(53, 12);
            this.lblRemain.TabIndex = 57;
            this.lblRemain.Text = "卡内金额";
            // 
            // lvlHowMach
            // 
            this.lvlHowMach.Location = new System.Drawing.Point(177, 158);
            this.lvlHowMach.Name = "lvlHowMach";
            this.lvlHowMach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlHowMach.Size = new System.Drawing.Size(53, 12);
            this.lvlHowMach.TabIndex = 55;
            this.lvlHowMach.Text = "卡项金额";
            // 
            // lblCardKind
            // 
            this.lblCardKind.Location = new System.Drawing.Point(8, 158);
            this.lblCardKind.Name = "lblCardKind";
            this.lblCardKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCardKind.Size = new System.Drawing.Size(53, 12);
            this.lblCardKind.TabIndex = 54;
            this.lblCardKind.Text = "卡类型";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(177, 134);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEndTime.Size = new System.Drawing.Size(53, 12);
            this.lblEndTime.TabIndex = 53;
            this.lblEndTime.Text = "到期日期";
            // 
            // lblBgnTime
            // 
            this.lblBgnTime.Location = new System.Drawing.Point(8, 131);
            this.lblBgnTime.Name = "lblBgnTime";
            this.lblBgnTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBgnTime.Size = new System.Drawing.Size(53, 12);
            this.lblBgnTime.TabIndex = 52;
            this.lblBgnTime.Text = "注册日期";
            // 
            // lblMPhone
            // 
            this.lblMPhone.Location = new System.Drawing.Point(177, 107);
            this.lblMPhone.Name = "lblMPhone";
            this.lblMPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMPhone.Size = new System.Drawing.Size(53, 12);
            this.lblMPhone.TabIndex = 50;
            this.lblMPhone.Text = "移动电话";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(8, 104);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhone.Size = new System.Drawing.Size(53, 12);
            this.lblPhone.TabIndex = 48;
            this.lblPhone.Text = "电话";
            // 
            // tbNo2
            // 
            this.tbNo2.Location = new System.Drawing.Point(236, 77);
            this.tbNo2.Name = "tbNo2";
            this.tbNo2.Size = new System.Drawing.Size(100, 21);
            this.tbNo2.TabIndex = 47;
            // 
            // lvlNo2
            // 
            this.lvlNo2.Location = new System.Drawing.Point(177, 80);
            this.lvlNo2.Name = "lvlNo2";
            this.lvlNo2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlNo2.Size = new System.Drawing.Size(53, 12);
            this.lvlNo2.TabIndex = 46;
            this.lvlNo2.Text = "合约编号";
            // 
            // tbnational
            // 
            this.tbnational.Location = new System.Drawing.Point(67, 74);
            this.tbnational.Name = "tbnational";
            this.tbnational.Size = new System.Drawing.Size(100, 21);
            this.tbnational.TabIndex = 45;
            // 
            // lblNational
            // 
            this.lblNational.Location = new System.Drawing.Point(8, 77);
            this.lblNational.Name = "lblNational";
            this.lblNational.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNational.Size = new System.Drawing.Size(53, 12);
            this.lblNational.TabIndex = 44;
            this.lblNational.Text = "民族";
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(236, 47);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(100, 21);
            this.tbNationality.TabIndex = 43;
            // 
            // lblNationality
            // 
            this.lblNationality.Location = new System.Drawing.Point(177, 50);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNationality.Size = new System.Drawing.Size(53, 12);
            this.lblNationality.TabIndex = 42;
            this.lblNationality.Text = "国籍";
            // 
            // lblSex
            // 
            this.lblSex.Location = new System.Drawing.Point(8, 50);
            this.lblSex.Name = "lblSex";
            this.lblSex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSex.Size = new System.Drawing.Size(53, 12);
            this.lblSex.TabIndex = 41;
            this.lblSex.Text = "性别";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(236, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 40;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(177, 23);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "姓名";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(8, 23);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNo.Size = new System.Drawing.Size(53, 12);
            this.lblNo.TabIndex = 37;
            this.lblNo.Text = "卡号";
            // 
            // lblNeedNo
            // 
            this.lblNeedNo.Location = new System.Drawing.Point(8, 20);
            this.lblNeedNo.Name = "lblNeedNo";
            this.lblNeedNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNeedNo.Size = new System.Drawing.Size(53, 12);
            this.lblNeedNo.TabIndex = 2;
            this.lblNeedNo.Text = "卡号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCardNoQ);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbNeedName);
            this.groupBox1.Controls.Add(this.lblNeedName);
            this.groupBox1.Controls.Add(this.lblNeedNo);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 47);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(347, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(217, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询(&Q)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbNeedName
            // 
            this.tbNeedName.Location = new System.Drawing.Point(235, 17);
            this.tbNeedName.Name = "tbNeedName";
            this.tbNeedName.Size = new System.Drawing.Size(100, 21);
            this.tbNeedName.TabIndex = 5;
            // 
            // lblNeedName
            // 
            this.lblNeedName.Location = new System.Drawing.Point(176, 20);
            this.lblNeedName.Name = "lblNeedName";
            this.lblNeedName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNeedName.Size = new System.Drawing.Size(53, 12);
            this.lblNeedName.TabIndex = 4;
            this.lblNeedName.Text = "姓名";
            // 
            // tbCardNoQ
            // 
            this.tbCardNoQ.Location = new System.Drawing.Point(67, 17);
            this.tbCardNoQ.Name = "tbCardNoQ";
            this.tbCardNoQ.Size = new System.Drawing.Size(100, 21);
            this.tbCardNoQ.TabIndex = 50;
            // 
            // frmVipPrepaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVipPrepaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员充值";
            this.Activated += new System.EventHandler(this.frmVipPrepaid_Activated);
            this.Deactivate += new System.EventHandler(this.frmVipPrepaid_Deactivate);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHowMach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lvlMach;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.NumericUpDown numMach;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbCardType;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.TextBox tbMPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.NumericUpDown numRemain;
        private System.Windows.Forms.NumericUpDown numHowMach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dataEnd;
        private System.Windows.Forms.Panel pVideo;
        private System.Windows.Forms.DateTimePicker dataBgn;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label lvlHowMach;
        private System.Windows.Forms.Label lblCardKind;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblBgnTime;
        private System.Windows.Forms.Label lblMPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbNo2;
        private System.Windows.Forms.Label lvlNo2;
        private System.Windows.Forms.TextBox tbnational;
        private System.Windows.Forms.Label lblNational;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblNeedNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbNeedName;
        private System.Windows.Forms.Label lblNeedName;
        private System.Windows.Forms.TextBox tbCardNoQ;

    }
}