namespace Assignment5.Views
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.MyProductDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.HardwareText = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.TableLoadTimer = new System.Windows.Forms.Timer(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opticaldriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audiotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mousttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webcamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.BackColor = System.Drawing.Color.Black;
            this.SelectionLabel.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionLabel.ForeColor = System.Drawing.Color.White;
            this.SelectionLabel.Location = new System.Drawing.Point(603, 92);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(840, 52);
            this.SelectionLabel.TabIndex = 0;
            this.SelectionLabel.Text = "DollarComputer Hardware List";
            this.SelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectionLabel.Click += new System.EventHandler(this.SelectionLabel_Click);
            // 
            // MyProductDataGridView
            // 
            this.MyProductDataGridView.AllowUserToAddRows = false;
            this.MyProductDataGridView.AllowUserToDeleteRows = false;
            this.MyProductDataGridView.AllowUserToResizeColumns = false;
            this.MyProductDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.MyProductDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MyProductDataGridView.AutoGenerateColumns = false;
            this.MyProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MyProductDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.MyProductDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MyProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.rAMtypeDataGridViewTextBoxColumn,
            this.rAMsizeDataGridViewTextBoxColumn,
            this.displaytypeDataGridViewTextBoxColumn,
            this.screensizeDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.cPUClassDataGridViewTextBoxColumn,
            this.cPUbrandDataGridViewTextBoxColumn,
            this.cPUtypeDataGridViewTextBoxColumn,
            this.cPUspeedDataGridViewTextBoxColumn,
            this.cPUnumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.hDDsizeDataGridViewTextBoxColumn,
            this.hDDspeedDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.opticaldriveDataGridViewTextBoxColumn,
            this.audiotypeDataGridViewTextBoxColumn,
            this.lANDataGridViewTextBoxColumn,
            this.wIFIDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.mousttypeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.webcamDataGridViewTextBoxColumn});
            this.MyProductDataGridView.DataSource = this.productBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyProductDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MyProductDataGridView.GridColor = System.Drawing.Color.Black;
            this.MyProductDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MyProductDataGridView.Location = new System.Drawing.Point(14, 160);
            this.MyProductDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyProductDataGridView.MultiSelect = false;
            this.MyProductDataGridView.Name = "MyProductDataGridView";
            this.MyProductDataGridView.ReadOnly = true;
            this.MyProductDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyProductDataGridView.RowHeadersWidth = 62;
            this.MyProductDataGridView.RowTemplate.Height = 28;
            this.MyProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyProductDataGridView.Size = new System.Drawing.Size(2000, 677);
            this.MyProductDataGridView.TabIndex = 1;
            this.MyProductDataGridView.SelectionChanged += new System.EventHandler(this.MyProductDataGridView_SelectionChanged);
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.BackColor = System.Drawing.Color.Black;
            this.SelectedLabel.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedLabel.Location = new System.Drawing.Point(12, 861);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(395, 52);
            this.SelectedLabel.TabIndex = 3;
            this.SelectedLabel.Text = "Selected Parts:";
            this.SelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectedLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // HardwareText
            // 
            this.HardwareText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardwareText.Location = new System.Drawing.Point(413, 861);
            this.HardwareText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HardwareText.Name = "HardwareText";
            this.HardwareText.ReadOnly = true;
            this.HardwareText.Size = new System.Drawing.Size(1601, 48);
            this.HardwareText.TabIndex = 4;
            this.HardwareText.TextChanged += new System.EventHandler(this.HardwareText_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(1653, 928);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(173, 66);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(1850, 928);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(164, 66);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "NEXT";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // TableLoadTimer
            // 
            this.TableLoadTimer.Interval = 500;
            this.TableLoadTimer.Tick += new System.EventHandler(this.TableLoadTimer_Tick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.costDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.costDataGridViewTextBoxColumn.Width = 79;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.manufacturerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.manufacturerDataGridViewTextBoxColumn.Width = 199;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.modelDataGridViewTextBoxColumn.Width = 94;
            // 
            // rAMtypeDataGridViewTextBoxColumn
            // 
            this.rAMtypeDataGridViewTextBoxColumn.DataPropertyName = "RAM_type";
            this.rAMtypeDataGridViewTextBoxColumn.HeaderText = "RAM Type";
            this.rAMtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAMtypeDataGridViewTextBoxColumn.Name = "rAMtypeDataGridViewTextBoxColumn";
            this.rAMtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMtypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rAMtypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rAMtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // rAMsizeDataGridViewTextBoxColumn
            // 
            this.rAMsizeDataGridViewTextBoxColumn.DataPropertyName = "RAM_size";
            this.rAMsizeDataGridViewTextBoxColumn.HeaderText = "RAM Size";
            this.rAMsizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAMsizeDataGridViewTextBoxColumn.Name = "rAMsizeDataGridViewTextBoxColumn";
            this.rAMsizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMsizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rAMsizeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rAMsizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // displaytypeDataGridViewTextBoxColumn
            // 
            this.displaytypeDataGridViewTextBoxColumn.DataPropertyName = "displaytype";
            this.displaytypeDataGridViewTextBoxColumn.HeaderText = "Display Type";
            this.displaytypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.displaytypeDataGridViewTextBoxColumn.Name = "displaytypeDataGridViewTextBoxColumn";
            this.displaytypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.displaytypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.displaytypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.displaytypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // screensizeDataGridViewTextBoxColumn
            // 
            this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
            this.screensizeDataGridViewTextBoxColumn.HeaderText = "Screen Size";
            this.screensizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
            this.screensizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.screensizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.screensizeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.screensizeDataGridViewTextBoxColumn.Width = 112;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.resolutionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resolutionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.resolutionDataGridViewTextBoxColumn.Width = 169;
            // 
            // cPUClassDataGridViewTextBoxColumn
            // 
            this.cPUClassDataGridViewTextBoxColumn.DataPropertyName = "CPU_Class";
            this.cPUClassDataGridViewTextBoxColumn.HeaderText = "CPU Class";
            this.cPUClassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUClassDataGridViewTextBoxColumn.Name = "cPUClassDataGridViewTextBoxColumn";
            this.cPUClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUClassDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUClassDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUClassDataGridViewTextBoxColumn.Width = 139;
            // 
            // cPUbrandDataGridViewTextBoxColumn
            // 
            this.cPUbrandDataGridViewTextBoxColumn.DataPropertyName = "CPU_brand";
            this.cPUbrandDataGridViewTextBoxColumn.HeaderText = "CPU Brand";
            this.cPUbrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUbrandDataGridViewTextBoxColumn.Name = "cPUbrandDataGridViewTextBoxColumn";
            this.cPUbrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUbrandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUbrandDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUbrandDataGridViewTextBoxColumn.Width = 139;
            // 
            // cPUtypeDataGridViewTextBoxColumn
            // 
            this.cPUtypeDataGridViewTextBoxColumn.DataPropertyName = "CPU_type";
            this.cPUtypeDataGridViewTextBoxColumn.HeaderText = "CPU Type";
            this.cPUtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUtypeDataGridViewTextBoxColumn.Name = "cPUtypeDataGridViewTextBoxColumn";
            this.cPUtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUtypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUtypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUspeedDataGridViewTextBoxColumn
            // 
            this.cPUspeedDataGridViewTextBoxColumn.DataPropertyName = "CPU_speed";
            this.cPUspeedDataGridViewTextBoxColumn.HeaderText = "CPU Speed";
            this.cPUspeedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUspeedDataGridViewTextBoxColumn.Name = "cPUspeedDataGridViewTextBoxColumn";
            this.cPUspeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUspeedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUspeedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUspeedDataGridViewTextBoxColumn.Width = 139;
            // 
            // cPUnumberDataGridViewTextBoxColumn
            // 
            this.cPUnumberDataGridViewTextBoxColumn.DataPropertyName = "CPU_number";
            this.cPUnumberDataGridViewTextBoxColumn.HeaderText = "Number of CPUs";
            this.cPUnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUnumberDataGridViewTextBoxColumn.Name = "cPUnumberDataGridViewTextBoxColumn";
            this.cPUnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUnumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPUnumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPUnumberDataGridViewTextBoxColumn.Width = 152;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.conditionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.conditionDataGridViewTextBoxColumn.Width = 154;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.oSDataGridViewTextBoxColumn.Width = 79;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.platformDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.platformDataGridViewTextBoxColumn.Width = 139;
            // 
            // hDDsizeDataGridViewTextBoxColumn
            // 
            this.hDDsizeDataGridViewTextBoxColumn.DataPropertyName = "HDD_size";
            this.hDDsizeDataGridViewTextBoxColumn.HeaderText = "HDD Size";
            this.hDDsizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hDDsizeDataGridViewTextBoxColumn.Name = "hDDsizeDataGridViewTextBoxColumn";
            this.hDDsizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDsizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hDDsizeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hDDsizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // hDDspeedDataGridViewTextBoxColumn
            // 
            this.hDDspeedDataGridViewTextBoxColumn.DataPropertyName = "HDD_speed";
            this.hDDspeedDataGridViewTextBoxColumn.HeaderText = "HDD Speed";
            this.hDDspeedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hDDspeedDataGridViewTextBoxColumn.Name = "hDDspeedDataGridViewTextBoxColumn";
            this.hDDspeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDspeedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hDDspeedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hDDspeedDataGridViewTextBoxColumn.Width = 139;
            // 
            // gPUTypeDataGridViewTextBoxColumn
            // 
            this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPU_Type";
            this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPU Type";
            this.gPUTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
            this.gPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gPUTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gPUTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gPUTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // opticaldriveDataGridViewTextBoxColumn
            // 
            this.opticaldriveDataGridViewTextBoxColumn.DataPropertyName = "optical_drive";
            this.opticaldriveDataGridViewTextBoxColumn.HeaderText = "Optical Drive";
            this.opticaldriveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opticaldriveDataGridViewTextBoxColumn.Name = "opticaldriveDataGridViewTextBoxColumn";
            this.opticaldriveDataGridViewTextBoxColumn.ReadOnly = true;
            this.opticaldriveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.opticaldriveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.opticaldriveDataGridViewTextBoxColumn.Width = 125;
            // 
            // audiotypeDataGridViewTextBoxColumn
            // 
            this.audiotypeDataGridViewTextBoxColumn.DataPropertyName = "Audio_type";
            this.audiotypeDataGridViewTextBoxColumn.HeaderText = "Audio Type";
            this.audiotypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.audiotypeDataGridViewTextBoxColumn.Name = "audiotypeDataGridViewTextBoxColumn";
            this.audiotypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.audiotypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.audiotypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.audiotypeDataGridViewTextBoxColumn.Width = 98;
            // 
            // lANDataGridViewTextBoxColumn
            // 
            this.lANDataGridViewTextBoxColumn.DataPropertyName = "LAN";
            this.lANDataGridViewTextBoxColumn.HeaderText = "LAN";
            this.lANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lANDataGridViewTextBoxColumn.Name = "lANDataGridViewTextBoxColumn";
            this.lANDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lANDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lANDataGridViewTextBoxColumn.Width = 64;
            // 
            // wIFIDataGridViewTextBoxColumn
            // 
            this.wIFIDataGridViewTextBoxColumn.DataPropertyName = "WIFI";
            this.wIFIDataGridViewTextBoxColumn.HeaderText = "WIFI";
            this.wIFIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wIFIDataGridViewTextBoxColumn.Name = "wIFIDataGridViewTextBoxColumn";
            this.wIFIDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIFIDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wIFIDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wIFIDataGridViewTextBoxColumn.Width = 79;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.widthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.widthDataGridViewTextBoxColumn.Width = 94;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.heightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.heightDataGridViewTextBoxColumn.Width = 109;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "Depth";
            this.depthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ReadOnly = true;
            this.depthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.depthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.depthDataGridViewTextBoxColumn.Width = 94;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.weightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.weightDataGridViewTextBoxColumn.Width = 109;
            // 
            // mousttypeDataGridViewTextBoxColumn
            // 
            this.mousttypeDataGridViewTextBoxColumn.DataPropertyName = "moust_type";
            this.mousttypeDataGridViewTextBoxColumn.HeaderText = "Moust Type";
            this.mousttypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mousttypeDataGridViewTextBoxColumn.Name = "mousttypeDataGridViewTextBoxColumn";
            this.mousttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.mousttypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mousttypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mousttypeDataGridViewTextBoxColumn.Width = 98;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Power";
            this.powerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.powerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.powerDataGridViewTextBoxColumn.Width = 94;
            // 
            // webcamDataGridViewTextBoxColumn
            // 
            this.webcamDataGridViewTextBoxColumn.DataPropertyName = "webcam";
            this.webcamDataGridViewTextBoxColumn.HeaderText = "Webcam";
            this.webcamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.webcamDataGridViewTextBoxColumn.Name = "webcamDataGridViewTextBoxColumn";
            this.webcamDataGridViewTextBoxColumn.ReadOnly = true;
            this.webcamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.webcamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.webcamDataGridViewTextBoxColumn.Width = 109;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Assignment5.Models.Product);
            // 
            // SelectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Assignment5.Properties.Resources.fin_serv_tech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2026, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.HardwareText);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.MyProductDataGridView);
            this.Controls.Add(this.SelectionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            this.Activated += new System.EventHandler(this.SelectForm_Activated);
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.Enter += new System.EventHandler(this.SelectForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.MyProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.DataGridView MyProductDataGridView;
        private System.Windows.Forms.Label SelectedLabel;
        private System.Windows.Forms.TextBox HardwareText;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opticaldriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audiotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIFIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mousttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webcamDataGridViewTextBoxColumn;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Timer TableLoadTimer;
    }
}