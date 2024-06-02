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
        private string selectedTab ="";
        private Int64 RoomStatusID;
        public static Int64 LoggedInID;
        public static string NameLog = "";
        public double price = 0;
        List<float> RoomPrice = new List<float> { };
        List<string> description = new List<string> { };
        List<string> inclusion = new List<string> { };
        public Int64 ReceiptNumber;
        List<int> SingleRoomNumber = new List<int> { }, SingleRoomID = new List<int> { };
        List<int> StandardDoubleRoomNumber = new List<int> { }, StandardDoubleRoomID = new List<int> { };
        List<int> DeluxeDoubleRoomNumber = new List<int> { }, DeluxeDoubleRoomID = new List<int> { };
        List<int> StandardTwinRoomNumber = new List<int> { }, StandardTwinRoomID = new List<int> { };
        List<int> StudioRoomNumber = new List<int> { }, StudioRoomID = new List<int> { };
        List<int> PresidentialSuiteNumber = new List<int> { }, PresidentialSuiteID = new List<int> { };
        public int RoomID = 0;


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
            UpdateReceiptNumber();
            PopulateRoomsInformation();
            UpdateRoomTypeAvailability();
            UpdateRoomNumberAvailability();
            UpdateRoomStatusID();
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
                string query = "select RoomNumber, RoomID from v_AllRoomInformation " +
                    "where status = 'Available'";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) >= 1001 && reader.GetInt32(0) <= 1024)
                            {
                                SingleRoomNumber.Add(reader.GetInt32(0));
                                SingleRoomID.Add(reader.GetInt32(1));
                            }
                            else if (reader.GetInt32(0) >= 2024 && reader.GetInt32(0) <= 2048)
                            {
                                StandardDoubleRoomNumber.Add(reader.GetInt32(0));
                                StandardDoubleRoomID.Add(reader.GetInt32(1));
                            }
                            else if (reader.GetInt32(0) >= 2148 && reader.GetInt32(0) <= 2172)
                            {
                                StandardTwinRoomNumber.Add(reader.GetInt32(0));
                                StandardTwinRoomID.Add(reader.GetInt32(1));
                            }
                            else if (reader.GetInt32(0) >= 4001 && reader.GetInt32(0) <= 4025)
                            {
                                DeluxeDoubleRoomNumber.Add(reader.GetInt32(0));
                                DeluxeDoubleRoomID.Add(reader.GetInt32(1));
                            }
                            else if (reader.GetInt32(0) >= 5001 && reader.GetInt32(0) <= 5025)
                            {
                                StudioRoomNumber.Add(reader.GetInt32(0));
                                StudioRoomID.Add(reader.GetInt32(1));
                            }
                            else if (reader.GetInt32(0) >= 6001 && reader.GetInt32(0) <= 6012)
                            {
                                PresidentialSuiteNumber.Add(reader.GetInt32(0));
                                PresidentialSuiteID.Add(reader.GetInt32(1));
                            }
                        }
                        cmbRoomNumber.DataSource = SingleRoomNumber;
                        
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
                string query = "select max(TransactionID), max(GuestID), max(BookingID) from t_BookedGuest";
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
        public void UpdateRoomStatusID()
        {
            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select max(RoomStatusID) from t_RoomStatus";
                connection.Open();
                using(SqliteCommand command = new SqliteCommand(query,connection)) {
                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        RoomStatusID = Convert.ToInt64(reader.GetValue(0)) + 1;
                    }
                }
                connection.Close();
            }
        }
        public void UpdateReceiptNumber()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select ReceiptNumber from t_BookingTransaction order by ReceiptNumber Desc";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        ReceiptNumber = (Int64)reader.GetValue(0) + 1;
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
            if (selectedTab == "SingleRoom")
            {
                RoomID = SingleRoomID[cmbRoomNumber.TabIndex];
            }
            else if(selectedTab == "StandardDoubleRoom")
            {
                RoomID = StandardDoubleRoomID[cmbRoomNumber.TabIndex];
            }
            else if (selectedTab == "StandardTwinRoom")
            {
                RoomID = StandardTwinRoomID[cmbRoomNumber.TabIndex];
            }
            else if (selectedTab == "DeluxeDoubleRoom")
            {
                RoomID = DeluxeDoubleRoomID[cmbRoomNumber.TabIndex];
            }
            else if (selectedTab == "StudioRoom")
            {
                RoomID = StudioRoomID[cmbRoomNumber.TabIndex];
            }
            else if (selectedTab == "PresidentialSuite")
            {
                RoomID = PresidentialSuiteID[cmbRoomNumber.TabIndex];
            }
            
            if (guestID.Text == tempGuestID)
            {
                using(SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string query = "insert into r_Guest (GuestID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, DateAdded) values " +
                        "('" + Int32.Parse(guestID.Text) + "', '" + firstName.Text + "', '" + middleName.Text + "', '" +lastName.Text +"', '"+phoneNumber.Text+"', '"+emailAddress.Text+"', '"+DateTime.Now.ToString()+"')";
                    connection.Open();
                    using(SqliteCommand command = new SqliteCommand(query, connection)) {
                        command.ExecuteScalar();
                    }
                    connection.Close();
                }
            }
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "insert into t_BookedGuest (TransactionID, GuestID, BookingID, TransactionDate) values ('" + Int32.Parse(transactionID.Text) + "', '" + Int32.Parse(guestID.Text) + "', '" + Int32.Parse(bookingID.Text) + "', '" + DateTime.Now.ToString() + "')";
                string query2 = "insert into t_BookingTransaction (ReceiptNumber, TransactionID, GuestID, TransactionDate, RoomCost, VAT, TotalCost, ModePayment) values ('" + ReceiptNumber + "', '" + Int32.Parse(transactionID.Text) + "', '" + Int32.Parse(guestID.Text) + "', '" + DateTime.Now.ToString() + "', '" + Int32.Parse(roomCost.Text) + "', '" + Int32.Parse(tax.Text) + "', '" + Int32.Parse(totalPrice.Text) + "', 'cash')";
                string query3 = "insert into t_RoomStatus (RoomStatusID, TransactionID, Status, RoomID, ScheduledCheckIn, ScheduledCheckout)" +
                    "values ('"+RoomStatusID+"','"+ Int32.Parse(transactionID.Text) + "','Occupied','"+RoomID+"','"+dateCheckIn.Value.ToString()+"','"+dateCheckOut.Value.ToString() + "')";
                string query4 = "update t_RoomAvailability set Status = 'Occupied' where RoomID ='"+RoomID+"'";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SqliteCommand command = new SqliteCommand(query2, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SqliteCommand command = new SqliteCommand(query3, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SqliteCommand command = new SqliteCommand(query4, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void tabRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(tabRoomTypes.SelectedIndex == 6)
            {
                cmbRoomNumber.Enabled = false;

            }
            

            if (tabRoomTypes.SelectedIndex == 0)
            {
                
                roomCost.Text = RoomPrice[2].ToString();
                roomInformation.Text = description[0];
                roomInclusion.Text = inclusion[0];
                cmbRoomNumber.DataSource = SingleRoomNumber;
                selectedTab = "SingleRoom";
                cmbRoomNumber.Enabled = true;
            }
            else if (tabRoomTypes.SelectedIndex == 1)
            {
                roomCost.Text = RoomPrice[3].ToString();
                roomInformation.Text = description[1];
                roomInclusion.Text = inclusion[1];
                cmbRoomNumber.DataSource = StandardDoubleRoomNumber;
                selectedTab = "StandardDoubleRoom";
                cmbRoomNumber.Enabled = true;

            }
            else if (tabRoomTypes.SelectedIndex == 2)
            {
                roomCost.Text = RoomPrice[4].ToString();
                roomInformation.Text = description[2];
                roomInclusion.Text = inclusion[2];
                cmbRoomNumber.DataSource = StandardTwinRoomNumber;
                selectedTab = "StandardTwinRoom";
                cmbRoomNumber.Enabled = true;

            }
            else if (tabRoomTypes.SelectedIndex == 3)
            {
                roomCost.Text = RoomPrice[0].ToString();
                roomInformation.Text = description[3];
                roomInclusion.Text = inclusion[3];
                cmbRoomNumber.DataSource = DeluxeDoubleRoomNumber;
                selectedTab = "DeluxeDoubleRoom";
                cmbRoomNumber.Enabled = true;

            }
            else if (tabRoomTypes.SelectedIndex == 4)
            {
                roomCost.Text = RoomPrice[5].ToString();
                roomInformation.Text = description[4];
                roomInclusion.Text = inclusion[4];
                cmbRoomNumber.DataSource = StudioRoomNumber;
                selectedTab = "StudioRoom";
                cmbRoomNumber.Enabled = true;

            }
            else if (tabRoomTypes.SelectedIndex == 5)
            {
                roomCost.Text = RoomPrice[1].ToString();
                roomInformation.Text = description[5];
                roomInclusion.Text = inclusion[5];
                cmbRoomNumber.DataSource = PresidentialSuiteNumber;
                selectedTab = "PresidentialSuite";
                cmbRoomNumber.Enabled = true;

            }
        }

        private void subTotal_TextChanged(object sender, EventArgs e)
        {
            tax.Text = Math.Round(price * 0.07).ToString();
        }

        private void tax_TextChanged(object sender, EventArgs e)
        {
            totalPrice.Text = (Convert.ToDouble(tax.Text) + Convert.ToDouble(subTotal.Text)).ToString();
        }

        private void dateCheckOut_ValueChanged(object sender, EventArgs e)
        {
            DateTime checkin = dateCheckIn.Value;
            DateTime checkout = dateCheckOut.Value;

            TimeSpan duration = new TimeSpan(checkout.Ticks - checkin.Ticks);

            int days = (int)duration.TotalDays;
            price = Convert.ToDouble(roomCost.Text);
            price += price * days;
            subTotal.Text = price.ToString();

        }
    }
}
