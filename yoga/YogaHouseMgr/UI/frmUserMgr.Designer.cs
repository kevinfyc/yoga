namespace UI
{
    partial class frmUserMgr
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
            this.lblPsd = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dgvUserMgr = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbUserType = new System.Windows.Forms.TextBox();
            this.lblUsetType = new System.Windows.Forms.Label();
            this.tbPsd = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserMgr)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPsd
            // 
            this.lblPsd.Location = new System.Drawing.Point(321, 63);
            this.lblPsd.Name = "lblPsd";
            this.lblPsd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPsd.Size = new System.Drawing.Size(62, 12);
            this.lblPsd.TabIndex = 74;
            this.lblPsd.Text = "密码";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(157, 63);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(60, 12);
            this.lblUserName.TabIndex = 72;
            this.lblUserName.Text = "用户名";
            // 
            // dgvUserMgr
            // 
            this.dgvUserMgr.AllowUserToAddRows = false;
            this.dgvUserMgr.AllowUserToDeleteRows = false;
            this.dgvUserMgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserMgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clUserName,
            this.clPsd,
            this.clUserType});
            this.dgvUserMgr.Location = new System.Drawing.Point(11, 20);
            this.dgvUserMgr.Name = "dgvUserMgr";
            this.dgvUserMgr.ReadOnly = true;
            this.dgvUserMgr.RowTemplate.Height = 23;
            this.dgvUserMgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserMgr.Size = new System.Drawing.Size(742, 419);
            this.dgvUserMgr.TabIndex = 0;
            this.dgvUserMgr.VirtualMode = true;
            // 
            // clId
            // 
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "编号";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clUserName
            // 
            this.clUserName.DataPropertyName = "Name";
            this.clUserName.HeaderText = "用户名";
            this.clUserName.Name = "clUserName";
            this.clUserName.ReadOnly = true;
            // 
            // clPsd
            // 
            this.clPsd.DataPropertyName = "Password";
            this.clPsd.HeaderText = "密码";
            this.clPsd.Name = "clPsd";
            this.clPsd.ReadOnly = true;
            // 
            // clUserType
            // 
            this.clUserType.DataPropertyName = "UserType";
            this.clUserType.HeaderText = "账户类型";
            this.clUserType.Name = "clUserType";
            this.clUserType.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(250, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(678, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "退出(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(169, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(88, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUserMgr);
            this.groupBox2.Location = new System.Drawing.Point(13, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 445);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // group1
            // 
            this.group1.Controls.Add(this.tbId);
            this.group1.Controls.Add(this.lblId);
            this.group1.Controls.Add(this.tbUserType);
            this.group1.Controls.Add(this.lblUsetType);
            this.group1.Controls.Add(this.tbPsd);
            this.group1.Controls.Add(this.tbUserName);
            this.group1.Controls.Add(this.lblPsd);
            this.group1.Controls.Add(this.lblUserName);
            this.group1.Controls.Add(this.btnSearch);
            this.group1.Controls.Add(this.btnCancel);
            this.group1.Controls.Add(this.btnDel);
            this.group1.Controls.Add(this.btnUpdate);
            this.group1.Controls.Add(this.btnAdd);
            this.group1.Location = new System.Drawing.Point(13, 12);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(759, 87);
            this.group1.TabIndex = 2;
            this.group1.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(-3, 63);
            this.lblId.Name = "lblId";
            this.lblId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblId.Size = new System.Drawing.Size(60, 12);
            this.lblId.TabIndex = 89;
            this.lblId.Text = "编号";
            // 
            // tbUserType
            // 
            this.tbUserType.Location = new System.Drawing.Point(563, 60);
            this.tbUserType.Name = "tbUserType";
            this.tbUserType.Size = new System.Drawing.Size(100, 21);
            this.tbUserType.TabIndex = 88;
            // 
            // lblUsetType
            // 
            this.lblUsetType.Location = new System.Drawing.Point(496, 63);
            this.lblUsetType.Name = "lblUsetType";
            this.lblUsetType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsetType.Size = new System.Drawing.Size(62, 12);
            this.lblUsetType.TabIndex = 87;
            this.lblUsetType.Text = "账户类型";
            // 
            // tbPsd
            // 
            this.tbPsd.Location = new System.Drawing.Point(388, 60);
            this.tbPsd.Name = "tbPsd";
            this.tbPsd.Size = new System.Drawing.Size(100, 21);
            this.tbPsd.TabIndex = 86;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(223, 60);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 21);
            this.tbUserName.TabIndex = 85;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(63, 60);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 21);
            this.tbId.TabIndex = 90;
            this.tbId.Text = "0";
            // 
            // frmUserMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.group1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "账户管理";
            this.Load += new System.EventHandler(this.frmUserMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserMgr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPsd;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridView dgvUserMgr;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.TextBox tbUserType;
        private System.Windows.Forms.Label lblUsetType;
        private System.Windows.Forms.TextBox tbPsd;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserType;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbId;

    }
}