using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLPayment;
using UI.BLLGoods;

namespace UI.Financial
{
    public partial class frmPaymentMgr : Form
    {
        WSPayment ws;
        BLLPayment.Payment[] paymentInfo;
        BLLGoods.Goods[] goodsInfo;
        public frmPaymentMgr()
        {
            ws = new WSPayment();
            InitializeComponent();
            dataPaymentInfo.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
        }

        private void frmPaymentMgr_Load(object sender, EventArgs e)
        {
            WSGoods wsg = new WSGoods();
            int a = 1, b;
            goodsInfo = wsg.Search(new BLLGoods.Goods() { Id = -1, Name = "" }, ref a, 100000, out b);
            List<UI.BLLGoods.Goods> pros = new List<BLLGoods.Goods>();
            pros.AddRange(goodsInfo);
            pros.Insert(0, new BLLGoods.Goods() { Id = -1, Name = "无" });
            cbPro.DataSource = pros;
            cbPro.DisplayMember = "Name";
            cbPro.ValueMember = "Id";
        }

        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {

            int total;
            paymentInfo = ws.Search(new Payment()
            {
                GoodsId = Convert.ToInt32(cbPro.SelectedValue),
            }, dataBgn.Value, dataEnd.Value, ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dataPaymentInfo.DataSource = paymentInfo;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Untils.ExportDataGridToCSV(dataPaymentInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ws.Dispose();
            ws = null;
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataPaymentInfo.SelectedRows != null && dataPaymentInfo.SelectedRows.Count > 0)
            {
                string id = dataPaymentInfo.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show(string.Format("确定要永久删除编号{0}付款单的信息吗？", id), "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
                MessageBox.Show(ws.Delete(Convert.ToInt32(id)));
                
                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的付款单");
            }
        }

        private void dataPaymentInfo_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            Payment c = paymentInfo[e.RowIndex];
            if (e.ColumnIndex == 2)
            {
                int i = 0;
                for (; i < goodsInfo.Length; i++)
                {
                    if (goodsInfo[i].Id == c.GoodsId)
                    {
                        e.Value = goodsInfo[i].Name;
                        break;
                    }
                }
                if (i == goodsInfo.Length) e.Value = "无";
            }
        }

        private void frmPaymentMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmPaymentMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));

        }
    }
}
