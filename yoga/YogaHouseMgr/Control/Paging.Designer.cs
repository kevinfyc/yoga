namespace Control
{
    partial class Paging
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tsPaging = new System.Windows.Forms.ToolStrip();
            this.tsbtnFirstPage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPageUp = new System.Windows.Forms.ToolStripButton();
            this.tsspt1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtPage = new System.Windows.Forms.ToolStripTextBox();
            this.tslblSpt = new System.Windows.Forms.ToolStripLabel();
            this.tslblTotalPages = new System.Windows.Forms.ToolStripLabel();
            this.tsspt2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPageDown = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLastPage = new System.Windows.Forms.ToolStripButton();
            this.tsspt3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnReload = new System.Windows.Forms.ToolStripButton();
            this.tsPaging.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPaging
            // 
            this.tsPaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsPaging.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPaging.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFirstPage,
            this.tsbtnPageUp,
            this.tsspt1,
            this.tstxtPage,
            this.tslblSpt,
            this.tslblTotalPages,
            this.tsspt2,
            this.tsbtnPageDown,
            this.tsbtnLastPage,
            this.tsspt3,
            this.tsbtnReload});
            this.tsPaging.Location = new System.Drawing.Point(0, 0);
            this.tsPaging.Name = "tsPaging";
            this.tsPaging.Size = new System.Drawing.Size(247, 22);
            this.tsPaging.TabIndex = 0;
            this.tsPaging.Text = "toolStrip1";
            // 
            // tsbtnFirstPage
            // 
            this.tsbtnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFirstPage.Image = global::Control.Properties.Resources.pagination_1;
            this.tsbtnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFirstPage.Name = "tsbtnFirstPage";
            this.tsbtnFirstPage.Size = new System.Drawing.Size(23, 19);
            this.tsbtnFirstPage.Text = "首页";
            this.tsbtnFirstPage.Click += new System.EventHandler(this.tsbtn_Click);
            // 
            // tsbtnPageUp
            // 
            this.tsbtnPageUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPageUp.Image = global::Control.Properties.Resources.pagination_2;
            this.tsbtnPageUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPageUp.Name = "tsbtnPageUp";
            this.tsbtnPageUp.Size = new System.Drawing.Size(23, 19);
            this.tsbtnPageUp.Text = "上一页";
            this.tsbtnPageUp.Click += new System.EventHandler(this.tsbtn_Click);
            // 
            // tsspt1
            // 
            this.tsspt1.Name = "tsspt1";
            this.tsspt1.Size = new System.Drawing.Size(6, 22);
            // 
            // tstxtPage
            // 
            this.tstxtPage.BackColor = System.Drawing.Color.White;
            this.tstxtPage.Name = "tstxtPage";
            this.tstxtPage.Size = new System.Drawing.Size(30, 22);
            this.tstxtPage.Text = "0";
            this.tstxtPage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tstxtPage_KeyUp);
            this.tstxtPage.TextChanged += new System.EventHandler(this.tstxtPage_TextChanged);
            // 
            // tslblSpt
            // 
            this.tslblSpt.Name = "tslblSpt";
            this.tslblSpt.Size = new System.Drawing.Size(12, 19);
            this.tslblSpt.Text = "/";
            // 
            // tslblTotalPages
            // 
            this.tslblTotalPages.Name = "tslblTotalPages";
            this.tslblTotalPages.Size = new System.Drawing.Size(13, 19);
            this.tslblTotalPages.Text = "0";
            // 
            // tsspt2
            // 
            this.tsspt2.Name = "tsspt2";
            this.tsspt2.Size = new System.Drawing.Size(6, 22);
            // 
            // tsbtnPageDown
            // 
            this.tsbtnPageDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPageDown.Image = global::Control.Properties.Resources.pagination_3;
            this.tsbtnPageDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPageDown.Name = "tsbtnPageDown";
            this.tsbtnPageDown.Size = new System.Drawing.Size(23, 19);
            this.tsbtnPageDown.Text = "下一页";
            this.tsbtnPageDown.Click += new System.EventHandler(this.tsbtn_Click);
            // 
            // tsbtnLastPage
            // 
            this.tsbtnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLastPage.Image = global::Control.Properties.Resources.pagination_4;
            this.tsbtnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLastPage.Name = "tsbtnLastPage";
            this.tsbtnLastPage.Size = new System.Drawing.Size(23, 19);
            this.tsbtnLastPage.Text = "尾页";
            this.tsbtnLastPage.Click += new System.EventHandler(this.tsbtn_Click);
            // 
            // tsspt3
            // 
            this.tsspt3.Name = "tsspt3";
            this.tsspt3.Size = new System.Drawing.Size(6, 22);
            // 
            // tsbtnReload
            // 
            this.tsbtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnReload.Image = global::Control.Properties.Resources.pagination_5;
            this.tsbtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReload.Name = "tsbtnReload";
            this.tsbtnReload.Size = new System.Drawing.Size(23, 19);
            this.tsbtnReload.Text = "刷新";
            this.tsbtnReload.Click += new System.EventHandler(this.tsbtn_Click);
            // 
            // Paging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsPaging);
            this.Name = "Paging";
            this.Size = new System.Drawing.Size(247, 22);
            this.tsPaging.ResumeLayout(false);
            this.tsPaging.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPaging;
        private System.Windows.Forms.ToolStripButton tsbtnFirstPage;
        private System.Windows.Forms.ToolStripButton tsbtnPageUp;
        private System.Windows.Forms.ToolStripButton tsbtnPageDown;
        private System.Windows.Forms.ToolStripButton tsbtnLastPage;
        private System.Windows.Forms.ToolStripButton tsbtnReload;
        private System.Windows.Forms.ToolStripSeparator tsspt1;
        private System.Windows.Forms.ToolStripTextBox tstxtPage;
        private System.Windows.Forms.ToolStripLabel tslblTotalPages;
        private System.Windows.Forms.ToolStripSeparator tsspt2;
        private System.Windows.Forms.ToolStripSeparator tsspt3;
        private System.Windows.Forms.ToolStripLabel tslblSpt;

    }
}
