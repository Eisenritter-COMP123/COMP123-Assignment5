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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(1002, 35);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
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
            this.printToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(14, 57);
            this.ProductInfoGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(456, 248);
            this.ProductInfoGroupBox.TabIndex = 3;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            this.ProductInfoGroupBox.Enter += new System.EventHandler(this.ProductInfoGroupBox_Enter);
            // 
            // ModelLabel
            // 
            this.ModelLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModelLabel.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.ForeColor = System.Drawing.Color.White;
            this.ModelLabel.Location = new System.Drawing.Point(594, 73);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(157, 42);
            this.ModelLabel.TabIndex = 4;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.ForeColor = System.Drawing.Color.White;
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 154);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(158, 42);
            this.ManufacturerLabel.TabIndex = 4;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(316, 160);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(211, 31);
            this.ModelTextBox.TabIndex = 5;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlatformLabel.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.ForeColor = System.Drawing.Color.White;
            this.PlatformLabel.Location = new System.Drawing.Point(9, 73);
            this.PlatformLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(155, 42);
            this.PlatformLabel.TabIndex = 4;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManufacturerTextBox.Enabled = false;
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(174, 160);
            this.ManufacturerTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(132, 31);
            this.ManufacturerTextBox.TabIndex = 5;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformTextBox.Location = new System.Drawing.Point(174, 79);
            this.PlatformTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(132, 31);
            this.PlatformTextBox.TabIndex = 5;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment5.Properties.Resources.fin_serv_tech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.ControlBox = false;
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
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
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
    }
}