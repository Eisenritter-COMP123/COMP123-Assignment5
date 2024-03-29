﻿/* Created By:      George Zhou
 * Student Number:  300613283
 * Date Last Modified: August 16, 2019
 * This program gets database from store and lets customer choose their order, and proceed to save, load, and place their order
 * Revision:        1.1
 */
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
        public static bool _dataLoaded;
        public SelectForm()
        {
            InitializeComponent();
        }

        public bool HasLoadedDataSource()
        {
            return false;
        }

        /// <summary>
        /// This Button Click Event Quits the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This Button Click Event Loads the Product Info Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.PRODUCTINFO_FORM].Show();
        }

        /// <summary>
        /// This event fires when the Select form loads and loads the Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
                _dataLoaded = false;
                TableLoadTimer.Enabled = true;
                //HardwareText.Text = $"{Program.product.manufacturer}-{Program.product.model}\t${Program.product.cost:f2}";

            }
            //Set initial selection to null

            //Do not select any data when first load
            MyProductDataGridView.CurrentCell.Selected=false;
        }

        /// <summary>
        /// This Event fires whenever the user changes their selction on the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Run this function only if the data is loaded
            if (_dataLoaded)
            {
                // local scope aliase
                var rowIndex = MyProductDataGridView.CurrentCell.RowIndex;
                var rows = MyProductDataGridView.Rows;
                //var columnCount = MyProductDataGridView.ColumnCount;
                var cells = rows[rowIndex].Cells;

                rows[rowIndex].Selected = true;

                //Save the product info to memory
                SaveProductToMemory(cells);

                HardwareText.Text = $"{Program.product.manufacturer} - {Program.product.model} \t Price: {Convert.ToDouble(Program.product.cost.ToString()):C2}";
            }
        }

        //This function sets the product property values
        private static void SaveProductToMemory(DataGridViewCellCollection cells)
        {
            Program.product.productID = short.Parse(cells[(int)Computer.ID].Value.ToString());
            Program.product.cost = decimal.Parse(cells[(int)Computer.COST].Value.ToString());
            Program.product.model = cells[(int)Computer.MODEL].Value.ToString();
            Program.product.RAM_type = cells[(int)Computer.RAM_TYPE].Value.ToString();
            Program.product.RAM_size = cells[(int)Computer.RAM_SIZE].Value.ToString();
            Program.product.displaytype = cells[(int)Computer.DISPLAYTYPE].Value.ToString();
            Program.product.screensize = cells[(int)Computer.SCREENSIZE].Value.ToString();
            Program.product.resolution = cells[(int)Computer.RESOLUTION].Value.ToString();
            Program.product.CPU_Class = cells[(int)Computer.CPU_CLASS].Value.ToString();
            Program.product.CPU_brand = cells[(int)Computer.CPU_BRAND].Value.ToString();
            Program.product.CPU_type = cells[(int)Computer.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = cells[(int)Computer.CPU_SPEED].Value.ToString();
            Program.product.condition = cells[(int)Computer.CONDITION].Value.ToString();
            Program.product.OS = cells[(int)Computer.OS].Value.ToString();
            Program.product.platform = cells[(int)Computer.PLATFORM].Value.ToString();
            Program.product.HDD_size = cells[(int)Computer.HDD_SIZE].Value.ToString();
            Program.product.GPU_Type = cells[(int)Computer.GPU_TYPE].Value.ToString();
            Program.product.optical_drive = cells[(int)Computer.OPTICAL_DRIVE].Value.ToString();
            Program.product.Audio_type = cells[(int)Computer.AUDIO_TYPE].Value.ToString();
            Program.product.LAN = cells[(int)Computer.LAN].Value.ToString();
            Program.product.WIFI = cells[(int)Computer.WIFI].Value.ToString();
            Program.product.width = cells[(int)Computer.WIDTH].Value.ToString();
            Program.product.height = cells[(int)Computer.HEIGHT].Value.ToString();
            Program.product.depth = cells[(int)Computer.DEPTH].Value.ToString();
            Program.product.weight = cells[(int)Computer.WEIGHT].Value.ToString();
            Program.product.moust_type = cells[(int)Computer.MOUST_TYPE].Value.ToString();
            Program.product.power = cells[(int)Computer.POWER].Value.ToString();
            Program.product.webcam = cells[(int)Computer.WEBCAM].Value.ToString();
            Program.product.manufacturer = cells[(int)Computer.MANUFACTURER].Value.ToString();
            Program.product.CPU_number = cells[(int)Computer.CPU_NUMBER].Value.ToString();
        }

        /// <summary>
        /// This Timer lets the data to be loaded first before change selection to avoid problem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableLoadTimer_Tick(object sender, EventArgs e)
        {
            TableLoadTimer.Enabled = false;
            _dataLoaded = true;
        }

        /// <summary>
        /// When the Text of this text box is changed, it allows user to click the next button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HardwareText_TextChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
        }

    }
    }
