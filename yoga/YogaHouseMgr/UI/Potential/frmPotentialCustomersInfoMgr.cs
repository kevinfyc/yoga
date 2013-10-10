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
    public partial class frmPotentialCustomersInfoMgr : Form
    {
        WSPotentialMember ws;
        PotentialMember[] pms;
        BLLAdviser.Adviser[] ads;
        public frmPotentialCustomersInfoMgr()
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
        private void frmPotentialCustomersInfoMgr_Load(object sender, EventArgs e)
        {
            var wsa = new BLLAdviser.WSAdviser();
            int a = 1 , b;
            if (Global.CurrentUser.UserType == "2")
            {
                ads = wsa.Search(new BLLAdviser.Adviser() { Id = -1, UserId = Global.CurrentUser.Id, Name = "", Position = "" }, ref a, 1, out b);
                if (ads == null)
                {
                    MessageBox.Show("当前界面只允许会籍顾问访问");
                    return;
                }
            }
            else if (Global.CurrentUser.UserType == "0")
            {
                ads = wsa.Search(new BLLAdviser.Adviser() { Id = -1, Name = "", Position = "" }, ref a, 100000, out b);
            }
            List<UI.BLLAdviser.Adviser> advisers = new List<BLLAdviser.Adviser>();
            advisers.Add(new BLLAdviser.Adviser() { Id = -1, Name = "全部" });
            if(ads!=null)
                advisers.AddRange(ads);
            cbAdviser.DataSource = advisers;
            cbAdviser.DisplayMember = "Name";
            cbAdviser.ValueMember = "Id";

            cbGender.SelectedIndex = 0;
            
            LoadByPaging(1);

            //显示/隐藏控件
            if (Global.CurrentUser.UserType == "2")
            {
                //btnAdd.Visible = btnModify.Visible = btnDel.Visible = 
                btnTrackInfo.Visible= false;
            }
            ///

            dataVipInfo.CellMouseClick += (ss, ee) =>
            {
                if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
                {
                    numberId.Value = Convert.ToDecimal(dataVipInfo.SelectedRows[0].Cells[0].Value);
                    tbName.Text = dataVipInfo.SelectedRows[0].Cells[1].Value.ToString();
                    cbGender.Text = dataVipInfo.SelectedRows[0].Cells[2].Value.ToString();
                    tbMPhone.Text = dataVipInfo.SelectedRows[0].Cells[3].Value.ToString();
                    object value = pms[dataVipInfo.SelectedRows[0].Index].AdviserId;
                    cbAdviser.SelectedValue = value==null?-1:value;
                    tbChannel.Text = dataVipInfo.SelectedRows[0].Cells[7].Value.ToString();
                    tbRemarks.Text = dataVipInfo.SelectedRows[0].Cells[8].Value.ToString();
                }
            };
        }

        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {
            int total;
            int a = Convert.ToInt32(cbAdviser.SelectedValue);
            pms = ws.Search(new PotentialMember()
            {
                Id = (int)numberId.Value,
                Name = tbName.Text.Trim(),
                AdviserId =Global.CurrentUser.UserType == "2"?ads[0].Id:Convert.ToInt32(cbAdviser.SelectedValue),
            }, true, ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dataVipInfo.DataSource = pms;
        }

        bool ValidateValue()
        {
            int len = tbName.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("姓名长度在1-20之间");
                return false;
            }
            len = tbMPhone.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("手机号码长度在1-20之间");
                return false;
            }
            len = tbChannel.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("客户渠道长度在1-20之间");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateValue()) return;

            int resultId = ws.Add(new PotentialMember()
            {
                Name = tbName.Text.Trim(),
                Mobilephone = tbMPhone.Text.Trim(),
                AdviserId = cbAdviser.SelectedValue.ToString() == "-1" ? null : (int?)Convert.ToInt32(cbAdviser.SelectedValue),
                CustomerChannel = tbChannel.Text.Trim(),
                Gender = cbGender.SelectedItem.ToString(),
                Remarks = tbRemarks.Text.Trim(),
            });
            if (resultId > 0)
            {
                ClearSearchConditions();
                LoadByPaging(paging1.CurrentPage);
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
            {
                string id = dataVipInfo.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataVipInfo.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show(string.Format("确定要永久删除{0}的信息吗？", name), "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
                MessageBox.Show(ws.Delete(Convert.ToInt32(id)));
                ClearSearchConditions();
                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的项");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int aid =Convert.ToInt32(cbAdviser.SelectedValue);
            MessageBox.Show(ws.Update(new PotentialMember()
            {
                Id = (int)numberId.Value,
                Name = tbName.Text.Trim(),
                Mobilephone = tbMPhone.Text.Trim(),
                AdviserId = aid<0?null:(int?)aid,
                CustomerChannel = tbChannel.Text.Trim(),
                Gender = cbGender.SelectedItem.ToString(),
                Remarks = tbRemarks.Text.Trim(),
            }));
            ClearSearchConditions();
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }
        void ClearSearchConditions()
        {
            numberId.Value = 0;
            tbName.Text = "";
            tbMPhone.Text = "";
            cbAdviser.SelectedIndex = 0;
            tbChannel.Text = "";
            tbRemarks.Text = "";
        }

        private void btnExportToPhone_Click(object sender, EventArgs e)
        {
            Untils.ExportDataGridToCSV(dataVipInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ws.Dispose();
            ws = null;
            this.Close();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (dataVipInfo.SelectedRows != null && dataVipInfo.SelectedRows.Count > 0)
            {
                string id = dataVipInfo.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(ws.Track(Convert.ToInt32(id)));
                ClearSearchConditions();
                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的项");
            }
        }

        private void btnTrackInfo_Click(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.ShowChildForm(typeof(Potential.frmPotentialCustomersTrackeInfo));
        }

        private void dataVipInfo_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (pms.Length <= e.RowIndex) return;
            PotentialMember pm = pms[e.RowIndex];
            if (e.ColumnIndex == 4)
            {
                int i = 0;
                for (; i < ads.Length; i++)
                {
                    if (ads[i].Id == pm.AdviserId)
                    {
                        e.Value = ads[i].Name;
                        break;
                    }
                }
                if (i == ads.Length) e.Value = "无";
            }
        }

        private void frmPotentialCustomersInfoMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmPotentialCustomersInfoMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }

    }
}
