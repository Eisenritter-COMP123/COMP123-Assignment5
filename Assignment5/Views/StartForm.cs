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
using System.IO;

namespace Assignment5.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Button Click Event loads the select order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.SELECT_FORM].Show();
        }

        /// <summary>
        /// This Button Click Event opens file dialog and loads the proper user defined text file, then it proceed to open the product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            StartFormOpenFileDialog.FileName = "Product.txt";
            StartFormOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StartFormOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files{*.*)|*.*";

            //open the file dialog
            var result = StartFormOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //Open the stream for reading
                    using (StreamReader inputStream = new StreamReader(File.Open(StartFormOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Read from file
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_type = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.displaytype = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.resolution = inputStream.ReadLine();
                        Program.product.CPU_Class = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.optical_drive = inputStream.ReadLine();
                        Program.product.Audio_type = inputStream.ReadLine();
                        Program.product.LAN = inputStream.ReadLine();
                        Program.product.WIFI = inputStream.ReadLine();
                        Program.product.width = inputStream.ReadLine();
                        Program.product.height = inputStream.ReadLine();
                        Program.product.depth = inputStream.ReadLine();
                        Program.product.weight = inputStream.ReadLine();
                        Program.product.moust_type = inputStream.ReadLine();
                        Program.product.power = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
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
            this.Hide();
            Program.Forms[FormNames.PRODUCTINFO_FORM].Show();
               
        }

        /// <summary>
        /// Quit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
