namespace Hotel_Management_System
{
    partial class StartupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            btn_Login = new Button();
            btnClose = new PictureBox();
            btnMinimize = new PictureBox();
            lblCompanyName = new Label();
            lblDeveloper = new Label();
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.ForeColor = Color.Black;
            btn_Login.Location = new Point(431, 312);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(94, 29);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(895, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(844, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 35);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblCompanyName
            // 
            lblCompanyName.Dock = DockStyle.Top;
            lblCompanyName.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(0, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(942, 101);
            lblCompanyName.TabIndex = 3;
            lblCompanyName.Text = "Company Name";
            lblCompanyName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeveloper.Location = new Point(12, 470);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(486, 22);
            lblDeveloper.TabIndex = 4;
            lblDeveloper.Text = "Hotel Management System Developed by :  ILPST Solutions";
            lblDeveloper.TextAlign = ContentAlignment.TopCenter;
            // 
            // username
            // 
            username.Location = new Point(381, 192);
            username.Name = "username";
            username.Size = new Size(196, 27);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(381, 264);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(196, 27);
            password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F);
            label1.Location = new Point(381, 172);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F);
            label2.Location = new Point(381, 244);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(942, 501);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(lblDeveloper);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(btn_Login);
            Controls.Add(lblCompanyName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartupForm";
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Login;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
        private Label lblCompanyName;
        private Label lblDeveloper;
        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
    }
}
