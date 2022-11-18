
namespace BaiTH02
{
    partial class cartitem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartitem_name_label = new System.Windows.Forms.Label();
            this.cartitem_price_label = new System.Windows.Forms.Label();
            this.cartitem_quantity_label = new System.Windows.Forms.Label();
            this.cartitem_check_picbox = new System.Windows.Forms.PictureBox();
            this.cartitem_picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cartitem_check_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartitem_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // cartitem_name_label
            // 
            this.cartitem_name_label.AutoSize = true;
            this.cartitem_name_label.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartitem_name_label.Location = new System.Drawing.Point(310, 25);
            this.cartitem_name_label.Name = "cartitem_name_label";
            this.cartitem_name_label.Size = new System.Drawing.Size(501, 73);
            this.cartitem_name_label.TabIndex = 1;
            this.cartitem_name_label.Text = "YAMAHA CLP P1";
            // 
            // cartitem_price_label
            // 
            this.cartitem_price_label.AutoSize = true;
            this.cartitem_price_label.Font = new System.Drawing.Font("Arial", 26.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartitem_price_label.ForeColor = System.Drawing.Color.DarkRed;
            this.cartitem_price_label.Location = new System.Drawing.Point(439, 176);
            this.cartitem_price_label.Name = "cartitem_price_label";
            this.cartitem_price_label.Size = new System.Drawing.Size(587, 71);
            this.cartitem_price_label.TabIndex = 2;
            this.cartitem_price_label.Text = "Price: 123.456 VND";
            // 
            // cartitem_quantity_label
            // 
            this.cartitem_quantity_label.AutoSize = true;
            this.cartitem_quantity_label.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartitem_quantity_label.ForeColor = System.Drawing.Color.Chocolate;
            this.cartitem_quantity_label.Location = new System.Drawing.Point(1082, 16);
            this.cartitem_quantity_label.Name = "cartitem_quantity_label";
            this.cartitem_quantity_label.Size = new System.Drawing.Size(353, 73);
            this.cartitem_quantity_label.TabIndex = 3;
            this.cartitem_quantity_label.Text = "Quantity: 3";
            // 
            // cartitem_check_picbox
            // 
            this.cartitem_check_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartitem_check_picbox.Location = new System.Drawing.Point(1397, 176);
            this.cartitem_check_picbox.Name = "cartitem_check_picbox";
            this.cartitem_check_picbox.Size = new System.Drawing.Size(94, 85);
            this.cartitem_check_picbox.TabIndex = 4;
            this.cartitem_check_picbox.TabStop = false;
            // 
            // cartitem_picbox
            // 
            this.cartitem_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartitem_picbox.Location = new System.Drawing.Point(6, 2);
            this.cartitem_picbox.Name = "cartitem_picbox";
            this.cartitem_picbox.Size = new System.Drawing.Size(282, 270);
            this.cartitem_picbox.TabIndex = 0;
            this.cartitem_picbox.TabStop = false;
            // 
            // cartitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.cartitem_check_picbox);
            this.Controls.Add(this.cartitem_quantity_label);
            this.Controls.Add(this.cartitem_price_label);
            this.Controls.Add(this.cartitem_name_label);
            this.Controls.Add(this.cartitem_picbox);
            this.Name = "cartitem";
            this.Size = new System.Drawing.Size(1505, 273);
            this.Load += new System.EventHandler(this.cartitem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cartitem_MouseClick);
            this.MouseEnter += new System.EventHandler(this.cartitem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.cartitem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.cartitem_check_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartitem_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cartitem_picbox;
        private System.Windows.Forms.Label cartitem_name_label;
        private System.Windows.Forms.Label cartitem_price_label;
        private System.Windows.Forms.Label cartitem_quantity_label;
        private System.Windows.Forms.PictureBox cartitem_check_picbox;
    }
}
