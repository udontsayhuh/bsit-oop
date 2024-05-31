namespace Hotel_Management_System
{
    partial class HMSUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMSUI));
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(1250, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 35);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 4;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1301, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // HMSUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(1348, 721);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HMSUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMSUI";
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnMinimize;
        private PictureBox btnClose;
    }
}