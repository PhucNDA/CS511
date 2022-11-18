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

public partial class Search : Form
    {
        //public class refer
        //{
        //    public ref FlowLayoutPanel tmp;
        //    public 
        //};
        //refer tmpp;
        FlowLayoutPanel tmp;
        public Search(ref FlowLayoutPanel home_flowpanel)
        {
            InitializeComponent();
            ref var tmpp = ref home_flowpanel;
            tmp = tmpp;
        }

        private void search_search_combobox_MouseClick(object sender, MouseEventArgs e)
        {
            search_search_combobox.Text = "";
            search_search_combobox.ForeColor = Color.Black;
        }

        private void search_search_combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                //tmp.Controls.Clear();
                //this.Close();
            }
        }

        private void search_search_combobox_KeyDown(object sender, KeyEventArgs e)
        {

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
        private void search_search_btn_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = ConvertCSVtoDataTable("rst.csv");
            tmp.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                if(row["Product"].ToString()==search_search_combobox.Text)
                {
                    Order item = new Order(row);
                    tmp.Controls.Add(item);
                    this.Close();
                    return;
                }
                    
            }
            MessageBox.Show("Unable to find the product. Type again suggested product");
        }

        private void search_back_picbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            search_price_label.Text = trackBar1.Value.ToString()+"M VND";
        }

        private void search_filter_btn_Click(object sender, EventArgs e)
        {
            string brand = search_brand_combobox.Text;
            string type = search_type_combobox.Text;
            string origin = search_origin_combobox.Text;
            long val = Convert.ToInt64(trackBar1.Value.ToString())*1000000;
            bool higher = search_higher_checkbox.Checked;
            System.Data.DataTable dt = ConvertCSVtoDataTable("rst.csv");
            System.Data.DataTable re = dt.Clone();
            re.Columns["Price"].DataType = typeof(Int64);
            foreach (DataRow row in dt.Rows)
                    re.ImportRow(row);
            tmp.Controls.Clear();
            if(search_acs_checkbox.Checked)
                re.DefaultView.Sort = "Price ASC";
            else
                re.DefaultView.Sort = "Price DESC";
            re = re.DefaultView.ToTable();
            dt = re;
            foreach (DataRow row in dt.Rows)
            {
                if(higher)
                {
                    bool flag = true;
                    if (brand != "" && row["Brand"].ToString() != brand) flag = false;
                    if (type != "" && row["Type"].ToString() != type) flag = false;
                    if (origin != "" && row["Origin"].ToString() != origin) flag = false;
                    if (val >= Convert.ToInt64(row["Price"].ToString())) flag = false;
                    if(flag==true)
                    {
                        Order item = new Order(row);
                        tmp.Controls.Add(item);
                    }
                }
                else 
                {
                    bool flag = true;
                    if (brand != "" && row["Brand"].ToString() != brand) flag = false;
                    if (type != "" && row["Type"].ToString() != type) flag = false;
                    if (origin != "" && row["Origin"].ToString() != origin) flag = false;
                    if (val <= Convert.ToInt64(row["Price"].ToString())) flag = false;
                    if (flag == true)
                    {
                        Order item = new Order(row);
                        tmp.Controls.Add(item);
                    }
                }

            }
            this.Close();
        }
    }
}
