namespace UI.Vip
{
    partial class frmVipEnter
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.cbIsCard2 = new System.Windows.Forms.CheckBox();
            this.timeRental = new System.Windows.Forms.DateTimePicker();
            this.lblRentalTime = new System.Windows.Forms.Label();
            this.cbRentalBox = new System.Windows.Forms.ComboBox();
            this.lblRentalBox = new System.Windows.Forms.Label();
            this.lblCoach = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbCardType = new System.Windows.Forms.TextBox();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.tbMPhone = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.numRemain = new System.Windows.Forms.NumericUpDown();
            this.numHowMach = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbNeedName = new System.Windows.Forms.TextBox();
            this.lblNeedName = new System.Windows.Forms.Label();
            this.lblNeedNo = new System.Windows.Forms.Label();
            this.tbCardNoQ = new System.Windows.Forms.TextBox();
            this.dataEnd = new System.Windows.Forms.DateTimePicker();
            this.pVideo = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbJoneCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTips = new System.Windows.Forms.TextBox();
            this.tbCoach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTempTimes = new System.Windows.Forms.TextBox();
            this.lblTempTimes = new System.Windows.Forms.Label();
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
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRemain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHowMach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(492, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(&Q)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(411, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "进场(&E)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(133, 57);
            this.lblCount.Name = "lblCount";
            this.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCount.Size = new System.Drawing.Size(53, 12);
            this.lblCount.TabIndex = 48;
            this.lblCount.Text = "次卡次数";
            // 
            // cbIsCard2
            // 
            this.cbIsCard2.AutoSize = true;
            this.cbIsCard2.Location = new System.Drawing.Point(45, 56);
            this.cbIsCard2.Name = "cbIsCard2";
            this.cbIsCard2.Size = new System.Drawing.Size(84, 16);
            this.cbIsCard2.TabIndex = 47;
            this.cbIsCard2.Text = "是否为次卡";
            this.cbIsCard2.UseVisualStyleBackColor = true;
            // 
            // timeRental
            // 
            this.timeRental.Location = new System.Drawing.Point(236, 210);
            this.timeRental.Name = "timeRental";
            this.timeRental.Size = new System.Drawing.Size(156, 21);
            this.timeRental.TabIndex = 46;
            // 
            // lblRentalTime
            // 
            this.lblRentalTime.Location = new System.Drawing.Point(177, 213);
            this.lblRentalTime.Name = "lblRentalTime";
            this.lblRentalTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRentalTime.Size = new System.Drawing.Size(53, 12);
            this.lblRentalTime.TabIndex = 45;
            this.lblRentalTime.Text = "租用日期";
            // 
            // cbRentalBox
            // 
            this.cbRentalBox.FormattingEnabled = true;
            this.cbRentalBox.Location = new System.Drawing.Point(66, 211);
            this.cbRentalBox.Name = "cbRentalBox";
            this.cbRentalBox.Size = new System.Drawing.Size(101, 20);
            this.cbRentalBox.TabIndex = 44;
            // 
            // lblRentalBox
            // 
            this.lblRentalBox.Location = new System.Drawing.Point(7, 214);
            this.lblRentalBox.Name = "lblRentalBox";
            this.lblRentalBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRentalBox.Size = new System.Drawing.Size(53, 12);
            this.lblRentalBox.TabIndex = 43;
            this.lblRentalBox.Text = "租用柜子";
            // 
            // lblCoach
            // 
            this.lblCoach.Location = new System.Drawing.Point(341, 186);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCoach.Size = new System.Drawing.Size(53, 12);
            this.lblCoach.TabIndex = 41;
            this.lblCoach.Text = "教练编号";
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
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.tbNeedName);
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.lblNeedName);
            this.groupBox2.Controls.Add(this.cbIsCard2);
            this.groupBox2.Controls.Add(this.lblNeedNo);
            this.groupBox2.Controls.Add(this.tbCardNoQ);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 47);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
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
            // lblNeedNo
            // 
            this.lblNeedNo.Location = new System.Drawing.Point(8, 20);
            this.lblNeedNo.Name = "lblNeedNo";
            this.lblNeedNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNeedNo.Size = new System.Drawing.Size(53, 12);
            this.lblNeedNo.TabIndex = 2;
            this.lblNeedNo.Text = "卡号";
            // 
            // tbCardNoQ
            // 
            this.tbCardNoQ.Location = new System.Drawing.Point(66, 17);
            this.tbCardNoQ.Name = "tbCardNoQ";
            this.tbCardNoQ.Size = new System.Drawing.Size(100, 21);
            this.tbCardNoQ.TabIndex = 49;
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
            this.pVideo.Location = new System.Drawing.Point(347, 20);
            this.pVideo.Name = "pVideo";
            this.pVideo.Size = new System.Drawing.Size(213, 155);
            this.pVideo.TabIndex = 61;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateBirthday);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbJoneCount);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbTips);
            this.groupBox3.Controls.Add(this.tbCoach);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbTempTimes);
            this.groupBox3.Controls.Add(this.lblTempTimes);
            this.groupBox3.Controls.Add(this.tbGender);
            this.groupBox3.Controls.Add(this.tbCardType);
            this.groupBox3.Controls.Add(this.tbCardNo);
            this.groupBox3.Controls.Add(this.tbMPhone);
            this.groupBox3.Controls.Add(this.tbPhone);
            this.groupBox3.Controls.Add(this.numRemain);
            this.groupBox3.Controls.Add(this.numHowMach);
            this.groupBox3.Controls.Add(this.dataEnd);
            this.groupBox3.Controls.Add(this.pVideo);
            this.groupBox3.Controls.Add(this.dataBgn);
            this.groupBox3.Controls.Add(this.timeRental);
            this.groupBox3.Controls.Add(this.lblRemain);
            this.groupBox3.Controls.Add(this.lvlHowMach);
            this.groupBox3.Controls.Add(this.lblRentalTime);
            this.groupBox3.Controls.Add(this.lblCardKind);
            this.groupBox3.Controls.Add(this.cbRentalBox);
            this.groupBox3.Controls.Add(this.lblEndTime);
            this.groupBox3.Controls.Add(this.lblCoach);
            this.groupBox3.Controls.Add(this.lblBgnTime);
            this.groupBox3.Controls.Add(this.lblRentalBox);
            this.groupBox3.Controls.Add(this.lblMPhone);
            this.groupBox3.Controls.Add(this.lblPhone);
            this.groupBox3.Controls.Add(this.tbNo2);
            this.groupBox3.Controls.Add(this.lvlNo2);
            this.groupBox3.Controls.Add(this.tbnational);
            this.groupBox3.Controls.Add(this.lblNational);
            this.groupBox3.Controls.Add(this.tbNationality);
            this.groupBox3.Controls.Add(this.lblNationality);
            this.groupBox3.Controls.Add(this.lblSex);
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.lblNo);
            this.groupBox3.Location = new System.Drawing.Point(7, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 375);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "会员信息资料";
            // 
            // tbJoneCount
            // 
            this.tbJoneCount.Location = new System.Drawing.Point(457, 210);
            this.tbJoneCount.Name = "tbJoneCount";
            this.tbJoneCount.Size = new System.Drawing.Size(100, 21);
            this.tbJoneCount.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 80;
            this.label1.Text = "参与次数";
            // 
            // tbTips
            // 
            this.tbTips.Location = new System.Drawing.Point(66, 269);
            this.tbTips.Multiline = true;
            this.tbTips.Name = "tbTips";
            this.tbTips.Size = new System.Drawing.Size(491, 100);
            this.tbTips.TabIndex = 79;
            // 
            // tbCoach
            // 
            this.tbCoach.Location = new System.Drawing.Point(401, 181);
            this.tbCoach.Name = "tbCoach";
            this.tbCoach.Size = new System.Drawing.Size(100, 21);
            this.tbCoach.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 75;
            this.label2.Text = "备注";
            // 
            // tbTempTimes
            // 
            this.tbTempTimes.Location = new System.Drawing.Point(235, 182);
            this.tbTempTimes.Name = "tbTempTimes";
            this.tbTempTimes.Size = new System.Drawing.Size(100, 21);
            this.tbTempTimes.TabIndex = 74;
            // 
            // lblTempTimes
            // 
            this.lblTempTimes.AutoSize = true;
            this.lblTempTimes.Location = new System.Drawing.Point(175, 185);
            this.lblTempTimes.Name = "lblTempTimes";
            this.lblTempTimes.Size = new System.Drawing.Size(53, 12);
            this.lblTempTimes.TabIndex = 72;
            this.lblTempTimes.Text = "次卡次数";
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
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(235, 242);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(100, 21);
            this.dateBirthday.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(176, 248);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 84;
            this.label3.Text = "生日";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(66, 242);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 21);
            this.tbEmail.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 245);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 82;
            this.label4.Text = "邮箱";
            // 
            // frmVipEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 475);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVipEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员进场";
            this.Activated += new System.EventHandler(this.frmVipEnter_Activated);
            this.Deactivate += new System.EventHandler(this.frmVipEnter_Deactivate);
            this.Load += new System.EventHandler(this.frmVipEnter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRemain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHowMach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox cbIsCard2;
        private System.Windows.Forms.DateTimePicker timeRental;
        private System.Windows.Forms.Label lblRentalTime;
        private System.Windows.Forms.ComboBox cbRentalBox;
        private System.Windows.Forms.Label lblRentalBox;
        private System.Windows.Forms.Label lblCoach;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbCardType;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.TextBox tbMPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.NumericUpDown numRemain;
        private System.Windows.Forms.NumericUpDown numHowMach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbNeedName;
        private System.Windows.Forms.Label lblNeedName;
        private System.Windows.Forms.Label lblNeedNo;
        private System.Windows.Forms.DateTimePicker dataEnd;
        private System.Windows.Forms.Panel pVideo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTempTimes;
        private System.Windows.Forms.Label lblTempTimes;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCoach;
        private System.Windows.Forms.TextBox tbTips;
        private System.Windows.Forms.TextBox tbCardNoQ;
        private System.Windows.Forms.TextBox tbJoneCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
    }
}