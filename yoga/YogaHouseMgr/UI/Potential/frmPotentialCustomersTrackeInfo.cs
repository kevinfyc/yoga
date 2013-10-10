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
    public partial class frmPotentialCustomersTrackeInfo : Form
    {
        WSPotentialMember ws;
        public frmPotentialCustomersTrackeInfo()
        {
            InitializeComponent();
            ws = new WSPotentialMember();
            dataAdviserInfo.AutoGenerateColumns = false;
            dataPotentialInfo.AutoGenerateColumns = false;
        }


        private void frmPotentialCustomersTrackeInfo_Load(object sender, EventArgs e)
        {
            dataAdviserInfo.ClearSelection();
            var wsa = new BLLAdviser.WSAdviser();
            int a = 1, b;
            var result = wsa.Search(new BLLAdviser.Adviser() { Id = -1, Name = "", Position = "" }, ref a, 100000, out b);
            this.dataAdviserInfo.DataSource = result;

            LoadDataAll();
            
            dataAdviserInfo.CellMouseClick += (s, ee) =>
                {
                    var res = ws.Search(new PotentialMember()
                    {
                        Name = "",
                        AdviserId = Convert.ToInt32(dataAdviserInfo.SelectedRows[0].Cells[0].Value),
                    },false, ref a, 10000000, out b);
                    dataPotentialInfo.DataSource = res;
                };
        }

        void ClearSearchConditions()
        {
            numAdviserId.Value = 0;
            tbName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ws.Dispose();
            ws = null;
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

            LoadDataAll();
        }
        void LoadDataAll()
        {
            int a = 1, b;
            dataPotentialInfo.DataSource = ws.Search(new PotentialMember()
            {
                Name = tbName.Text.Trim(),
                AdviserId = (int)numAdviserId.Value,
            },true, ref a, 10000000, out b);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataPotentialInfo.SelectedRows == null || dataPotentialInfo.SelectedRows.Count <1)
            {
                MessageBox.Show("请在右边列表中选择要添加给指定顾问的潜在客户！");
                return;
            }

            if (dataAdviserInfo.SelectedRows != null && dataAdviserInfo.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                string id = dataAdviserInfo.SelectedRows[0].Cells[0].Value.ToString();
                foreach (DataGridViewRow row in dataPotentialInfo.SelectedRows)
                {
                    if (row.Cells[0].Value.ToString()!=id) 
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                }
                MessageBox.Show(ws.Allots(ids.ToArray(), Convert.ToInt32(dataAdviserInfo.SelectedRows[0].Cells[0].Value)));
                LoadDataAll();
            }
            else
                MessageBox.Show("请在左边列表中选择顾问");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataPotentialInfo.SelectedRows == null || dataPotentialInfo.SelectedRows.Count < 1)
            {
                MessageBox.Show("请在右边列表中选择要删除的潜在客户！");
                return;
            }
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in dataPotentialInfo.SelectedRows)
            {
                 ids.Add(Convert.ToInt32(row.Cells[0].Value));
            }
            MessageBox.Show(ws.DeleteBatch(ids.ToArray()));
            LoadDataAll();
        }

        private void frmPotentialCustomersTrackeInfo_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmPotentialCustomersTrackeInfo_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
