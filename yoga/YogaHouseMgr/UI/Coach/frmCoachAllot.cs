using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLCoach;
using UI.BLLMember;

namespace UI.Coach
{
    public partial class frmCoachAllot : Form
    {
        WSCoach wsc;
        WSMemeber wsm;
        DataGridViewSelectedRowCollection rows;
        public frmCoachAllot()
        {
            InitializeComponent();
            dataCoachInfo.AutoGenerateColumns = false;
            dataMemberInfo.AutoGenerateColumns = false;
        } 

        private void frmCoachAllot_Load(object sender, EventArgs e)
        {
            loadingData();
        }

        private void loadingData()
        {
            wsm = new BLLMember.WSMemeber();
            wsc = new BLLCoach.WSCoach();
            int a1 = 1, a2 = 1, b1, b2;
            BLLCoach.Coach[] coach = wsc.Search(new BLLCoach.Coach()
            {
                Id = -1,
                Name = "",
                Mobilephone = ""
            }, ref a1, 100000, out b1);
            dataCoachInfo.DataSource = coach;

            BLLMember.Member[] member = wsm.Search(new BLLMember.Member()
            {
                CardNo = "",
                Name = "",
                Mobilephone = "",
                CoachId = -1,
                CardType = "",
                AdviserId = -1
            }, true, ref a2, 100000, out b2);
            dataMemberInfo.DataSource = member;
        }

        private void btnAllot_Click(object sender, EventArgs e)
        {
            rows = null;

            if (dataMemberInfo.SelectedRows != null && dataMemberInfo.SelectedRows.Count > 0)
                rows = dataMemberInfo.SelectedRows;
            else
            {
                MessageBox.Show("请在列表中选择会员！");
                return;
            }

            if (dataCoachInfo.SelectedRows != null && dataCoachInfo.SelectedRows.Count > 0)
            {
                int[] ids = new int[rows.Count];
                int i = 0;
                foreach (DataGridViewRow row in rows)
                {
                    ids[i++] = Convert.ToInt32(row.Cells[0].Value);
                }
                MessageBox.Show( wsm.CoachAllots(ids, Convert.ToInt32(dataCoachInfo.SelectedRows[0].Cells[0].Value)));
                loadingData();
            }
            else
                MessageBox.Show("请在列表中选择教练");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            wsc.Dispose();
            wsm.Discover();
            wsc = null;
            wsm = null;
            this.Close();
        }

        private void frmCoachAllot_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmCoachAllot_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
