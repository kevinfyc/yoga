namespace UI.Goods
{
    partial class frmGoodsMgr
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
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.dataGoodsInfo = new System.Windows.Forms.DataGridView();
            this.clCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paging1 = new Control.Paging();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGoodsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(53, 68);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(722, 21);
            this.tbRemarks.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 117;
            this.label4.Text = "备注";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(53, 39);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(79, 21);
            this.tbNo.TabIndex = 116;
            this.tbNo.Text = "0";
            // 
            // dataGoodsInfo
            // 
            this.dataGoodsInfo.AllowUserToAddRows = false;
            this.dataGoodsInfo.AllowUserToDeleteRows = false;
            this.dataGoodsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGoodsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCardNo,
            this.clName,
            this.clPrice,
            this.clRemarks});
            this.dataGoodsInfo.Location = new System.Drawing.Point(15, 126);
            this.dataGoodsInfo.Name = "dataGoodsInfo";
            this.dataGoodsInfo.ReadOnly = true;
            this.dataGoodsInfo.RowTemplate.Height = 23;
            this.dataGoodsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGoodsInfo.Size = new System.Drawing.Size(760, 424);
            this.dataGoodsInfo.TabIndex = 114;
            // 
            // clCardNo
            // 
            this.clCardNo.DataPropertyName = "Id";
            this.clCardNo.HeaderText = "编号";
            this.clCardNo.Name = "clCardNo";
            this.clCardNo.ReadOnly = true;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "名称";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 80;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "价格";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
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
            this.paging1.Location = new System.Drawing.Point(15, 98);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(760, 22);
            this.paging1.TabIndex = 113;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(235, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(40, 12);
            this.lblPrice.TabIndex = 112;
            this.lblPrice.Text = "价格";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(52, 21);
            this.tbName.TabIndex = 111;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(136, 45);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 110;
            this.lblName.Text = "名称";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(15, 45);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNo.Size = new System.Drawing.Size(32, 12);
            this.lblNo.TabIndex = 109;
            this.lblNo.Text = "编号";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(712, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Location = new System.Drawing.Point(279, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 22);
            this.btnExport.TabIndex = 107;
            this.btnExport.Text = "导出(&S)";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(213, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 22);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.Text = "查询(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Location = new System.Drawing.Point(147, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 22);
            this.btnDel.TabIndex = 105;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.AutoSize = true;
            this.btnModify.Location = new System.Drawing.Point(81, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(60, 22);
            this.btnModify.TabIndex = 104;
            this.btnModify.Text = "修改(&M)";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(15, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 22);
            this.btnAdd.TabIndex = 103;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.DecimalPlaces = 2;
            this.tbPrice.Location = new System.Drawing.Point(297, 39);
            this.tbPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(120, 21);
            this.tbPrice.TabIndex = 119;
            // 
            // frmGoodsMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.dataGoodsInfo);
            this.Controls.Add(this.paging1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGoodsMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "商品管理";
            this.Activated += new System.EventHandler(this.frmGoodsMgr_Activated);
            this.Deactivate += new System.EventHandler(this.frmGoodsMgr_Deactivate);
            this.Load += new System.EventHandler(this.frmGoodsMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGoodsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.DataGridView dataGoodsInfo;
        private Control.Paging paging1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown tbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRemarks;
    }
}