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
    public partial class Property : Form
    {
        string product;
        string brand;
        string type;
        int pedal;
        string status;
        int remaining;
        string info;
        DataRow row;
        public Property(DataRow roww)
        {
            InitializeComponent();
            row = roww;
            prob_picbox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(row["Product"].ToString());
            product = row["Product"].ToString();
            brand = row["Brand"].ToString();
            type = row["Type"].ToString();
            pedal = Convert.ToInt32(row["pedal"].ToString());
            status = row["Status"].ToString();
            remaining= Convert.ToInt32(row["Remaining"].ToString());
            info = row["Information"].ToString();
            prob_brand_label.Text = "Brand: " + brand;
            prob_type_label.Text = "Type: " + type;
            prob_pedal_label.Text = "Pedal: " + pedal.ToString();
            prob_status_label.Text = "Status: " + status;
            prob_remaining_label.Text = "Remaining: " + remaining.ToString();
            prob_information_label.Text = info;
            prob_product_label.Text = product;
            string s = row["Price"].ToString();
            int cnt = 0;
            string t = "";
            for(int i=s.Length-1;i>=0;i-=1)
            {
                if(cnt==3)
                {
                    t += '.';
                    cnt = 0;
                }
                t += s[i];
                cnt++;
            }
            string res = "";
            for (int i = t.Length - 1; i >= 0; i -= 1)
                res += t[i];
            prop_price_label.Text = res + " VND";
        }

        private void prop_back_picbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Property_Load(object sender, EventArgs e)
        {
        }

        private void prob_cart_picbox_MouseHover(object sender, EventArgs e)
        {

        }

        private void prob_cart_picbox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.PeachPuff;
        }

        private void prob_cart_picbox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.Bisque;
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
        public static void DataTabletoCSV(System.Data.DataTable dt, string name)
        {
            StringBuilder sb = new StringBuilder();

            string[] columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(name, sb.ToString());
        }
        private void prob_cart_picbox_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value>remaining)
            {
                MessageBox.Show("Insufficient number of item!");
            }
            else 
            {
                // implementation here
                DataTable dt = ConvertCSVtoDataTable("cart.csv");
                dt.Rows.Add(product, row["Price"], numericUpDown1.Value);
                DataTabletoCSV(dt, "cart.csv");
                MessageBox.Show("Added to Cart");
            }
        }
    }
}
