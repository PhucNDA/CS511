using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace tmp
{
    
    public partial class Game : Form
    {
        string type;
        string[] name;
        int id;
        int scorewr;
        int scoresp;
        bool record = false;
        bool check = false;
        System.Media.SoundPlayer soundplay = new SoundPlayer(@"Ring10.wav");
        string begin;
        string topic;

        public Game(string typee)
        {
            type = typee;
            InitializeComponent();
        }

        private void game_btn_exit_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Bisque;
        }

        private void game_btn_exit_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.PeachPuff;
        }

        private void game_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void game_btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Topic tp = new Topic();
            tp.Show();
        }

        private void Game_Load(object sender, EventArgs e)     
        {
            begin = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            scorewr = scoresp = id = 0;
            if (type == "fruits")
            {
                string []tmp = { "apple", "banana","watermelon","mango","kiwi","durian","orange","cucumber","cherry","strawberry" };
                name = tmp;
                name = Shuffle(name);
                Visualize(name[id]);
                topic = "fruits";
            }
            else if (type == "animals")
            {

                string[] tmp = { "dog", "cat", "lion", "tiger", "ant", "bee", "snake", "butterfly", "chicken", "kangaroo" };
                name = tmp;
                name = Shuffle(name);
                Visualize(name[id]);
                topic = "animals";
            }
            else
            {
                string[] tmp = { "car", "truck", "helicopter", "motorbike", "bike", "train", "plane", "ship", "submarine", "canoe" };
                name = tmp;
                name = Shuffle(name);
                Visualize(name[id]);
                topic = "vehicles";
            }
        }

        public string[] Shuffle(string [] nums)
        {
            var rnd = new Random();
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                string temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }
            return nums;
        }
        public void  Visualize(string name)
        {
            string resName = name;
            Image img = (Image)Properties.Resources.ResourceManager.GetObject(resName);
            game_picbox.BackgroundImage = img;
        }

        private void game_btn_check_Click(object sender, EventArgs e)
        {
            if (check == true)
                return;
            check = true;
            string txt = game_txt_write.Text;
            string txt1 = game_txt_speak.Text;
            if (txt == name[id])
            {
                scorewr++;
                game_picbox_writejudge.BackgroundImage = Properties.Resources.correct;
            }
            else
            {
                game_picbox_writejudge.BackgroundImage = Properties.Resources.wrong;
            }
            if (txt1 == name[id])
            {
                scoresp++;
                game_picbox_speakjudge.BackgroundImage = Properties.Resources.correct;
            }
            else
                game_picbox_speakjudge.BackgroundImage = Properties.Resources.wrong;     
                        
            soundplay.Play();
        }

        private void game_btn_next_Click(object sender, EventArgs e)
        {
            if (check == false)
                return;
            check = false;
            game_picbox_speakjudge.BackgroundImage = null;
            game_picbox_writejudge.BackgroundImage = null;
            soundplay.Stop();
            id++;
            if (id == 5)
            {
                this.Close();
                Result rs = new Result(scorewr + scoresp, scorewr, scoresp, begin,topic);
                rs.Show();
                return;
            }
            game_label_score.Text = ((scorewr+scoresp).ToString() + "/10");
            Visualize(name[id]);
            game_txt_write.Text = "";
            game_txt_speak.Text = "";
        }
        
        private void game_btn_mic_Click(object sender, EventArgs e)
        {
            if (record)
            {
                game_btn_mic.BackColor = Color.PeachPuff;
            }
            else
            {
                game_btn_mic.BackColor = Color.Crimson;
                SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
                recognizer.LoadGrammar(new DictationGrammar());

                recognizer.SpeechRecognized +=new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
                recognizer.SetInputToDefaultAudioDevice();
                recognizer.RecognizeAsync(RecognizeMode.Single);
            }
            record = !record;
        }

        private void game_picbox_writejudge_Click(object sender, EventArgs e)
        {

        }
        public void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            game_txt_speak.Text = e.Result.Text.ToLower();
        }
    }
}
