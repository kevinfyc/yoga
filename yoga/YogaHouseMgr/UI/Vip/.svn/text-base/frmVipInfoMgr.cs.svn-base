using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLMember;
namespace UI.Vip
{
    public partial class frmVipInfoMgr : Form
    {
        WSMemeber wsm;
        Member[] ms;
        int aid;
        public frmVipInfoMgr()
        {
            InitializeComponent();
            wsm = new WSMemeber();
            dataVipInfo.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
            cbCardKind.SelectedIndex = 0;
        }
        private void frmVipInfoMgr_Load(object sender, EventArgs e)
        {
            
            /*
             * 0，管理员
             * 1，前台
             * 2，会籍
             * 3，财务
             */
            string userType = Global.CurrentUser.UserType;
            switch (userType)
            {
                case "1":
                    this.btnAdd.Visible = false;
                    this.Text = "会员资料管理--前台";
                    break;
                case "2":
                    this.btnAdd.Visible = false;
                    this.btnModify.Visible = false;
                    this.btnDel.Visible = false;
                    this.btnChange.Visible = false;
                    this.btnVacate.Visible = false;
                    this.btnEnter.Visible = false;
                    this.Text = "会员资料管理--会籍部";
                    BLLAdviser.WSAdviser wsa = new BLLAdviser.WSAdviser();
                    int a = 1, b;
                    var res = wsa.Search(new BLLAdviser.Adviser() { UserId = Global.CurrentUser.Id, Name = "", Position = "" }, ref a, 1, out b);
                    if (res == null)
                    {
                        MessageBox.Show("当前界面只允许会籍顾问访问");
                        return;
                    }
                    aid = res[0].Id;
                    break;
                case "3":
                    this.btnModify.Visible = false;
                    this.btnDel.Visible = false;
                    this.btnChange.Visible = false;
                    this.btnVacate.Visible = false;
                    this.btnEnter.Visible = false;
                    this.Text = "会员资料管理--财务部";
                    break;
            }
            LoadByPaging(1);
        }

        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {
            int total;
            Member m= new Member()
            {
                //Id = (int)numberCardNo.Value,
                CardNo = tbCardNoQ.Text.Trim(),
                Name = tbName.Text.Trim(),
                Mobilephone = tbMPhone.Text.Trim(),
                CardType = cbCardKind.SelectedIndex < 1 ? "" : cbCardKind.SelectedItem.ToString(),
                CoachId = -1,
                AdviserId = aid
            };
            ms = wsm.Search(m, aid<=0, ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dataVipInfo.DataSource = ms;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewVip frm = new frmAddNewVip();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                LoadByPaging(paging1.CurrentPage);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
            {
                frmAddNewVip frm = new frmAddNewVip(ms[dataVipInfo.SelectedRows[0].Index],1);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    LoadByPaging(paging1.CurrentPage);
                }
            }
            else
            {
                MessageBox.Show("请在列表中选择要修改的会员");
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32( dataVipInfo.SelectedRows[0].Cells[0].Value);
                string name = dataVipInfo.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show(string.Format("确定要永久删除{0}的信息吗？", name), "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
                MessageBox.Show(wsm.Delete(id));
                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的会员");
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
            {
                frmVipQuery frm = new frmVipQuery(ms[dataVipInfo.SelectedRows[0].Index]);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请在列表中选择要查看的会员");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
            {
                frmAddNewVip frm = new frmAddNewVip(ms[dataVipInfo.SelectedRows[0].Index],2);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    LoadByPaging(paging1.CurrentPage);
                }
            }
            else
            {
                MessageBox.Show("请在列表中选择要转卡的会员");
            }
        }

        private void btnVacate_Click(object sender, EventArgs e)
        {
            if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
            {
                frmAddNewVip frm = new frmAddNewVip(ms[dataVipInfo.SelectedRows[0].Index], 3);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    LoadByPaging(paging1.CurrentPage);
                }
            }
            else
            {
                MessageBox.Show("请在列表中选择要请假的会员");
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在前台菜单中选择进场功能操作");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Untils.ExportDataGridToCSV(dataVipInfo);
        }

        private void frmVipInfoMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmVipInfoMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }


    }
}
