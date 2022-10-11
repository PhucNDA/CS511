using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace tmp
{
    public partial class Topic : Form
    {
        System.Media.SoundPlayer soundplay;
        bool music = true;
        public Topic()
        {
            InitializeComponent();
        }

        private void topic_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void topic_btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            home_form f1 = new home_form();
            f1.Show();
        }

        private void topic_btn_exit_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Bisque;
        }

        private void topic_btn_exit_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.PeachPuff;
        }

        private void topic_picbox_music_MouseEnter(object sender, EventArgs e)
        {
            topic_picbox_music.BackColor = Color.Bisque;
        }

        private void topic_picbox_music_MouseLeave(object sender, EventArgs e)
        {
            topic_picbox_music.BackColor = Color.PeachPuff;
        }

        private void Topic_Load(object sender, EventArgs e)
        {
            soundplay = new SoundPlayer(@"looperman-l-0672953-0078774-ozzi-twinkle-lil-star-80bpm-gminor.wav");
            soundplay.PlayLooping();
            music = true;
        }

        private void topic_picbox_music_MouseClick(object sender, MouseEventArgs e)
        {
            if (music)
            {
                music = false;
                Image img = new Bitmap(@"2203527_mute_sound_speaker_volume_icon.png");
                topic_picbox_music.BackgroundImage = img;
                soundplay.Stop();
            }
            else
            {
                music = true;
                Image img = new Bitmap(@"2203528_lound_sound_speaker_volume_icon.png");
                topic_picbox_music.BackgroundImage = img;
                soundplay.PlayLooping();
            }
        }

        private void topic_picbox_fruits_MouseEnter(object sender, EventArgs e)
        {
            topic_picbox_fruits.BackColor = Color.BlanchedAlmond;
            label1.ForeColor = Color.DarkCyan;
        }

        private void topic_picbox_vehicles_MouseEnter(object sender, EventArgs e)
        {
            topic_picbox_vehicles.BackColor = Color.BlanchedAlmond;
            label2.ForeColor = Color.DarkCyan;
        }

        private void topic_picbox_animals_MouseEnter(object sender, EventArgs e)
        {
            topic_picbox_animals.BackColor = Color.BlanchedAlmond;
            label3.ForeColor = Color.DarkCyan;
        }

        private void topic_picbox_fruits_MouseLeave(object sender, EventArgs e)
        {
            topic_picbox_fruits.BackColor = Color.AntiqueWhite;
            label1.ForeColor = Color.Crimson;
        }

        private void topic_picbox_vehicles_MouseLeave(object sender, EventArgs e)
        {
            topic_picbox_vehicles.BackColor = Color.AntiqueWhite;
            label2.ForeColor = Color.Crimson;
        }

        private void topic_picbox_animals_MouseLeave(object sender, EventArgs e)
        {
            topic_picbox_animals.BackColor = Color.AntiqueWhite;
            label3.ForeColor = Color.Crimson;
        }

        private void topic_picbox_fruits_Click(object sender, EventArgs e)
        {
            this.Close();
            soundplay.Stop();
            Game ga = new Game("fruits");
            ga.Show();
        }

        private void topic_picbox_vehicles_Click(object sender, EventArgs e)
        {
            this.Close();
            soundplay.Stop();
            Game ga = new Game("vehicles");
            ga.Show();
        }

        private void topic_picbox_animals_Click(object sender, EventArgs e)
        {
            this.Close();
            soundplay.Stop();
            Game ga = new Game("animals");
            ga.Show();
        }
    }
}
