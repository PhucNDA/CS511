using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH02
{
    public partial class Order : UserControl
    {
        DataRow row;
        public Order(DataRow roww)
        {
            InitializeComponent();
            row = roww;
        }

        private void order_btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Firebrick;
        }

        private void order_btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            Property pt = new Property(row);
            pt.Show();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            order_label.Text = row["Product"].ToString();
            order_picbox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(order_label.Text);
        }
    }
}
