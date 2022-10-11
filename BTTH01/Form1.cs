using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tmp
{
    public partial class home_form : Form
    {
        System.Media.SoundPlayer soundplay;
        bool music = true;
        public home_form()
        {
            InitializeComponent();
        }

        private void home_btn_exit_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Bisque;
        }

        private void home_btn_exit_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.PeachPuff;
        }

        private void home_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void home_btn_leaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard lb = new Leaderboard();
            this.Hide();
            lb.Show();
        }

        private void home_btn_database_Click(object sender, EventArgs e)
        {
           Database db = new Database();
            this.Hide();
            db.Show();
        }

        private void home_picbox_play_MouseEnter(object sender, EventArgs e)
        {
            home_picbox_play.BackColor = Color.Orange;
        }

        private void home_picbox_play_MouseLeave(object sender, EventArgs e)
        {
            home_picbox_play.BackColor = Color.PeachPuff;
        }

        private void home_picbox_music_MouseEnter(object sender, EventArgs e)
        {
            home_picbox_music.BackColor = Color.Bisque;
        }

        private void home_picbox_music_MouseLeave(object sender, EventArgs e)
        {
            home_picbox_music.BackColor = Color.PeachPuff;
        }

        private void home_picbox_music_Click(object sender, EventArgs e)
        {
            if (music)
            {
                music = false;
                Image img = new Bitmap(@"2203527_mute_sound_speaker_volume_icon.png");
                home_picbox_music.BackgroundImage = img;
                soundplay.Stop();
            }
            else 
            {
                music = true;
                Image img = new Bitmap(@"2203528_lound_sound_speaker_volume_icon.png");
                home_picbox_music.BackgroundImage = img;
                soundplay.PlayLooping();
            }
        }

        private void home_form_Load(object sender, EventArgs e)
        {
            soundplay = new SoundPlayer(@"looperman-l-0672953-0078774-ozzi-twinkle-lil-star-80bpm-gminor.wav");
            soundplay.PlayLooping();
            music = true;
        }

        private void home_picbox_play_Click(object sender, EventArgs e)
        {
            this.Hide();
            soundplay.Stop();
            Topic tp = new Topic();
            tp.Show();
        }
    }
}
