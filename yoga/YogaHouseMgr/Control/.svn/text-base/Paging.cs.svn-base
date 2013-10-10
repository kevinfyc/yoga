using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public partial class Paging : UserControl
    {
        public delegate void PagingEventHandler(object sender, PagingEventArgs e);

        public event PagingEventHandler OnFirstPage;
        public event PagingEventHandler OnLastPage;
        public event PagingEventHandler OnPageUp;
        public event PagingEventHandler OnPageDown;
        public event PagingEventHandler OnReload;
        public event PagingEventHandler OnJumpToPage;

        public int CurrentPage 
        {
            get { return System.Convert.ToInt32(tstxtPage.Text); }
            set
            {
                tstxtPage.Text = value.ToString();
            }
        }
        public int TotalPages 
        { 
            set
            {
                tslblTotalPages.Text = value.ToString();
            }
        }
        public Paging()
        {
            InitializeComponent();
        }

        private void tsbtn_Click(object sender, EventArgs e)
        {
            ToolStripItem btn = sender as ToolStripItem;
            if (btn == null) return;
            PagingEventArgs pe = new PagingEventArgs();
            pe.CurrentPage = this.CurrentPage;
            switch (btn.Name)
            {
                case "tsbtnFirstPage":
                    pe.JumpToPage = 1;
                    if (OnFirstPage != null) OnFirstPage(this, pe);
                    break;
                case "tsbtnPageUp":
                    pe.JumpToPage = CurrentPage - 1;
                    if (OnPageUp != null) OnPageUp(this, pe);
                    break;
                case "tsbtnPageDown":
                    pe.JumpToPage = CurrentPage + 1;
                    if (OnPageDown != null) OnPageDown(this, pe);
                    break;
                case "tsbtnLastPage":
                    pe.JumpToPage = -1;
                    if (OnLastPage != null) OnLastPage(this, pe);
                    break;
                case "tsbtnReload":
                    pe.JumpToPage = CurrentPage;
                    if (OnReload != null) OnReload(this, pe);
                    break;
                default:
                    break;
            }
        }

        private void tstxtPage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tstxtPage_TextChanged(sender, e);
                PagingEventArgs pe = new PagingEventArgs();
                pe.JumpToPage = System.Convert.ToInt32(tstxtPage.Text);
                if (OnJumpToPage!=null) OnJumpToPage(this, pe);
            }
        }

        private void tstxtPage_TextChanged(object sender, EventArgs e)
        {
            string txt = "";
            foreach (char charactor in tstxtPage.Text)
            {
                if (char.IsNumber(charactor)) txt += charactor;
            }
            if (string.IsNullOrEmpty(txt.Trim())) txt = "0";
            if (System.Convert.ToInt32(txt.Trim()) > System.Convert.ToInt32(tslblTotalPages.Text))
                txt = tslblTotalPages.Text;
            tstxtPage.Text = txt;
        }
    }

    public class PagingEventArgs : EventArgs
    {
        public int CurrentPage { get; set; }
        public int JumpToPage { get; set; }
    }
}
