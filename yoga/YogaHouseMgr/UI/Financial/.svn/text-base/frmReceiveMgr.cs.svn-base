using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLCollect;
using UI.BLLGoods;

namespace UI.Financial
{
    public partial class frmReceiveMgr : Form
    {
        WSCollect ws;
        BLLCollect.Collect[] collectInfo;
        BLLGoods.Goods[] goodsInfo;
        public frmReceiveMgr()
        {
            ws = new WSCollect();
            InitializeComponent(); dataCollectInfo.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
        }


        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {
            int total;
            collectInfo = ws.Search(new Collect()
            {
                GoodsId = Convert.ToInt32(cbPro.SelectedValue),
            }, dataBgn.Value, dataEnd.Value, ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dataCollectInfo.DataSource = collectInfo;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Untils.ExportDataGridToCSV(dataCollectInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ws.Dispose();
            ws = null;
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ws.Update(new Collect()
            {
                GoodsId = Convert.ToInt32(cbPro.SelectedValue)
            }));
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataCollectInfo.SelectedRows != null && dataCollectInfo.SelectedRows.Count > 0)
            {
                string id = dataCollectInfo.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show(string.Format("确定要永久删除编号{0}收款单的信息吗？", id), "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
                MessageBox.Show(ws.Delete(Convert.ToInt32(id)));

                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的收款单");
            }
        }

        private void frmReceiveMgr_Load(object sender, EventArgs e)
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

        private void dataCollectInfo_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            Collect c = collectInfo[e.RowIndex];
            if (e.ColumnIndex == 1)
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

        private void frmReceiveMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));

        }

        private void frmReceiveMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));

        }
    }
}
