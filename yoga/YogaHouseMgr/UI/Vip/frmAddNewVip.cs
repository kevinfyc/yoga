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
using UI.BLLPotentialMember;
namespace UI.Vip
{
    public partial class frmAddNewVip : Form
    {
        private int pid = -1;
        private Member memberToUpdate;
        private int operate=0;
        WSMemeber wsm;
        WSPotentialMember wsp;
        CardReader crInstance;
        public frmAddNewVip()
        {
            InitializeComponent();
            wsm = new WSMemeber();
            wsp = new WSPotentialMember();
            cbCardKind.SelectedIndex = 0;
            cbSex.SelectedIndex = 0;
            crInstance = new CardReader();
        }

        public frmAddNewVip(int pid):this()
        {
            this.pid = pid;
        }
        /// <summary>
        /// operate:0-添加;1-更新;2-转卡;3-请假（延长有效期）
        /// </summary>
        /// <param name="memberToUpdate"></param>
        /// <param name="operate">操作</param>
        public frmAddNewVip(Member memberToUpdate, int operate): this()
        {
            this.memberToUpdate = memberToUpdate;
            switch (operate)
            {
                case 1:
                    this.Text = "会员信息修改";
                    break;
                case 2:
                    this.Text = "会员转卡";
                    break;
                case 3:
                    this.Text = "会员请假";
                    break;
                default:
                    break;
            }
            this.operate = operate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (vw != null)
            {
                vw.Stop();
                vw = null;
            }
            if (File.Exists("snapshot.jpg")) File.Delete("snapshot.jpg");
            this.Close();
        }

        private void btnOpenVideo_Click(object sender, EventArgs e)
        {
            vw = new VideoWork(pVideo.Handle, 0, 0, pVideo.Width, pVideo.Height);
            vw.Start();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (pVideo.BackgroundImage != null)
            {
                pVideo.BackgroundImage.Dispose();
                pVideo.BackgroundImage = null;
            }
            if (vw.GrabImage("snapshot.bmp"))
            {
                vw.Stop();
                Bitmap bmp = new Bitmap("snapshot.bmp");
                bmp.Save("snapshot.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                pVideo.BackgroundImage = bmp;
            }
            
        }

        private void btnCloseVideo_Click(object sender, EventArgs e)
        {
            vw.Stop();
        }
        bool ValidateValue()
        {
            int len = tbCardNo.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("卡号长度在1-20之间");
                return false;
            }
            len = tbName.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("姓名长度在1-20之间");
                return false;
            }
            len = tbMobilephone .Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("手机号码长度在1-20之间");
                return false;
            }
            len = tbNo2.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("合约编号长度在1-20之间");
                return false;
            }
            len = tbTips.Text.Trim().Length;
            if (len > 1000)
            {
                MessageBox.Show("备注长度不能超过1000");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateValue()) return;

            BLLMember.Member m = new BLLMember.Member();
            m.CardNo = tbCardNo.Text.Trim();//
            m.Name = tbName.Text.Trim();
            m.Gender = cbSex.SelectedItem.ToString();
            m.Nation = tbNationality.Text.Trim();
            m.People = tbnational.Text.Trim();
            m.RegistDate = dataBgn.Value;
            m.CardType = cbCardKind.SelectedItem.ToString();
            m.TempTimes = (int)numTempTimes.Value;
            m.Birthday = dateBirthday.Value;
            m.Email = tbEmail.Text.Trim() == "" ? "无" : tbEmail.Text.Trim();
            m.IsTemp = (m.CardType=="次卡" || m.CardType=="高温卡");
            if (operate == 0)
            {
                switch (m.CardType)
                {
                    case "次卡":
                    case "高温卡":
                        dataEnd.Value = m.ExpireDate = DateTime.Now.AddYears(1);
                        break;
                    case "月卡":
                    case "季卡":
                    case "半年卡":
                    case "一年卡":
                    case "二年卡":
                    case "三年卡":
                        m.ExpireDate = dataEnd.Value;
                        break;
                    default:
                        break;
                }
            }
            m.Telephone = tbTelephone.Text.Trim();
            m.Mobilephone = tbMobilephone.Text.Trim();
            m.ContractNo = tbNo2.Text.Trim();
            m.CardStartMoney = (int)numHowMach.Value;
            m.CardRestMoney = (int)numRemain.Value;
            m.Remarks = tbTips.Text.Trim();
            //m.Picture = string.Format("{0}_{1}.jpg", m.Name, DateTime.Now.ToString("yyMMddHHmm"));
            byte[] picData = null;
            
            if (File.Exists("snapshot.jpg"))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream("snapshot.jpg", FileMode.Open, FileAccess.Read);
                    picData = new byte[fs.Length];
                    fs.Read(picData, 0, picData.Length);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
            if(memberToUpdate!=null)//更新会员资料
            {
                m.Id = memberToUpdate.Id;
                string msg = null;
                if (operate == 1) msg = wsm.Update(m, picData);
                else if (operate == 2) msg = wsm.Change(m, picData);
                else if (operate == 3)
                {
                    if (dataEnd.Value <= memberToUpdate.ExpireDate)
                    {
                        MessageBox.Show("过期时间应晚于原时间");
                        return;
                    }
                    msg = wsm.AddExprire(m.Id, dataEnd.Value,tbTips.Text);
                }
                MessageBox.Show(msg);
                this.DialogResult =msg.Contains("成功")?System.Windows.Forms.DialogResult.Yes:System.Windows.Forms.DialogResult.No;
                this.Close();
                return;
            }
            int id;
            if (pid > 0) id = wsm.PotentialToMember(m, picData, pid);
            else id = wsm.AddMember(m, picData);
            if (id < 0)
            {
                MessageBox.Show("操作失败，请检查卡号是否有误");
                return;
            }
            //TODO 下面开始写卡,把id写入卡中
            crInstance.HF_WRITE(1, id);


            //最后成功的结果
            MessageBox.Show("录入会员成功，卡号为：" + tbCardNo.Text);
            if (pid > 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
        }

        private void cbCardKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            numTempTimes.Enabled = (cbCardKind.SelectedItem.ToString() == "次卡" || 
                cbCardKind.SelectedItem.ToString() == "高温卡" );
        }

        private void frmAddNewVip_Load(object sender, EventArgs e)
        {
            if (File.Exists("snapshot.jpg")) File.Delete("snapshot.jpg");
            if (pid > 0)//转正
            {
                int a=1,b;
                PotentialMember[] pms = wsp.Search(new PotentialMember() { Id = pid, Name = "", AdviserId = -1 }, true, ref a, 1, out b);
                if (pms == null )
                {
                    MessageBox.Show(string.Format("编号为{0}的潜在会员不存在",pid));
                    return;
                }
                tbName.Text = pms[0].Name;
                cbSex.SelectedItem = pms[0].Gender;
                tbMobilephone.Text = pms[0].Mobilephone;
            }
            else if(memberToUpdate!=null)//修改
            {
                SetValue(memberToUpdate);
            }
            if (operate > 0)
            {
                numHowMach.Enabled = false;
            }
            if (operate >1)
            {
                tbNo2.Enabled = false;
                dataBgn.Enabled = false;
                dataEnd.Enabled = false;
                cbCardKind.Enabled = false;
                numRemain.Enabled = false;
                numTempTimes.Enabled = false;
            }
            if (operate > 2)
            {
                tbName.Enabled = false;
                tbMobilephone.Enabled = false;
                tbnational.Enabled = false;
                tbNationality.Enabled = false;
                tbTelephone.Enabled = false;
                cbSex.Enabled = false;
                btnShoot.Enabled = false;
                btnOpenVideo.Enabled = false;
                //tbTips.Enabled = false;
                dataEnd.Enabled = true;
            }
        }
        void SetValue(Member m)
        {
            if (m == null) return;
            tbName.Text = m.Name;
            tbCardNo.Text = m.Id.ToString();
            cbCardKind.SelectedItem = m.CardType;
            tbMobilephone.Text = m.Mobilephone;
            tbnational.Text = m.People;
            tbNationality.Text = m.Nation;
            cbSex.SelectedItem = m.Gender;
            tbNo2.Text = m.ContractNo;
            tbTelephone.Text = m.Telephone;
            dateBirthday.Value = m.Birthday.Value;

            numHowMach.Value = (decimal)m.CardStartMoney;
            numRemain.Value = (decimal)m.CardRestMoney;
            dataBgn.Value = m.RegistDate;
            dataEnd.Value = m.ExpireDate;
            tbTips.Text = m.Remarks;
            numTempTimes.Value = m.TempTimes;
            m.Birthday = dateBirthday.Value;
            m.Email = tbEmail.Text.Trim() == "" ? "无" : tbEmail.Text.Trim();
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

        private void frmAddNewVip_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
            
            if (Global.isConnectHf)
                crInstance.disconnet(crInstance.icdev);
        }

        private void frmAddNewVip_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }
    }
}
