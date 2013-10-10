using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using UI.BLLMember;
using UI.BLLRack;
using UI.BLLImport;
namespace UI.Vip
{
    public partial class frmVipEnter : Form
    {
        WSMemeber wsm;
        WSRack wsr;
        WSImport wsi;
        Member m;
        CardReader crInstance;
        public frmVipEnter()
        {
            InitializeComponent();
            wsm = new WSMemeber();
            wsr = new WSRack();
            wsi = new WSImport();
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
            },true, ref a, 1, out b);

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
            tbTempTimes.Text = "";
            tbCoach.Text = "";
            tbTips.Text = "";
            tbEmail.Text = "";
            dateBirthday.Value = DateTime.Now;
            pVideo.BackgroundImage = null;
        }
        void SetValue(Member m)
        {
            if (m == null) return;
            tbName.Text = m.Name;
            tbCardNo.Text = m.Id.ToString();
            tbCardType.Text = m.CardType;
            tbTempTimes.Text = m.TempTimes.ToString();
            tbCoach.Text = m.CoachId.ToString();
            tbPhone.Text = m.Telephone;
            tbMPhone.Text = m.Mobilephone;
            tbnational.Text = m.People;
            tbNationality.Text = m.Nation;
            tbGender.Text = m.Gender;
            tbNo2.Text = m.ContractNo;
            numHowMach.Value = (decimal)m.CardStartMoney;
            numRemain.Value = (decimal)m.CardRestMoney;
            dataBgn.Value = m.RegistDate;
            dataEnd.Value = m.ExpireDate;
            tbTips.Text = m.Remarks;
            tbJoneCount.Text = m.JoneCount.ToString();
            dateBirthday.Value = (DateTime)m.Birthday;
            tbEmail.Text = m.Email;
            if (m.Birthday.Value.Month == DateTime.Now.Month && m.Birthday.Value.Day == DateTime.Now.Day)
                MessageBox.Show(string.Format("{0}先生/女士，生日快乐！", tbName.Text));
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (m == null)
            {
                MessageBox.Show("请决定要进场的会员");
                return;
            }
            string enterresult = wsi.Import(m.Id, m.Name, m.IsTemp, (int)cbRentalBox.SelectedValue);

            MessageBox.Show(enterresult);
        }

        private void frmVipEnter_Load(object sender, EventArgs e)
        {
            int a= 1,b;
            BLLRack.Rack[] racks = wsr.Search(new BLLRack.Rack() { }, ref a, 10000000, out b);
            List<BLLRack.Rack> rs = new List<BLLRack.Rack>();
            rs.Add(new BLLRack.Rack() { Id=-1, Remarks="无" });
            if(racks!=null) rs.AddRange(racks);
            cbRentalBox.DataSource = rs;
            cbRentalBox.DisplayMember = "Id";
            cbRentalBox.ValueMember = "Id";
        }

        private void frmVipEnter_Activated(object sender, EventArgs e)
        {
            crInstance.startRead();
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ",this.Text));
        }

        private void frmVipEnter_Deactivate(object sender, EventArgs e)
        {
            crInstance.pauseRead();
            frmYogaHouseMgr.MainForm.setCurActiveFrmText("");
        }
    }
}
