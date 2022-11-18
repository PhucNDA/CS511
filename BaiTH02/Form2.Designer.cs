
namespace BaiTH02
{
    partial class Search
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
            this.search_search_combobox = new System.Windows.Forms.ComboBox();
            this.search_searchfor = new System.Windows.Forms.Label();
            this.search_search_btn = new System.Windows.Forms.Button();
            this.search_back_picbox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.search_brand_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search_type_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_origin_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.search_price_label = new System.Windows.Forms.Label();
            this.search_higher_checkbox = new System.Windows.Forms.CheckBox();
            this.search_filter_btn = new System.Windows.Forms.Button();
            this.search_acs_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.search_back_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_search_combobox
            // 
            this.search_search_combobox.AutoCompleteCustomSource.AddRange(new string[] {
            "APOLLO RU200",
            "Bosendorfer 120 CL",
            "Boston UP-132E PE",
            "BOWMAN CX230 SR",
            "CASIO PX-870",
            "CASIO PX-S3100",
            "ESSEX UP-123 WN",
            "KAWAI BL51 Wn",
            "KAWAI K-400",
            "Kimball Art Case",
            "Kohler & Campbell J310B",
            "KOHLER CAMPBELL KIG-48D",
            "KORG C1 Air Black",
            "MASON MODEL 50",
            "MEISTER ME28",
            "ROLAND F701 WH",
            "ROLAND KF-10 MB",
            "ROLAND LX-705 LO",
            "ROLAND LX-706",
            "ROLAND RD-88",
            "SHIGERU KAWAI SK-2",
            "SHIGERU KAWAI SK-EX",
            "YAMAHA C1 PE",
            "YAMAHA C7X",
            "YAMAHA CLP-795GP",
            "YAMAHA ELS-02C",
            "YAMAHA GB1K",
            "YAMAHA P-125",
            "YAMAHA U1J PE",
            "YAMAHA YDP-165 WA"});
            this.search_search_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.search_search_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.search_search_combobox.Font = new System.Drawing.Font("Mongolian Baiti", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_search_combobox.ForeColor = System.Drawing.Color.DarkGray;
            this.search_search_combobox.FormattingEnabled = true;
            this.search_search_combobox.Location = new System.Drawing.Point(293, 12);
            this.search_search_combobox.Name = "search_search_combobox";
            this.search_search_combobox.Size = new System.Drawing.Size(638, 48);
            this.search_search_combobox.TabIndex = 0;
            this.search_search_combobox.Text = "Search for product";
            this.search_search_combobox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_search_combobox_KeyDown);
            this.search_search_combobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_search_combobox_KeyPress);
            this.search_search_combobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_search_combobox_MouseClick);
            // 
            // search_searchfor
            // 
            this.search_searchfor.AutoSize = true;
            this.search_searchfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_searchfor.Location = new System.Drawing.Point(12, 21);
            this.search_searchfor.Name = "search_searchfor";
            this.search_searchfor.Size = new System.Drawing.Size(255, 32);
            this.search_searchfor.TabIndex = 1;
            this.search_searchfor.Text = "Search for product:";
            // 
            // search_search_btn
            // 
            this.search_search_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.search_search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.search_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_search_btn.Location = new System.Drawing.Point(948, 12);
            this.search_search_btn.Name = "search_search_btn";
            this.search_search_btn.Size = new System.Drawing.Size(156, 48);
            this.search_search_btn.TabIndex = 2;
            this.search_search_btn.Text = "Find";
            this.search_search_btn.UseVisualStyleBackColor = false;
            this.search_search_btn.Click += new System.EventHandler(this.search_search_btn_Click);
            // 
            // search_back_picbox
            // 
            this.search_back_picbox.BackgroundImage = global::BaiTH02.Properties.Resources.back_img;
            this.search_back_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_back_picbox.Location = new System.Drawing.Point(1271, 3);
            this.search_back_picbox.Name = "search_back_picbox";
            this.search_back_picbox.Size = new System.Drawing.Size(88, 92);
            this.search_back_picbox.TabIndex = 3;
            this.search_back_picbox.TabStop = false;
            this.search_back_picbox.Click += new System.EventHandler(this.search_back_picbox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.Location = new System.Drawing.Point(8, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1251, 10);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter product:";
            // 
            // search_brand_combobox
            // 
            this.search_brand_combobox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_brand_combobox.FormattingEnabled = true;
            this.search_brand_combobox.Items.AddRange(new object[] {
            "APOLLO",
            "Bosendorfer",
            "Boston",
            "BOWMAN",
            "CASIO",
            "ESSEX",
            "KAWAI",
            "Kimball",
            "Kohler & Campbell",
            "KOHLER CAMPBELL",
            "KORG",
            "MASON",
            "MEISTER",
            "ROLAND",
            "SHIGERU KAWAI",
            "YAMAHA"});
            this.search_brand_combobox.Location = new System.Drawing.Point(263, 146);
            this.search_brand_combobox.Name = "search_brand_combobox";
            this.search_brand_combobox.Size = new System.Drawing.Size(318, 45);
            this.search_brand_combobox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(717, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 53);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // search_type_combobox
            // 
            this.search_type_combobox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_type_combobox.FormattingEnabled = true;
            this.search_type_combobox.Items.AddRange(new object[] {
            "Upright",
            "Digital",
            "Grand",
            "Electon"});
            this.search_type_combobox.Location = new System.Drawing.Point(604, 145);
            this.search_type_combobox.Name = "search_type_combobox";
            this.search_type_combobox.Size = new System.Drawing.Size(318, 45);
            this.search_type_combobox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1037, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 53);
            this.label4.TabIndex = 10;
            this.label4.Text = "Origin";
            // 
            // search_origin_combobox
            // 
            this.search_origin_combobox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_origin_combobox.FormattingEnabled = true;
            this.search_origin_combobox.Items.AddRange(new object[] {
            "Japan",
            "Austria",
            "Korea",
            "USA"});
            this.search_origin_combobox.Location = new System.Drawing.Point(948, 145);
            this.search_origin_combobox.Name = "search_origin_combobox";
            this.search_origin_combobox.Size = new System.Drawing.Size(318, 45);
            this.search_origin_combobox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(717, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(478, 255);
            this.trackBar1.Maximum = 5238;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(592, 80);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // search_price_label
            // 
            this.search_price_label.AutoSize = true;
            this.search_price_label.Font = new System.Drawing.Font("MV Boli", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_price_label.ForeColor = System.Drawing.Color.DarkRed;
            this.search_price_label.Location = new System.Drawing.Point(708, 310);
            this.search_price_label.Name = "search_price_label";
            this.search_price_label.Size = new System.Drawing.Size(222, 58);
            this.search_price_label.TabIndex = 14;
            this.search_price_label.Text = "0M VND";
            // 
            // search_higher_checkbox
            // 
            this.search_higher_checkbox.AutoSize = true;
            this.search_higher_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_higher_checkbox.Location = new System.Drawing.Point(1092, 255);
            this.search_higher_checkbox.Name = "search_higher_checkbox";
            this.search_higher_checkbox.Size = new System.Drawing.Size(126, 35);
            this.search_higher_checkbox.TabIndex = 15;
            this.search_higher_checkbox.Text = "Higher";
            this.search_higher_checkbox.UseVisualStyleBackColor = true;
            // 
            // search_filter_btn
            // 
            this.search_filter_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.search_filter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.search_filter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_filter_btn.Location = new System.Drawing.Point(1203, 336);
            this.search_filter_btn.Name = "search_filter_btn";
            this.search_filter_btn.Size = new System.Drawing.Size(156, 48);
            this.search_filter_btn.TabIndex = 16;
            this.search_filter_btn.Text = "Filter";
            this.search_filter_btn.UseVisualStyleBackColor = false;
            this.search_filter_btn.Click += new System.EventHandler(this.search_filter_btn_Click);
            // 
            // search_acs_checkbox
            // 
            this.search_acs_checkbox.AutoSize = true;
            this.search_acs_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_acs_checkbox.Location = new System.Drawing.Point(1092, 217);
            this.search_acs_checkbox.Name = "search_acs_checkbox";
            this.search_acs_checkbox.Size = new System.Drawing.Size(205, 41);
            this.search_acs_checkbox.TabIndex = 17;
            this.search_acs_checkbox.Text = "Ascending";
            this.search_acs_checkbox.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1371, 396);
            this.Controls.Add(this.search_acs_checkbox);
            this.Controls.Add(this.search_filter_btn);
            this.Controls.Add(this.search_higher_checkbox);
            this.Controls.Add(this.search_price_label);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search_origin_combobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_type_combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_brand_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search_back_picbox);
            this.Controls.Add(this.search_search_btn);
            this.Controls.Add(this.search_searchfor);
            this.Controls.Add(this.search_search_combobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.search_back_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox search_search_combobox;
        private System.Windows.Forms.Label search_searchfor;
        private System.Windows.Forms.Button search_search_btn;
        private System.Windows.Forms.PictureBox search_back_picbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox search_brand_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox search_type_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox search_origin_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label search_price_label;
        private System.Windows.Forms.CheckBox search_higher_checkbox;
        private System.Windows.Forms.Button search_filter_btn;
        private System.Windows.Forms.CheckBox search_acs_checkbox;
    }
}