using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLUser;
using UI.BLLConsumption;
using UI.BLLGoods;
namespace UI.Vip
{
    public partial class frmVipConsumptionMgr : Form
    {
        WSUser wsu;
        WSConsumption wsc;
        ConsumptionRecord[] crs;
        public frmVipConsumptionMgr()
        {
            InitializeComponent();
            wsu = new WSUser();
            wsc = new WSConsumption();
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
            crs = wsc.Search(dataBgn.Value, dataEnd.Value, tbCardNoQ.Text.Trim(), //(int)numberCardNo.Value,
                tbName.Text.Trim(), (int)cbOpter.SelectedValue, (int)cbProjects.SelectedValue,ref page, 20, out b);
            dgvPrepaid.DataSource = crs;
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

        private void frmVipConsumptionMgr_Load(object sender, EventArgs e)
        {
            dataBgn.Value = DateTime.Now.AddDays(-1);

            List<User> u = new List<User>();
            u.Add(new User() { Id = 0, Name = "全部" });
            u.AddRange(wsu.List());
            cbOpter.DataSource = u;
            cbOpter.ValueMember = "Id";
            cbOpter.DisplayMember = "Name";
            cbOpter.SelectedIndex = 0;

            WSGoods wsg = new WSGoods();
            List<BLLGoods.Goods> g = new List<BLLGoods.Goods>();
            g.Add(new BLLGoods.Goods() { Id = 0, Name = "全部" });
            int a=1,b;
            g.AddRange(wsg.Search(new BLLGoods.Goods(){Name=""},ref a,10000000,out b));
            cbProjects.DataSource = g;
            cbProjects.ValueMember = "Id";
            cbProjects.DisplayMember = "Name";
            cbProjects.SelectedIndex = 0;
        }

        private void frmVipConsumptionMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmVipConsumptionMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
