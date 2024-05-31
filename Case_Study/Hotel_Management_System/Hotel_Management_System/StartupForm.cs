namespace Hotel_Management_System
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            initializeFormAttributes();
        }
        public void initializeFormAttributes()
        {
            lblCompanyName.Text = "Malake Ltd. Corp. Inc.";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
