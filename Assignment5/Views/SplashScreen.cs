/* Created By:      George Zhou
 * Student Number:  300613283
 * Date Last Modified: August 16, 2019
 * This program gets database from store and lets customer choose their order, and proceed to save, load, and place their order
 * Revision:        1.1
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When splash screen loads, enable the splash timers and progress bar timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            ProgressTimer.Enabled = true;
        }

        /// <summary>
        /// When splash timer ticks, loads start form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            ProgressTimer.Enabled = false;
            this.Hide();
            Program.Forms[FormNames.START_FORM].Show();
        }

        /// <summary>
        /// When progress timer ticks, increase the progress bar progress until its at 100%
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (SplashProgressBar.Value < 100)
            {
                SplashProgressBar.Value += 5;
            }
        }
    }
}
