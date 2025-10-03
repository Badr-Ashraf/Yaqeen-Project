using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void LoadFormInPanel(Form frm)
        {
            frm.TopLevel = false;              // يخلي الفورم يشتغل كـ Control مش نافذة مستقلة
            frm.FormBorderStyle = FormBorderStyle.None; // يشيل الشريط والكورنرات
            frm.Dock = DockStyle.Fill;         // يملأ البانل بالكامل
            panel1.Controls.Clear();           // يمسح أي محتوى قديم من البانل
            panel1.Controls.Add(frm);          // يضيف الفورم الجديد جوا البانل
            frm.Show();                        // يعرضه
        }

        private void SetRoundedCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // top-left arc
            path.AddArc(0, 0, radius, radius, 180, 90);
            // top-right arc
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            // bottom-right arc
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            // bottom-left arc
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void pbExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void MOuse_Down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0); // 0xA1 = WM_NCLBUTTONDOWN, 0x2 = HTCAPTION
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;   // شيل الشريط والحدود
            SetRoundedCorners(30);

            HomeScreen home = new HomeScreen();
            LoadFormInPanel(home);


        }

        private void Show_HomeScreen_Click(object sender, MouseEventArgs e)
        {
            HomeScreen home = new HomeScreen();
            LoadFormInPanel(home);
        }

     
        private void Show_Prayers_Screen(object sender, MouseEventArgs e)
        {
            Prayer_times frm = new Prayer_times();
            LoadFormInPanel(frm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Azkar azkar = new Azkar();
            LoadFormInPanel(azkar);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Tasbeh fr = new Tasbeh();
            LoadFormInPanel(fr);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Quran fr = new Quran();
            LoadFormInPanel(fr);
        }
    }
}
