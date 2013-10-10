namespace UI.Adviser
{
    partial class frmAdviserMgr
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
            this.paging1 = new Control.Paging();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMPhone = new System.Windows.Forms.TextBox();
            this.lblMPhone = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCoachNo = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvAdviser = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobilephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberCardNo = new Control.Numberic();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdviser)).BeginInit();
            this.SuspendLayout();
            // 
            // paging1
            // 
            this.paging1.CurrentPage = 0;
            this.paging1.Location = new System.Drawing.Point(13, 124);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(759, 22);
            this.paging1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberCardNo);
            this.groupBox1.Controls.Add(this.tbMPhone);
            this.groupBox1.Controls.Add(this.lblMPhone);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblCoachNo);
            this.groupBox1.Controls.Add(this.tbPosition);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 106);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // tbMPhone
            // 
            this.tbMPhone.Location = new System.Drawing.Point(653, 23);
            this.tbMPhone.Name = "tbMPhone";
            this.tbMPhone.Size = new System.Drawing.Size(100, 21);
            this.tbMPhone.TabIndex = 74;
            // 
            // lblMPhone
            // 
            this.lblMPhone.Location = new System.Drawing.Point(594, 27);
            this.lblMPhone.Name = "lblMPhone";
            this.lblMPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMPhone.Size = new System.Drawing.Size(53, 12);
            this.lblMPhone.TabIndex = 73;
            this.lblMPhone.Text = "移动电话";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(517, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "修改(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(436, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 76;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(355, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 75;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCoachNo
            // 
            this.lblCoachNo.Location = new System.Drawing.Point(4, 26);
            this.lblCoachNo.Name = "lblCoachNo";
            this.lblCoachNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCoachNo.Size = new System.Drawing.Size(53, 12);
            this.lblCoachNo.TabIndex = 73;
            this.lblCoachNo.Text = "编号";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(492, 23);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 21);
            this.tbPosition.TabIndex = 72;
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(433, 27);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPosition.Size = new System.Drawing.Size(53, 12);
            this.lblPosition.TabIndex = 71;
            this.lblPosition.Text = "岗位";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(678, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(598, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "查找(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(221, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 44;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(162, 26);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "姓名";
            // 
            // dgvAdviser
            // 
            this.dgvAdviser.AllowUserToAddRows = false;
            this.dgvAdviser.AllowUserToDeleteRows = false;
            this.dgvAdviser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdviser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.clUserName,
            this.colName,
            this.colPosition,
            this.colMobilephone});
            this.dgvAdviser.Location = new System.Drawing.Point(13, 154);
            this.dgvAdviser.MultiSelect = false;
            this.dgvAdviser.Name = "dgvAdviser";
            this.dgvAdviser.ReadOnly = true;
            this.dgvAdviser.RowTemplate.Height = 23;
            this.dgvAdviser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdviser.Size = new System.Drawing.Size(759, 396);
            this.dgvAdviser.TabIndex = 14;
            this.dgvAdviser.VirtualMode = true;
            this.dgvAdviser.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvAdviser_CellValueNeeded);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "编号";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // clUserName
            // 
            this.clUserName.HeaderText = "登录名";
            this.clUserName.Name = "clUserName";
            this.clUserName.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "岗位";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colMobilephone
            // 
            this.colMobilephone.DataPropertyName = "Mobilephone";
            this.colMobilephone.HeaderText = "移动电话";
            this.colMobilephone.Name = "colMobilephone";
            this.colMobilephone.ReadOnly = true;
            // 
            // numberCardNo
            // 
            this.numberCardNo.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numberCardNo.Location = new System.Drawing.Point(63, 23);
            this.numberCardNo.MaxLength = ((uint)(0u));
            this.numberCardNo.Name = "numberCardNo";
            this.numberCardNo.Size = new System.Drawing.Size(99, 21);
            this.numberCardNo.TabIndex = 78;
            this.numberCardNo.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cbUserName
            // 
            this.cbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Items.AddRange(new object[] {
            "女",
            "男",
            "其它"});
            this.cbUserName.Location = new System.Drawing.Point(385, 23);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(55, 20);
            this.cbUserName.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(338, 28);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 99;
            this.label2.Text = "登录名";
            // 
            // frmAdviserMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.paging1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAdviser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdviserMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "顾问管理";
            this.Activated += new System.EventHandler(this.frmAdviserMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmAdviserMgr_Deactivate);
            this.Load += new System.EventHandler(this.frmAdviserMgr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdviser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.Paging paging1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCoachNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvAdviser;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbMPhone;
        private System.Windows.Forms.Label lblMPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobilephone;
        private Control.Numberic numberCardNo;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.Label label2;
    }
}