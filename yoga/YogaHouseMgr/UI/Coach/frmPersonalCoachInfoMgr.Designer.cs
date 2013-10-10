namespace UI.Coach
{
    partial class frmPersonalCoachInfoMgr
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
            this.numNo = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.paging1 = new Control.Paging();
            this.btnPickClass = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.tbMPhone = new System.Windows.Forms.TextBox();
            this.lblMPhone = new System.Windows.Forms.Label();
            this.numCocahNo = new System.Windows.Forms.NumericUpDown();
            this.lblCoachNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCocahNo)).BeginInit();
            this.SuspendLayout();
            // 
            // numNo
            // 
            this.numNo.Location = new System.Drawing.Point(65, 45);
            this.numNo.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numNo.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNo.Name = "numNo";
            this.numNo.Size = new System.Drawing.Size(100, 21);
            this.numNo.TabIndex = 54;
            this.numNo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(678, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "退出(&X)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(596, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "查找(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(759, 396);
            this.dataGridView1.TabIndex = 8;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numCocahNo);
            this.groupBox1.Controls.Add(this.lblCoachNo);
            this.groupBox1.Controls.Add(this.tbMPhone);
            this.groupBox1.Controls.Add(this.lblMPhone);
            this.groupBox1.Controls.Add(this.btnPickClass);
            this.groupBox1.Controls.Add(this.btnPick);
            this.groupBox1.Controls.Add(this.numNo);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(234, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 44;
            // 
            // paging1
            // 
            this.paging1.CurrentPage = 0;
            this.paging1.Location = new System.Drawing.Point(13, 125);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(759, 22);
            this.paging1.TabIndex = 7;
            // 
            // btnPickClass
            // 
            this.btnPickClass.Location = new System.Drawing.Point(90, 16);
            this.btnPickClass.Name = "btnPickClass";
            this.btnPickClass.Size = new System.Drawing.Size(75, 23);
            this.btnPickClass.TabIndex = 56;
            this.btnPickClass.Text = "选课(&T)";
            this.btnPickClass.UseVisualStyleBackColor = true;
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(9, 16);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 55;
            this.btnPick.Text = "挑选(&S)";
            this.btnPick.UseVisualStyleBackColor = true;
            // 
            // tbMPhone
            // 
            this.tbMPhone.Location = new System.Drawing.Point(412, 44);
            this.tbMPhone.Name = "tbMPhone";
            this.tbMPhone.Size = new System.Drawing.Size(100, 21);
            this.tbMPhone.TabIndex = 72;
            // 
            // lblMPhone
            // 
            this.lblMPhone.Location = new System.Drawing.Point(353, 48);
            this.lblMPhone.Name = "lblMPhone";
            this.lblMPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMPhone.Size = new System.Drawing.Size(53, 12);
            this.lblMPhone.TabIndex = 71;
            this.lblMPhone.Text = "移动电话";
            // 
            // numCocahNo
            // 
            this.numCocahNo.Location = new System.Drawing.Point(583, 44);
            this.numCocahNo.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numCocahNo.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCocahNo.Name = "numCocahNo";
            this.numCocahNo.Size = new System.Drawing.Size(100, 21);
            this.numCocahNo.TabIndex = 74;
            this.numCocahNo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblCoachNo
            // 
            this.lblCoachNo.Location = new System.Drawing.Point(524, 48);
            this.lblCoachNo.Name = "lblCoachNo";
            this.lblCoachNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCoachNo.Size = new System.Drawing.Size(53, 12);
            this.lblCoachNo.TabIndex = 73;
            this.lblCoachNo.Text = "教练编号";
            // 
            // frmPersonalCoachInfoMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paging1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPersonalCoachInfoMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "私教会员信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.numNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCocahNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPickClass;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.TextBox tbName;
        private Control.Paging paging1;
        private System.Windows.Forms.TextBox tbMPhone;
        private System.Windows.Forms.Label lblMPhone;
        private System.Windows.Forms.NumericUpDown numCocahNo;
        private System.Windows.Forms.Label lblCoachNo;
    }
}