﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using UI.BLLMember;
using UI.BLLGoods;

namespace UI.Intergral
{
    public partial class frmIntegralConsumption : Form
    {
        public int mid = -1;
        WSMemeber wsm;
        Member ResultInfo;
        BLLGoods.Goods[] goodsInfo;
        CardReader crInstance;
        public frmIntegralConsumption()
        {
            wsm = new WSMemeber();
            InitializeComponent();
            crInstance = new CardReader();
            crInstance.OnReadFini += readCallBack;
        }

        private void readCallBack(object sender, ReaderEventArgs e)
        {
            //this.numberCardNo.Value = Convert.ToDecimal(e.id);
            this.tbCardNoQ.Text = wsm.GetCardNoById(e.id);
            //
            this.tbNeedName.Text = "";
            btnSearch_Click(null, null);
        }

        public frmIntegralConsumption(int mid)
            : this()
        {
            this.mid = mid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                CardNo = tbCardNoQ.Text.Trim(),
                Name = tbNeedName.Text.Trim(),
                Mobilephone = "",
                CoachId = -1,
                CardType = ""
            }, true, ref a, 1, out b);
            if (result != null)
                SetValue(result[0]);
            else
                ClearValue();
        }

        private void frmIntegralConsumption_Load(object sender, EventArgs e)
        {
            WSGoods wsg = new WSGoods();
            int a1 = 1, b1;
            goodsInfo = wsg.Search(new BLLGoods.Goods() { Id = -1, Name = "" }, ref a1, 100000, out b1);
            List<UI.BLLGoods.Goods> pros = new List<BLLGoods.Goods>();
            pros.AddRange(goodsInfo);
            pros.Insert(0, new BLLGoods.Goods() { Id = -1, Name = "无" });
            cbPro.DataSource = pros;
            cbPro.DisplayMember = "Name";
            cbPro.ValueMember = "Id";
            cbPro.SelectedValueChanged += cbPro_SelectedValueChanged;

            if (mid < 0) return;
            int a = 1, b;
            var result = wsm.Search(new Member()
            {
                Id = mid,
                Name = "",
                Mobilephone = "",
                CoachId = -1,
                CardType = ""
            }, true, ref a, 1, out b);
            if (result != null)
                SetValue(result[0]);
            else
                ClearValue();
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
            numScore.Value = 0;
            dataBgn.Value = DateTime.Now;
            dataEnd.Value = DateTime.Now;
            pVideo.BackgroundImage = null;
        }

        void SetValue(Member m)
        {
            if (m == null) return;
            this.ResultInfo = m;
            tbName.Text = m.Name;
            tbCardNo.Text = m.Id.ToString();
            tbCardType.Text = m.CardType;
            tbMPhone.Text = m.Mobilephone;
            tbnational.Text = m.People;
            tbNationality.Text = m.Nation;
            tbGender.Text = m.Gender;
            tbNo2.Text = m.ContractNo;
            numHowMach.Value = (decimal)m.CardStartMoney;
            numScore.Value = (decimal)m.Score;
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

        private void btnConsump_Click(object sender, EventArgs e)
        {
            if (ResultInfo == null) return;
            MessageBox.Show(wsm.ConsumptionScore(new Member()
            {
                Id = ResultInfo.Id,
            }, Convert.ToInt32(numIntegral.Value)));
        }

        private void cbPro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbPro.SelectedValue) <= 0)
            {
                numIntegral.Text = "";
                return;
            }

            foreach (BLLGoods.Goods g in goodsInfo)
            {
                if (g.Id == Convert.ToInt32(cbPro.SelectedValue))
                {
                    numIntegral.Text = g.Price.ToString();
                    break;
                }
            }
        }

        private void frmIntegralConsumption_Activated(object sender, EventArgs e)
        {
            crInstance.startRead();
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmIntegralConsumption_Deactivate(object sender, EventArgs e)
        {
            crInstance.pauseRead();
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
