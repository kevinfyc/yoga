namespace UI.Coach
{
    partial class frmCoachMgr
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCoachs = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobilephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPrivate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCoachId = new System.Windows.Forms.TextBox();
            this.cbIsPrivate = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCoachNo = new System.Windows.Forms.Label();
            this.tbMPhone = new System.Windows.Forms.TextBox();
            this.lblMPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.paging1 = new Control.Paging();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // dgvCoachs
            // 
            this.dgvCoachs.AllowUserToAddRows = false;
            this.dgvCoachs.AllowUserToDeleteRows = false;
            this.dgvCoachs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoachs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colMobilephone,
            this.colIsPrivate});
            this.dgvCoachs.Location = new System.Drawing.Point(13, 154);
            this.dgvCoachs.MultiSelect = false;
            this.dgvCoachs.Name = "dgvCoachs";
            this.dgvCoachs.ReadOnly = true;
            this.dgvCoachs.RowTemplate.Height = 23;
            this.dgvCoachs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoachs.Size = new System.Drawing.Size(759, 396);
            this.dgvCoachs.TabIndex = 11;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "编号";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colMobilephone
            // 
            this.colMobilephone.DataPropertyName = "Mobilephone";
            this.colMobilephone.HeaderText = "移动电话";
            this.colMobilephone.Name = "colMobilephone";
            this.colMobilephone.ReadOnly = true;
            // 
            // colIsPrivate
            // 
            this.colIsPrivate.DataPropertyName = "IsPrivate";
            this.colIsPrivate.HeaderText = "是否私教";
            this.colIsPrivate.Name = "colIsPrivate";
            this.colIsPrivate.ReadOnly = true;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(182, 26);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "姓名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCoachId);
            this.groupBox1.Controls.Add(this.cbIsPrivate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblCoachNo);
            this.groupBox1.Controls.Add(this.tbMPhone);
            this.groupBox1.Controls.Add(this.lblMPhone);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 106);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // tbCoachId
            // 
            this.tbCoachId.Location = new System.Drawing.Point(63, 23);
            this.tbCoachId.Name = "tbCoachId";
            this.tbCoachId.Size = new System.Drawing.Size(100, 21);
            this.tbCoachId.TabIndex = 80;
            this.tbCoachId.Text = "0";
            this.tbCoachId.TextChanged += new System.EventHandler(this.tbCoachId_TextChanged);
            // 
            // cbIsPrivate
            // 
            this.cbIsPrivate.AutoSize = true;
            this.cbIsPrivate.Location = new System.Drawing.Point(581, 25);
            this.cbIsPrivate.Name = "cbIsPrivate";
            this.cbIsPrivate.Size = new System.Drawing.Size(48, 16);
            this.cbIsPrivate.TabIndex = 79;
            this.cbIsPrivate.Text = "私教";
            this.cbIsPrivate.UseVisualStyleBackColor = true;
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
            // tbMPhone
            // 
            this.tbMPhone.Location = new System.Drawing.Point(426, 23);
            this.tbMPhone.Name = "tbMPhone";
            this.tbMPhone.Size = new System.Drawing.Size(100, 21);
            this.tbMPhone.TabIndex = 72;
            // 
            // lblMPhone
            // 
            this.lblMPhone.Location = new System.Drawing.Point(367, 27);
            this.lblMPhone.Name = "lblMPhone";
            this.lblMPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMPhone.Size = new System.Drawing.Size(53, 12);
            this.lblMPhone.TabIndex = 71;
            this.lblMPhone.Text = "移动电话";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(241, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 44;
            // 
            // paging1
            // 
            this.paging1.CurrentPage = 0;
            this.paging1.Location = new System.Drawing.Point(13, 124);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(759, 22);
            this.paging1.TabIndex = 12;
            // 
            // frmCoachMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.paging1);
            this.Controls.Add(this.dgvCoachs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCoachMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教练信息管理";
            this.Activated += new System.EventHandler(this.frmCoachMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmCoachMgr_Deactivate);
            this.Load += new System.EventHandler(this.frmCoachMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCoachs;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCoachNo;
        private System.Windows.Forms.TextBox tbMPhone;
        private System.Windows.Forms.Label lblMPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobilephone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsPrivate;
        private System.Windows.Forms.CheckBox cbIsPrivate;
        private Control.Paging paging1;
        private System.Windows.Forms.TextBox tbCoachId;
    }
}