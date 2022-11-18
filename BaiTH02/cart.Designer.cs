
namespace BaiTH02
{
    partial class cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.home_shopname_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cart_totalprice_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cart_checkout_picbox = new System.Windows.Forms.PictureBox();
            this.cart_exit_picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cart_checkout_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_exit_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1821, 903);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // home_shopname_label
            // 
            this.home_shopname_label.AutoSize = true;
            this.home_shopname_label.Font = new System.Drawing.Font("Script MT Bold", 27.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_shopname_label.Location = new System.Drawing.Point(12, 12);
            this.home_shopname_label.Name = "home_shopname_label";
            this.home_shopname_label.Size = new System.Drawing.Size(384, 78);
            this.home_shopname_label.TabIndex = 2;
            this.home_shopname_label.Text = "PucPuc Store";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 26.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 1047);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total price:";
            // 
            // cart_totalprice_label
            // 
            this.cart_totalprice_label.AutoSize = true;
            this.cart_totalprice_label.Font = new System.Drawing.Font("Lucida Handwriting", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_totalprice_label.ForeColor = System.Drawing.Color.Navy;
            this.cart_totalprice_label.Location = new System.Drawing.Point(951, 1039);
            this.cart_totalprice_label.Name = "cart_totalprice_label";
            this.cart_totalprice_label.Size = new System.Drawing.Size(77, 80);
            this.cart_totalprice_label.TabIndex = 4;
            this.cart_totalprice_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1660, 1033);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 80);
            this.label3.TabIndex = 5;
            this.label3.Text = "VND";
            // 
            // cart_checkout_picbox
            // 
            this.cart_checkout_picbox.BackgroundImage = global::BaiTH02.Properties.Resources.checkout;
            this.cart_checkout_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cart_checkout_picbox.Location = new System.Drawing.Point(1686, 1106);
            this.cart_checkout_picbox.Name = "cart_checkout_picbox";
            this.cart_checkout_picbox.Size = new System.Drawing.Size(147, 131);
            this.cart_checkout_picbox.TabIndex = 6;
            this.cart_checkout_picbox.TabStop = false;
            this.cart_checkout_picbox.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.cart_checkout_picbox.MouseLeave += new System.EventHandler(this.cart_checkout_picbox_MouseLeave);
            // 
            // cart_exit_picbox
            // 
            this.cart_exit_picbox.BackgroundImage = global::BaiTH02.Properties.Resources.exit_img;
            this.cart_exit_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cart_exit_picbox.Location = new System.Drawing.Point(1766, 12);
            this.cart_exit_picbox.Name = "cart_exit_picbox";
            this.cart_exit_picbox.Size = new System.Drawing.Size(88, 92);
            this.cart_exit_picbox.TabIndex = 1;
            this.cart_exit_picbox.TabStop = false;
            this.cart_exit_picbox.Click += new System.EventHandler(this.cart_exit_picbox_Click);
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1866, 1249);
            this.Controls.Add(this.cart_checkout_picbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cart_totalprice_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home_shopname_label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cart_exit_picbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cart";
            this.Load += new System.EventHandler(this.cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cart_checkout_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_exit_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cart_exit_picbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label home_shopname_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cart_totalprice_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox cart_checkout_picbox;
    }
}