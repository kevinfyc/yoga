using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class frmRfTest : Form
    {
        public frmRfTest()
        {
            InitializeComponent();
            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
            comboPort.Items.Add("COM1");
            comboPort.Items.Add("COM2");
            comboPort.Items.Add("COM3");
            comboPort.Items.Add("COM4");
            comboBaud.Items.Add("9600");
            comboBaud.Items.Add("19200");
            comboBaud.Items.Add("38400");
            comboBaud.Items.Add("57600");
            comboBaud.Items.Add("115200");
            comboPort.SelectedIndex = 0;
            comboBaud.SelectedIndex = 4;

            textSec.Text = "1";
            textKey.Text = "ffffffffffff";
            textData.Text = "00112233445566778899aabbccddeeff";
            textValue.Text = "10000";
        }
        public int icdev; // 通讯设备标识符
        public Int16 st;
        public int sec;
        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            st = 0;
            byte[] ver = new byte[30];
            int[] baudarray = new int[5];
            baudarray[0] = 9600;
            baudarray[1] = 19200;
            baudarray[2] = 38400;
            baudarray[3] = 57600;
            baudarray[4] = 115200;

            st = common.lib_ver(ver);
            string sver = System.Text.Encoding.ASCII.GetString(ver);
            lbSoftVer.Text = sver;

            Int16 port = 0;
            int baud = 9600;
            port = (Int16)comboPort.SelectedIndex;
            int nitem = comboBaud.SelectedIndex;
            baud = baudarray[nitem];
            icdev = common.rf_init(port, baud);
            if (icdev > 0)
            {
                lbResult.Text = "打开串口成功！";
                byte[] status = new byte[30];
                st = common.rf_get_status(icdev, status);
                lbHardVer.Text = System.Text.Encoding.ASCII.GetString(status);
                common.rf_beep(icdev, 5);
            }
            else
                lbResult.Text = "打开串口失败！";
        }

        private void btnDisconnect_Click(object sender, System.EventArgs e)
        {
            st = common.rf_exit(icdev);
            if (st == 0)
                lbResult.Text = "断开连接成功！";
            else
                lbResult.Text = "断开连接失败！";
        }

        private void btnBeep_Click(object sender, System.EventArgs e)
        {
            st = common.rf_beep(icdev, 10);
            if (st == 0)
                lbResult.Text = "蜂鸣成功！";
            else
                lbResult.Text = "蜂鸣失败！";
        }

        private void btnSeekCard_Click(object sender, System.EventArgs e)
        {
            UInt16 tagtype = 0;
            byte size = 0;
            uint snr = 0;

            mifareone.rf_reset(icdev, 3);
            st = mifareone.rf_request(icdev, 1, out tagtype);
            if (st != 0)
            {
                lbResult.Text = "request error!";
                return;
            }

            st = mifareone.rf_anticoll(icdev, 0, out snr);
            if (st != 0)
            {
                lbResult.Text = "anticoll error!";
                return;
            }
            string snrstr = "";
            snrstr = snr.ToString("X");
            lbSnr.Text = snrstr;

            st = mifareone.rf_select(icdev, snr, out size);
            if (st != 0)
            {
                lbResult.Text = "select error!";
                return;
            }
            lbResult.Text = "寻卡成功！";
        }

        private void btnAuth_Click(object sender, System.EventArgs e)
        {
            byte[] key1 = new byte[17];
            byte[] key2 = new byte[7];
            int i = 0;
            string skey = textKey.Text;
            int keylen = textKey.TextLength;
            if (keylen != 12)
            {
                lbResult.Text = "请正确输入密码，密码长度不对！";
                return;
            }
            if (textSec.TextLength < 1)
            {
                lbResult.Text = "请输入扇区号！";
                return;
            }

            sec = Convert.ToInt32(textSec.Text, 10);
            if (sec < 1 || sec > 15)
            {
                lbResult.Text = "扇区号不正确！";
                return;
            }

            for (i = 0; i < keylen; i++)
            {
                if (skey[i] >= '0' && skey[i] <= '9')
                    continue;
                if (skey[i] <= 'a' && skey[i] <= 'f')
                    continue;
                if (skey[i] <= 'A' && skey[i] <= 'F')
                    continue;
            }
            if (i != keylen)
            {
                lbResult.Text = "密码必须为十六进制数！";
                return;

            }
            key1 = Encoding.ASCII.GetBytes(skey);
            common.a_hex(key1, key2, 12);
            st = common.rf_load_key(icdev, 0, sec, key2);
            if (st != 0)
            {
                lbResult.Text = "装载密码失败！";
                return;
            }
            st = mifareone.rf_authentication(icdev, 0, sec);
            if (st != 0)
                lbResult.Text = "认证失败！";
            else
                lbResult.Text = "认证成功！";
        }

        private void btnReadData_Click(object sender, System.EventArgs e)
        {
            int i = 0;
            byte[] data = new byte[16];
            byte[] buff = new byte[32];

            for (i = 0; i < 16; i++)
                data[i] = 0;
            for (i = 0; i < 32; i++)
                buff[i] = 0;
            st = mifareone.rf_read(icdev, sec * 4 + 1, data);
            if (st == 0)
            {
                common.hex_a(data, buff, 16);
                textData.Text = System.Text.Encoding.ASCII.GetString(buff);
                lbResult.Text = "读数据成功！";
            }
            else
                lbResult.Text = "读数据失败！";
        }

        private void btnWriteData_Click(object sender, System.EventArgs e)
        {
            int i = 0;
            byte[] databuff = new byte[16];
            byte[] buff = new byte[32];

            if (textData.TextLength < 32)
            {
                lbResult.Text = "请正确输入数据，数据长度不对！";
                return;
            }
            string data = textData.Text;
            for (i = 0; i < data.Length; i++)
            {
                if (data[i] >= '0' && data[i] <= '9')
                    continue;
                if (data[i] <= 'a' && data[i] <= 'f')
                    continue;
                if (data[i] <= 'A' && data[i] <= 'F')
                    continue;
            }
            if (i != data.Length)
            {
                lbResult.Text = "数据必须为十六进制数！";
                return;

            }

            buff = Encoding.ASCII.GetBytes(data);
            common.a_hex(buff, databuff, 32);
            st = mifareone.rf_write(icdev, sec * 4 + 1, databuff);
            if (st == 0)
                lbResult.Text = "写数据成功！";
            else
                lbResult.Text = "写数据失败！";
        }

        private void btnValueOp_Click(object sender, System.EventArgs e)
        {
            uint cvalue = 0;
            uint val = 0;
            int i = 0;


            if (textValue.TextLength < 1)
            {
                lbResult.Text = "请输入值！";
                return;
            }

            cvalue = Convert.ToUInt32(textValue.Text, 10);
            if (cvalue < 1 || cvalue > 4294966000)
            {
                lbResult.Text = "输入的值不正确！";
                return;
            }

            st = mifareone.rf_initval(icdev, sec * 4 + 2, cvalue);
            if (st != 0)
            {
                lbResult.Text = "初始化值操作失败！";
                return;
            }
            st = mifareone.rf_increment(icdev, sec * 4 + 2, 1000);
            if (st != 0)
            {
                lbResult.Text = "加值操作失败！";
                return;
            }
            st = mifareone.rf_decrement(icdev, sec * 4 + 2, 100);
            if (st != 0)
            {
                lbResult.Text = "减值操作失败！";
                return;
            }
            st = mifareone.rf_readval(icdev, sec * 4 + 2, out val);
            if (st != 0)
            {
                lbResult.Text = "读当前值操作失败！";
                return;
            }
            textValue.Text = val.ToString();
            lbResult.Text = "值操作成功！";
        }
    }
}
