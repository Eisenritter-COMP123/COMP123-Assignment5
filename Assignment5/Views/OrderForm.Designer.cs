namespace Assignment5.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.SystemComponentsPart2GroupBox = new System.Windows.Forms.GroupBox();
            this.ComponentPart2TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OSContextLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GPUContextLabel = new System.Windows.Forms.Label();
            this.HDDContextLabel = new System.Windows.Forms.Label();
            this.CPUSpeedContextLabel = new System.Windows.Forms.Label();
            this.CPUNumberContextLabel = new System.Windows.Forms.Label();
            this.CPUTypeContextLabel = new System.Windows.Forms.Label();
            this.CPUBrandContextLabel = new System.Windows.Forms.Label();
            this.MemoryContextLabel = new System.Windows.Forms.Label();
            this.LCDSizeContextLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.DividerPictureBox = new System.Windows.Forms.PictureBox();
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.ProductInfoTableLayoutPanel.SuspendLayout();
            this.SystemComponentsPart2GroupBox.SuspendLayout();
            this.ComponentPart2TableLayoutPanel.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DividerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            this.OrderFormMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(2026, 35);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SystemComponentsGroupBox.Controls.Add(this.ProductInfoTableLayoutPanel);
            this.SystemComponentsGroupBox.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.SystemComponentsGroupBox.ForeColor = System.Drawing.Color.White;
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(12, 54);
            this.SystemComponentsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(1000, 171);
            this.SystemComponentsGroupBox.TabIndex = 3;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // ProductInfoTableLayoutPanel
            // 
            this.ProductInfoTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProductInfoTableLayoutPanel.ColumnCount = 4;
            this.ProductInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22202F));
            this.ProductInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77706F));
            this.ProductInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22202F));
            this.ProductInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77891F));
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ModelTextBox, 3, 1);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ModelLabel, 2, 1);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.OSTextBox, 1, 0);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.PlatformLabel, 2, 0);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ManufacturerLabel, 0, 1);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ManufacturerTextBox, 1, 1);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ConditionLabel, 0, 0);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.PlatformTextBox, 3, 0);
            this.ProductInfoTableLayoutPanel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.ProductInfoTableLayoutPanel.Location = new System.Drawing.Point(12, 64);
            this.ProductInfoTableLayoutPanel.Name = "ProductInfoTableLayoutPanel";
            this.ProductInfoTableLayoutPanel.RowCount = 2;
            this.ProductInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProductInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProductInfoTableLayoutPanel.Size = new System.Drawing.Size(982, 100);
            this.ProductInfoTableLayoutPanel.TabIndex = 6;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.ModelTextBox.Location = new System.Drawing.Point(711, 57);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(268, 36);
            this.ModelTextBox.TabIndex = 5;
            // 
            // ModelLabel
            // 
            this.ModelLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModelLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.ModelLabel.ForeColor = System.Drawing.Color.White;
            this.ModelLabel.Location = new System.Drawing.Point(493, 50);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(212, 50);
            this.ModelLabel.TabIndex = 4;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OSTextBox.Enabled = false;
            this.OSTextBox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.OSTextBox.Location = new System.Drawing.Point(221, 7);
            this.OSTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(266, 36);
            this.OSTextBox.TabIndex = 5;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlatformLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.PlatformLabel.ForeColor = System.Drawing.Color.White;
            this.PlatformLabel.Location = new System.Drawing.Point(493, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(212, 50);
            this.PlatformLabel.TabIndex = 4;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlatformLabel.Click += new System.EventHandler(this.PlatformLabel_Click);
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.ManufacturerLabel.ForeColor = System.Drawing.Color.White;
            this.ManufacturerLabel.Location = new System.Drawing.Point(3, 50);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(212, 50);
            this.ManufacturerLabel.TabIndex = 4;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManufacturerTextBox.Enabled = false;
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.ManufacturerTextBox.Location = new System.Drawing.Point(221, 57);
            this.ManufacturerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(266, 36);
            this.ManufacturerTextBox.TabIndex = 5;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConditionLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.ConditionLabel.ForeColor = System.Drawing.Color.White;
            this.ConditionLabel.Location = new System.Drawing.Point(3, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(212, 50);
            this.ConditionLabel.TabIndex = 4;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.PlatformTextBox.Location = new System.Drawing.Point(711, 7);
            this.PlatformTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(268, 36);
            this.PlatformTextBox.TabIndex = 5;
            // 
            // SystemComponentsPart2GroupBox
            // 
            this.SystemComponentsPart2GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SystemComponentsPart2GroupBox.Controls.Add(this.ComponentPart2TableLayoutPanel);
            this.SystemComponentsPart2GroupBox.Location = new System.Drawing.Point(12, 232);
            this.SystemComponentsPart2GroupBox.Name = "SystemComponentsPart2GroupBox";
            this.SystemComponentsPart2GroupBox.Size = new System.Drawing.Size(1000, 789);
            this.SystemComponentsPart2GroupBox.TabIndex = 4;
            this.SystemComponentsPart2GroupBox.TabStop = false;
            // 
            // ComponentPart2TableLayoutPanel
            // 
            this.ComponentPart2TableLayoutPanel.ColumnCount = 2;
            this.ComponentPart2TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.ComponentPart2TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.OSContextLabel, 1, 9);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.label8, 1, 8);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.GPUContextLabel, 1, 7);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.HDDContextLabel, 1, 6);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.CPUSpeedContextLabel, 1, 5);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.CPUNumberContextLabel, 1, 4);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.CPUTypeContextLabel, 1, 3);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.CPUBrandContextLabel, 1, 2);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.MemoryContextLabel, 1, 1);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.LCDSizeContextLabel, 1, 0);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.MemoryLabel, 0, 1);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.CPUBrandLabel, 0, 2);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.CPUTypeLabel, 0, 3);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.CPUNumberLabel, 0, 4);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.CPUSpeedLabel, 0, 5);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.HDDLabel, 0, 6);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.GPULabel, 0, 7);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.WebCamLabel, 0, 8);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.OSLabel, 0, 9);
            this.ComponentPart2TableLayoutPanel.Controls.Add(this.LCDSizeLabel, 0, 0);
            this.ComponentPart2TableLayoutPanel.Location = new System.Drawing.Point(12, 34);
            this.ComponentPart2TableLayoutPanel.Name = "ComponentPart2TableLayoutPanel";
            this.ComponentPart2TableLayoutPanel.RowCount = 10;
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ComponentPart2TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComponentPart2TableLayoutPanel.Size = new System.Drawing.Size(979, 729);
            this.ComponentPart2TableLayoutPanel.TabIndex = 0;
            // 
            // OSContextLabel
            // 
            this.OSContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.OSContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.OSContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.OSContextLabel.Location = new System.Drawing.Point(228, 648);
            this.OSContextLabel.Name = "OSContextLabel";
            this.OSContextLabel.Size = new System.Drawing.Size(748, 72);
            this.OSContextLabel.TabIndex = 24;
            this.OSContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label8.Location = new System.Drawing.Point(228, 576);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(748, 72);
            this.label8.TabIndex = 23;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUContextLabel
            // 
            this.GPUContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPUContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.GPUContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.GPUContextLabel.Location = new System.Drawing.Point(228, 504);
            this.GPUContextLabel.Name = "GPUContextLabel";
            this.GPUContextLabel.Size = new System.Drawing.Size(748, 72);
            this.GPUContextLabel.TabIndex = 22;
            this.GPUContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDContextLabel
            // 
            this.HDDContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.HDDContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.HDDContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.HDDContextLabel.Location = new System.Drawing.Point(228, 432);
            this.HDDContextLabel.Name = "HDDContextLabel";
            this.HDDContextLabel.Size = new System.Drawing.Size(748, 72);
            this.HDDContextLabel.TabIndex = 21;
            this.HDDContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedContextLabel
            // 
            this.CPUSpeedContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUSpeedContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.CPUSpeedContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.CPUSpeedContextLabel.Location = new System.Drawing.Point(228, 360);
            this.CPUSpeedContextLabel.Name = "CPUSpeedContextLabel";
            this.CPUSpeedContextLabel.Size = new System.Drawing.Size(748, 72);
            this.CPUSpeedContextLabel.TabIndex = 20;
            this.CPUSpeedContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberContextLabel
            // 
            this.CPUNumberContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUNumberContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.CPUNumberContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.CPUNumberContextLabel.Location = new System.Drawing.Point(228, 288);
            this.CPUNumberContextLabel.Name = "CPUNumberContextLabel";
            this.CPUNumberContextLabel.Size = new System.Drawing.Size(748, 72);
            this.CPUNumberContextLabel.TabIndex = 19;
            this.CPUNumberContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeContextLabel
            // 
            this.CPUTypeContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUTypeContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.CPUTypeContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.CPUTypeContextLabel.Location = new System.Drawing.Point(228, 216);
            this.CPUTypeContextLabel.Name = "CPUTypeContextLabel";
            this.CPUTypeContextLabel.Size = new System.Drawing.Size(748, 72);
            this.CPUTypeContextLabel.TabIndex = 18;
            this.CPUTypeContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUBrandContextLabel
            // 
            this.CPUBrandContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUBrandContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.CPUBrandContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.CPUBrandContextLabel.Location = new System.Drawing.Point(228, 144);
            this.CPUBrandContextLabel.Name = "CPUBrandContextLabel";
            this.CPUBrandContextLabel.Size = new System.Drawing.Size(748, 72);
            this.CPUBrandContextLabel.TabIndex = 17;
            this.CPUBrandContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryContextLabel
            // 
            this.MemoryContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.MemoryContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.MemoryContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.MemoryContextLabel.Location = new System.Drawing.Point(228, 72);
            this.MemoryContextLabel.Name = "MemoryContextLabel";
            this.MemoryContextLabel.Size = new System.Drawing.Size(748, 72);
            this.MemoryContextLabel.TabIndex = 16;
            this.MemoryContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCDSizeContextLabel
            // 
            this.LCDSizeContextLabel.BackColor = System.Drawing.Color.Transparent;
            this.LCDSizeContextLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.LCDSizeContextLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LCDSizeContextLabel.Location = new System.Drawing.Point(228, 0);
            this.LCDSizeContextLabel.Name = "LCDSizeContextLabel";
            this.LCDSizeContextLabel.Size = new System.Drawing.Size(748, 72);
            this.LCDSizeContextLabel.TabIndex = 15;
            this.LCDSizeContextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.MemoryLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.MemoryLabel.ForeColor = System.Drawing.Color.White;
            this.MemoryLabel.Location = new System.Drawing.Point(3, 72);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(219, 72);
            this.MemoryLabel.TabIndex = 6;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.CPUBrandLabel.ForeColor = System.Drawing.Color.White;
            this.CPUBrandLabel.Location = new System.Drawing.Point(3, 144);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(219, 72);
            this.CPUBrandLabel.TabIndex = 7;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.CPUTypeLabel.ForeColor = System.Drawing.Color.White;
            this.CPUTypeLabel.Location = new System.Drawing.Point(3, 216);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(219, 72);
            this.CPUTypeLabel.TabIndex = 8;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.CPUNumberLabel.ForeColor = System.Drawing.Color.White;
            this.CPUNumberLabel.Location = new System.Drawing.Point(3, 288);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(219, 72);
            this.CPUNumberLabel.TabIndex = 9;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.CPUSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(3, 360);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(219, 72);
            this.CPUSpeedLabel.TabIndex = 10;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.BackColor = System.Drawing.Color.Transparent;
            this.HDDLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.HDDLabel.ForeColor = System.Drawing.Color.White;
            this.HDDLabel.Location = new System.Drawing.Point(3, 432);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(219, 72);
            this.HDDLabel.TabIndex = 11;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPULabel
            // 
            this.GPULabel.BackColor = System.Drawing.Color.Transparent;
            this.GPULabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.GPULabel.ForeColor = System.Drawing.Color.White;
            this.GPULabel.Location = new System.Drawing.Point(3, 504);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(219, 72);
            this.GPULabel.TabIndex = 12;
            this.GPULabel.Text = "GPU Type";
            this.GPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.BackColor = System.Drawing.Color.Transparent;
            this.WebCamLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.WebCamLabel.ForeColor = System.Drawing.Color.White;
            this.WebCamLabel.Location = new System.Drawing.Point(3, 576);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(219, 72);
            this.WebCamLabel.TabIndex = 13;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSLabel
            // 
            this.OSLabel.BackColor = System.Drawing.Color.Transparent;
            this.OSLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.OSLabel.ForeColor = System.Drawing.Color.White;
            this.OSLabel.Location = new System.Drawing.Point(3, 648);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(219, 72);
            this.OSLabel.TabIndex = 14;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LCDSizeLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.LCDSizeLabel.ForeColor = System.Drawing.Color.White;
            this.LCDSizeLabel.Location = new System.Drawing.Point(3, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(219, 72);
            this.LCDSizeLabel.TabIndex = 5;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.YourPriceGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.YourPriceGroupBox.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.YourPriceGroupBox.ForeColor = System.Drawing.Color.White;
            this.YourPriceGroupBox.Location = new System.Drawing.Point(1018, 523);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(996, 414);
            this.YourPriceGroupBox.TabIndex = 5;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriceLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DividerPictureBox, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 87);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sales Tax (13%):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(3, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(321, 87);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price:";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 87);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sales Tax (13%):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(1841, 945);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(173, 66);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // DividerPictureBox
            // 
            this.DividerPictureBox.BackgroundImage = global::Assignment5.Properties.Resources.DividerLine;
            this.tableLayoutPanel1.SetColumnSpan(this.DividerPictureBox, 3);
            this.DividerPictureBox.Location = new System.Drawing.Point(3, 177);
            this.DividerPictureBox.Name = "DividerPictureBox";
            this.DividerPictureBox.Size = new System.Drawing.Size(978, 81);
            this.DividerPictureBox.TabIndex = 10;
            this.DividerPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment5.Properties.Resources.fin_serv_tech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2026, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.SystemComponentsPart2GroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.ProductInfoTableLayoutPanel.ResumeLayout(false);
            this.ProductInfoTableLayoutPanel.PerformLayout();
            this.SystemComponentsPart2GroupBox.ResumeLayout(false);
            this.ComponentPart2TableLayoutPanel.ResumeLayout(false);
            this.YourPriceGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DividerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.TableLayoutPanel ProductInfoTableLayoutPanel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.GroupBox SystemComponentsPart2GroupBox;
        private System.Windows.Forms.TableLayoutPanel ComponentPart2TableLayoutPanel;
        private System.Windows.Forms.Label OSContextLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label GPUContextLabel;
        private System.Windows.Forms.Label HDDContextLabel;
        private System.Windows.Forms.Label CPUSpeedContextLabel;
        private System.Windows.Forms.Label CPUNumberContextLabel;
        private System.Windows.Forms.Label CPUTypeContextLabel;
        private System.Windows.Forms.Label CPUBrandContextLabel;
        private System.Windows.Forms.Label MemoryContextLabel;
        private System.Windows.Forms.Label LCDSizeContextLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox DividerPictureBox;
    }
}