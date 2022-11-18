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
    public partial class cartitem : UserControl
    {
        DataRow row;
        bool check = false;
        Label tmp;
        public cartitem(DataRow roww, Label tmpp)
        {
            InitializeComponent();
            row = roww;
            ref var tt = ref tmpp;
            tmp = tt;
        }

        private void cartitem_Load(object sender, EventArgs e)
        {
            cartitem_name_label.Text = row["Product"].ToString();
            cartitem_picbox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(cartitem_name_label.Text);
            cartitem_quantity_label.Text = "Quantity: " + row["Quantity"].ToString();
            string s = row["Price"].ToString();
            int cnt = 0;
            string t = "";
            for (int i = s.Length - 1; i >= 0; i -= 1)
            {
                if (cnt == 3)
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
            cartitem_price_label.Text = "Price: " + res + " VND";
        }

        private void cartitem_MouseEnter(object sender, EventArgs e)
        {
            cartitem ct = (cartitem)sender;
            if (ct.check == true) return;
            ct.BackColor = Color.Beige;
        }

        private void cartitem_MouseLeave(object sender, EventArgs e)
        {            
            cartitem ct = (cartitem)sender;
            if (ct.check == true) return;
            ct.BackColor = Color.AntiqueWhite;
        }

        private void cartitem_MouseClick(object sender, MouseEventArgs e)
        {
            string ss = "";
            if (check == false)
            {
                cartitem_check_picbox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("check");
                BackColor = Color.LightGreen;
                check = true;
                for (int i = 0; i <= tmp.Text.Length-1; i++)
                    if (tmp.Text[i] != '.')
                        ss += tmp.Text[i];
                long a = Convert.ToInt64(cartitem_quantity_label.Text.Replace("Quantity: ", ""));
                string tam = cartitem_price_label.Text.Replace("Price: ", "").Replace(".", "");
                long b = Convert.ToInt64(tam.Replace(" VND", ""));
                long num = (Convert.ToInt64(ss) + a * b);
                ss = num.ToString();

            }
            else
            {
                cartitem_check_picbox.BackgroundImage = null;
                BackColor = Color.AntiqueWhite;
                check = false;
                for (int i = 0; i <= tmp.Text.Length - 1; i++)
                    if (tmp.Text[i] != '.')
                        ss += tmp.Text[i];
                long a = Convert.ToInt64(cartitem_quantity_label.Text.Replace("Quantity: ", ""));
                string tam = cartitem_price_label.Text.Replace("Price: ", "").Replace(".", "");
                long b = Convert.ToInt64(tam.Replace(" VND", ""));
                long num = (Convert.ToInt64(ss) - a * b);
                ss = num.ToString();
            }
            string s = ss;
            int cnt = 0;
            string t = "";
            for (int i = s.Length - 1; i >= 0; i -= 1)
            {
                if (cnt == 3)
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
            tmp.Text = res;
        }
    }
}
