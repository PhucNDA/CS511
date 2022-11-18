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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        public void init()
        {
            System.Data.DataTable dt = ConvertCSVtoDataTable("rst.csv");
            foreach (DataRow row in dt.Rows)
            {
                Order item = new Order(row);
                home_flowpanel.Controls.Add(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            
        }

        private void home_exit_picbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void home_flowpanel_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Firebrick;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_home_picbox_MouseEnter(object sender, EventArgs e)
        {
        }

        private void home_home_label_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.Font = new System.Drawing.Font("VNI-Present", 24, System.Drawing.FontStyle.Underline);
        }

        private void home_home_label_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.Font = new System.Drawing.Font("VNI-Present", 24);
        }

        private void home_home_label_Click(object sender, EventArgs e)
        {
            home_flowpanel.Controls.Clear();
            init();
        }

        private void home_search_label_Click(object sender, EventArgs e)
        {
            Search se = new Search(ref home_flowpanel);
            se.Show();

        }

        private void home_cart_label_Click(object sender, EventArgs e)
        {
            cart ct = new cart();
            ct.Show();
        }
    }
}
