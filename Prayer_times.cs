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
    public partial class Prayer_times : Form
    {
        public Prayer_times()
        {
            InitializeComponent();
        }

         
        private void Time_Now(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss tt");
            The_Coming_Prayer();
            Message_Prayer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Message_Prayer()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;

            TimeSpan fajr = new TimeSpan(5, 16, 0);
            TimeSpan duhr = new TimeSpan(12, 46, 0);
            TimeSpan asr = new TimeSpan(16, 14, 0);
            TimeSpan maghrib = new TimeSpan(18, 52, 0);
            TimeSpan isha = new TimeSpan(20, 07, 0);

            if (now.Hours ==  fajr.Hours && now.Minutes == fajr.Minutes)
            {

                Notify_Prayer("الفجر");
                return;
            }
            if (now.Hours == duhr.Hours && now.Minutes == duhr.Minutes)
            {

                Notify_Prayer("الظهر");
             
                return;
            }
            if (now.Hours == asr.Hours && now.Minutes == asr.Minutes)
            {
                Notify_Prayer("العصر");
                return;
            }
            if (now.Hours == maghrib.Hours && now.Minutes == maghrib.Minutes)
            {
                Notify_Prayer("المغرب");
                return;
            }
            if (now.Hours == isha.Hours && now.Minutes == isha.Minutes)
            {
                Notify_Prayer("العشاء");
                return;
            }

        }
         
        private void  Notify_Prayer(string textt)
        {

            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = textt;
            notifyIcon1.BalloonTipText = textt+" حان الآن وقت أذان";
            notifyIcon1.Visible = true;   // مهم يتشاف في التراي
            notifyIcon1.ShowBalloonTip(4000);  // الرقم = المدة بالـ ms (هنا 4 ثواني)



        }

        private void The_Coming_Prayer()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;

            TimeSpan fajr = new TimeSpan(5, 16, 0);
            TimeSpan duhr = new TimeSpan(12, 46, 0);
            TimeSpan asr = new TimeSpan(16, 14, 0);
            TimeSpan maghrib = new TimeSpan(18, 52, 0);
            TimeSpan isha = new TimeSpan(20, 07, 0);

            if (now < fajr)
            {
                label9.Text = "الفجر";
                return;
            }
            if (now < duhr)
            {
                label9.Text = "الظهر";
                return;
            }
            if (now < asr)
            {
                label9.Text = "العصر";
                return;
            }
            if (now < maghrib)
            {
                label9.Text = "المغرب";
                return;
            }
            if (now < isha)
            {
                label9.Text = "العشاء";
                return;
            }

            // لو الوقت عدى العشاء يبقى الصلاة القادمة هي الفجر (اليوم الجديد)
            label9.Text = "الفجر";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
