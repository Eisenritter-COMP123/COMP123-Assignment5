using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            ProgressTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            ProgressTimer.Enabled = false;
            this.Hide();
            Program.Forms[FormNames.START_FORM].Show();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (SplashProgressBar.Value < 100)
            {
                SplashProgressBar.Value += 5;
            }
        }
    }
}
