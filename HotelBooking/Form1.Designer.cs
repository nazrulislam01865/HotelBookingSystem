namespace HotelBooking
{
    partial class Form1
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
            this.Loading = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Loading
            // 
            this.Loading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Loading.AnimationSpeed = 500;
            this.Loading.BackColor = System.Drawing.Color.Transparent;
            this.Loading.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Loading.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.Loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(169)))));
            this.Loading.InnerColor = System.Drawing.Color.White;
            this.Loading.InnerMargin = 1;
            this.Loading.InnerWidth = 1;
            this.Loading.Location = new System.Drawing.Point(100, 59);
            this.Loading.MarqueeAnimationSpeed = 2000;
            this.Loading.Name = "Loading";
            this.Loading.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Loading.OuterMargin = -25;
            this.Loading.OuterWidth = 27;
            this.Loading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(161)))), ((int)(((byte)(169)))));
            this.Loading.ProgressWidth = 15;
            this.Loading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Loading.Size = new System.Drawing.Size(220, 220);
            this.Loading.StartAngle = 270;
            this.Loading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Loading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Loading.SubscriptText = "";
            this.Loading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Loading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Loading.SuperscriptText = "";
            this.Loading.TabIndex = 0;
            this.Loading.TextMargin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.Loading.Value = 70;
            this.Loading.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(420, 338);
            this.Controls.Add(this.Loading);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar Loading;
        private System.Windows.Forms.Timer timer1;
    }
}

