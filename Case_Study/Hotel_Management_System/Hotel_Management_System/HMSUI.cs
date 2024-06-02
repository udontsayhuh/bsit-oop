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
        public static string NameLog = "";
        public double price = 0;
        List<float> RoomPrice = new List<float> { };
        List<string> description = new List<string> { };
        List<string> inclusion = new List<string> { };


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
            UpdateTransactionNumber();
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
            PopulateRoomInformations();
            roomInformation.Text = description[0];
            roomInclusion.Text = inclusion[0];
        }
        public void PopulateRoomsInformation()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select * from v_AllRoomInformation";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
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
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select RoomType, RoomCost, Count(RoomType) from v_AllRoomInformation " +
                    "where status = 'Available' group by RoomType having count(RoomType) > 1 ";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<string> RoomType = new List<string> { };
                        List<int> AvailableRooms = new List<int> { };

                        while (reader.Read())
                        {
                            RoomType.Add(reader.GetString(0));
                            RoomPrice.Add(reader.GetFloat(1));
                            AvailableRooms.Add(reader.GetInt32(2));
                        }
                        lblAvail1.Text = AvailableRooms[2].ToString();
                        lblAvail2.Text = AvailableRooms[3].ToString();
                        lblAvail3.Text = AvailableRooms[4].ToString();
                        lblAvail4.Text = AvailableRooms[0].ToString();
                        lblAvail5.Text = AvailableRooms[5].ToString();
                        lblAvail6.Text = AvailableRooms[1].ToString();
                        roomCost.Text = RoomPrice[2].ToString();

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
                            else if (reader.GetInt32(0) >= 2024 && reader.GetInt32(0) <= 2048)
                            {
                                StandardDoubleRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if (reader.GetInt32(0) >= 2148 && reader.GetInt32(0) <= 2172)
                            {
                                StandardTwinRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if (reader.GetInt32(0) >= 4001 && reader.GetInt32(0) <= 4025)
                            {
                                DeluxeDoubleRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if (reader.GetInt32(0) >= 5001 && reader.GetInt32(0) <= 5025)
                            {
                                StudioRoomNumber.Add(reader.GetInt32(0));
                            }
                            else if (reader.GetInt32(0) >= 6001 && reader.GetInt32(0) <= 6012)
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
        private string tempGuestID = "";
        public void UpdateTransactionNumber()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select TransactionID, GuestID, BookingID from t_BookedGuest order by TransactionID desc";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        transactionID.Text = ((Int64)reader.GetValue(0) + 1).ToString();
                        tempGuestID = guestID.Text = ((Int64)reader.GetValue(1) + 1).ToString();
                        bookingID.Text = ((Int64)reader.GetValue(2) + 1).ToString();

                    }
                }
                connection.Close();
            }
        }
        private void emailAddress_Leave(object sender, EventArgs e)
        {
            string check = emailAddress.Text;
            if (check != "")
            {
                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string query = "select * from r_Guest where EmailAddress = '" + check + "'";
                    connection.Open();
                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                guestID.Text = reader.GetValue(0).ToString();
                                firstName.Text = (string)reader.GetValue(1);
                                middleName.Text = (string)reader.GetValue(2);
                                lastName.Text = (string)reader.GetValue(3);
                                phoneNumber.Text = (string)reader.GetValue(4);
                                emailAddress.Text = (string)reader.GetValue(5);
                            }

                        }
                    }
                    connection.Close();
                }
            }
            else
            {
                guestID.Text = tempGuestID;
                phoneNumber.Text = "";
                firstName.Text = "";
                middleName.Text = "";
                lastName.Text = "";
            }

        }
        public void PopulateRoomInformations()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select Description, Inclusion from i_RoomDescription";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            description.Add(reader.GetValue(0).ToString());
                            inclusion.Add(reader.GetValue(1).ToString());
                        }
                    }
                    connection.Close();
                }
            }
        }
        #endregion


        private void btnNewBook_Click(object sender, EventArgs e)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "insert into t_BookedGuest (TransactionID, GuestID, BookingID, TransactionDate) values TransactionID = '" + transactionID.Text + "', GuestID = '" + guestID.Text + "', BookingID= '" + bookingID.Text + "', TransactionDate='" + DateTime.Now.ToString() + "'";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void dateCheckOut_Leave(object sender, EventArgs e)
        {
            DateTime checkin = dateCheckIn.Value;
            DateTime checkout = dateCheckOut.Value;

            TimeSpan duration = new TimeSpan(checkout.Ticks - checkin.Ticks);

            int days = (int)duration.TotalDays;
            price = Convert.ToDouble(roomCost.Text);
            price += price * days;
            totalPrice.Text = price.ToString();
            

        }

        private void tabRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                

        if (tabRoomTypes.SelectedIndex == 0)
            {
                roomCost.Text = RoomPrice[2].ToString();
                roomInformation.Text = description[0];
                roomInclusion.Text = inclusion[0];
            }
        else if (tabRoomTypes.SelectedIndex == 1)
            {
                roomCost.Text = RoomPrice[3].ToString();
                roomInformation.Text = description[1];
                roomInclusion.Text = inclusion[1];
            }
        else if (tabRoomTypes.SelectedIndex == 2)
            {
                roomCost.Text = RoomPrice[4].ToString();
                roomInformation.Text = description[2];
                roomInclusion.Text = inclusion[2];
            }
        else if (tabRoomTypes.SelectedIndex == 3)
            {
                roomCost.Text = RoomPrice[0].ToString();
                roomInformation.Text = description[3];
                roomInclusion.Text = inclusion[3];
            }
        else if (tabRoomTypes.SelectedIndex == 4)
            {
                roomCost.Text = RoomPrice[5].ToString();
                roomInformation.Text = description[4];
                roomInclusion.Text = inclusion[4];
            }
        else if (tabRoomTypes.SelectedIndex == 5)
            {
                roomCost.Text = RoomPrice[1].ToString();
                roomInformation.Text = description[5];
                roomInclusion.Text = inclusion[5];
            }
        }   
    }
}
