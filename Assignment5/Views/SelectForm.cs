using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5.Models;

namespace Assignment5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.PRODUCTINFO_FORM].Show();
        }

        private void SelectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }
    }
}
