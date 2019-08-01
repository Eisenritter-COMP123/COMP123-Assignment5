namespace Assignment5.Views
{
    partial class SplashScreen
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
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SplashProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.WelcomeLabel.Font = new System.Drawing.Font("Unispace", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 340);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(1000, 110);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to Dollar Computers";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashProgressBar
            // 
            this.SplashProgressBar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SplashProgressBar.Location = new System.Drawing.Point(31, 695);
            this.SplashProgressBar.Name = "SplashProgressBar";
            this.SplashProgressBar.Size = new System.Drawing.Size(992, 40);
            this.SplashProgressBar.TabIndex = 1;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment5.Properties.Resources.fin_serv_tech;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.SplashProgressBar);
            this.Controls.Add(this.WelcomeLabel);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ProgressBar SplashProgressBar;
        private System.Windows.Forms.Timer ProgressTimer;
    }
}