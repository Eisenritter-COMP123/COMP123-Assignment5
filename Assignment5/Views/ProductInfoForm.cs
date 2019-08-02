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
            LoadDatatoTextBox();
        }

        private void LoadDatatoTextBox()
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
                    //Write to File
                     outputStream.WriteLine(Program.product.productID         );
                     outputStream.WriteLine(Program.product.cost              );
                     outputStream.WriteLine(Program.product.model             );
                     outputStream.WriteLine(Program.product.RAM_type          );
                     outputStream.WriteLine(Program.product.RAM_size          );
                     outputStream.WriteLine(Program.product.displaytype       );
                     outputStream.WriteLine(Program.product.screensize        );
                     outputStream.WriteLine(Program.product.resolution        );
                     outputStream.WriteLine(Program.product.CPU_Class         );
                     outputStream.WriteLine(Program.product.CPU_brand         );
                     outputStream.WriteLine(Program.product.CPU_type          );
                     outputStream.WriteLine(Program.product.CPU_speed         );
                     outputStream.WriteLine(Program.product.condition         );
                     outputStream.WriteLine(Program.product.OS                );
                     outputStream.WriteLine(Program.product.platform          );
                     outputStream.WriteLine(Program.product.HDD_size          );
                     outputStream.WriteLine(Program.product.GPU_Type          );
                     outputStream.WriteLine(Program.product.optical_drive     );
                     outputStream.WriteLine(Program.product.Audio_type        );
                     outputStream.WriteLine(Program.product.LAN               );
                     outputStream.WriteLine(Program.product.WIFI              );
                     outputStream.WriteLine(Program.product.width             );
                     outputStream.WriteLine(Program.product.height            );
                     outputStream.WriteLine(Program.product.depth             );
                     outputStream.WriteLine(Program.product.weight            );
                     outputStream.WriteLine(Program.product.moust_type        );
                     outputStream.WriteLine(Program.product.power             );
                     outputStream.WriteLine(Program.product.webcam            );
                     outputStream.WriteLine(Program.product.manufacturer      );
                     outputStream.WriteLine(Program.product.CPU_number);
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
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost=decimal.Parse(inputStream.ReadLine());
                        Program.product.model=inputStream.ReadLine();
                        Program.product.RAM_type=inputStream.ReadLine();
                        Program.product.RAM_size=inputStream.ReadLine();
                        Program.product.displaytype=inputStream.ReadLine();
                        Program.product.screensize=inputStream.ReadLine();
                        Program.product.resolution=inputStream.ReadLine();
                        Program.product.CPU_Class=inputStream.ReadLine();
                        Program.product.CPU_brand=inputStream.ReadLine();
                        Program.product.CPU_type=inputStream.ReadLine();
                        Program.product.CPU_speed=inputStream.ReadLine();
                        Program.product.condition=inputStream.ReadLine();
                        Program.product.OS=inputStream.ReadLine();
                        Program.product.platform=inputStream.ReadLine();
                        Program.product.HDD_size=inputStream.ReadLine();
                        Program.product.GPU_Type=inputStream.ReadLine();
                        Program.product.optical_drive=inputStream.ReadLine();
                        Program.product.Audio_type=inputStream.ReadLine();
                        Program.product.LAN=inputStream.ReadLine();
                        Program.product.WIFI=inputStream.ReadLine();
                        Program.product.width=inputStream.ReadLine();
                        Program.product.height=inputStream.ReadLine();
                        Program.product.depth=inputStream.ReadLine();
                        Program.product.weight=inputStream.ReadLine();
                        Program.product.moust_type=inputStream.ReadLine();
                        Program.product.power=inputStream.ReadLine();
                        Program.product.webcam=inputStream.ReadLine();
                        Program.product.manufacturer=inputStream.ReadLine();
                        Program.product.CPU_number=inputStream.ReadLine();
                        //Clean up
                        inputStream.Close();
                        inputStream.Dispose();
                        LoadDatatoTextBox();
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
