namespace UI.Rack
{
    partial class frmRackMgr
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
            this.tbRackNo = new System.Windows.Forms.TextBox();
            this.tbCardNoQ = new System.Windows.Forms.TextBox();
            this.tbTips = new System.Windows.Forms.TextBox();
            this.dataEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEndtime = new System.Windows.Forms.Label();
            this.dataBgn = new System.Windows.Forms.DateTimePicker();
            this.lblBgnTime = new System.Windows.Forms.Label();
            this.lvlTips = new System.Windows.Forms.Label();
            this.lblRankId = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paging1 = new Control.Paging();
            this.dataRankInfo = new System.Windows.Forms.DataGridView();
            this.tbnoq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clRackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBgnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRankInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbnoq);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbRackNo);
            this.groupBox1.Controls.Add(this.tbCardNoQ);
            this.groupBox1.Controls.Add(this.tbTips);
            this.groupBox1.Controls.Add(this.dataEnd);
            this.groupBox1.Controls.Add(this.lblEndtime);
            this.groupBox1.Controls.Add(this.dataBgn);
            this.groupBox1.Controls.Add(this.lblBgnTime);
            this.groupBox1.Controls.Add(this.lvlTips);
            this.groupBox1.Controls.Add(this.lblRankId);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbRackNo
            // 
            this.tbRackNo.Location = new System.Drawing.Point(215, 53);
            this.tbRackNo.Name = "tbRackNo";
            this.tbRackNo.Size = new System.Drawing.Size(100, 21);
            this.tbRackNo.TabIndex = 86;
            // 
            // tbCardNoQ
            // 
            this.tbCardNoQ.Location = new System.Drawing.Point(50, 53);
            this.tbCardNoQ.Name = "tbCardNoQ";
            this.tbCardNoQ.Size = new System.Drawing.Size(100, 21);
            this.tbCardNoQ.TabIndex = 85;
            // 
            // tbTips
            // 
            this.tbTips.Location = new System.Drawing.Point(50, 81);
            this.tbTips.Name = "tbTips";
            this.tbTips.Size = new System.Drawing.Size(703, 21);
            this.tbTips.TabIndex = 84;
            // 
            // dataEnd
            // 
            this.dataEnd.Location = new System.Drawing.Point(553, 53);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.Size = new System.Drawing.Size(100, 21);
            this.dataEnd.TabIndex = 83;
            // 
            // lblEndtime
            // 
            this.lblEndtime.Location = new System.Drawing.Point(494, 56);
            this.lblEndtime.Name = "lblEndtime";
            this.lblEndtime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEndtime.Size = new System.Drawing.Size(53, 12);
            this.lblEndtime.TabIndex = 82;
            this.lblEndtime.Text = "到期日期";
            // 
            // dataBgn
            // 
            this.dataBgn.Location = new System.Drawing.Point(380, 53);
            this.dataBgn.Name = "dataBgn";
            this.dataBgn.Size = new System.Drawing.Size(100, 21);
            this.dataBgn.TabIndex = 81;
            // 
            // lblBgnTime
            // 
            this.lblBgnTime.Location = new System.Drawing.Point(321, 56);
            this.lblBgnTime.Name = "lblBgnTime";
            this.lblBgnTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBgnTime.Size = new System.Drawing.Size(53, 12);
            this.lblBgnTime.TabIndex = 80;
            this.lblBgnTime.Text = "租用日期";
            // 
            // lvlTips
            // 
            this.lvlTips.Location = new System.Drawing.Point(11, 84);
            this.lvlTips.Name = "lvlTips";
            this.lvlTips.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvlTips.Size = new System.Drawing.Size(32, 12);
            this.lvlTips.TabIndex = 76;
            this.lvlTips.Text = "备注";
            // 
            // lblRankId
            // 
            this.lblRankId.Location = new System.Drawing.Point(148, 56);
            this.lblRankId.Name = "lblRankId";
            this.lblRankId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRankId.Size = new System.Drawing.Size(62, 12);
            this.lblRankId.TabIndex = 74;
            this.lblRankId.Text = "柜子编号";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(11, 56);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNo.Size = new System.Drawing.Size(32, 12);
            this.lblNo.TabIndex = 72;
            this.lblNo.Text = "卡号";
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
            this.groupBox2.Controls.Add(this.paging1);
            this.groupBox2.Controls.Add(this.dataRankInfo);
            this.groupBox2.Location = new System.Drawing.Point(13, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // paging1
            // 
            this.paging1.CurrentPage = 0;
            this.paging1.Location = new System.Drawing.Point(11, 14);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(742, 22);
            this.paging1.TabIndex = 1;
            // 
            // dataRankInfo
            // 
            this.dataRankInfo.AllowUserToAddRows = false;
            this.dataRankInfo.AllowUserToDeleteRows = false;
            this.dataRankInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRankInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRackId,
            this.clNo,
            this.clRenter,
            this.clBgnTime,
            this.clPeriod,
            this.clTips});
            this.dataRankInfo.Location = new System.Drawing.Point(11, 42);
            this.dataRankInfo.Name = "dataRankInfo";
            this.dataRankInfo.ReadOnly = true;
            this.dataRankInfo.RowTemplate.Height = 23;
            this.dataRankInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRankInfo.Size = new System.Drawing.Size(742, 376);
            this.dataRankInfo.TabIndex = 0;
            this.dataRankInfo.VirtualMode = true;
            this.dataRankInfo.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataRankInfo_CellValueNeeded);
            // 
            // tbnoq
            // 
            this.tbnoq.Location = new System.Drawing.Point(428, 20);
            this.tbnoq.Name = "tbnoq";
            this.tbnoq.ReadOnly = true;
            this.tbnoq.Size = new System.Drawing.Size(100, 21);
            this.tbnoq.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(341, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 87;
            this.label1.Text = "柜子内编号";
            // 
            // clRackId
            // 
            this.clRackId.DataPropertyName = "Id";
            this.clRackId.HeaderText = "内编号";
            this.clRackId.Name = "clRackId";
            this.clRackId.ReadOnly = true;
            // 
            // clNo
            // 
            this.clNo.DataPropertyName = "RackNo";
            this.clNo.HeaderText = "柜子编号";
            this.clNo.Name = "clNo";
            this.clNo.ReadOnly = true;
            // 
            // clRenter
            // 
            this.clRenter.HeaderText = "租赁人";
            this.clRenter.Name = "clRenter";
            this.clRenter.ReadOnly = true;
            // 
            // clBgnTime
            // 
            this.clBgnTime.DataPropertyName = "RentDate";
            this.clBgnTime.HeaderText = "租赁日期";
            this.clBgnTime.Name = "clBgnTime";
            this.clBgnTime.ReadOnly = true;
            // 
            // clPeriod
            // 
            this.clPeriod.DataPropertyName = "RentExpire";
            this.clPeriod.HeaderText = "到期时间";
            this.clPeriod.Name = "clPeriod";
            this.clPeriod.ReadOnly = true;
            // 
            // clTips
            // 
            this.clTips.DataPropertyName = "Remarks";
            this.clTips.HeaderText = "备注";
            this.clTips.Name = "clTips";
            this.clTips.ReadOnly = true;
            // 
            // frmRackMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRackMgr";
            this.Text = "租柜管理";
            this.Activated += new System.EventHandler(this.frmRackMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmRackMgr_Deactivate);
            this.Load += new System.EventHandler(this.frmRackMgr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRankInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lvlTips;
        private System.Windows.Forms.Label lblRankId;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.DateTimePicker dataEnd;
        private System.Windows.Forms.Label lblEndtime;
        private System.Windows.Forms.DateTimePicker dataBgn;
        private System.Windows.Forms.Label lblBgnTime;
        private System.Windows.Forms.DataGridView dataRankInfo;
        private System.Windows.Forms.TextBox tbTips;
        private Control.Paging paging1;
        private System.Windows.Forms.TextBox tbCardNoQ;
        private System.Windows.Forms.TextBox tbRackNo;
        private System.Windows.Forms.TextBox tbnoq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBgnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTips;
    }
}