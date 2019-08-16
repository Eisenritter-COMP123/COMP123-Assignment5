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
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// This is the Order From
/// </summary>
namespace Assignment5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        //Creating a Bitmap list of Images
        List<Bitmap> pictures = new List<Bitmap>();

        //This method load the bitmap pictures into picture list
        private void LoadPictures()
        {
            pictures.Add(Properties.Resources.PCIndex1);
            pictures.Add(Properties.Resources.PCIndex2);
            pictures.Add(Properties.Resources.PCIndex3);
            pictures.Add(Properties.Resources.PCIndex4);
            pictures.Add(Properties.Resources.PCIndex5);
            pictures.Add(Properties.Resources.PCIndex6);
            pictures.Add(Properties.Resources.PCIndex7);
            pictures.Add(Properties.Resources.PCIndex8);
            pictures.Add(Properties.Resources.PCIndex9);
            pictures.Add(Properties.Resources.PCIndex10);
            pictures.Add(Properties.Resources.PCIndex11);
            pictures.Add(Properties.Resources.PCIndex12);
            pictures.Add(Properties.Resources.PCIndex13);
            pictures.Add(Properties.Resources.PCIndex14);
            pictures.Add(Properties.Resources.PCIndex15);
            pictures.Add(Properties.Resources.PCIndex16);
            pictures.Add(Properties.Resources.PCIndex17);
            pictures.Add(Properties.Resources.PCIndex18);
            pictures.Add(Properties.Resources.PCIndex19);
            pictures.Add(Properties.Resources.PCIndex20);
            pictures.Add(Properties.Resources.PCIndex21);
            pictures.Add(Properties.Resources.PCIndex22);
        }

        /// <summary>
        /// This function displays print preview and allows printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        /// <summary>
        /// Quit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        /// <summary>
        /// This is the event handler for the BackToolStripMenuItem Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.PRODUCTINFO_FORM].Show();
        }

        /// <summary>
        /// This is the event handler for the Finish Button click event, displays a message through message box then proceed to quit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your business.\nYour order will be processed within 7-10 business days.", "GoodBye", MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();
        }

        /// <summary>
        /// This event fires whenever this form Loads, It loads the product values into each corresponding textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            PriceContextLabel.Text = $"{Program.product.cost:c2}";

            //Calculating tax and total tax using cost and format them into 2 decimal Currency
            TaxContextLabel.Text = $"{Convert.ToDouble(Program.product.cost)*0.13:c2}";
            TotalContextLabel.Text = $"{Convert.ToDouble(Program.product.cost) * 1.13:c2}";

            //Clear the picture list
            pictures.Clear();
            //Load in the pictures
            LoadPictures();

            //Load image
            PCPictureBox.Image = pictures[Program.product.productID-1];

        }

    }
}
