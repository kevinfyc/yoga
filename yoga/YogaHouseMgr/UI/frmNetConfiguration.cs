using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UI
{
    public partial class frmNetConfiguration : Form
    {
        public frmNetConfiguration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = tbIp.Text + ":" + tbPort.Text + "/";
            SetValue("server", url, 1);
            SetValue("UI_BLLCoach_WSCoach", url + "WSCoach.asmx", 2);
            SetValue("UI_BLLMember_WSMemeber", url + "WSMemeber.asmx", 2);
            SetValue("UI_BLLAdviser_WSAdviser", url + "WSAdviser.asmx", 2);
            SetValue("UI_BLLPotentialMember_WSPotentialMember", url + "WSPotentialMember.asmx", 2);
            SetValue("UI_BLLGoods_WSGoods", url + "WSGoods.asmx", 2);
            SetValue("UI_BLLPayment_WSPayment", url + "WSPayment.asmx", 2);
            SetValue("UI_BLLCollect_WSCollect", url + "WSCollect.asmx", 2);
            SetValue("UI_BLLUser_WSUser", url + "WSUser.asmx", 2);
            SetValue("UI_BLLPrepaid_WSPrepaid", url + "WSPrepaid.asmx", 2);
            SetValue("UI_BLLConsumption_WSConsumption", url + "WSConsumption.asmx", 2);
            SetValue("UI_BLLRack_WSRack", url + "WSRack.asmx", 2);
            SetValue("UI_BLLImport_WSImport", url + "WSImport.asmx", 2);
            SetValue("YogaHouseMgr_BLLIni_WSIni", url + "WSIni.asmx", 2);
            MessageBox.Show("配置成功，请重新启动软件");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //读取Value值 
        public static string GetConfigString(string key)
        {
            // 
            // TODO: 在此处添加构造函数逻辑 
            // 
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

        //写操作 
        public static void SetValue(string AppKey, string AppValue, int opt)
        {
            XmlDocument xDoc = new XmlDocument();
            //获取可执行文件的路径和名称 
            xDoc.Load(System.Windows.Forms.Application.ExecutablePath + ".config");
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            switch (opt)
            {
                case 1:
                    xNode = xDoc.SelectSingleNode("//appSettings");
                    xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");
                    if (xElem1 != null) xElem1.SetAttribute("value", AppValue);
                    else
                    {
                        xElem2 = xDoc.CreateElement("add");
                        xElem2.SetAttribute("key", AppKey);
                        xElem2.SetAttribute("value", AppValue);
                        xNode.AppendChild(xElem2);
                    }
                    break;
                case 2:
                    xNode = xDoc.SelectSingleNode("//applicationSettings");
                    xElem1 = (XmlElement)xNode.SelectSingleNode("//UI.Properties.Settings").SelectSingleNode("//setting[@name='"+AppKey+"']");//.SelectSingleNode("//value");
                    xElem1["value"].InnerText = AppValue;
                    break;
            }

            xDoc.Save(System.Windows.Forms.Application.ExecutablePath + ".config");
        }
    }
}
