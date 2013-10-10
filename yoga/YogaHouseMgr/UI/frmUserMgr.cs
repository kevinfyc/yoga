using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLUser;

namespace UI
{
    public partial class frmUserMgr : Form
    {
        WSUser wsu;
        public frmUserMgr()
        {
            InitializeComponent();
            dgvUserMgr.AutoGenerateColumns = false;
            wsu = new WSUser();
        }

        private bool check()
        {
            int len = tbUserName.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("用户名长度为1-20");
                return false;
            }
            len = tbPsd.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("密码长度为1-20");
                return false;
            }
            len = tbUserType.Text.Trim().Length;
            if (len > 1 || len < 0)
            {
                MessageBox.Show("账号类型长度为1");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            User u = new BLLUser.User()
            {
                Name = tbUserName.Text.Trim(),
                Password = tbPsd.Text.Trim(),
                UserType = tbUserType.Text.Trim()
            };
            MessageBox.Show(string.Format("name =={0},\npas == {1},\ntype=={2},\n", u.Name, u.Password, u.UserType));
            int id = wsu.Add(u);
            clear();
            if (id >= 0)
                MessageBox.Show(string.Format("{0}添加成功", u.Name));
            else
                MessageBox.Show("添加失败");
            LoadByPaging();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!check())return;

            MessageBox.Show(wsu.Update(new BLLUser.User()
            {
                Id = Convert.ToInt32(tbId.Text.Trim()),
                Name = tbUserName.Text.Trim(),
                Password = tbPsd.Text.Trim(),
                UserType = tbUserType.Text.Trim()
            }));
            clear();
            LoadByPaging();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = dgvUserMgr.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgvUserMgr.SelectedRows[0].Cells[1].Value.ToString();
            if (MessageBox.Show(string.Format("确定要永久删除{0}的信息吗？", name), "警告",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                return;
            MessageBox.Show(wsu.Delete(Convert.ToInt32(id)));
            clear();
            LoadByPaging();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging();
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            wsu.Dispose();
            wsu = null;
            this.Close();
        }

        private void LoadByPaging()
        {
            int a = 1, b;
            BLLUser.User[] users = wsu.Search(new BLLUser.User()
            {
                Id = Convert.ToInt32(tbId.Text.Trim()),
                Name = tbUserName.Text.Trim(),
            }, ref a, 20000, out b);
            dgvUserMgr.DataSource = users;
        }

        private void frmUserMgr_Load(object sender, EventArgs e)
        {
            LoadByPaging();
            dgvUserMgr.CellMouseClick += (ss, ee) =>
            {
                if (dgvUserMgr.SelectedRows != null && dgvUserMgr.SelectedRows.Count > 0)
                {
                    tbId.Text = dgvUserMgr.SelectedRows[0].Cells[0].Value.ToString();
                    tbUserName.Text = dgvUserMgr.SelectedRows[0].Cells[1].Value.ToString();
                    tbPsd.Text = dgvUserMgr.SelectedRows[0].Cells[2].Value.ToString();
                    tbUserType.Text = dgvUserMgr.SelectedRows[0].Cells[3].Value.ToString();
                }
            };
        }

        private void clear()
        {
            tbId.Text = "0";
            tbUserName.Text = "";
            tbPsd.Text = "";
            tbUserType.Text = "";
        }
    }
}
