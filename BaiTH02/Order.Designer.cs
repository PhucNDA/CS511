
namespace BaiTH02
{
    partial class Order
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
            this.order_label = new System.Windows.Forms.Label();
            this.order_btn = new System.Windows.Forms.Button();
            this.order_picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.order_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // order_label
            // 
            this.order_label.AutoSize = true;
            this.order_label.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_label.Location = new System.Drawing.Point(8, 363);
            this.order_label.Name = "order_label";
            this.order_label.Size = new System.Drawing.Size(244, 37);
            this.order_label.TabIndex = 3;
            this.order_label.Text = "SamSung Galaxy";
            // 
            // order_btn
            // 
            this.order_btn.BackColor = System.Drawing.Color.Red;
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.Color.Snow;
            this.order_btn.Location = new System.Drawing.Point(75, 415);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(303, 68);
            this.order_btn.TabIndex = 4;
            this.order_btn.Text = "ORDER NOW";
            this.order_btn.UseVisualStyleBackColor = false;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            this.order_btn.MouseEnter += new System.EventHandler(this.order_btn_MouseEnter);
            this.order_btn.MouseLeave += new System.EventHandler(this.order_btn_MouseLeave);
            // 
            // order_picbox
            // 
            this.order_picbox.BackColor = System.Drawing.Color.SeaShell;
            this.order_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.order_picbox.Location = new System.Drawing.Point(15, 17);
            this.order_picbox.Name = "order_picbox";
            this.order_picbox.Size = new System.Drawing.Size(424, 343);
            this.order_picbox.TabIndex = 1;
            this.order_picbox.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.order_label);
            this.Controls.Add(this.order_picbox);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(458, 496);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox order_picbox;
        private System.Windows.Forms.Label order_label;
        private System.Windows.Forms.Button order_btn;
    }
}
