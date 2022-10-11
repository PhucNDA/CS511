using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;


namespace tmp
{
    public partial class Result : Form
    {
        System.Media.SoundPlayer soundplay;
        int total, write, speak;
        string begin, end;
        bool check = false;
        string topic;
        public Result(int totall, int writee, int speakk, string beginn, string topicc)
        {
            total = totall;
            write = writee;
            speak = speakk;
            begin = beginn;
            topic = topicc;
            end = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            soundplay = new SoundPlayer(@"looperman-l-5636859-0307184-funny-clavinet.wav");
            soundplay.PlayLooping();
            result_label_score.Text = total.ToString() + "/10";
            result_label_write.Text = write.ToString() + "/5";
            result_label_speak.Text = speak.ToString() + "/5";
        }

        private void result_btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            home_form f1 = new home_form();
            f1.Show();
        }

        private void result_btn_back_MouseEnter(object sender, EventArgs e)
        {
            result_btn_back.BackColor = Color.Bisque;
        }

        private void result_btn_back_MouseLeave(object sender, EventArgs e)
        {
            result_btn_back.BackColor = Color.PeachPuff;
        }

        private void result_btn_check_Click(object sender, EventArgs e)
        {
            if (check == true)
                return;
            System.Data.DataTable dt = ConvertCSVtoDataTable("rst.csv");
            dt.Rows.Add(result_txt_name.Text, total.ToString(), write.ToString(), speak.ToString(), begin, end, topic);
            DataTabletoCSV(dt, "rst.csv");
            check = true;
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
    }
}
