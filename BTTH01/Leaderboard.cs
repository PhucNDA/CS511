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

namespace tmp
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ConvertCSVtoDataTable("rst.csv");
        }

        private void leaderboard_btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            home_form f1 = new home_form();
            f1.Show();
        }

        private void leaderboard_btn_back_MouseEnter(object sender, EventArgs e)
        {
            leaderboard_btn_back.BackColor = Color.Bisque;
        }

        private void leaderboard_btn_back_MouseLeave(object sender, EventArgs e)
        {
            leaderboard_btn_back.BackColor = Color.PeachPuff;
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

        private void lead_picbox_fruit_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.BlanchedAlmond;
        }

        private void lead_picbox_fruit_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.AntiqueWhite;
        }

        private void lead_picbox_fruit_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            DataTable dt = new DataTable();
            dt = ConvertCSVtoDataTable("rst.csv");

            DataTable re = dt.Clone();
            re.Columns["totalscore"].DataType = typeof(Int32);
            if (pb.Name == "lead_picbox_fruit")
            {
                foreach (DataRow row in dt.Rows)
                    if (row["topic"].ToString() == "fruits")
                        re.ImportRow(row);
                re.DefaultView.Sort = "totalscore DESC";
                re=re.DefaultView.ToTable();
                label1.Text = re.Rows[0]["username"].ToString();
                label1_w.Text = "W: " + re.Rows[0]["writing"].ToString();
                label1_s.Text = "S: " + re.Rows[0]["speaking"].ToString();
                label2.Text = re.Rows[1]["username"].ToString();
                label2_w.Text = "W: " + re.Rows[1]["writing"].ToString();
                label2_s.Text = "S: " + re.Rows[1]["speaking"].ToString();
                label3.Text = re.Rows[2]["username"].ToString();
                label3_w.Text = "W: " + re.Rows[2]["writing"].ToString();
                label3_s.Text = "S: " + re.Rows[2]["speaking"].ToString();
            }
            else if (pb.Name == "lead_picbox_vehicles")
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["topic"].ToString() == "vehicles")
                        re.ImportRow(row);
                }
                re.DefaultView.Sort = "totalscore DESC";
                re = re.DefaultView.ToTable();
                label1.Text = re.Rows[0]["username"].ToString();
                label1_w.Text = "W: " + re.Rows[0]["writing"].ToString();
                label1_s.Text = "S: " + re.Rows[0]["speaking"].ToString();
                label2.Text = re.Rows[1]["username"].ToString();
                label2_w.Text = "W: " + re.Rows[1]["writing"].ToString();
                label2_s.Text = "S: " + re.Rows[1]["speaking"].ToString();
                label3.Text = re.Rows[2]["username"].ToString();
                label3_w.Text = "W: " + re.Rows[2]["writing"].ToString();
                label3_s.Text = "S: " + re.Rows[2]["speaking"].ToString();
            }
            else 
            {             
                foreach (DataRow row in dt.Rows)
                {
                    if (row["topic"].ToString() == "animals")
                        re.ImportRow(row);
                }
                re.DefaultView.Sort = "totalscore DESC";
                re = re.DefaultView.ToTable();
                label1.Text = re.Rows[0]["username"].ToString();
                label1_w.Text = "W: " + re.Rows[0]["writing"].ToString();
                label1_s.Text = "S: " + re.Rows[0]["speaking"].ToString();
                label2.Text = re.Rows[1]["username"].ToString();
                label2_w.Text = "W: " + re.Rows[1]["writing"].ToString();
                label2_s.Text = "S: " + re.Rows[1]["speaking"].ToString();
                label3.Text = re.Rows[2]["username"].ToString();
                label3_w.Text = "W: " + re.Rows[2]["writing"].ToString();
                label3_s.Text = "S: " + re.Rows[2]["speaking"].ToString();
            }
        }
    }
}
