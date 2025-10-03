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
    public partial class Tasbeh : Form
    {
        public Tasbeh()
        {
            InitializeComponent();
        }
        int count = 0;

        private void pb_1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = count.ToString();
        }

        private void pb_2_Click(object sender, EventArgs e)
        {
            count = 0;
            label1.Text = count.ToString();
        }



        int count2 = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            count2++;
            label2.Text = count2.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count2 = 0;
            label2.Text = count2.ToString();
        }




        int count3= 0;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            count3++;
            label3.Text = count3.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            count3 =0;
            label3.Text = count3.ToString();
        }




        int count4 = 0;

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            count4++;
            label4.Text = count4.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            count4 = 0;
            label4.Text = count4.ToString();
        }



        int count5 = 0;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            count5++;
            label5.Text = count5.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            count5 = 0;
            label5.Text = count5.ToString();
        }




        int count6 = 0; 
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            count6++;
            label6.Text = count6.ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            count6 = 0;
            label6.Text = count6.ToString();
        }



        int count7 = 0;
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            count7++;
            label7.Text = count7.ToString();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            count7 = 0;
            label7.Text = count7.ToString();
        }




        int count8 = 0;
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            count8++;
            label8.Text = count8.ToString();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            count8 = 0;
            label8.Text = count8.ToString();
        }
    }
}
