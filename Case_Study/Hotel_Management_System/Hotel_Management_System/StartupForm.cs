using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace Hotel_Management_System
{
    

    public partial class StartupForm : Form
    {
        public static Int64 LoggedInID;
        private string connectionString = "Data Source = HMSCS.db;";
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

        private void Verification(string password, string username)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "Select employeeID, username, password from r_Attendant where username = '" + username + "' and password = '" + password + "'";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            LoggedInID = (Int64)reader.GetValue(0);
                        }
                        else
                        {
                            username = "";
                            password= "";
                            MessageBox.Show("Invalid Credentials", "Please Try Again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Verification(password.Text, username.Text);
                Hide();
                var HMSUI = new HMSUI();
                HMSUI.FormClosed += new FormClosedEventHandler(child_FormClosed);
                HMSUI.Show();
            }
            catch (Exception)
            {
                username.Text = "";
                password.Text = "";
                MessageBox.Show("Invalid Credentials", "Please Try Again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        void child_FormClosed(object? sender, FormClosedEventArgs e)
        {
            password.Text = "";
            username.Text = "";
        }
    }
}
