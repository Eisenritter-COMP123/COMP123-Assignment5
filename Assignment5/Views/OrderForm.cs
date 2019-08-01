using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PlatformLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
