using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Project
{
    public partial class Azkar : Form
    {
        public Azkar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            p_Sleep.Visible = false;
        }
        private void PB_Night_Click(object sender, MouseEventArgs e)
        {
            p_night.Visible = false;
        }
        private void PB_Morning_Click(object sender, MouseEventArgs e)
        {
            p_morning.Visible = false;
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text;
        }

        private void Azkar_Load(object sender, EventArgs e)
        {
            p_Sleep.Visible = false;
            p_night.Visible = false;
            p_morning.Visible = false;
            P_Dua.Visible = false;
            p_ِAfterPrayer.Visible = false;
            p_prayer.Visible = false;
        }




        private void btn_Sleep_Click(object sender, EventArgs e)
        {
            p_Sleep.Visible=true;
            p_night.Visible = false;
            p_morning.Visible = false;
            P_Dua.Visible = false;
            p_ِAfterPrayer.Visible = false;
            p_prayer.Visible = false;
        }
        private void btn_night_Click(object sender, EventArgs e)
        {
            p_night.Visible = true;
            p_Sleep.Visible = false;
            p_morning.Visible = false;
            P_Dua.Visible = false;
            p_ِAfterPrayer.Visible = false;
            p_prayer.Visible = false;
        }
        private void btn_morning_Click(object sender, EventArgs e)
        {
            p_morning.Visible = true;
            p_night.Visible = false;
            p_Sleep.Visible = false;
            p_ِAfterPrayer.Visible = false;
            P_Dua.Visible = false;
            p_prayer.Visible = false;
        }


        private void btn_Dua_Cliack(object sender, MouseEventArgs e)
        {
            P_Dua.Visible = true;
            p_morning.Visible = false;
            p_night.Visible = false;
            p_Sleep.Visible = false;
            p_ِAfterPrayer.Visible = false;
            p_prayer.Visible = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            P_Dua.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p_ِAfterPrayer.Visible = true;
            P_Dua.Visible = false;
            p_morning.Visible = false;
            p_night.Visible = false;
            p_Sleep.Visible = false;
            p_prayer.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            p_ِAfterPrayer.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            p_prayer.Visible=false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p_prayer.Visible = true;
            p_ِAfterPrayer.Visible = false;
            P_Dua.Visible = false;
            p_morning.Visible = false;
            p_night.Visible = false;
            p_Sleep.Visible = false;
        }

        private void p_ِAfterPrayer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
