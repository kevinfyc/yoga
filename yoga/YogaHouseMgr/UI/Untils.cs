using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using UI.BLLUser;
using System.IO;
using System.Configuration;
namespace UI
{
    public class Global
    {
        public static User CurrentUser;
        public static bool isConnectHf = false;
        public static string ServerBaseUrl= ConfigurationManager.AppSettings["server"];
    }

    public class Untils
    {
        public static string FilterNumberString(string target)
        {
            string txt = "";
            foreach (char charactor in target)
            {
                if (char.IsNumber(charactor)) txt += charactor;
            }
            if (string.IsNullOrEmpty(txt.Trim())) txt = "0";
            return txt;
        }

        /// <summary>
        /// Export the data from datatable to CSV file
        /// </summary>
        /// <param name="grid"></param>
        public static void ExportDataGridToCSV(DataGridView dgv)
        {
            string path = "";

            //File info initialization
            path = path + DateTime.Now.ToString("yyyyMMddhhmmss");
            path = path + ".csv";

            System.IO.FileStream fs = new FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, new System.Text.UnicodeEncoding());
            //Tabel header
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sw.Write(dgv.Columns[i].HeaderText);
                sw.Write("\t");
            }
            sw.WriteLine("");
            //Table body

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                {
                    sw.Write(DelQuota(dgv[j,i].Value.ToString()));
                    sw.Write("\t");
                }
                sw.WriteLine("");
            }
            sw.Flush();
            sw.Close();

        }



        /// <summary>
        /// Delete special symbol
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DelQuota(string str)
        {
            string result = str;
            string[] strQuota = { "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "`", ";", "'", ",", ".", "/", ":", "/,", "<", ">", "?" };
            for (int i = 0; i < strQuota.Length; i++)
            {
                if (result.IndexOf(strQuota[i]) > -1)
                    result = result.Replace(strQuota[i], "");
            }
            return result;
        }
    }
}
