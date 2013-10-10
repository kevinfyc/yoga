using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLPrepaid;
using UI.BLLUser;
namespace UI.Vip
{
    public partial class frmVipPrepaidMgr : Form
    {
        WSPrepaid wsp;
        PrepaidRecord[] prs;
        WSUser wsu;
        public frmVipPrepaidMgr()
        {
            InitializeComponent();
            wsp = new WSPrepaid();
            wsu = new WSUser();
            dgvPrepaid.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
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
            prs = wsp.Search(dataBgn.Value, dataEnd.Value, tbCardNoQ.Text.Trim(), //(int)numberCardNo.Value,
                tbName.Text.Trim(), (int)cbOpter.SelectedValue, ref page, 20, out b);
            dgvPrepaid.DataSource = prs;
            paging1.CurrentPage = page;
            paging1.TotalPages = b;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Untils.ExportDataGridToCSV(dgvPrepaid);
        }

        private void frmVipPrepaidMgr_Load(object sender, EventArgs e)
        {
            dataBgn.Value = DateTime.Now.AddDays(-1);
            List<User> u = new List<User>();
            u.Add(new User() {Id=0,Name="全部" });
            u.AddRange(wsu.List());
            cbOpter.DataSource = u;
            cbOpter.ValueMember = "Id";
            cbOpter.DisplayMember = "Name";
            cbOpter.SelectedIndex = 0;
        }

        private void frmVipPrepaidMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmVipPrepaidMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
