﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using UI.BLLImport;
using System.Runtime.InteropServices;

namespace UI
{

    public partial class frmYogaHouseMgr : Form
    {

        [DllImport("user32.dll")]
        static extern bool LockWindowUpdate(IntPtr hWndLock);

        private static frmYogaHouseMgr _MainForm;

        public static frmYogaHouseMgr MainForm
        {
            get
            {
                return _MainForm;
            }
        }

        public void setCurActiveFrmText(string c)
        {
            this.curActiveFrm.Text = c;
        }


        WSImport wsi;
        public frmYogaHouseMgr()
        {
            InitializeComponent();
            _MainForm = this;
            this.tssl.Text = string.Format("当前登录账户:{0}",Global.CurrentUser.Name.ToString());
            wsi = new WSImport();
        }

        // 教练部分
        private void 教练分配AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Coach.frmCoachAllot));
        }

        private void 教练管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Coach.frmCoachMgr));
        }

        private void 教练登录SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Coach.frmCoachSignIn));
        }

        private void 私教课程管理CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Coach.frmPersonalCoachCourseMgr));
        }

        private void 私教信息管理IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Coach.frmPersonalCoachInfoMgr));
        }

        public void ShowChildForm(Type frmType)
        {
            Form target = null;

            foreach (var child in this.MdiChildren)
            {
                if (child.GetType() != frmType) continue;
                target = child;
                break;
            }
            if (target == null)
            {
                target = Assembly.GetAssembly(frmType).CreateInstance(frmType.FullName) as Form;
                target.MdiParent = this;
                target.Show();
            }
            else
            {
                target.BringToFront();
            }
        }

        private void frmYogaHouseMgr_Load(object sender, EventArgs e)
        {
            this.前台FToolStripMenuItem.Visible = false;
            this.教练CToolStripMenuItem.Visible = false;
            this.会籍JToolStripMenuItem.Visible = false;
            this.toolStripMenuItem4.Visible = false;
            this.其他OToolStripMenuItem.Visible = false;

            /*
             * 0，管理员
             * 1，前台
             * 2，会籍
             * 3，财务
             */
            string userType = Global.CurrentUser.UserType;
            switch (userType)
            {
                case "0":
                    this.前台FToolStripMenuItem.Visible = true;
                    this.教练CToolStripMenuItem.Visible = true;
                    this.会籍JToolStripMenuItem.Visible = true;
                    this.toolStripMenuItem4.Visible = true;
                    this.其他OToolStripMenuItem.Visible = true;
                    this.一键清场JToolStripMenuItem.Visible = true;
                    this.statueUserType.Text = "  账户类型：管理员  ";
                    break;
                case "1":
                    this.前台FToolStripMenuItem.Visible = true;
                    this.教练CToolStripMenuItem.Visible = true;

                    this.教练分配AToolStripMenuItem.Visible = true;
                    this.toolStripMenuItem1.Visible = false;
                    this.教练管理MToolStripMenuItem.Visible = false;

                    this.会籍JToolStripMenuItem.Visible = false;
                    this.toolStripMenuItem4.Visible = false;
                    this.其他OToolStripMenuItem.Visible = false;
                    this.一键清场JToolStripMenuItem.Visible = true;
                    this.statueUserType.Text = "  账户类型：前台  ";

                    break;
                case "2":
                    this.前台FToolStripMenuItem.Visible = true;

                    this.toolStripMenuItem7.Visible = false;
                    this.toolStripMenuItem9.Visible = false;
                    this.toolStripMenuItem12.Visible = false;
                    this.toolStripMenuItem8.Visible = false;
                    this.toolStripMenuItem13.Visible = false;
                    this.toolStripMenuItem6.Visible = false;
                    this.toolStripMenuItem10.Visible = false;
                    this.toolStripSeparator1.Visible = false;
                    this.积分查询ToolStripMenuItem.Visible = false;
                    this.积分获取GToolStripMenuItem.Visible = false;
                    this.积分消费SToolStripMenuItem.Visible = false;
                    this.柜子管理RToolStripMenuItem.Visible = false;
                    this.会员进场EToolStripMenuItem.Visible = false;
                    this.会员进场管理OToolStripMenuItem.Visible = false;

                    this.教练CToolStripMenuItem.Visible = false;
                    this.会籍JToolStripMenuItem.Visible = true;

                    this.转正GToolStripMenuItem.Visible = false;
                    this.跟踪TToolStripMenuItem.Visible = false;
                    this.顾问管理AToolStripMenuItem.Visible = false;
                    this.toolStripMenuItem11.Visible = true;
                    this.管理MToolStripMenuItem.Visible = true;

                    this.toolStripMenuItem4.Visible = false;
                    this.其他OToolStripMenuItem.Visible = false;
                    this.一键清场JToolStripMenuItem.Visible = false;

                    this.statueUserType.Text = "  账户类型：会籍  ";
                    break;
                case "3":
                    this.前台FToolStripMenuItem.Visible = true;
                    
                    this.toolStripMenuItem7.Visible = false;
                    this.toolStripMenuItem9.Visible = false;
                    this.toolStripMenuItem12.Visible = false;
                    this.toolStripMenuItem8.Visible = false;
                    this.toolStripMenuItem13.Visible = false;
                    this.toolStripMenuItem6.Visible = false;
                    this.toolStripMenuItem10.Visible = false;
                    this.toolStripSeparator1.Visible = false;
                    this.积分查询ToolStripMenuItem.Visible = false;
                    this.积分获取GToolStripMenuItem.Visible = false;
                    this.积分消费SToolStripMenuItem.Visible = false;
                    this.柜子管理RToolStripMenuItem.Visible = false;
                    this.会员进场EToolStripMenuItem.Visible = false;
                    this.会员进场管理OToolStripMenuItem.Visible = false;

                    this.教练CToolStripMenuItem.Visible = false;
                    this.会籍JToolStripMenuItem.Visible = true;

                    
                    this.转正GToolStripMenuItem.Visible = true;
                    this.跟踪TToolStripMenuItem.Visible = false;
                    this.顾问管理AToolStripMenuItem.Visible = false;
                    this.toolStripMenuItem11.Visible = false;
                    this.管理MToolStripMenuItem.Visible = false;

                    this.toolStripMenuItem4.Visible = true;
                    this.其他OToolStripMenuItem.Visible = true;

                    this.添加会员AToolStripMenuItem.Visible = true;
                    this.账户管理UToolStripMenuItem.Visible = false;
                    this.一键清场JToolStripMenuItem.Visible = false;

                    this.statueUserType.Text = "  账户类型：会计  ";

                    break;
            }
        }

        private void 添加新会员AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmAddNewVip));
        }

        private void 转正GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Potential.frmPotentialCustomersToVip));
        }

        private void 管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Potential.frmPotentialCustomersInfoMgr));
        }

        private void 商品管理GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Goods.frmGoodsMgr));
        }

        private void 跟踪TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Potential.frmPotentialCustomersTrackeInfo));
        }

        private void 收款单CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Financial.frmeRceiveInfo));
        }

        private void 付款单PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Financial.frmPaymentInfo));
        }

        private void 收款单管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Financial.frmReceiveMgr));
        }

        private void 付款单管理TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Financial.frmPaymentMgr));
        }

        private void 会员资料管理MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmVipInfoMgr));
        }

        private void 积分查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Intergral.frmIntegralQuery));
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmVipQuery));
        }

        private void 积分获取GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Intergral.frmIntegralGain));
        }

        private void 积分消费SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Intergral.frmIntegralConsumption));
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmVipConsumption));
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmVipPrepaid));
        }

        private void 柜子管理RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Rack.frmRackMgr));
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Potential.frmPotentialCustomersPickInfo));
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmVipPrepaidMgr));
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmVipConsumptionMgr));
        }

        private void 会员进场EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmVipEnter));
        }

        private void 会员进场管理OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmVipEnterInfoMgr));
        }

        private void 添加会员AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Vip.frmAddNewVip));
        }

        private void 账户管理UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(frmUserMgr));
        }

        private void 顾问管理AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(typeof(Adviser.frmAdviserMgr));
        }

        private void 一键清场JToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wsi.Clear().ToString());
        }

        private void frmYogaHouseMgr_ResizeBegin(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
        }

        private void frmYogaHouseMgr_ResizeEnd(object sender, EventArgs e)
        {
            LockWindowUpdate(IntPtr.Zero);
        }
    }
}
