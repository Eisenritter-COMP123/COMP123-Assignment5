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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.SELECT_FORM].Show();
        }

        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.PRODUCTINFO_FORM].Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
