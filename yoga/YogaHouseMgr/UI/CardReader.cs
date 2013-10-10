using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public class ReaderEventArgs : EventArgs
    {
        public int id { get; set; }
    }

    class CardReader
    {
        private bool starting { get; set; }
        public void startRead()
        {
            if (starting) return;
            starting = true;
            if (t == null)
                t = new System.Windows.Forms.Timer();
            t.Start();
            HF_READ();
        }

        public void pauseRead()
        {
            if (!starting) return;
            starting = false;
            if (t == null)
                t = new System.Windows.Forms.Timer();
            t.Stop();
            if (Global.isConnectHf)
                disconnet(icdev);
        }

        public delegate void ReaderEventHandler(object sender, ReaderEventArgs e);
        public event ReaderEventHandler OnReadFini;

        System.Windows.Forms.Timer t;
        public int icdev;
        public int connect(Int16 port, int baud)
        {
            icdev = common.rf_init(port, baud);
            Global.isConnectHf = icdev > 0 ? true : false;
            return icdev;
        }

        public int disconnet(int icdev)
        {
            Int16 st = common.rf_exit(icdev);
            Global.isConnectHf = st == 0 ? false : true;
            return st;
        }

        public int seek(int icdev)
        {
            Int16 st;
            UInt16 tagtype = 0;
            byte size = 0;
            uint snr = 0;

            card.rf_reset(icdev, 3);
            st = card.rf_request(icdev, 1, out tagtype);
            if (st != 0)
                return -1;

            st = card.rf_anticoll(icdev, 0, out snr);
            if (st != 0)
                return -2;

            st = card.rf_select(icdev, snr, out size);
            if (st != 0)
                return -3;

            return 0;
        }

        public int auth(int icdev, int sec)
        {
            Int16 st;
            byte[] key1 = new byte[17];
            byte[] key2 = new byte[7];
            int i = 0;
            string skey = "ffffffffffff";
            int keylen = skey.Length;
            if (keylen != 12)
                return -1;

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
                return -2;

            key1 = Encoding.ASCII.GetBytes(skey);
            common.a_hex(key1, key2, 12);
            st = common.rf_load_key(icdev, 0, sec, key2);
            if (st != 0)
                return -3;

            st = card.rf_authentication(icdev, 0, sec);
            if (st != 0)
                return 1;
            else
                return 0;
        }
        public int read(int icdev, int sec)
        {
            int i = 0;
            byte[] data = new byte[16];

            for (i = 0; i < 16; i++)
                data[i] = 0;

            if (card.rf_read(icdev, sec * 4 + 1, data) == 0)
            {
                common.rf_beep(icdev, 5);
                return BitConverter.ToInt32(convert(data), 0);
            }
            else
                return -1;
        }

        public Int16 write(int icdev, int sec, int data)
        {
            int i = 0;
            byte[] databuff = new byte[16];
            for (i = 0; i < 16; i++)
                databuff[i] = 0;

            databuff = convert(BitConverter.GetBytes(data));
            return card.rf_write(icdev, sec * 4 + 1, databuff);
        }

        private byte[] convert(byte[] src)
        {
            int l = src.Length;
            int i = 0;
            if (l == 4)
            {
                byte[] data = new byte[16];
                for (i = 0; i < 16; ++i)
                {
                    if (i < 4)
                        data[i] = src[i];
                    else
                        data[i] = Convert.ToByte(0);
                }
                return data;
            }
            else if (l == 16)
            {
                byte[] data = new byte[4];
                for (i = 0; i < 4; ++i)
                    data[i] = src[i];
                return data;
            }
            return src;
        }

        public void HF_READ()
        {
            if (!starting) return;
            if (Global.isConnectHf)
            {
                disconnet(icdev);
                if (t != null)
                    t.Stop();
            }
            icdev = connect(0, 9600);
            if (icdev <= 0)
            {
                //MessageBox.Show("can not connect!");
                return;
            }
            if (t == null)
                t = new System.Windows.Forms.Timer();
            t.Tick += (s, e) =>
            {
                if (seek(icdev) != 0)
                    return;
                if (auth(icdev, 1) != 0)
                    return;
                int data = read(icdev, 1);
                ReaderEventArgs r = new ReaderEventArgs();
                r.id = data;
                if (OnReadFini != null) OnReadFini(this, r);
                Console.WriteLine(data.ToString());

            };
            t.Interval = 1000;
            t.Enabled = true;
            t.Start();
        }

        public void HF_WRITE(int sec, int data)
        {
            if (Global.isConnectHf)
                disconnet(icdev);
            icdev = connect(0, 9600);
            if (icdev <= 0)
            {
                MessageBox.Show("打开串口失败！");
                return;
            }

            if (seek(icdev) != 0)
            {
                return;
            }
            if (auth(icdev, 1) != 0)
            {
                return;
            }
            if (write(icdev, 1, data) != 0)
                MessageBox.Show("写卡失败！");
            else
                MessageBox.Show("写卡成功！");
        }
    }
}
