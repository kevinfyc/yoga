using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLPotentialMember;

namespace UI.Potential
{
    public partial class frmPotentialCustomersToVip : Form
    {
        WSPotentialMember ws;
        public frmPotentialCustomersToVip()
        {
            InitializeComponent();
            ws = new WSPotentialMember();
            dataVipInfo.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
        }
        private void frmPotentialCustomersToVip_Load(object sender, EventArgs e)
        {
            var wsa = new BLLAdviser.WSAdviser();
            int a = 1, b;
            var result = wsa.Search(new BLLAdviser.Adviser() { Id = -1, Name = "", Position = "" }, ref a, 100000, out b);
            if (result == null) return;
            List<UI.BLLAdviser.Adviser> advisers = new List<BLLAdviser.Adviser>();
            advisers.AddRange(result);
            advisers.Insert(0, new BLLAdviser.Adviser() { Id = -1, Name = "请选择" });
            cbAdviser.DataSource = advisers;
            cbAdviser.DisplayMember = "Name";
            cbAdviser.ValueMember = "Id";

            LoadByPaging(1);

        }

        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {
            int total;
            PotentialMember[] potential = ws.Search(new PotentialMember()
            {
                Id = Convert.ToInt32(tbCardNo.Text.Trim()),
                Name = tbName.Text.Trim(),
                AdviserId = (int?)Convert.ToInt32(cbAdviser.SelectedValue),
            }, true, ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dataVipInfo.DataSource = potential;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ws.Dispose();
            ws = null;
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataVipInfo.SelectedRows[0].Cells[0].Value);
                Vip.frmAddNewVip vip = new Vip.frmAddNewVip(id);
                if (DialogResult.Yes == vip.ShowDialog())
                {
                    LoadByPaging(paging1.CurrentPage);
                    MessageBox.Show("转正成功");
                }
                else
                    MessageBox.Show("转正失败");
            }
            else
            {
                MessageBox.Show("请在列表中选择要转正的客户");
            }
        }

        private void frmPotentialCustomersToVip_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmPotentialCustomersToVip_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
