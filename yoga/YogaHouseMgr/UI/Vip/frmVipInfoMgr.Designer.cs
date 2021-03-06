﻿namespace UI.Vip
{
    partial class frmVipInfoMgr
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnVacate = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCardKind = new System.Windows.Forms.ComboBox();
            this.lblCardKind = new System.Windows.Forms.Label();
            this.lblMPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.dataVipInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMPhone = new System.Windows.Forms.TextBox();
            this.paging1 = new Control.Paging();
            this.tbCardNoQ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataVipInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 22);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.AutoSize = true;
            this.btnModify.Location = new System.Drawing.Point(78, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(60, 22);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "修改(&M)";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Location = new System.Drawing.Point(144, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 22);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Location = new System.Drawing.Point(210, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(60, 22);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "查看(&V)";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnChange
            // 
            this.btnChange.AutoSize = true;
            this.btnChange.Location = new System.Drawing.Point(277, 12);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(60, 22);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "转卡(&Z)";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnVacate
            // 
            this.btnVacate.AutoSize = true;
            this.btnVacate.Location = new System.Drawing.Point(343, 12);
            this.btnVacate.Name = "btnVacate";
            this.btnVacate.Size = new System.Drawing.Size(60, 22);
            this.btnVacate.TabIndex = 6;
            this.btnVacate.Text = "请假(&H)";
            this.btnVacate.UseVisualStyleBackColor = true;
            this.btnVacate.Click += new System.EventHandler(this.btnVacate_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.AutoSize = true;
            this.btnEnter.Location = new System.Drawing.Point(409, 12);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(60, 22);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "进场(&E)";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Location = new System.Drawing.Point(475, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 22);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "导出(&S)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.AutoSize = true;
            this.btnQuery.Location = new System.Drawing.Point(541, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(82, 22);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(709, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbCardKind
            // 
            this.cbCardKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardKind.FormattingEnabled = true;
            this.cbCardKind.Items.AddRange(new object[] {
            "全部",
            "次卡",
            "月卡",
            "季卡",
            "半年卡",
            "一年卡",
            "二年卡",
            "三年卡",
            "高温卡"});
            this.cbCardKind.Location = new System.Drawing.Point(422, 42);
            this.cbCardKind.Name = "cbCardKind";
            this.cbCardKind.Size = new System.Drawing.Size(49, 20);
            this.cbCardKind.TabIndex = 44;
            // 
            // lblCardKind
            // 
            this.lblCardKind.Location = new System.Drawing.Point(370, 45);
            this.lblCardKind.Name = "lblCardKind";
            this.lblCardKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCardKind.Size = new System.Drawing.Size(46, 12);
            this.lblCardKind.TabIndex = 43;
            this.lblCardKind.Text = "卡类型";
            // 
            // lblMPhone
            // 
            this.lblMPhone.AutoSize = true;
            this.lblMPhone.Location = new System.Drawing.Point(255, 45);
            this.lblMPhone.Name = "lblMPhone";
            this.lblMPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMPhone.Size = new System.Drawing.Size(29, 12);
            this.lblMPhone.TabIndex = 41;
            this.lblMPhone.Text = "手机";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(195, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(52, 21);
            this.tbName.TabIndex = 40;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(148, 45);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "姓名";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(12, 45);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNo.Size = new System.Drawing.Size(32, 12);
            this.lblNo.TabIndex = 37;
            this.lblNo.Text = "卡号";
            // 
            // dataVipInfo
            // 
            this.dataVipInfo.AllowUserToAddRows = false;
            this.dataVipInfo.AllowUserToDeleteRows = false;
            this.dataVipInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVipInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.clScore,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dataVipInfo.Location = new System.Drawing.Point(12, 98);
            this.dataVipInfo.Name = "dataVipInfo";
            this.dataVipInfo.ReadOnly = true;
            this.dataVipInfo.RowTemplate.Height = 23;
            this.dataVipInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVipInfo.Size = new System.Drawing.Size(760, 452);
            this.dataVipInfo.TabIndex = 47;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "卡号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Mobilephone";
            this.Column3.HeaderText = "手机";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // clScore
            // 
            this.clScore.DataPropertyName = "Score";
            this.clScore.HeaderText = "积分";
            this.clScore.Name = "clScore";
            this.clScore.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CardType";
            this.Column4.HeaderText = "类型";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IsTemp";
            this.Column5.HeaderText = "次卡";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 60;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "RegistDate";
            this.Column7.HeaderText = "注册时间";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 140;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ExpireDate";
            this.Column8.HeaderText = "过期时间";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 140;
            // 
            // tbMPhone
            // 
            this.tbMPhone.Location = new System.Drawing.Point(290, 41);
            this.tbMPhone.Name = "tbMPhone";
            this.tbMPhone.Size = new System.Drawing.Size(70, 21);
            this.tbMPhone.TabIndex = 70;
            // 
            // paging1
            // 
            this.paging1.CurrentPage = 0;
            this.paging1.Location = new System.Drawing.Point(12, 69);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(760, 22);
            this.paging1.TabIndex = 46;
            // 
            // tbCardNoQ
            // 
            this.tbCardNoQ.Location = new System.Drawing.Point(50, 42);
            this.tbCardNoQ.Name = "tbCardNoQ";
            this.tbCardNoQ.Size = new System.Drawing.Size(92, 21);
            this.tbCardNoQ.TabIndex = 71;
            // 
            // frmVipInfoMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tbCardNoQ);
            this.Controls.Add(this.tbMPhone);
            this.Controls.Add(this.dataVipInfo);
            this.Controls.Add(this.paging1);
            this.Controls.Add(this.cbCardKind);
            this.Controls.Add(this.lblCardKind);
            this.Controls.Add(this.lblMPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnVacate);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVipInfoMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员资料管理";
            this.Activated += new System.EventHandler(this.frmVipInfoMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmVipInfoMgr_Deactivate);
            this.Load += new System.EventHandler(this.frmVipInfoMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVipInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnVacate;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbCardKind;
        private System.Windows.Forms.Label lblCardKind;
        private System.Windows.Forms.Label lblMPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private Control.Paging paging1;
        private System.Windows.Forms.DataGridView dataVipInfo;
        private System.Windows.Forms.TextBox tbMPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox tbCardNoQ;
    }
}