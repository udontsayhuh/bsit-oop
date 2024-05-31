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
            btmGuestInfo = new Button();
            btnBook = new Button();
            btnRoomInfo = new Button();
            btnInvoiceSummary = new Button();
            btnReports = new Button();
            lblLoggedIn = new Label();
            pnlAttendant = new Panel();
            lblProcessed = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            pnlAttendant.SuspendLayout();
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
            // btmGuestInfo
            // 
            btmGuestInfo.BackgroundImage = (Image)resources.GetObject("btmGuestInfo.BackgroundImage");
            btmGuestInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btmGuestInfo.Location = new Point(87, 79);
            btmGuestInfo.Name = "btmGuestInfo";
            btmGuestInfo.Size = new Size(100, 100);
            btmGuestInfo.TabIndex = 97;
            btmGuestInfo.TabStop = false;
            btmGuestInfo.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            btnBook.BackgroundImage = (Image)resources.GetObject("btnBook.BackgroundImage");
            btnBook.BackgroundImageLayout = ImageLayout.Stretch;
            btnBook.Location = new Point(252, 79);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(100, 100);
            btnBook.TabIndex = 98;
            btnBook.TabStop = false;
            btnBook.UseVisualStyleBackColor = true;
            // 
            // btnRoomInfo
            // 
            btnRoomInfo.BackgroundImage = (Image)resources.GetObject("btnRoomInfo.BackgroundImage");
            btnRoomInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnRoomInfo.Location = new Point(417, 79);
            btnRoomInfo.Name = "btnRoomInfo";
            btnRoomInfo.Size = new Size(100, 100);
            btnRoomInfo.TabIndex = 99;
            btnRoomInfo.TabStop = false;
            btnRoomInfo.UseVisualStyleBackColor = true;
            // 
            // btnInvoiceSummary
            // 
            btnInvoiceSummary.BackgroundImage = (Image)resources.GetObject("btnInvoiceSummary.BackgroundImage");
            btnInvoiceSummary.BackgroundImageLayout = ImageLayout.Stretch;
            btnInvoiceSummary.Location = new Point(582, 79);
            btnInvoiceSummary.Name = "btnInvoiceSummary";
            btnInvoiceSummary.Size = new Size(100, 100);
            btnInvoiceSummary.TabIndex = 99;
            btnInvoiceSummary.TabStop = false;
            btnInvoiceSummary.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.BackgroundImage = (Image)resources.GetObject("btnReports.BackgroundImage");
            btnReports.BackgroundImageLayout = ImageLayout.Stretch;
            btnReports.Location = new Point(747, 79);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(100, 100);
            btnReports.TabIndex = 99;
            btnReports.TabStop = false;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // lblLoggedIn
            // 
            lblLoggedIn.AutoSize = true;
            lblLoggedIn.Location = new Point(81, 22);
            lblLoggedIn.Name = "lblLoggedIn";
            lblLoggedIn.Size = new Size(120, 20);
            lblLoggedIn.TabIndex = 100;
            lblLoggedIn.Text = "Name Logged In";
            // 
            // pnlAttendant
            // 
            pnlAttendant.Controls.Add(lblProcessed);
            pnlAttendant.Controls.Add(label2);
            pnlAttendant.Controls.Add(label1);
            pnlAttendant.Controls.Add(lblLoggedIn);
            pnlAttendant.Location = new Point(875, 79);
            pnlAttendant.Name = "pnlAttendant";
            pnlAttendant.Size = new Size(444, 100);
            pnlAttendant.TabIndex = 101;
            // 
            // lblProcessed
            // 
            lblProcessed.AutoSize = true;
            lblProcessed.Location = new Point(81, 42);
            lblProcessed.Name = "lblProcessed";
            lblProcessed.Size = new Size(118, 20);
            lblProcessed.TabIndex = 100;
            lblProcessed.Text = "Processed Count";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 100;
            label1.Text = "Logged in: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 100;
            label2.Text = "Processed: ";
            // 
            // HMSUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(1348, 721);
            Controls.Add(pnlAttendant);
            Controls.Add(btnReports);
            Controls.Add(btnInvoiceSummary);
            Controls.Add(btnRoomInfo);
            Controls.Add(btnBook);
            Controls.Add(btmGuestInfo);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HMSUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMSUI";
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            pnlAttendant.ResumeLayout(false);
            pnlAttendant.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnMinimize;
        private PictureBox btnClose;
        private Button btmGuestInfo;
        private Button btnBook;
        private Button btnRoomInfo;
        private Button btnInvoiceSummary;
        private Button btnReports;
        private Label lblLoggedIn;
        private Panel pnlAttendant;
        private Label lblProcessed;
        private Label label1;
        private Label label2;
    }
}