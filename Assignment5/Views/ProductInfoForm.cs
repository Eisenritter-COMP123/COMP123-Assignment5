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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void PIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void PIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            PIDTextBox.Text = Program.product.productID.ToString();
            ConditionTextBox.Text = Program.product.condition;
            CostTextbox.Text = $"${Program.product.cost:F2}";
            PlatformTextBox.Text = Program.product.platform;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            OSTextBox.Text = Program.product.OS;
            ModelTextBox.Text = Program.product.model;
            MemoryTextBox.Text = Program.product.RAM_size;
            CPUBrandTextBox.Text = Program.product.CPU_brand;
            CPUTypeTextBox.Text = Program.product.CPU_type;
            LCDSizeTextBox.Text = Program.product.screensize;
            CPUNumberTextBox.Text = Program.product.CPU_number;
            CPUClockTextBox.Text = Program.product.CPU_speed;
            HDDTextBox.Text = Program.product.HDD_size;
            GPUTypeTextBox.Text = Program.product.GPU_Type;
            WebCamTextBox.Text = Program.product.webcam;
        }
    }
}
