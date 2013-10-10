using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLGoods;

namespace UI.Goods
{
    public partial class frmGoodsMgr : Form
    {
        WSGoods ws;
        public frmGoodsMgr()
        {
            InitializeComponent();
            ws = new WSGoods();
            dataGoodsInfo.AutoGenerateColumns = false;
            paging1.OnFirstPage += ChangePage;
            paging1.OnJumpToPage += ChangePage;
            paging1.OnLastPage += ChangePage;
            paging1.OnPageDown += ChangePage;
            paging1.OnPageUp += ChangePage;
            paging1.OnReload += ChangePage;
        }

        private void frmGoodsMgr_Load(object sender, EventArgs e)
        {
            LoadByPaging(1);

            dataGoodsInfo.CellMouseClick += (ss, ee) =>
            {
                if (dataGoodsInfo.SelectedRows != null && dataGoodsInfo.SelectedRows.Count > 0)
                {
                    tbNo.Text = dataGoodsInfo.SelectedRows[0].Cells[0].Value.ToString();
                    tbName.Text = dataGoodsInfo.SelectedRows[0].Cells[1].Value.ToString();
                    tbPrice.Value = Convert.ToDecimal(dataGoodsInfo.SelectedRows[0].Cells[2].Value);
                    tbRemarks.Text = dataGoodsInfo.SelectedRows[0].Cells[3].Value.ToString();
                }
            };
        }

        void ChangePage(object s, Control.PagingEventArgs e)
        {
            LoadByPaging(e.JumpToPage);
        }
        void LoadByPaging(int page)
        {
            int total;
            BLLGoods.Goods[] coachs = ws.Search(new BLLGoods.Goods()
            {
                Id = Convert.ToInt32(tbNo.Text.Trim()),
                Name = tbName.Text.Trim(),
            }, ref page, 20, out total);
            paging1.TotalPages = total;
            paging1.CurrentPage = page;
            dataGoodsInfo.DataSource = coachs;
        }

        bool ValidateValue()
        {
            int len = tbName.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("姓名长度在1-20之间");
                return false;
            }
            len = tbPrice.Text.Trim().Length;
            if (len < 1 || len > 20)
            {
                MessageBox.Show("价格长度在1-20之间");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateValue()) return;

            int resultId = ws.Add(new BLLGoods.Goods()
            {
                Name = tbName.Text.Trim(),
                Price = (double)tbPrice.Value,
                Remarks = tbRemarks.Text.Trim(),
            });
            if (resultId > 0)
            {
                ClearSearchConditions();
                LoadByPaging(paging1.CurrentPage);
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ws.Update(new BLLGoods.Goods()
            {
                Id = Convert.ToInt32(tbNo.Text.Trim()),
                Name = tbName.Text.Trim(),
                Price = (double)tbPrice.Value,
                Remarks = tbRemarks.Text.Trim(),
            }));
            ClearSearchConditions();
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGoodsInfo.SelectedRows != null && dataGoodsInfo.SelectedRows.Count > 0)
            {
                string id = dataGoodsInfo.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGoodsInfo.SelectedRows[0].Cells[1].Value.ToString();
                if (MessageBox.Show(string.Format("确定要永久删除{0}的信息吗？", name), "警告",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
                MessageBox.Show(ws.Delete(Convert.ToInt32(id)));
                ClearSearchConditions();
                LoadByPaging(paging1.CurrentPage);
            }
            else
            {
                MessageBox.Show("请在列表中选择要删除的项");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadByPaging(paging1.CurrentPage);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Untils.ExportDataGridToCSV(dataGoodsInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ws.Dispose();
            ws = null;
            this.Close();
        }

        void ClearSearchConditions()
        {
            tbNo.Text = "0";
            tbName.Text = "";
            tbPrice.Text = "";
        }

        private void frmGoodsMgr_Activated(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("  {0}  ", this.Text));
        }

        private void frmGoodsMgr_Deactivate(object sender, EventArgs e)
        {
            frmYogaHouseMgr.MainForm.setCurActiveFrmText(string.Format("", this.Text));
        }
    }
}
