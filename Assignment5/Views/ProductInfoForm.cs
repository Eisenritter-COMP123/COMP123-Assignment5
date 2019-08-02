using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            ProductInfoSaveFileDialog.FileName = "Product.txt";
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files{*.*)|*.*";

            //open the file dialog
            var result = ProductInfoSaveFileDialog.ShowDialog();
            if(result != DialogResult.Cancel)
            {
                //open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(File.Open(ProductInfoSaveFileDialog.FileName, FileMode.Create)))
                {
                    //writing all text box string to the file
                    foreach (Control c in this.ProductInfoTableLayoutPanel.Controls)
                    {
                        if (c is TextBox)
                        {
                            outputStream.WriteLine(((TextBox)c).Text);
                        }
                    }
                    foreach (Control c in this.TechSpecsTableLayoutMenu.Controls)
                    {
                        if (c is TextBox)
                        {
                            outputStream.WriteLine(((TextBox)c).Text);
                        }
                    }
                    foreach (Control c in this.GeneralInfoTableLayoutPanel.Controls)
                    {
                        if (c is TextBox)
                        {
                            outputStream.WriteLine(((TextBox)c).Text);
                        }
                    }
                    //cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    //Give feedback to the user that the file has been saved
                    MessageBox.Show("File Saved...", "Saving File...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

           
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            ProductInfoOpenFileDialog.FileName = "Product.txt";
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files{*.*)|*.*";

            //open the file dialog
            var result = ProductInfoOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //Open the stream for reading
                    using (StreamReader inputStream = new StreamReader(File.Open(ProductInfoOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Read from file
                        foreach (Control c in this.ProductInfoTableLayoutPanel.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = inputStream.ReadLine();
                            }
                        }
                        foreach (Control c in this.TechSpecsTableLayoutMenu.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = inputStream.ReadLine();
                            }
                        }
                        foreach (Control c in this.GeneralInfoTableLayoutPanel.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = inputStream.ReadLine();
                            }
                        }
                        //Clean up
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SelectAnotherButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.SELECT_FORM].Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.ORDER_FORM].Show();
        }
    }
}
