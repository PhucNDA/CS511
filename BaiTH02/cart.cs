using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH02
{
    public partial class cart : Form
    {
        public cart()
        {
            InitializeComponent();
        }

        private void cart_exit_picbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static System.Data.DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }
            return dt;
        }
        private void cart_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dt = ConvertCSVtoDataTable("cart.csv");
            foreach (DataRow row in dt.Rows)
            {
                cartitem item = new cartitem(row, cart_totalprice_label);
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.Bisque;
        }

        private void cart_checkout_picbox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.PeachPuff;
        }
    }
}
