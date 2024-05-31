using Microsoft.Data.Sqlite;
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

        string connectionString = "Data Source=HMSCS.db";

        public HMSUI()
        {
            NameLog = StartupForm.NameLog;
            LoggedInID = StartupForm.LoggedInID;
            InitializeComponent();
            InitializeUI();
            
        }
        

        #region ButtonAndPanelInteraction

        private void Toggle_Panel(Panel panel)
        {
            if (panel.Visible == true)
            {
                pnlBook.Visible = false;
                pnlGuestinfo.Visible = false;
                pnlInvoiceSummary.Visible = false;
                pnlReports.Visible = false;
                pnlRoomInfo.Visible = false;
            }
            else
            {
                pnlBook.Visible = false;
                pnlGuestinfo.Visible = false;
                pnlInvoiceSummary.Visible = false;
                pnlReports.Visible = false;
                pnlRoomInfo.Visible = false;
                panel.Visible = true;
            }
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            Toggle_Panel(pnlReports);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Toggle_Panel(pnlBook);
        }

        private void btnRoomInfo_Click(object sender, EventArgs e)
        {
            Toggle_Panel(pnlRoomInfo);
        }

        private void btmGuestInfo_Click(object sender, EventArgs e)
        {
            Toggle_Panel(pnlGuestinfo);
        }

        private void btnInvoiceSummary_Click(object sender, EventArgs e)
        {
            Toggle_Panel(pnlInvoiceSummary);
        }

        #endregion

        #region DataCenter
        public void InitializeUI()
        {
            PopulateRoomsInformation();
            UpdateRoomTypeAvailability();
            UpdateRoomNumberAvailability();
            pnlBook.Visible = false;
            pnlGuestinfo.Visible = false;
            pnlInvoiceSummary.Visible = false;
            pnlReports.Visible = false;
            pnlRoomInfo.Visible = false;
            lblLoggedIn.Text = NameLog;
        }
        public void PopulateRoomsInformation()
        {
            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select * from v_AllRoomInformation";
                connection.Open();
                using(SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        db_RoomInformation.DataSource = dataTable;
                        
                    }
                }
                connection.Close();
            }
        }
        public void UpdateRoomTypeAvailability()
        {
            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select RoomType, Count(RoomType) from v_AllRoomInformation " +
                    "where status = 'Available' group by RoomType having count(RoomType) > 1 ";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<string> RoomType = new List<string> { };
                        List<int> AvailableRooms = new List<int> { };
                        while (reader.Read()) {

                            
                            RoomType.Add(reader.GetString(0));
                            AvailableRooms.Add(reader.GetInt32(1));
                        }
                        lblAvail1.Text = AvailableRooms[0].ToString();
                        lblAvail2.Text = AvailableRooms[1].ToString();
                        lblAvail3.Text = AvailableRooms[2].ToString();
                        lblAvail4.Text = AvailableRooms[3].ToString();
                        lblAvail5.Text = AvailableRooms[4].ToString();
                        lblAvail6.Text = AvailableRooms[5].ToString();

                    }
                    connection.Close();
                }
            }
        }
        public void UpdateRoomNumberAvailability()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select RoomNumber from v_AllRoomInformation " +
                    "where status = 'Available'";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<int> SingleRoomNumber = new List<int> { };
                        List<int> StandardDoubleRoomNumber = new List<int> { };
                        List<int> DeluxeDoubleRoomNumber = new List<int> { };
                        List<int> StandardTwinRoomNumber = new List<int> { };
                        List<int> StudioRoomNumber = new List<int> { };
                        List<int> PresidentialSuiteNumber = new List<int> { };
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) >= 1001 && reader.GetInt32(0) <= 1024)
                            {
                                SingleRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if(reader.GetInt32(0) >= 2024 && reader.GetInt32(0) <= 2048)
                            {
                                StandardDoubleRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if( reader.GetInt32(0) >= 2148 && reader.GetInt32(0) <= 2172)
                            {
                                StandardTwinRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if( reader.GetInt32(0) >= 4001 && reader.GetInt32(0) <= 4025)
                            {
                                DeluxeDoubleRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if (reader.GetInt32(0) >= 5001 && reader.GetInt32(0) <= 5025)
                            {
                                StudioRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if(reader.GetInt32(0) >= 6001 && reader.GetInt32(0) <= 6012)
                            {
                                PresidentialSuiteNumber.Add(reader.GetInt32(0));
                            }
                        }
                        cmbSingleRoomNumber.DataSource = SingleRoomNumber;
                        cmbDeluxeDoubleRoomNumber.DataSource = DeluxeDoubleRoomNumber;
                        cmbStandardDoubleRoomNumber.DataSource = StandardDoubleRoomNumber;
                        cmbStandardTwinRoomNumber.DataSource = StandardTwinRoomNumber;
                        cmbStudioRoomNumber.DataSource = StudioRoomNumber;
                        cmbPresidentialSuiteNumber.DataSource = PresidentialSuiteNumber;
                    }
                    connection.Close();
                }
            }
        }

        #endregion
    }
}
