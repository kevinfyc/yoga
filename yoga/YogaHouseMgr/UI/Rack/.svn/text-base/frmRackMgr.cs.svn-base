using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLRack;
using UI.BLLMember;

namespace UI.Rack
{
    public partial class frmRackMgr : Form
    {
        WSRack wsr;
        BLLRack.Rack[] rackInfo;
        BLLMember.Member[] memberInfo;
        WSMemeber ws;
        public frmRackMgr()
        {
            wsr = new WSRack();
            InitializeComponent();
            dataRankInfo.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
        }

        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }

        void LoadByPaging(int page)
        {
            int total;
            rackInfo = wsr.Search(new BLLRack.Rack()
            {
                //Id = Convert.ToInt32(numberRankId.Value)
                RackNo = tbRackNo.Text.Trim(),
            }, ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dataRankInfo.DataSource = rackInfo;
        }

        private void frmRackMgr_Load(object sender, EventArgs e)
        {
            ws = new WSMemeber();
            int a = 1, b;
            memberInfo = ws.Search(new Member()
            {
                CardNo = "",
                Name = "",
                Mobilephone = "",
                CardType = "",
                CoachId = -1,
                AdviserId = -1
            }, true, ref a, 100000, out b);

            LoadByPaging(1);

            dataRankInfo.CellMouseClick += (ss, ee) =>
            {


                if (dataRankInfo.SelectedRows != null && dataRankInfo.SelectedRows.Count > 0)
                {
                    tbnoq.Text = dataRankInfo.SelectedRows[0].Cells[0].Value.ToString();
                    tbRackNo.Text = dataRankInfo.SelectedRows[0].Cells[1].Value.ToString();
                    object value = rackInfo[dataRankInfo.SelectedRows[0].Index].RenterId;
                    tbCardNoQ.Text = value == null ? "" : ws.GetCardNoById(Convert.ToInt32(value));
                    dataBgn.Value = Convert.ToDateTime(dataRankInfo.SelectedRows[0].Cells[3].Value);
                    dataEnd.Value = Convert.ToDateTime(dataRankInfo.SelectedRows[0].Cells[4].Value);
                    tbTips.Text = dataRankInfo.SelectedRows[0].Cells[5].Value.ToString();
                }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateValue()) return;

            DateTime d = dataEnd.Value;
            d = d.AddHours(-d.Hour);
            d = d.AddMinutes(-d.Minute);
            d = d.AddSeconds(-d.Second);

            int id = wsr.Add(new BLLRack.Rack()
            {
                RackNo = tbRackNo.Text.Trim(),
                RenterId = ws.GetIdByCardNo(tbCardNoQ.Text),
                RentDate = dataBgn.Value,
                RentExpire = d,
                Remarks = tbTips.Text.ToString()
            });

            if (id >= 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
                return;
            }
            clearValue();
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DateTime d = dataEnd.Value;
            d = d.AddHours(-d.Hour);
            d = d.AddMinutes(-d.Minute);
            d = d.AddSeconds(-d.Second);
            MessageBox.Show(wsr.Update((new BLLRack.Rack()
            {
                Id = Convert.ToInt32(tbnoq.Text.Trim()),
                RackNo = tbRackNo.Text,
                RenterId = ws.GetIdByCardNo(tbCardNoQ.Text),
                Remarks = tbTips.Text.ToString()
            }),dataBgn.Value, d));
            clearValue();
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataRankInfo.SelectedRows != null && dataRankInfo.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataRankInfo.SelectedRows[0].Cells[0].Value);
                if (MessageBox.Show(string.Format("确定要永久删除{0}的信息吗？", id), "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
                MessageBox.Show(wsr.Delete(id));
                clearValue();
                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的会员");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            wsr.Dispose();
            wsr = null;
            this.Close();
        }

        private bool ValidateValue()
        {
            if (tbCardNoQ.Text == "")
            {
                MessageBox.Show("卡号不能为空");
                return false;
            }
            if (tbRackNo.Text == "")
            {
                MessageBox.Show("柜子编号不能为空");
                return false;
            }
            int id = ws.GetIdByCardNo(tbCardNoQ.Text);
            if (id > 0)
                return true;
            MessageBox.Show("没有该会员!");
            return false;
        }

        private void clearValue()
        {
            tbRackNo.Text = "";
            tbCardNoQ.Text = "";
        }

        private void dataRankInfo_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (rackInfo == null)
                return;
            if (rackInfo.Length <= e.RowIndex) return;
            if (e.ColumnIndex == 1)
            {
                int i = 0;
                for (; i < memberInfo.Length; i++)
                {
                    if (memberInfo[i].Id == rackInfo[e.RowIndex].RenterId)
                    {
                        e.Value = memberInfo[i].Name;
                        break;
                    }
                }
                if (i == memberInfo.Length) e.Value = "无";
            }
        }

        private void frmRackMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmRackMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
