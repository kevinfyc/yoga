﻿namespace UI.Potential
{
    partial class frmPotentialCustomersTrackeInfo
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
            this.dataAdviserInfo = new System.Windows.Forms.DataGridView();
            this.clAdviserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdviserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAdviserPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataPotentialInfo = new System.Windows.Forms.DataGridView();
            this.clId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLastTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numAdviserId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdviserInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPotentialInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdviserId)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAdviserInfo
            // 
            this.dataAdviserInfo.AllowUserToAddRows = false;
            this.dataAdviserInfo.AllowUserToDeleteRows = false;
            this.dataAdviserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdviserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAdviserId,
            this.clAdviserName,
            this.clAdviserPosition});
            this.dataAdviserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataAdviserInfo.Location = new System.Drawing.Point(3, 17);
            this.dataAdviserInfo.MultiSelect = false;
            this.dataAdviserInfo.Name = "dataAdviserInfo";
            this.dataAdviserInfo.ReadOnly = true;
            this.dataAdviserInfo.RowTemplate.Height = 23;
            this.dataAdviserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAdviserInfo.Size = new System.Drawing.Size(344, 485);
            this.dataAdviserInfo.TabIndex = 0;
            // 
            // clAdviserId
            // 
            this.clAdviserId.DataPropertyName = "Id";
            this.clAdviserId.HeaderText = "编号";
            this.clAdviserId.Name = "clAdviserId";
            this.clAdviserId.ReadOnly = true;
            // 
            // clAdviserName
            // 
            this.clAdviserName.DataPropertyName = "Name";
            this.clAdviserName.HeaderText = "姓名";
            this.clAdviserName.Name = "clAdviserName";
            this.clAdviserName.ReadOnly = true;
            // 
            // clAdviserPosition
            // 
            this.clAdviserPosition.DataPropertyName = "Position";
            this.clAdviserPosition.HeaderText = "岗位";
            this.clAdviserPosition.Name = "clAdviserPosition";
            this.clAdviserPosition.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataPotentialInfo);
            this.groupBox2.Location = new System.Drawing.Point(367, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 505);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "潜在客户信息";
            // 
            // dataPotentialInfo
            // 
            this.dataPotentialInfo.AllowUserToAddRows = false;
            this.dataPotentialInfo.AllowUserToDeleteRows = false;
            this.dataPotentialInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPotentialInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId2,
            this.clName2,
            this.clMobilePhone,
            this.clLastTime});
            this.dataPotentialInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPotentialInfo.Location = new System.Drawing.Point(3, 17);
            this.dataPotentialInfo.Name = "dataPotentialInfo";
            this.dataPotentialInfo.ReadOnly = true;
            this.dataPotentialInfo.RowTemplate.Height = 23;
            this.dataPotentialInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPotentialInfo.Size = new System.Drawing.Size(399, 485);
            this.dataPotentialInfo.TabIndex = 1;
            // 
            // clId2
            // 
            this.clId2.DataPropertyName = "Id";
            this.clId2.HeaderText = "编号";
            this.clId2.Name = "clId2";
            this.clId2.ReadOnly = true;
            this.clId2.Width = 80;
            // 
            // clName2
            // 
            this.clName2.DataPropertyName = "Name";
            this.clName2.HeaderText = "姓名";
            this.clName2.Name = "clName2";
            this.clName2.ReadOnly = true;
            this.clName2.Width = 85;
            // 
            // clMobilePhone
            // 
            this.clMobilePhone.DataPropertyName = "MobilePhone";
            this.clMobilePhone.HeaderText = "手机";
            this.clMobilePhone.Name = "clMobilePhone";
            this.clMobilePhone.ReadOnly = true;
            this.clMobilePhone.Width = 85;
            // 
            // clLastTime
            // 
            this.clLastTime.DataPropertyName = "LastContact";
            this.clLastTime.HeaderText = "最后联系";
            this.clLastTime.Name = "clLastTime";
            this.clLastTime.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(706, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.AutoSize = true;
            this.btnQuery.Location = new System.Drawing.Point(389, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(63, 22);
            this.btnQuery.TabIndex = 66;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(458, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 22);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataAdviserInfo);
            this.groupBox1.Location = new System.Drawing.Point(14, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 505);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会籍顾问信息";
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Location = new System.Drawing.Point(524, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 22);
            this.btnDel.TabIndex = 74;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(17, 20);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 104;
            this.lblName.Text = "姓名";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(64, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(83, 21);
            this.tbName.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(165, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 106;
            this.label1.Text = "顾问编号";
            // 
            // numAdviserId
            // 
            this.numAdviserId.Location = new System.Drawing.Point(233, 15);
            this.numAdviserId.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numAdviserId.Name = "numAdviserId";
            this.numAdviserId.Size = new System.Drawing.Size(83, 21);
            this.numAdviserId.TabIndex = 108;
            // 
            // frmPotentialCustomersTrackeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numAdviserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPotentialCustomersTrackeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "潜在客户跟踪信息";
            this.Activated += new System.EventHandler(this.frmPotentialCustomersTrackeInfo_Activated);
            this.Deactivate += new System.EventHandler(this.frmPotentialCustomersTrackeInfo_Deactivate);
            this.Load += new System.EventHandler(this.frmPotentialCustomersTrackeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAdviserInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPotentialInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAdviserId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAdviserInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataPotentialInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLastTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdviserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdviserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAdviserPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAdviserId;
    }
}