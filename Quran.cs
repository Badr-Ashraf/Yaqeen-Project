using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Practice_Project
{
    public partial class Quran : Form
    {
        public Quran()
        {
            InitializeComponent();
        }



        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;


          private void  Play_Surah (string  surah){
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                audioFile = new AudioFileReader(surah);
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
          }
         private void Pause_Surah()
        {
            if (outputDevice != null)
            {
                outputDevice.Pause(); // يوقف مؤقتًا
            }
        }



        private void btn_elnas_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\abdelbasset-abdessamad-114-an-nas-703-1615\abdelbasset-abdessamad-114-an-nas-703-1615.mp3");
        }

        private void pause_elnas(object sender, MouseEventArgs e)
        {
            Pause_Surah();
        }

        private void btn_Alfalq_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Desktop\Combo\113.mp3");
        }

        private void pause_Alfalq_Click(object sender, EventArgs e)
        {
            Pause_Surah();
        }

        private void btn_Ele5las_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\112.mp3");
        }

        private void pb_Ele5las_Click(object sender, EventArgs e)
        {
            Pause_Surah();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\111.mp3");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pause_Surah();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\110.mp3");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\109.mp3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\108.mp3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\107.mp3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\106.mp3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\105.mp3");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\104.mp3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\103.mp3");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\102.mp3");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\101.mp3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\100 (1).mp3");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\099.mp3");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\098.mp3");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\097.mp3");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\096.mp3");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\095.mp3");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\094.mp3");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\093.mp3");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\092.mp3");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\091.mp3");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\090.mp3");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\089.mp3");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\088.mp3"); 
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\087.mp3");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\086.mp3");

        }

        private void button27_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\085.mp3");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\084.mp3");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\083.mp3");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\082.mp3");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\081.mp3");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\080.mp3");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\079.mp3");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\078.mp3");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\077.mp3");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\076.mp3");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Play_Surah(@"C:\Users\bebo\Downloads\075.mp3");
        }
    }
}
