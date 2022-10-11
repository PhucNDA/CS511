
namespace tmp
{
    partial class Result
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
            this.result_txt_name = new System.Windows.Forms.RichTextBox();
            this.result_btn_check = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.result_label_score = new System.Windows.Forms.Label();
            this.result_label_write = new System.Windows.Forms.Label();
            this.result_label_speak = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // result_txt_name
            // 
            this.result_txt_name.Font = new System.Drawing.Font("VNI-Ariston", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txt_name.Location = new System.Drawing.Point(190, 460);
            this.result_txt_name.Name = "result_txt_name";
            this.result_txt_name.Size = new System.Drawing.Size(285, 63);
            this.result_txt_name.TabIndex = 2;
            this.result_txt_name.Text = "";
            // 
            // result_btn_check
            // 
            this.result_btn_check.BackColor = System.Drawing.Color.PeachPuff;
            this.result_btn_check.BackgroundImage = global::tmp.Properties.Resources.tick;
            this.result_btn_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.result_btn_check.Location = new System.Drawing.Point(489, 460);
            this.result_btn_check.Name = "result_btn_check";
            this.result_btn_check.Size = new System.Drawing.Size(63, 62);
            this.result_btn_check.TabIndex = 3;
            this.result_btn_check.UseVisualStyleBackColor = false;
            this.result_btn_check.Click += new System.EventHandler(this.result_btn_check_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::tmp.Properties.Resources.englishkid;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(728, 373);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(464, 426);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tmp.Properties.Resources.congrat;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 797);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // result_label_score
            // 
            this.result_label_score.AutoSize = true;
            this.result_label_score.Font = new System.Drawing.Font("VNI-Ariston", 26.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.result_label_score.ForeColor = System.Drawing.Color.OrangeRed;
            this.result_label_score.Location = new System.Drawing.Point(261, 159);
            this.result_label_score.Name = "result_label_score";
            this.result_label_score.Size = new System.Drawing.Size(167, 85);
            this.result_label_score.TabIndex = 11;
            this.result_label_score.Text = "0/10";
            // 
            // result_label_write
            // 
            this.result_label_write.AutoSize = true;
            this.result_label_write.Font = new System.Drawing.Font("VNI-Ariston", 26.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.result_label_write.ForeColor = System.Drawing.Color.OrangeRed;
            this.result_label_write.Location = new System.Drawing.Point(385, 259);
            this.result_label_write.Name = "result_label_write";
            this.result_label_write.Size = new System.Drawing.Size(154, 99);
            this.result_label_write.TabIndex = 12;
            this.result_label_write.Text = "0/5";
            // 
            // result_label_speak
            // 
            this.result_label_speak.AutoSize = true;
            this.result_label_speak.Font = new System.Drawing.Font("VNI-Ariston", 26.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.result_label_speak.ForeColor = System.Drawing.Color.OrangeRed;
            this.result_label_speak.Location = new System.Drawing.Point(385, 344);
            this.result_label_speak.Name = "result_label_speak";
            this.result_label_speak.Size = new System.Drawing.Size(154, 99);
            this.result_label_speak.TabIndex = 13;
            this.result_label_speak.Text = "0/5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Ariston", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(179, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "writing:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Ariston", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(145, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 64);
            this.label2.TabIndex = 15;
            this.label2.Text = "speaking:";
            // 
            // result_btn_back
            // 
            this.result_btn_back.BackColor = System.Drawing.Color.PeachPuff;
            this.result_btn_back.BackgroundImage = global::tmp.Properties.Resources._3847918_arrow_return_signs_traffic_icon;
            this.result_btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.result_btn_back.Location = new System.Drawing.Point(861, 108);
            this.result_btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result_btn_back.Name = "result_btn_back";
            this.result_btn_back.Size = new System.Drawing.Size(172, 168);
            this.result_btn_back.TabIndex = 16;
            this.result_btn_back.UseVisualStyleBackColor = false;
            this.result_btn_back.Click += new System.EventHandler(this.result_btn_back_Click);
            this.result_btn_back.MouseEnter += new System.EventHandler(this.result_btn_back_MouseEnter);
            this.result_btn_back.MouseLeave += new System.EventHandler(this.result_btn_back_MouseLeave);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1234, 801);
            this.Controls.Add(this.result_btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_label_speak);
            this.Controls.Add(this.result_label_write);
            this.Controls.Add(this.result_label_score);
            this.Controls.Add(this.result_btn_check);
            this.Controls.Add(this.result_txt_name);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox result_txt_name;
        private System.Windows.Forms.Button result_btn_check;
        private System.Windows.Forms.Label result_label_score;
        private System.Windows.Forms.Label result_label_write;
        private System.Windows.Forms.Label result_label_speak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button result_btn_back;
    }
}