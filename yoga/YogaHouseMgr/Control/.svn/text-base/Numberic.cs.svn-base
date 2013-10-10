using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public partial class Numberic : UserControl
    {
        public decimal DefaultValue{get;set;}
        private uint maxLength;
        public uint MaxLength 
        {
            get
            {
                return maxLength;
            }
            set
            {
                maxLength = value;
                if (txtValue.Text.Length > value)
                    txtValue.Text = txtValue.Text.Substring(0, (int)value);
            }
        }

        public decimal Value 
        {
            get
            {
                return Convert.ToDecimal(txtValue.Text.Trim());
            }
            set
            {
                txtValue.Text = value.ToString();
            }
        }

        public Numberic()
        {
            InitializeComponent();
            txtValue.Text = "0";
            txtValue.TextChanged += (s, e) =>
                {
                    txtValue.Text = FilterNumberString(txtValue.Text);
                };
        }
        string FilterNumberString(string target)
        {
            string txt = "";
            foreach (char charactor in target)
            {
                if (char.IsNumber(charactor)) txt += charactor;
            }
            if (string.IsNullOrEmpty(txt.Trim())) txt = DefaultValue.ToString();
            return txt;
        }

        private void Numberic_Load(object sender, EventArgs e)
        {
            txtValue.Text = Value.ToString();
        }
    }
}
