
namespace tmp
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.game_btn_exit = new System.Windows.Forms.Button();
            this.game_btn_back = new System.Windows.Forms.Button();
            this.game_picbox = new System.Windows.Forms.PictureBox();
            this.game_txt_write = new System.Windows.Forms.RichTextBox();
            this.game_txt_speak = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.game_label_score = new System.Windows.Forms.Label();
            this.game_btn_check = new System.Windows.Forms.Button();
            this.game_btn_next = new System.Windows.Forms.Button();
            this.game_picbox_writejudge = new System.Windows.Forms.PictureBox();
            this.game_picbox_speakjudge = new System.Windows.Forms.PictureBox();
            this.game_btn_mic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.game_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_picbox_writejudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_picbox_speakjudge)).BeginInit();
            this.SuspendLayout();
            // 
            // game_btn_exit
            // 
            this.game_btn_exit.BackColor = System.Drawing.Color.PeachPuff;
            this.game_btn_exit.BackgroundImage = global::tmp.Properties.Resources._1646012_cancel_delete_error_exit_remove_icon;
            this.game_btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_btn_exit.Location = new System.Drawing.Point(1128, 11);
            this.game_btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_btn_exit.Name = "game_btn_exit";
            this.game_btn_exit.Size = new System.Drawing.Size(94, 90);
            this.game_btn_exit.TabIndex = 3;
            this.game_btn_exit.UseVisualStyleBackColor = false;
            this.game_btn_exit.Click += new System.EventHandler(this.game_btn_exit_Click);
            this.game_btn_exit.MouseEnter += new System.EventHandler(this.game_btn_exit_MouseEnter);
            this.game_btn_exit.MouseLeave += new System.EventHandler(this.game_btn_exit_MouseLeave);
            // 
            // game_btn_back
            // 
            this.game_btn_back.BackColor = System.Drawing.Color.PeachPuff;
            this.game_btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("game_btn_back.BackgroundImage")));
            this.game_btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_btn_back.Location = new System.Drawing.Point(11, 10);
            this.game_btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_btn_back.Name = "game_btn_back";
            this.game_btn_back.Size = new System.Drawing.Size(94, 91);
            this.game_btn_back.TabIndex = 4;
            this.game_btn_back.UseVisualStyleBackColor = false;
            this.game_btn_back.Click += new System.EventHandler(this.game_btn_back_Click);
            this.game_btn_back.MouseEnter += new System.EventHandler(this.game_btn_exit_MouseEnter);
            this.game_btn_back.MouseLeave += new System.EventHandler(this.game_btn_exit_MouseLeave);
            // 
            // game_picbox
            // 
            this.game_picbox.BackColor = System.Drawing.Color.Linen;
            this.game_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_picbox.Location = new System.Drawing.Point(326, 11);
            this.game_picbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_picbox.Name = "game_picbox";
            this.game_picbox.Size = new System.Drawing.Size(583, 583);
            this.game_picbox.TabIndex = 5;
            this.game_picbox.TabStop = false;
            // 
            // game_txt_write
            // 
            this.game_txt_write.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.game_txt_write.Font = new System.Drawing.Font("VNI-Ariston", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.game_txt_write.ForeColor = System.Drawing.SystemColors.ControlText;
            this.game_txt_write.Location = new System.Drawing.Point(380, 618);
            this.game_txt_write.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_txt_write.Name = "game_txt_write";
            this.game_txt_write.Size = new System.Drawing.Size(459, 54);
            this.game_txt_write.TabIndex = 6;
            this.game_txt_write.Text = "";
            // 
            // game_txt_speak
            // 
            this.game_txt_speak.Enabled = false;
            this.game_txt_speak.Font = new System.Drawing.Font("VNI-Ariston", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.game_txt_speak.Location = new System.Drawing.Point(380, 705);
            this.game_txt_speak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_txt_speak.Name = "game_txt_speak";
            this.game_txt_speak.Size = new System.Drawing.Size(459, 54);
            this.game_txt_speak.TabIndex = 7;
            this.game_txt_speak.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Ariston", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(164, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Writing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Ariston", 15.85714F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(139, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "Speaking";
            // 
            // game_label_score
            // 
            this.game_label_score.AutoSize = true;
            this.game_label_score.Font = new System.Drawing.Font("VNI-Ariston", 26.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.game_label_score.ForeColor = System.Drawing.Color.OrangeRed;
            this.game_label_score.Location = new System.Drawing.Point(81, 280);
            this.game_label_score.Name = "game_label_score";
            this.game_label_score.Size = new System.Drawing.Size(167, 85);
            this.game_label_score.TabIndex = 10;
            this.game_label_score.Text = "0/10";
            // 
            // game_btn_check
            // 
            this.game_btn_check.BackColor = System.Drawing.Color.Salmon;
            this.game_btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_btn_check.Location = new System.Drawing.Point(900, 649);
            this.game_btn_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_btn_check.Name = "game_btn_check";
            this.game_btn_check.Size = new System.Drawing.Size(121, 78);
            this.game_btn_check.TabIndex = 11;
            this.game_btn_check.Text = "Check";
            this.game_btn_check.UseVisualStyleBackColor = false;
            this.game_btn_check.Click += new System.EventHandler(this.game_btn_check_Click);
            // 
            // game_btn_next
            // 
            this.game_btn_next.BackColor = System.Drawing.Color.PeachPuff;
            this.game_btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("game_btn_next.BackgroundImage")));
            this.game_btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_btn_next.Location = new System.Drawing.Point(1110, 271);
            this.game_btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_btn_next.Name = "game_btn_next";
            this.game_btn_next.Size = new System.Drawing.Size(103, 94);
            this.game_btn_next.TabIndex = 12;
            this.game_btn_next.UseVisualStyleBackColor = false;
            this.game_btn_next.Click += new System.EventHandler(this.game_btn_next_Click);
            this.game_btn_next.MouseEnter += new System.EventHandler(this.game_btn_exit_MouseEnter);
            this.game_btn_next.MouseLeave += new System.EventHandler(this.game_btn_exit_MouseLeave);
            // 
            // game_picbox_writejudge
            // 
            this.game_picbox_writejudge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_picbox_writejudge.Location = new System.Drawing.Point(1097, 598);
            this.game_picbox_writejudge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_picbox_writejudge.Name = "game_picbox_writejudge";
            this.game_picbox_writejudge.Size = new System.Drawing.Size(91, 74);
            this.game_picbox_writejudge.TabIndex = 13;
            this.game_picbox_writejudge.TabStop = false;
            this.game_picbox_writejudge.Click += new System.EventHandler(this.game_picbox_writejudge_Click);
            // 
            // game_picbox_speakjudge
            // 
            this.game_picbox_speakjudge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_picbox_speakjudge.Location = new System.Drawing.Point(1097, 681);
            this.game_picbox_speakjudge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_picbox_speakjudge.Name = "game_picbox_speakjudge";
            this.game_picbox_speakjudge.Size = new System.Drawing.Size(91, 74);
            this.game_picbox_speakjudge.TabIndex = 14;
            this.game_picbox_speakjudge.TabStop = false;
            // 
            // game_btn_mic
            // 
            this.game_btn_mic.BackColor = System.Drawing.Color.PeachPuff;
            this.game_btn_mic.BackgroundImage = global::tmp.Properties.Resources.mic;
            this.game_btn_mic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_btn_mic.Location = new System.Drawing.Point(44, 676);
            this.game_btn_mic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_btn_mic.Name = "game_btn_mic";
            this.game_btn_mic.Size = new System.Drawing.Size(89, 83);
            this.game_btn_mic.TabIndex = 15;
            this.game_btn_mic.UseVisualStyleBackColor = false;
            this.game_btn_mic.Click += new System.EventHandler(this.game_btn_mic_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1234, 801);
            this.Controls.Add(this.game_btn_mic);
            this.Controls.Add(this.game_picbox_speakjudge);
            this.Controls.Add(this.game_picbox_writejudge);
            this.Controls.Add(this.game_btn_next);
            this.Controls.Add(this.game_btn_check);
            this.Controls.Add(this.game_label_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.game_txt_speak);
            this.Controls.Add(this.game_txt_write);
            this.Controls.Add(this.game_picbox);
            this.Controls.Add(this.game_btn_back);
            this.Controls.Add(this.game_btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.game_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_picbox_writejudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_picbox_speakjudge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button game_btn_exit;
        private System.Windows.Forms.Button game_btn_back;
        private System.Windows.Forms.PictureBox game_picbox;
        private System.Windows.Forms.RichTextBox game_txt_write;
        private System.Windows.Forms.RichTextBox game_txt_speak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label game_label_score;
        private System.Windows.Forms.Button game_btn_check;
        private System.Windows.Forms.Button game_btn_next;
        private System.Windows.Forms.PictureBox game_picbox_writejudge;
        private System.Windows.Forms.PictureBox game_picbox_speakjudge;
        private System.Windows.Forms.Button game_btn_mic;
    }
}