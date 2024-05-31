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
            btn_Register = new Button();
            btn_Login = new Button();
            btnClose = new PictureBox();
            btnMinimize = new PictureBox();
            lblCompanyName = new Label();
            lblDeveloper = new Label();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.ForeColor = Color.FromArgb(124, 117, 123);
            btn_Register.Location = new Point(240, 322);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(94, 29);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            btn_Login.ForeColor = Color.FromArgb(124, 117, 123);
            btn_Login.Location = new Point(574, 322);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(94, 29);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
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
            lblCompanyName.Dock = DockStyle.Fill;
            lblCompanyName.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(0, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(942, 501);
            lblCompanyName.TabIndex = 3;
            lblCompanyName.Text = "Company Name";
            lblCompanyName.TextAlign = ContentAlignment.MiddleCenter;
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
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(942, 501);
            Controls.Add(lblDeveloper);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(btn_Login);
            Controls.Add(btn_Register);
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

        private Button btn_Register;
        private Button btn_Login;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
        private Label lblCompanyName;
        private Label lblDeveloper;
    }
}
