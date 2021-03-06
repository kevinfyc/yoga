﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using UI.BLLGoods;
using UI.BLLMember;

namespace UI.Vip
{
    public partial class frmVipConsumption : Form
    {
        WSMemeber wsm;
        BLLGoods.Goods[] goodsInfo;
        Member m;
        CardReader crInstance;
        public frmVipConsumption()
        {
            InitializeComponent();
            wsm = new WSMemeber();
            crInstance = new CardReader();
            crInstance.OnReadFini += readCallBack;
        }

        private void readCallBack(object sender, ReaderEventArgs e)
        {
            //this.numberCardNo.Value = Convert.ToDecimal(e.id);
            this.tbCardNoQ.Text = wsm.GetCardNoById(e.id);
            this.tbNeedName.Text = "";
            btnSearch_Click(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ClearValue()
        {
            tbName.Text = "";
            tbCardNo.Text = "";
            tbCardType.Text = "";
            tbMPhone.Text = "";
            tbnational.Text = "";
            tbNationality.Text = "";
            tbGender.Text = "";
            tbNo2.Text = "";
            numHowMach.Value = 0;
            numRemain.Value = 0;
            dataBgn.Value = DateTime.Now;
            dataEnd.Value = DateTime.Now;
            pVideo.BackgroundImage = null;
        }
        void SetValue(Member m)
        {
            if (m == null) return;
            tbName.Text = m.Name;
            tbCardNo.Text = m.Id.ToString();
            tbCardType.Text = m.CardType;
            tbMPhone.Text = m.Mobilephone;
            tbnational.Text = m.People;
            tbNationality.Text = m.Nation;
            tbGender.Text = m.Gender;
            tbNo2.Text = m.ContractNo;
            numHowMach.Value = (decimal)m.CardStartMoney;
            numRemain.Value = (decimal)m.CardRestMoney;
            dataBgn.Value = m.RegistDate;
            dataEnd.Value = m.ExpireDate;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(Global.ServerBaseUrl + "Images/" + m.Id + ".jpg");
            req.Method = "GET";
            try
            {
                var resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                if (stream == null || !stream.CanRead) return;
                pVideo.BackgroundImage = Bitmap.FromStream(stream);
                stream.Close();
            }
            catch
            {
                pVideo.BackgroundImage = Bitmap.FromFile("default.jpg");
            }
        }

        private void frmVipConsumption_Load(object sender, EventArgs e)
        {
            WSGoods wsg = new WSGoods();
            int a = 1, b;
            goodsInfo = wsg.Search(new BLLGoods.Goods() { Id = -1, Name = "" }, ref a, 100000, out b);
            if (goodsInfo == null)
                return;
            cbPro.DataSource = goodsInfo;
            cbPro.DisplayMember = "Name";
            cbPro.ValueMember = "Id";
            cbPro.SelectedIndexChanged += (s, ee) =>
                {
                    numMach.Value = (decimal)(cbPro.SelectedItem as BLLGoods.Goods).Price;
                };
            cbPro.SelectedIndex = 0;
            numMach.Value = (decimal)goodsInfo[0].Price;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbCardNoQ.Text.Trim().Length < 1 && tbNeedName.Text.Trim().Length < 1)
            {
                ClearValue();
                return;
            }
            int a = 1, b;
            var result = wsm.Search(new Member()
            {
                //Id = (int)numberCardNo.Value,
                CardNo = this.tbCardNoQ.Text.Trim(),
                Name = tbNeedName.Text.Trim(),
                Mobilephone = "",
                CoachId = -1,
                CardType = ""
            }, true, ref a, 1, out b);
            if (result != null)
            {
                m = result[0];
                SetValue(m);
            }
            else
            {
                m = null;
                ClearValue();
            }
        }

        private void btnConsump_Click(object sender, EventArgs e)
        {
            if (m == null)
            {
                MessageBox.Show("请指定要扣值的会员");
                return;
            }
            BLLGoods.Goods g = (cbPro.SelectedItem as BLLGoods.Goods);
            string result = wsm.Consumption(m.Id, g.Price,g.Id,Global.CurrentUser.Id);
            if (result.Contains("成功"))
            {
                m.CardRestMoney -= g.Price;
                m.Score += (int)g.Price;
                SetValue(m);
            }
            MessageBox.Show(result);
        }

        private void frmVipConsumption_Activated(object sender, EventArgs e)
        {
            crInstance.startRead();
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmVipConsumption_Deactivate(object sender, EventArgs e)
        {
            crInstance.pauseRead();
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
