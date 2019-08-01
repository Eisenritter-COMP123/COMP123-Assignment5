namespace Assignment5.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PIDLabel = new System.Windows.Forms.Label();
            this.PIDTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CostTextbox = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1002, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(220, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.selectAnotherProductToolStripMenuItem.Text = "&Select Another Product";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(14, 152);
            this.ProductInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(976, 171);
            this.ProductInfoGroupBox.TabIndex = 2;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 331);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(976, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tech Specs";
            // 
            // PIDLabel
            // 
            this.PIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.PIDLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDLabel.ForeColor = System.Drawing.Color.White;
            this.PIDLabel.Location = new System.Drawing.Point(12, 66);
            this.PIDLabel.Name = "PIDLabel";
            this.PIDLabel.Size = new System.Drawing.Size(142, 29);
            this.PIDLabel.TabIndex = 4;
            this.PIDLabel.Text = "Product ID:";
            this.PIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PIDTextBox
            // 
            this.PIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIDTextBox.Enabled = false;
            this.PIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDTextBox.Location = new System.Drawing.Point(158, 60);
            this.PIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIDTextBox.Name = "PIDTextBox";
            this.PIDTextBox.Size = new System.Drawing.Size(137, 35);
            this.PIDTextBox.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConditionLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.ForeColor = System.Drawing.Color.White;
            this.ConditionLabel.Location = new System.Drawing.Point(339, 66);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(155, 29);
            this.ConditionLabel.TabIndex = 4;
            this.ConditionLabel.Text = "Condition:";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextBox.Location = new System.Drawing.Point(500, 60);
            this.ConditionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(137, 35);
            this.ConditionTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(692, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CostTextbox
            // 
            this.CostTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CostTextbox.Enabled = false;
            this.CostTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextbox.Location = new System.Drawing.Point(825, 60);
            this.CostTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CostTextbox.Name = "CostTextbox";
            this.CostTextbox.Size = new System.Drawing.Size(137, 35);
            this.CostTextbox.TabIndex = 5;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment5.Properties.Resources.fin_serv_tech;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.CostTextbox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.PIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.PIDLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductInfoForm";
            this.Text = "Product Info Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PIDLabel;
        private System.Windows.Forms.TextBox PIDTextBox;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CostTextbox;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}