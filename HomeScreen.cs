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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void FacebookLogo_Click(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/share/1APdj4fpME/");
        }

        private void Linkedin_logo_click(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/saqr-ashraf-664643312/");
        }

        private void github_click(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Badr-Ashraf");
        }
    }
}
