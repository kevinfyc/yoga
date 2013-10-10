namespace UI.Vip
{
    partial class frmVipEnterInfoMgr
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
            this.dgvImports = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEnd = new System.Windows.Forms.DateTimePicker();
            this.dataBgn = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lvlTimeForm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCardNoQ = new System.Windows.Forms.TextBox();
            this.chkIsTemp = new System.Windows.Forms.CheckBox();
            this.paging1 = new Control.Paging();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImports)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImports
            // 
            this.dgvImports.AllowUserToAddRows = false;
            this.dgvImports.AllowUserToDeleteRows = false;
            this.dgvImports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvImports.Location = new System.Drawing.Point(13, 119);
            this.dgvImports.Name = "dgvImports";
            this.dgvImports.ReadOnly = true;
            this.dgvImports.RowTemplate.Height = 23;
            this.dgvImports.Size = new System.Drawing.Size(759, 431);
            this.dgvImports.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MemberId";
            this.Column2.HeaderText = "会员卡号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MemberName";
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Date";
            this.Column4.HeaderText = "时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IsTemp";
            this.Column5.HeaderText = "次卡";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataEnd
            // 
            this.dataEnd.Location = new System.Drawing.Point(204, 17);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.Size = new System.Drawing.Size(106, 21);
            this.dataEnd.TabIndex = 53;
            // 
            // dataBgn
            // 
            this.dataBgn.Location = new System.Drawing.Point(65, 17);
            this.dataBgn.Name = "dataBgn";
            this.dataBgn.Size = new System.Drawing.Size(110, 21);
            this.dataBgn.TabIndex = 52;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(678, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(437, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "查找(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(220, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(90, 21);
            this.tbName.TabIndex = 44;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(161, 49);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "姓名";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(6, 49);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNo.Size = new System.Drawing.Size(53, 12);
            this.lblNo.TabIndex = 41;
            this.lblNo.Text = "卡号";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(181, 23);
            this.lblTo.Name = "lblTo";
            this.lblTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTo.Size = new System.Drawing.Size(17, 12);
            this.lblTo.TabIndex = 39;
            this.lblTo.Text = "到";
            // 
            // lvlTimeForm
            // 
            this.lvlTimeForm.Location = new System.Drawing.Point(6, 23);
            this.lvlTimeForm.Name = "lvlTimeForm";
            this.lvlTimeForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlTimeForm.Size = new System.Drawing.Size(53, 12);
            this.lvlTimeForm.TabIndex = 37;
            this.lvlTimeForm.Text = "从";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.tbCardNoQ);
            this.groupBox1.Controls.Add(this.chkIsTemp);
            this.groupBox1.Controls.Add(this.dataEnd);
            this.groupBox1.Controls.Add(this.dataBgn);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lvlTimeForm);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tbCardNoQ
            // 
            this.tbCardNoQ.Location = new System.Drawing.Point(65, 46);
            this.tbCardNoQ.Name = "tbCardNoQ";
            this.tbCardNoQ.Size = new System.Drawing.Size(110, 21);
            this.tbCardNoQ.TabIndex = 58;
            // 
            // chkIsTemp
            // 
            this.chkIsTemp.AutoSize = true;
            this.chkIsTemp.Location = new System.Drawing.Point(332, 48);
            this.chkIsTemp.Name = "chkIsTemp";
            this.chkIsTemp.Size = new System.Drawing.Size(84, 16);
            this.chkIsTemp.TabIndex = 54;
            this.chkIsTemp.Text = "是否为次卡";
            this.chkIsTemp.UseVisualStyleBackColor = true;
            // 
            // paging1
            // 
            this.paging1.CurrentPage = 0;
            this.paging1.Location = new System.Drawing.Point(13, 91);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(759, 22);
            this.paging1.TabIndex = 55;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Location = new System.Drawing.Point(518, 45);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 22);
            this.btnExport.TabIndex = 56;
            this.btnExport.Text = "导出(&S)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmVipEnterInfoMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvImports);
            this.Controls.Add(this.paging1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVipEnterInfoMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员进场管理 ";
            this.Activated += new System.EventHandler(this.frmVipEnterInfoMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmVipEnterInfoMgr_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImports;
        private System.Windows.Forms.DateTimePicker dataEnd;
        private System.Windows.Forms.DateTimePicker dataBgn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lvlTimeForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIsTemp;
        private Control.Paging paging1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox tbCardNoQ;
        private System.Windows.Forms.Button btnExport;
    }
}