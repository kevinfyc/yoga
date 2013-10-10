namespace UI.Vip
{
    partial class frmVipPrepaidMgr
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataEnd = new System.Windows.Forms.DateTimePicker();
            this.dataBgn = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblOpter = new System.Windows.Forms.Label();
            this.cbOpter = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lvlOptTime = new System.Windows.Forms.Label();
            this.paging1 = new Control.Paging();
            this.dgvPrepaid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCardNoQ = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepaid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCardNoQ);
            this.groupBox1.Controls.Add(this.dataEnd);
            this.groupBox1.Controls.Add(this.dataBgn);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblOpter);
            this.groupBox1.Controls.Add(this.cbOpter);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lvlOptTime);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataEnd
            // 
            this.dataEnd.Location = new System.Drawing.Point(194, 17);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.Size = new System.Drawing.Size(100, 21);
            this.dataEnd.TabIndex = 53;
            // 
            // dataBgn
            // 
            this.dataBgn.Location = new System.Drawing.Point(65, 17);
            this.dataBgn.Name = "dataBgn";
            this.dataBgn.Size = new System.Drawing.Size(100, 21);
            this.dataBgn.TabIndex = 52;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(684, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(600, 42);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 50;
            this.btnExport.Text = "导出（&E)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(519, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "查找(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblOpter
            // 
            this.lblOpter.Location = new System.Drawing.Point(354, 49);
            this.lblOpter.Name = "lblOpter";
            this.lblOpter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOpter.Size = new System.Drawing.Size(53, 12);
            this.lblOpter.TabIndex = 48;
            this.lblOpter.Text = "操作员";
            // 
            // cbOpter
            // 
            this.cbOpter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpter.FormattingEnabled = true;
            this.cbOpter.Location = new System.Drawing.Point(413, 44);
            this.cbOpter.Name = "cbOpter";
            this.cbOpter.Size = new System.Drawing.Size(100, 20);
            this.cbOpter.TabIndex = 46;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(234, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 44;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(175, 49);
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
            this.lblTo.Location = new System.Drawing.Point(171, 23);
            this.lblTo.Name = "lblTo";
            this.lblTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTo.Size = new System.Drawing.Size(17, 12);
            this.lblTo.TabIndex = 39;
            this.lblTo.Text = "到";
            // 
            // lvlOptTime
            // 
            this.lvlOptTime.Location = new System.Drawing.Point(6, 23);
            this.lvlOptTime.Name = "lvlOptTime";
            this.lvlOptTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlOptTime.Size = new System.Drawing.Size(53, 12);
            this.lvlOptTime.TabIndex = 37;
            this.lvlOptTime.Text = "操作时间";
            // 
            // paging1
            // 
            this.paging1.CurrentPage = 0;
            this.paging1.Location = new System.Drawing.Point(13, 99);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(759, 22);
            this.paging1.TabIndex = 1;
            // 
            // dgvPrepaid
            // 
            this.dgvPrepaid.AllowUserToAddRows = false;
            this.dgvPrepaid.AllowUserToDeleteRows = false;
            this.dgvPrepaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrepaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPrepaid.Location = new System.Drawing.Point(13, 127);
            this.dgvPrepaid.Name = "dgvPrepaid";
            this.dgvPrepaid.ReadOnly = true;
            this.dgvPrepaid.RowTemplate.Height = 23;
            this.dgvPrepaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrepaid.Size = new System.Drawing.Size(759, 423);
            this.dgvPrepaid.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "系统单据";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Date";
            this.Column2.HeaderText = "日期";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MemberId";
            this.Column3.HeaderText = "会员卡号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MemberName";
            this.Column4.HeaderText = "会员姓名";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Money";
            this.Column5.HeaderText = "金额";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Operater";
            this.Column6.HeaderText = "操作员";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tbCardNoQ
            // 
            this.tbCardNoQ.Location = new System.Drawing.Point(65, 44);
            this.tbCardNoQ.Name = "tbCardNoQ";
            this.tbCardNoQ.Size = new System.Drawing.Size(100, 21);
            this.tbCardNoQ.TabIndex = 72;
            // 
            // frmVipPrepaidMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvPrepaid);
            this.Controls.Add(this.paging1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVipPrepaidMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员充值管理";
            this.Activated += new System.EventHandler(this.frmVipPrepaidMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmVipPrepaidMgr_Deactivate);
            this.Load += new System.EventHandler(this.frmVipPrepaidMgr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepaid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lvlOptTime;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblOpter;
        private System.Windows.Forms.ComboBox cbOpter;
        private Control.Paging paging1;
        private System.Windows.Forms.DataGridView dgvPrepaid;
        private System.Windows.Forms.DateTimePicker dataEnd;
        private System.Windows.Forms.DateTimePicker dataBgn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox tbCardNoQ;
    }
}