using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLImport;
namespace UI.Vip
{
    public partial class frmVipEnterInfoMgr : Form
    {
        WSImport wsi;
        public frmVipEnterInfoMgr()
        {
            InitializeComponent();
            wsi = new WSImport();
            dgvImports.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
            dataBgn.Value = DateTime.Now.AddDays(-1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {
            int b;
            var result = wsi.Search(new ImportRecord()
            {
                 IsTemp = chkIsTemp.Checked,
                  //MemberId = (int)numberCardNo.Value,
                   MemberName = tbName.Text.Trim()
            }, tbCardNoQ.Text.Trim(), dataBgn.Value, dataEnd.Value, ref page, 20, out b);
            dgvImports.DataSource = result;
            paging1.CurrentPage = page;
            paging1.TotalPages = b;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }

        private void frmVipEnterInfoMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmVipEnterInfoMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Untils.ExportDataGridToCSV(dgvImports);
        }
    }
}
