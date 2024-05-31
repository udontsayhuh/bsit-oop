using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class HMSUI : Form
    {
        public static Int64 LoggedInID;
        public static string NameLog;
        public HMSUI()
        {
            NameLog = StartupForm.NameLog;
            LoggedInID = StartupForm.LoggedInID;
            InitializeComponent();
            lblLoggedIn.Text = NameLog;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StartupForm.LoggedInID = 0;
            lblLoggedIn.Text = "";
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
