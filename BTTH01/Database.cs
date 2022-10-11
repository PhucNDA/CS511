using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmp
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("En", typeof(string));
            dt.Columns.Add("Vn", typeof(string));

            dt.Rows.Add("1", "Apple", "Quả Táo");
            dt.Rows.Add("2", "Banana", "Quả Chuối");
            dt.Rows.Add("3", "Watermelon", "Quả Dưa Hấu");
            dt.Rows.Add("4", "Mango", "Quả Xoài");
            dt.Rows.Add("5", "Kiwi", "Quả Kiwi");
            dt.Rows.Add("6", "Durian", "Quả Sầu Riêng");
            dt.Rows.Add("7", "Orange", "Quả Cam");
            dt.Rows.Add("8", "Cucumber", "Quả Dưa Chuột");
            dt.Rows.Add("9", "Cherry", "Quả Cherry");
            dt.Rows.Add("10", "Strawberry", "Quả Dâu Tây");

            dt.Rows.Add("11", "Dog", "Con Chó");
            dt.Rows.Add("12", "Cat", "Con Mèo");
            dt.Rows.Add("13", "Lion", "Con Sử Tử");
            dt.Rows.Add("14", "Tiger", "Con Cọp");
            dt.Rows.Add("15", "Ant", "Con Kiếng");
            dt.Rows.Add("16", "Bee", "Con Ong");
            dt.Rows.Add("17", "Snake", "Con Rắn");
            dt.Rows.Add("18", "Butterfly", "Con Bướm");
            dt.Rows.Add("19", "Chicken", "Con Gà");
            dt.Rows.Add("20", "Kangaroo", "Con Chuột Túi");

            dt.Rows.Add("21", "Car", "Xe Hơi");
            dt.Rows.Add("22", "Truck", "Xe Tải");
            dt.Rows.Add("23", "Helicopter", "Trực Thăng");
            dt.Rows.Add("24", "Motorbike", "Xe Moto");
            dt.Rows.Add("25", "Bike", "Xe Đạp");
            dt.Rows.Add("26", "Train", "Xe lửa");
            dt.Rows.Add("27", "Plane", "Máy Bay");
            dt.Rows.Add("28", "Ship", "Tàu Thuyền");
            dt.Rows.Add("29", "Submarine", "Tàu Ngầm");
            dt.Rows.Add("30", "Canoe", "Xuồng Ca Nô");

            dataGridView1.DataSource = dt;
        }

        private void database_btn_back_MouseEnter(object sender, EventArgs e)
        {
            database_btn_back.BackColor = Color.Bisque;
        }

        private void database_btn_back_MouseLeave(object sender, EventArgs e)
        {
            database_btn_back.BackColor = Color.PeachPuff;
        }

        private void database_btn_back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            home_form f1 = new home_form();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
