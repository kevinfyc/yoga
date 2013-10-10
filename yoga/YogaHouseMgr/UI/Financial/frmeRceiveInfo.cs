using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLGoods;
using UI.BLLCollect;
using UI.BLLMember;
namespace UI.Financial
{
    public partial class frmeRceiveInfo : Form
    {
        WSCollect ws;
        WSMemeber wsm;
        BLLGoods.Goods[] goodsInfo;
        public frmeRceiveInfo()
        {
            ws = new WSCollect();
            wsm = new WSMemeber();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateValue()) return;

            int id = ws.Add(new Collect()
            {
                Datie = dataTime.Value,
                GoodsId = cbPro.SelectedValue.ToString() == "-1" ? -1 : Convert.ToInt32(cbPro.SelectedValue),
                MemberId = Convert.ToInt32(wsm.GetIdByCardNo(tbCardNoQ.Text)),
                UserId = Convert.ToInt32(Global.CurrentUser.Id),
                Remarks = tbMTips.Text.Trim()
            });
            if (id > 0)
            {
                tbSysInfo.Text = id.ToString();
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ws.Dispose();
            ws = null;
            this.Close();
        }

        private void frmeRceiveInfo_Load(object sender, EventArgs e)
        {
            WSGoods wsg = new WSGoods();
            int a = 1, b;
            goodsInfo = wsg.Search(new BLLGoods.Goods() { Id = -1, Name = "" }, ref a, 100000, out b);
            List<UI.BLLGoods.Goods> pros = new List<BLLGoods.Goods>();
            pros.AddRange(goodsInfo);
            pros.Insert(0, new BLLGoods.Goods() { Id = -1, Name = "无" });
            cbPro.DataSource = pros;
            cbPro.DisplayMember = "Name";
            cbPro.ValueMember = "Id";
            cbPro.SelectedValueChanged += cbPro_SelectedValueChanged;
        }

        private void cbPro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbPro.SelectedValue) <= 0) 
            {
                numMach.Text = "";
                return; 
            }

            foreach (BLLGoods.Goods g in goodsInfo)
            {
                if (g.Id == Convert.ToInt32(cbPro.SelectedValue))
                {
                    numMach.Text = g.Price.ToString();
                    break;
                }
            }
        }

        private bool ValidateValue()
        {
            if (Convert.ToInt32(cbPro.SelectedValue) <= 0)
            {
                MessageBox.Show("请选择项目");
                return false;
            }

            int id = wsm.GetIdByCardNo(tbCardNoQ.Text);
            if (id > 0)
                return true;
            MessageBox.Show("没有该会员!");
            return false;
        }

        private void frmeRceiveInfo_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmeRceiveInfo_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
