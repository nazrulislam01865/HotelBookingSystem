namespace HotelBooking
{
    partial class LoginDb
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
            System.Windows.Forms.Label MemberLoginLabel;
            this.LoginText = new System.Windows.Forms.Panel();
            this.cusButton1 = new CustomControls.RJControls.CusButton();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new CustomControls.RJControls.CusButton();
            this.customTextBox2 = new HotelBooking.CustomTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.customTextBox1 = new HotelBooking.CustomTextBox();
            this.showPassword = new System.Windows.Forms.PictureBox();
            this.ForgetPass = new System.Windows.Forms.Button();
            MemberLoginLabel = new System.Windows.Forms.Label();
            this.LoginText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberLoginLabel
            // 
            MemberLoginLabel.AutoSize = true;
            MemberLoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MemberLoginLabel.ForeColor = System.Drawing.Color.Black;
            MemberLoginLabel.Location = new System.Drawing.Point(56, 103);
            MemberLoginLabel.Name = "MemberLoginLabel";
            MemberLoginLabel.Size = new System.Drawing.Size(137, 25);
            MemberLoginLabel.TabIndex = 5;
            MemberLoginLabel.Text = "Member Login";
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.LoginText.Controls.Add(this.ForgetPass);
            this.LoginText.Controls.Add(this.pictureBox3);
            this.LoginText.Controls.Add(this.pictureBox4);
            this.LoginText.Controls.Add(this.cusButton1);
            this.LoginText.Controls.Add(this.label1);
            this.LoginText.Controls.Add(this.loginBtn);
            this.LoginText.Controls.Add(MemberLoginLabel);
            this.LoginText.Controls.Add(this.customTextBox2);
            this.LoginText.Controls.Add(this.pictureBox1);
            this.LoginText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginText.Location = new System.Drawing.Point(0, 0);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(250, 380);
            this.LoginText.TabIndex = 0;
            this.LoginText.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginText_Paint);
            // 
            // cusButton1
            // 
            this.cusButton1.BackColor = System.Drawing.Color.Transparent;
            this.cusButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.cusButton1.BorderColor = System.Drawing.Color.Transparent;
            this.cusButton1.BorderRadius = 0;
            this.cusButton1.BorderSize = 0;
            this.cusButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusButton1.FlatAppearance.BorderSize = 0;
            this.cusButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cusButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.cusButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusButton1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cusButton1.Location = new System.Drawing.Point(73, 335);
            this.cusButton1.Name = "cusButton1";
            this.cusButton1.Size = new System.Drawing.Size(101, 19);
            this.cusButton1.TabIndex = 8;
            this.cusButton1.Text = "Create account";
            this.cusButton1.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.cusButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t have account?.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.loginBtn.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.loginBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginBtn.BorderRadius = 10;
            this.loginBtn.BorderSize = 0;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(80, 288);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(86, 26);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login ->";
            this.loginBtn.TextColor = System.Drawing.Color.Black;
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.customTextBox2.customMultiline = false;
            this.customTextBox2.customText = "Password";
            this.customTextBox2.Location = new System.Drawing.Point(25, 195);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.password = true;
            this.customTextBox2.Size = new System.Drawing.Size(209, 40);
            this.customTextBox2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Image = global::HotelBooking.Properties.Resources._6310507;
            this.pictureBox2.Location = new System.Drawing.Point(250, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 380);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::HotelBooking.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(34, 178);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 1);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelBooking.Properties.Resources.key_11263140;
            this.pictureBox1.Location = new System.Drawing.Point(100, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::HotelBooking.Properties.Resources.line;
            this.pictureBox4.Location = new System.Drawing.Point(34, 232);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 1);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.customTextBox1.customMultiline = false;
            this.customTextBox1.customText = "Username";
            this.customTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customTextBox1.Location = new System.Drawing.Point(25, 140);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.password = false;
            this.customTextBox1.Size = new System.Drawing.Size(209, 38);
            this.customTextBox1.TabIndex = 1;
            // 
            // showPassword
            // 
            this.showPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.Image = global::HotelBooking.Properties.Resources.openEye;
            this.showPassword.Location = new System.Drawing.Point(197, 217);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(15, 12);
            this.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPassword.TabIndex = 2;
            this.showPassword.TabStop = false;
            // 
            // ForgetPass
            // 
            this.ForgetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetPass.FlatAppearance.BorderSize = 0;
            this.ForgetPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ForgetPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgetPass.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ForgetPass.Location = new System.Drawing.Point(25, 236);
            this.ForgetPass.Name = "ForgetPass";
            this.ForgetPass.Size = new System.Drawing.Size(92, 23);
            this.ForgetPass.TabIndex = 12;
            this.ForgetPass.Text = "Forget Password?";
            this.ForgetPass.UseVisualStyleBackColor = false;
            // 
            // LoginDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(570, 380);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginDb";
            this.Load += new System.EventHandler(this.LoginDb_Load);
            this.LoginText.ResumeLayout(false);
            this.LoginText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomTextBox customTextBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.RJControls.CusButton loginBtn;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.CusButton cusButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CustomTextBox customTextBox1;
        private System.Windows.Forms.PictureBox showPassword;
        private System.Windows.Forms.Button ForgetPass;
    }
}