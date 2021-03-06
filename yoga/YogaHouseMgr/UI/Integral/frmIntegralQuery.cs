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

namespace UI.Intergral
{
    public partial class frmIntegralQuery : Form
    {
        public int mid = -1;
        WSMemeber wsm;
        CardReader crInstance;
        public frmIntegralQuery()
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
            this.tbNeedName.Text = "";
            btnSearch_Click(null, null);
        }

        public frmIntegralQuery(int mid)
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

        private void frmIntegralQuery_Load(object sender, EventArgs e)
        {
            if (mid < 0) return;
            int a=1,b;
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
            tbCardNo.Text ="";
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
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(Global.ServerBaseUrl+"Images/"+m.Id+".jpg");
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

        private void frmIntegralQuery_Activated(object sender, EventArgs e)
        {
            crInstance.startRead();
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmIntegralQuery_Deactivate(object sender, EventArgs e)
        {
            crInstance.pauseRead();
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
