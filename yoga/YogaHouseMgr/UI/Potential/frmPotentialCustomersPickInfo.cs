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
    public partial class frmPotentialCustomersPickInfo : Form
    {
        WSPotentialMember ws;
        int aid;
        
        public frmPotentialCustomersPickInfo()
        {
            InitializeComponent();
            ws = new WSPotentialMember();
            dgvCurrent.AutoGenerateColumns = false;
            dgvPublic.AutoGenerateColumns = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadDataAll();
        }

        private void frmPotentialCustomersPickInfo_Load(object sender, EventArgs e)
        {
            BLLAdviser.WSAdviser wsa = new BLLAdviser.WSAdviser();
            int a=1,b;
            var res = wsa.Search(new BLLAdviser.Adviser() { Id = -1, UserId = Global.CurrentUser.Id , Name ="",Position=""}, ref a, 1, out b);
            if (res == null)
            {
                MessageBox.Show("当前界面只允许会籍顾问访问");
                return;
            }
            aid = res[0].Id;
            tbAdviserId.Text = aid.ToString();
            LoadSelf();
            LoadDataAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvPublic.SelectedRows == null || dgvPublic.SelectedRows.Count < 1)
            {
                MessageBox.Show("请在右边列表中选择要添加给当前顾问的潜在客户！");
                return;
            }
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in dgvPublic.SelectedRows)
            {
                ids.Add(Convert.ToInt32(row.Cells[0].Value));
            }
            MessageBox.Show(ws.Allots(ids.ToArray(), aid));
            ClearSearchConditions();
            LoadDataAll();
            LoadSelf();
        }

        void ClearSearchConditions()
        {
            tbName.Text = "";
        }
        void LoadSelf()
        {
            int a = 1, b;
            dgvCurrent.DataSource = ws.Search(new PotentialMember()
            {
                Name = tbName.Text.Trim(),
                AdviserId = aid
            }, false, ref a, 10000000, out b);
        }
        void LoadDataAll()
        {
            int a = 1, b;
            dgvPublic.DataSource = ws.Search(new PotentialMember()
            {
                Name = tbName.Text.Trim(),
                AdviserId = null
            }, false, ref a, 10000000, out b);
        }

        private void frmPotentialCustomersPickInfo_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmPotentialCustomersPickInfo_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
