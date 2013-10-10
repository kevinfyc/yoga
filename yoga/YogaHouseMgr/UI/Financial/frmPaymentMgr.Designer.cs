﻿namespace UI.Financial
{
    partial class frmPaymentMgr
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
            this.dataPaymentInfo = new System.Windows.Forms.DataGridView();
            this.clSysId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEnd = new System.Windows.Forms.DateTimePicker();
            this.dataBgn = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPro = new System.Windows.Forms.Label();
            this.cbPro = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lvlOptTime = new System.Windows.Forms.Label();
            this.paging1 = new Control.Paging();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPaymentInfo
            // 
            this.dataPaymentInfo.AllowUserToAddRows = false;
            this.dataPaymentInfo.AllowUserToDeleteRows = false;
            this.dataPaymentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaymentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSysId,
            this.clOptDate,
            this.clPro,
            this.clPrice});
            this.dataPaymentInfo.Location = new System.Drawing.Point(13, 154);
            this.dataPaymentInfo.Name = "dataPaymentInfo";
            this.dataPaymentInfo.ReadOnly = true;
            this.dataPaymentInfo.RowTemplate.Height = 23;
            this.dataPaymentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPaymentInfo.Size = new System.Drawing.Size(759, 396);
            this.dataPaymentInfo.TabIndex = 5;
            this.dataPaymentInfo.VirtualMode = true;
            this.dataPaymentInfo.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataPaymentInfo_CellValueNeeded);
            // 
            // clSysId
            // 
            this.clSysId.DataPropertyName = "Id";
            this.clSysId.HeaderText = "系统编号";
            this.clSysId.Name = "clSysId";
            this.clSysId.ReadOnly = true;
            // 
            // clOptDate
            // 
            this.clOptDate.DataPropertyName = "Date";
            this.clOptDate.HeaderText = "操作日期";
            this.clOptDate.Name = "clOptDate";
            this.clOptDate.ReadOnly = true;
            // 
            // clPro
            // 
            this.clPro.HeaderText = "项目编号";
            this.clPro.Name = "clPro";
            this.clPro.ReadOnly = true;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Money";
            this.clPrice.HeaderText = "金额";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            // 
            // dataEnd
            // 
            this.dataEnd.Location = new System.Drawing.Point(207, 17);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.Size = new System.Drawing.Size(111, 21);
            this.dataEnd.TabIndex = 53;
            // 
            // dataBgn
            // 
            this.dataBgn.Location = new System.Drawing.Point(65, 17);
            this.dataBgn.Name = "dataBgn";
            this.dataBgn.Size = new System.Drawing.Size(113, 21);
            this.dataBgn.TabIndex = 52;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(253, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(91, 70);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 50;
            this.btnExport.Text = "导出（&E)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "查找(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPro
            // 
            this.lblPro.Location = new System.Drawing.Point(6, 47);
            this.lblPro.Name = "lblPro";
            this.lblPro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPro.Size = new System.Drawing.Size(53, 12);
            this.lblPro.TabIndex = 48;
            this.lblPro.Text = "项目";
            // 
            // cbPro
            // 
            this.cbPro.FormattingEnabled = true;
            this.cbPro.Location = new System.Drawing.Point(65, 44);
            this.cbPro.Name = "cbPro";
            this.cbPro.Size = new System.Drawing.Size(113, 20);
            this.cbPro.TabIndex = 46;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(184, 23);
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
            this.paging1.Location = new System.Drawing.Point(13, 125);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(759, 22);
            this.paging1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.dataEnd);
            this.groupBox1.Controls.Add(this.dataBgn);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblPro);
            this.groupBox1.Controls.Add(this.cbPro);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lvlOptTime);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(172, 70);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 54;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmPaymentMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataPaymentInfo);
            this.Controls.Add(this.paging1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPaymentMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "付款单汇总表";
            this.Activated += new System.EventHandler(this.frmPaymentMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmPaymentMgr_Deactivate);
            this.Load += new System.EventHandler(this.frmPaymentMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPaymentInfo;
        private System.Windows.Forms.DateTimePicker dataEnd;
        private System.Windows.Forms.DateTimePicker dataBgn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.ComboBox cbPro;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lvlOptTime;
        private Control.Paging paging1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSysId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
    }
}