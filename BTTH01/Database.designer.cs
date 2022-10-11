
namespace tmp
{
    partial class Database
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database_btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(885, 726);
            this.dataGridView1.TabIndex = 0;
            // 
            // database_btn_back
            // 
            this.database_btn_back.BackColor = System.Drawing.Color.PeachPuff;
            this.database_btn_back.BackgroundImage = global::tmp.Properties.Resources._3847918_arrow_return_signs_traffic_icon;
            this.database_btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.database_btn_back.Location = new System.Drawing.Point(996, 300);
            this.database_btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.database_btn_back.Name = "database_btn_back";
            this.database_btn_back.Size = new System.Drawing.Size(172, 168);
            this.database_btn_back.TabIndex = 1;
            this.database_btn_back.UseVisualStyleBackColor = false;
            this.database_btn_back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.database_btn_back_MouseClick);
            this.database_btn_back.MouseEnter += new System.EventHandler(this.database_btn_back_MouseEnter);
            this.database_btn_back.MouseLeave += new System.EventHandler(this.database_btn_back_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(997, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Words";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1234, 801);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.database_btn_back);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button database_btn_back;
        private System.Windows.Forms.Label label1;
    }
}