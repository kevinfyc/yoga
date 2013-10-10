using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.BLLIni;

namespace UI
{
    public partial class frmRegister : Form
    {
        static WSIni ini;
        public frmRegister()
        {
            InitializeComponent();
            ini = new WSIni();
        }

        private void btnRigiter_Click(object sender, EventArgs e)
        {
            UI.Tools.License l = new Tools.License();

            try
            {
                int[] p = l.decode(tbRegiter.Text.ToString());

                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
            catch
            {
                MessageBox.Show("注册码无效");
                return;
            }
        }
    }
}
