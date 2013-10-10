using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLAdviser;
using UI.BLLUser;

namespace UI.Adviser
{
    public partial class frmAdviserMgr : Form
    {
        WSAdviser ws;
        WSUser wsu;
        BLLAdviser.Adviser[] adviserInfo;
        BLLUser.User[] userInfo;
        public frmAdviserMgr()
        {
            InitializeComponent();
            dgvAdviser.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
            wsu = new WSUser();
        }

        private void frmAdviserMgr_Load(object sender, EventArgs e)
        {
            userInfo = wsu.List();
            List<UI.BLLUser.User> users = new List<BLLUser.User>();
            users.AddRange(userInfo);
            users.Insert(0, new BLLUser.User() { Id = -1, Name = "无" });
            cbUserName.DataSource = users;
            cbUserName.DisplayMember = "Name";
            cbUserName.ValueMember = "Id";

            LoadByPaging(1);

            dgvAdviser.CellMouseClick += (ss, ee) =>
            {
                if (dgvAdviser.SelectedRows != null && dgvAdviser.SelectedRows.Count > 0)
                {
                    numberCardNo.Value = Convert.ToDecimal(dgvAdviser.SelectedRows[0].Cells[0].Value);
                    tbName.Text = dgvAdviser.SelectedRows[0].Cells[2].Value.ToString();

                    object value = adviserInfo[dgvAdviser.SelectedRows[0].Index].UserId;
                    cbUserName.SelectedValue = value == null ? -1 : value;

                    tbPosition.Text = dgvAdviser.SelectedRows[0].Cells[3].Value.ToString();
                    tbMPhone.Text = dgvAdviser.SelectedRows[0].Cells[4].Value.ToString();
                }
            };
        }
        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {
            if (ws == null) ws = new WSAdviser();
            int total;
            adviserInfo = ws.Search(new BLLAdviser.Adviser()
            {
                Id = Convert.ToInt32(numberCardNo.Value),
                Name = tbName.Text.Trim(),
                Position = tbPosition.Text.Trim(),
                Mobilephone = tbMPhone.Text.Trim()
            }, ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dgvAdviser.DataSource = adviserInfo;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ws.Add(new BLLAdviser.Adviser()
            {
                Name = tbName.Text.Trim(),
                UserId = Convert.ToInt32(cbUserName.SelectedValue),
                Position = tbPosition.Text.Trim(),
                Mobilephone = tbMPhone.Text.Trim()
            }));
            ClearSearchConditions();
            LoadByPaging(paging1.CurrentPage);
        }

        void ClearSearchConditions()
        {
            numberCardNo.Value = 0;
            tbName.Text = "";
            tbPosition.Text = "";
            tbMPhone.Text = "";
            cbUserName.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ws.Update(new BLLAdviser.Adviser()
            {
                Id = Convert.ToInt32(numberCardNo.Value),
                UserId = Convert.ToInt32(cbUserName.SelectedValue),
                Name = tbName.Text.Trim(),
                Position = tbPosition.Text.Trim(),
                Mobilephone = tbMPhone.Text.Trim(),
            }));
            ClearSearchConditions();
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdviser.SelectedRows != null && dgvAdviser.SelectedRows.Count > 0)
            {
                string id = dgvAdviser.SelectedRows[0].Cells[0].Value.ToString();
                string name = dgvAdviser.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show(string.Format("确定要永久删除{0}顾问的信息吗？", name), "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
                MessageBox.Show(ws.Delete(Convert.ToInt32(id)));
                ClearSearchConditions();
                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的顾问");
            }
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

        private void tbAdviserId_TextChanged(object sender, EventArgs e)
        {
            //tbAdviserId.Text = Untils.FilterNumberString(tbAdviserId.Text);
        }

        private void frmAdviserMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmAdviserMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }

        private void dgvAdviser_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            BLLAdviser.Adviser c = adviserInfo[e.RowIndex];
            if (e.ColumnIndex == 1)
            {
                int i = 0;
                for (; i < userInfo.Length; i++)
                {
                    if (userInfo[i].Id == c.UserId)
                    {
                        e.Value = userInfo[i].Name;
                        break;
                    }
                }
                if (i == userInfo.Length) e.Value = "无";
            }
        }
    }
}
