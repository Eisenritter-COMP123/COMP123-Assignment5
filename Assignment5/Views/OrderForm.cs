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
           ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ProductInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PlatformLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event handler for the AboutToolStripMenuItem Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ABOUT_FORM].ShowDialog();
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.PRODUCTINFO_FORM].Show();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your business.\nYour order will be processed within 7-10 business days.", "GoodBye", MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionTextBox.Text = Program.product.condition;
            PlatformTextBox.Text = Program.product.platform;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            ModelTextBox.Text = Program.product.model;

            LCDSizeContextLabel.Text = Program.product.screensize;
            MemoryContextLabel.Text = Program.product.RAM_size;
            CPUBrandContextLabel.Text = Program.product.CPU_brand;
            CPUTypeContextLabel.Text = Program.product.CPU_type;
            CPUNumberContextLabel.Text = Program.product.CPU_number;
            CPUSpeedContextLabel.Text = Program.product.CPU_speed;
            HDDContextLabel.Text = Program.product.HDD_size;
            GPUContextLabel.Text = Program.product.GPU_Type;
            WebCamContextLabel.Text = Program.product.webcam;
            OSContextLabel.Text = Program.product.OS;

            PriceContextLabel.Text = $"${Program.product.cost:f2}";
            TaxContextLabel.Text = $"${Convert.ToDouble(Program.product.cost)*0.13:f2}";
            TotalContextLabel.Text = $"${Convert.ToDouble(Program.product.cost) * 1.13:f2}";
        }

    }
}
