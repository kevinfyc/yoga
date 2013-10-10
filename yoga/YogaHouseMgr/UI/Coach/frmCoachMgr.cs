using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLCoach;

namespace UI.Coach
{
    public partial class frmCoachMgr : Form
    {
        WSCoach ws;
        public frmCoachMgr()
        {
            InitializeComponent();
            dgvCoachs.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
        }

        private void frmCoachMgr_Load(object sender, EventArgs e)
        {
            LoadByPaging(1);
            
            dgvCoachs.CellMouseClick += (ss, ee) =>
            {
                if (dgvCoachs.SelectedRows != null && dgvCoachs.SelectedRows.Count > 0)
                {
                    tbCoachId.Text = dgvCoachs.SelectedRows[0].Cells[0].Value.ToString();
                    tbName.Text = dgvCoachs.SelectedRows[0].Cells[1].Value.ToString();
                    tbMPhone.Text = dgvCoachs.SelectedRows[0].Cells[2].Value.ToString();
                    cbIsPrivate.Checked = Convert.ToBoolean(dgvCoachs.SelectedRows[0].Cells[3].Value);
                }
            };
        }
        void ChangePage(object s,Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {
            if(ws == null) ws = new WSCoach();
            int total;
            BLLCoach.Coach[] coachs = ws.Search(new BLLCoach.Coach()
            {
                Id = Convert.ToInt32(tbCoachId.Text.Trim()),
                Name = tbName.Text.Trim(),
                Mobilephone = tbMPhone.Text.Trim()
            },ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dgvCoachs.DataSource = coachs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ws.Add(new BLLCoach.Coach()
            {
                 IsPrivate = cbIsPrivate.Checked,
                 Name = tbName.Text.Trim(),
                  Mobilephone = tbMPhone.Text.Trim(),
            }));
            ClearSearchConditions();
            LoadByPaging(paging1.CurrentPage);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCoachs.SelectedRows != null && dgvCoachs.SelectedRows.Count > 0)
            {
                string id = dgvCoachs.SelectedRows[0].Cells[0].Value.ToString();
                string name = dgvCoachs.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show(string.Format("确定要永久删除{0}教练的信息吗？", name), "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
                MessageBox.Show(ws.Delete(Convert.ToInt32(id)));
                ClearSearchConditions();
                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的教练");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ws.Update(new BLLCoach.Coach()
            {
                Id = Convert.ToInt32(tbCoachId.Text),
                IsPrivate = cbIsPrivate.Checked,
                Name = tbName.Text.Trim(),
                Mobilephone = tbMPhone.Text.Trim(),
            }));
            ClearSearchConditions();
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ws.Dispose();
            ws = null;
            this.Close();
        }

        private void tbCoachId_TextChanged(object sender, EventArgs e)
        {
            tbCoachId.Text = Untils.FilterNumberString(tbCoachId.Text);
        }

        void ClearSearchConditions()
        {
            tbCoachId.Text = "0";
            tbName.Text = "";
            tbMPhone.Text = "";
        }

        private void frmCoachMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmCoachMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
