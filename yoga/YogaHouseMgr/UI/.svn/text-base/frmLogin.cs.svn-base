using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLUser;
using UI.BLLIni;

namespace UI
{
    public partial class frmLogin : Form
    {
        WSUser wsu;
        WSIni ini;
        UI.Tools.License l;
        public frmLogin()
        {
            InitializeComponent();
            wsu = new WSUser();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int len = tbUserName.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("用户名长度为1-20");
                return;
            }
            len = tbPassword.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("密码长度为1-20");
                return;
            }
            if (!register_()) return;
            Global.CurrentUser = wsu.Login(tbUserName.Text.Trim(), tbPassword.Text.Trim());
            if (Global.CurrentUser == null)
            {
                MessageBox.Show("用户名与密码不匹配");
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnopt_Click(object sender, EventArgs e)
        {
            frmNetConfiguration frm = new frmNetConfiguration();
            frm.ShowDialog();
        }

        bool register_()
        {
            ini = new WSIni();
            l = new UI.Tools.License();
            if (ini.serverHasIni())
            {
                string isFirst = ini.IniReadValue("Path", "port");
                if (Convert.ToBoolean(isFirst))
                {
                    MessageBox.Show("请注册");
                    if (!registerFunc()) return false;
                }
                else
                {
                    string d = ini.IniReadValue("Path", "ip");
                    if (Convert.ToInt32(d) < 0)
                    {
                        MessageBox.Show("配置文件不正确，请不要手动修改！");
                        return false;
                    }
                    string t = ini.IniReadValue("Path", "server");
                    int[] p = l.decode(l.base64Decode(t));
                    int days = p[0] * 365 + p[1] * 30 + p[2];
                    if (!check(days, ini.getServerPath()))
                    {
                        MessageBox.Show("已过期！请重新注册");
                        if (!registerFunc()) return false;
                        return false;
                    }
                    else
                        ini.IniWriteValue("Path", "ip", "0");
                }
            }
            else
            {
                MessageBox.Show("缺少配置文件，无法启动！");
                return false;
            }
            return true;
        }

        bool registerFunc()
        {
            frmRegister frmR = new frmRegister();
            frmR.ShowDialog();
            if (frmR.DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("注册成功，请登录！");
                string rt = frmR.tbRegiter.Text.ToString();
                ini.IniWriteValue("Path", "server", l.base64Encode(rt));
            }
            else
            {
                MessageBox.Show("注册码无效！");
                return false;
            }
            int y = ini.getServerTime().Year;
            int m = ini.getServerTime().Month;
            int d = ini.getServerTime().Day;
            string v = string.Format("{0:00}{1:00}{2:00}", m, y - 2000, d);
            ini.IniWriteValue("Path", "client", l.base64Encode(v));
            ini.IniWriteValue("Path", "port", "false");
            return true;
        }

        bool check(int days, string cp)
        {
            string t = l.base64Decode(ini.IniReadValue("Path", "Client"));
            int y = Convert.ToInt32(string.Format("{0}{1}", t[2], t[3]));
            int m = Convert.ToInt32(string.Format("{0}{1}", t[0], t[1]));
            int d = Convert.ToInt32(string.Format("{0}{1}", t[4], t[5]));
            DateTime dt1 = Convert.ToDateTime(string.Format("20{0}-{1}-{2}",
                string.Format("{0:00}", y),
                string.Format("{0:00}", m),
                string.Format("{0:00}", d)));
            DateTime dt2 = ini.getServerTime();
            dt2 = dt2.AddHours(-dt2.Hour);
            dt2 = dt2.AddMinutes(-dt2.Minute);
            dt2 = dt2.AddSeconds(-dt2.Second);
            TimeSpan span = dt2.Subtract(dt1);
            int dayDiff = span.Days;
            if (dayDiff < 0)
            {
                ini.IniWriteValue("Path", "ip", dayDiff.ToString());
                return false;
            }
            return dayDiff < days ? true : false;
        }
    }
}
