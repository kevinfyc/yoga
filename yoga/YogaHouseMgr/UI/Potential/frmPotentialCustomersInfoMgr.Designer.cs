namespace UI.Potential
{
    partial class frmPotentialCustomersInfoMgr
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
            this.tbMPhone = new System.Windows.Forms.TextBox();
            this.dataVipInfo = new System.Windows.Forms.DataGridView();
            this.clCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMobilephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLastContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustomerChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paging1 = new Control.Paging();
            this.lblMPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportToPhone = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAdviser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbChannel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrackInfo = new System.Windows.Forms.Button();
            this.numberId = new Control.Numberic();
            ((System.ComponentModel.ISupportInitialize)(this.dataVipInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMPhone
            // 
            this.tbMPhone.Location = new System.Drawing.Point(399, 39);
            this.tbMPhone.Name = "tbMPhone";
            this.tbMPhone.Size = new System.Drawing.Size(79, 21);
            this.tbMPhone.TabIndex = 93;
            // 
            // dataVipInfo
            // 
            this.dataVipInfo.AllowUserToAddRows = false;
            this.dataVipInfo.AllowUserToDeleteRows = false;
            this.dataVipInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVipInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCardNo,
            this.clName,
            this.clGender,
            this.clMobilephone,
            this.clAdviser,
            this.clCreateTime,
            this.clLastContact,
            this.clCustomerChannel,
            this.clRemarks});
            this.dataVipInfo.Location = new System.Drawing.Point(12, 126);
            this.dataVipInfo.Name = "dataVipInfo";
            this.dataVipInfo.ReadOnly = true;
            this.dataVipInfo.RowTemplate.Height = 23;
            this.dataVipInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVipInfo.Size = new System.Drawing.Size(760, 424);
            this.dataVipInfo.TabIndex = 91;
            this.dataVipInfo.VirtualMode = true;
            this.dataVipInfo.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataVipInfo_CellValueNeeded);
            // 
            // clCardNo
            // 
            this.clCardNo.DataPropertyName = "Id";
            this.clCardNo.HeaderText = "编号";
            this.clCardNo.Name = "clCardNo";
            this.clCardNo.ReadOnly = true;
            this.clCardNo.Width = 80;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "姓名";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 80;
            // 
            // clGender
            // 
            this.clGender.DataPropertyName = "Gender";
            this.clGender.HeaderText = "性别";
            this.clGender.Name = "clGender";
            this.clGender.ReadOnly = true;
            this.clGender.Width = 52;
            // 
            // clMobilephone
            // 
            this.clMobilephone.DataPropertyName = "Mobilephone";
            this.clMobilephone.HeaderText = "手机号码";
            this.clMobilephone.Name = "clMobilephone";
            this.clMobilephone.ReadOnly = true;
            this.clMobilephone.Width = 80;
            // 
            // clAdviser
            // 
            this.clAdviser.HeaderText = "顾问";
            this.clAdviser.Name = "clAdviser";
            this.clAdviser.ReadOnly = true;
            this.clAdviser.Width = 60;
            // 
            // clCreateTime
            // 
            this.clCreateTime.DataPropertyName = "CreateTime";
            this.clCreateTime.HeaderText = "加入时间";
            this.clCreateTime.Name = "clCreateTime";
            this.clCreateTime.ReadOnly = true;
            this.clCreateTime.Width = 90;
            // 
            // clLastContact
            // 
            this.clLastContact.DataPropertyName = "LastContact";
            this.clLastContact.HeaderText = "最近联系";
            this.clLastContact.Name = "clLastContact";
            this.clLastContact.ReadOnly = true;
            this.clLastContact.Width = 90;
            // 
            // clCustomerChannel
            // 
            this.clCustomerChannel.DataPropertyName = "CustomerChannel";
            this.clCustomerChannel.HeaderText = "客户渠道";
            this.clCustomerChannel.Name = "clCustomerChannel";
            this.clCustomerChannel.ReadOnly = true;
            // 
            // clRemarks
            // 
            this.clRemarks.DataPropertyName = "Remarks";
            this.clRemarks.HeaderText = "备注";
            this.clRemarks.Name = "clRemarks";
            this.clRemarks.ReadOnly = true;
            // 
            // paging1
            // 
            this.paging1.CurrentPage = 0;
            this.paging1.Location = new System.Drawing.Point(12, 98);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(760, 22);
            this.paging1.TabIndex = 90;
            // 
            // lblMPhone
            // 
            this.lblMPhone.Location = new System.Drawing.Point(340, 44);
            this.lblMPhone.Name = "lblMPhone";
            this.lblMPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMPhone.Size = new System.Drawing.Size(53, 12);
            this.lblMPhone.TabIndex = 86;
            this.lblMPhone.Text = "手机号码";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(180, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(52, 21);
            this.tbName.TabIndex = 85;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(133, 45);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 84;
            this.lblName.Text = "姓名";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(12, 45);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNo.Size = new System.Drawing.Size(32, 12);
            this.lblNo.TabIndex = 83;
            this.lblNo.Text = "编号";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(709, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExportToPhone
            // 
            this.btnExportToPhone.AutoSize = true;
            this.btnExportToPhone.Location = new System.Drawing.Point(276, 12);
            this.btnExportToPhone.Name = "btnExportToPhone";
            this.btnExportToPhone.Size = new System.Drawing.Size(81, 22);
            this.btnExportToPhone.TabIndex = 80;
            this.btnExportToPhone.Text = "导出手机(&O)";
            this.btnExportToPhone.UseVisualStyleBackColor = true;
            this.btnExportToPhone.Click += new System.EventHandler(this.btnExportToPhone_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.AutoSize = true;
            this.btnTrack.Location = new System.Drawing.Point(363, 12);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(60, 22);
            this.btnTrack.TabIndex = 79;
            this.btnTrack.Text = "跟踪(&T)";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(210, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 22);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = "查询(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Location = new System.Drawing.Point(144, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 22);
            this.btnDel.TabIndex = 73;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.AutoSize = true;
            this.btnModify.Location = new System.Drawing.Point(78, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(60, 22);
            this.btnModify.TabIndex = 72;
            this.btnModify.Text = "修改(&M)";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 22);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(481, 44);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 95;
            this.label1.Text = "顾问";
            // 
            // cbAdviser
            // 
            this.cbAdviser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdviser.FormattingEnabled = true;
            this.cbAdviser.Location = new System.Drawing.Point(527, 40);
            this.cbAdviser.Name = "cbAdviser";
            this.cbAdviser.Size = new System.Drawing.Size(77, 20);
            this.cbAdviser.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(232, 44);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 97;
            this.label2.Text = "性别";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "女",
            "男",
            "其它"});
            this.cbGender.Location = new System.Drawing.Point(279, 39);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(55, 20);
            this.cbGender.TabIndex = 98;
            // 
            // tbChannel
            // 
            this.tbChannel.Location = new System.Drawing.Point(678, 40);
            this.tbChannel.Name = "tbChannel";
            this.tbChannel.Size = new System.Drawing.Size(94, 21);
            this.tbChannel.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(607, 44);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 99;
            this.label3.Text = "客户渠道";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(50, 68);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(722, 21);
            this.tbRemarks.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 101;
            this.label4.Text = "备注";
            // 
            // btnTrackInfo
            // 
            this.btnTrackInfo.AutoSize = true;
            this.btnTrackInfo.Location = new System.Drawing.Point(429, 12);
            this.btnTrackInfo.Name = "btnTrackInfo";
            this.btnTrackInfo.Size = new System.Drawing.Size(81, 22);
            this.btnTrackInfo.TabIndex = 103;
            this.btnTrackInfo.Text = "跟踪信息(&I)";
            this.btnTrackInfo.UseVisualStyleBackColor = true;
            this.btnTrackInfo.Click += new System.EventHandler(this.btnTrackInfo_Click);
            // 
            // numberId
            // 
            this.numberId.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numberId.Location = new System.Drawing.Point(50, 39);
            this.numberId.MaxLength = ((uint)(0u));
            this.numberId.Name = "numberId";
            this.numberId.Size = new System.Drawing.Size(79, 21);
            this.numberId.TabIndex = 104;
            this.numberId.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // frmPotentialCustomersInfoMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.numberId);
            this.Controls.Add(this.btnTrackInfo);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbChannel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAdviser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMPhone);
            this.Controls.Add(this.dataVipInfo);
            this.Controls.Add(this.paging1);
            this.Controls.Add(this.lblMPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExportToPhone);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPotentialCustomersInfoMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "潜在用户信息管理";
            this.Activated += new System.EventHandler(this.frmPotentialCustomersInfoMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmPotentialCustomersInfoMgr_Deactivate);
            this.Load += new System.EventHandler(this.frmPotentialCustomersInfoMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVipInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMPhone;
        private System.Windows.Forms.DataGridView dataVipInfo;
        private Control.Paging paging1;
        private System.Windows.Forms.Label lblMPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportToPhone;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAdviser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbChannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrackInfo;
        private Control.Numberic numberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMobilephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdviser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLastContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustomerChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRemarks;
    }
}