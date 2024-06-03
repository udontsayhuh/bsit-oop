﻿using Microsoft.Data.Sqlite;
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
        #region VariablesForSupplyingInformation
        private string selectedTab = "";
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
        #endregion

        public HMSUI()
        {
            NameLog = StartupForm.NameLog;
            LoggedInID = StartupForm.LoggedInID;
            InitializeComponent();
            InitializeUI();

        }

        private void HMSUI_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        #region UIMainButtonAndPanelInteraction

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
            dateCheckIn.MinDate = DateTime.Now;
            dateCheckOut.MinDate = DateTime.Now;
            lblDate.Text = DateTime.Now.Date.ToString("MM/dd/yyyy dddd");
            pnlBook.Visible = false;
            pnlGuestinfo.Visible = false;
            pnlInvoiceSummary.Visible = false;
            pnlReports.Visible = false;
            pnlRoomInfo.Visible = false;
            lblLoggedIn.Text = NameLog;
            PopulateRoomInformations();
            personPanel.Visible = false;
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

                    }
                    connection.Close();
                }
            }
        }
        public void ClearRoomAvailabilityList()
        {
            SingleRoomID.Clear();
            SingleRoomNumber.Clear();
            StandardDoubleRoomID.Clear();
            StandardDoubleRoomNumber.Clear();
            StandardTwinRoomID.Clear();
            StandardTwinRoomNumber.Clear();
            DeluxeDoubleRoomID.Clear();
            DeluxeDoubleRoomNumber.Clear();
            StudioRoomID.Clear();
            StudioRoomNumber.Clear();
            PresidentialSuiteID.Clear();
            PresidentialSuiteNumber.Clear();
        }
        public void UpdateRoomNumberAvailability()
        {
            ClearRoomAvailabilityList();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select RoomNumber, RoomID from v_AllRoomInformation where status = 'Available'";
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
                    }
                    connection.Close();
                }
            }
        }
        private string tempGuestID = "";
        private string p2TempGuestID = "";
        private string p3TempGuestID = "";
        private string p4TempGuestID = "";
        private string p5TempGuestID = "";
        public void UpdateTransactionNumber()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select max(TransactionID), max(GuestID), max(BookingID) from t_BookedGuest";
                string query1 = "select max(GuestID) from r_Guest";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        transactionID.Text = ((Int64)reader.GetValue(0) + 1).ToString();
                        bookingID.Text = ((Int64)reader.GetValue(2) + 1).ToString();

                    }
                }
                using (SqliteCommand command = new SqliteCommand(query1, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        tempGuestID = guestID.Text = ((Int64)reader.GetValue(0) + 1).ToString();
                    }
                }
                connection.Close();
            }
        }
        public void UpdateRoomStatusID()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                string query = "select max(RoomStatusID) from t_RoomStatus";
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
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
        private void p2EmailAddress_Leave(object sender, EventArgs e)
        {
            string check = p2EmailAddress.Text;
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
                                p2GuestID.Text = reader.GetValue(0).ToString();
                                p2FirstName.Text = (string)reader.GetValue(1);
                                p2MiddleName.Text = (string)reader.GetValue(2);
                                p2LastName.Text = (string)reader.GetValue(3);
                                p2PhoneNumber.Text = (string)reader.GetValue(4);
                                p2EmailAddress.Text = (string)reader.GetValue(5);
                            }

                        }
                    }
                    connection.Close();
                }
            }
            else
            {
                p2GuestID.Text = p2TempGuestID;
                p2PhoneNumber.Text = "";
                p2FirstName.Text = "";
                p2MiddleName.Text = "";
                p2LastName.Text = "";
            }
        }
        private void p3EmailAddress_Leave(object sender, EventArgs e)
        {
            string check = p3EmailAddress.Text;
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
                                p3GuestID.Text = reader.GetValue(0).ToString();
                                p3FirstName.Text = (string)reader.GetValue(1);
                                p3MiddleName.Text = (string)reader.GetValue(2);
                                p3LastName.Text = (string)reader.GetValue(3);
                                p3PhoneNumber.Text = (string)reader.GetValue(4);
                                p3EmailAddress.Text = (string)reader.GetValue(5);
                            }

                        }
                    }
                    connection.Close();
                }
            }
            else
            {
                p3GuestID.Text = p3TempGuestID;
                p3PhoneNumber.Text = "";
                p3FirstName.Text = "";
                p3MiddleName.Text = "";
                p3LastName.Text = "";
            }
        }
        private void p4EmailAddress_Leave(object sender, EventArgs e)
        {
            string check = p4EmailAddress.Text;
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
                                p4GuestID.Text = reader.GetValue(0).ToString();
                                p4FirstName.Text = (string)reader.GetValue(1);
                                p4MiddleName.Text = (string)reader.GetValue(2);
                                p4LastName.Text = (string)reader.GetValue(3);
                                p4ContactNumber.Text = (string)reader.GetValue(4);
                                p4EmailAddress.Text = (string)reader.GetValue(5);
                            }

                        }
                    }
                    connection.Close();
                }
            }
            else
            {
                p4GuestID.Text = p4TempGuestID;
                p4ContactNumber.Text = "";
                p4FirstName.Text = "";
                p4MiddleName.Text = "";
                p4LastName.Text = "";
            }
        }
        private void p5EmailAddress_Leave(object sender, EventArgs e)
        {
            string check = p5EmailAddress.Text;
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
                                p5GuestID.Text = reader.GetValue(0).ToString();
                                p5FirstName.Text = (string)reader.GetValue(1);
                                p5MiddleName.Text = (string)reader.GetValue(2);
                                p5LastName.Text = (string)reader.GetValue(3);
                                p5ContactNumber.Text = (string)reader.GetValue(4);
                                p5EmailAddress.Text = (string)reader.GetValue(5);
                            }

                        }
                    }
                    connection.Close();
                }
            }
            else
            {
                p5GuestID.Text = p5TempGuestID;
                p5ContactNumber.Text = "";
                p5FirstName.Text = "";
                p5MiddleName.Text = "";
                p5LastName.Text = "";
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
        public void BookSuccess()
        {
            dateCheckIn.Value = DateTime.Now;
            dateCheckIn.Value = DateTime.Now;

            UpdateTransactionNumber();
            UpdateRoomStatusID();
            UpdateReceiptNumber();
            UpdateRoomTypeAvailability();
            UpdateRoomNumberAvailability();

            emailAddress.Text = "";
            firstName.Text = "";
            middleName.Text = "";
            lastName.Text = "";
            phoneNumber.Text = "";
            tax.Text = "0";
            subTotal.Text = "0";
            totalPrice.Text = "0";
            roomCost.Text = "0";
            tabRoomTypes.SelectedIndex = 6;
        }
        public void ClearP2Info()
        {
            p2EmailAddress.Text = "";
            p2PhoneNumber.Text = "";
            p2FirstName.Text = "";
            p2MiddleName.Text = "";
            p2LastName.Text = "";
        }
        public void ClearP3Info()
        {
            p3EmailAddress.Text = "";
            p3PhoneNumber.Text = "";
            p3FirstName.Text = "";
            p3MiddleName.Text = "";
            p3LastName.Text = "";
        }
        public void ClearP4Info()
        {
            p4EmailAddress.Text = "";
            p4ContactNumber.Text = "";
            p4FirstName.Text = "";
            p4MiddleName.Text = "";
            p4LastName.Text = "";
        }
        public void ClearP5Info()
        {
            p5EmailAddress.Text = "";
            p5ContactNumber.Text = "";
            p5FirstName.Text = "";
            p5MiddleName.Text = "";
            p5LastName.Text = "";
        }
        #endregion

        #region BookingTransaction
        private void btnNewBook_Click(object sender, EventArgs e)
        {
            int check = 0;
                if ((addPersonInfo1.Visible == true) && (p2EmailAddress.Text == "" || p2FirstName.Text == "" || p2MiddleName.Text == "" || p2LastName.Text == "" || p2PhoneNumber.Text == ""))
                {
                    check = 1;
                }
                else if ((addPersonInfo2.Visible == true) && (p3EmailAddress.Text == "" || p3PhoneNumber.Text == "" || p3FirstName.Text == "" || p3MiddleName.Text == "" || p3LastName.Text == ""))
                {
                    check = 1;
                }
                else if ((addPersonInfo3.Visible == true) && (p4EmailAddress.Text == "" || p4ContactNumber.Text == "" || p4FirstName.Text == "" || p4MiddleName.Text == "" || p4LastName.Text == ""))
                {
                    check = 1;
                }
                else if ((addPersonInfo4.Visible == true) && (p5EmailAddress.Text == "" || p5FirstName.Text == "" || p5MiddleName.Text == "" || p5LastName.Text == "" || p5ContactNumber.Text == ""))
                {
                    check = 1;
                }
     
            if (totalPrice.Text == "" || emailAddress.Text == "" || phoneNumber.Text == "" || firstName.Text == "" || lastName.Text == "" || middleName.Text == "")
            {
                check = 1;
            }
            if (check == 1)
            {
                if (totalPrice.Text == "") MessageBox.Show("Please Select a Correct Room Number and Check Out Date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Please Complete All Necessary Information", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                if (selectedTab == "SingleRoom")
                {
                    RoomID = SingleRoomID[cmbRoomNumber.SelectedIndex];
                }
                else if (selectedTab == "StandardDoubleRoom")
                {
                    RoomID = StandardDoubleRoomID[cmbRoomNumber.SelectedIndex];
                }
                else if (selectedTab == "StandardTwinRoom")
                {
                    RoomID = StandardTwinRoomID[cmbRoomNumber.SelectedIndex];
                }
                else if (selectedTab == "DeluxeDoubleRoom")
                {
                    RoomID = DeluxeDoubleRoomID[cmbRoomNumber.SelectedIndex];
                }
                else if (selectedTab == "StudioRoom")
                {
                    RoomID = StudioRoomID[cmbRoomNumber.SelectedIndex];
                }
                else if (selectedTab == "PresidentialSuite")
                {
                    RoomID = PresidentialSuiteID[cmbRoomNumber.SelectedIndex];
                }

                if (guestID.Text == tempGuestID)
                {
                    using (SqliteConnection connection = new SqliteConnection(connectionString))
                    {
                        string query = "insert into r_Guest (GuestID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, DateAdded) values " +
                            "('" + Int32.Parse(guestID.Text) + "', '" + firstName.Text + "', '" + middleName.Text + "', '" + lastName.Text + "', '" + phoneNumber.Text + "', '" + emailAddress.Text + "', '" + DateTime.Now.ToString() + "')";
                        connection.Open();
                        using (SqliteCommand command = new SqliteCommand(query, connection))
                        {
                            command.ExecuteScalar();
                        }
                        connection.Close();
                    }
                }

                if((addPersonInfo1.Visible == true) && (p2GuestID.Text == p2TempGuestID))
                {
                    using (SqliteConnection connection = new SqliteConnection(connectionString))
                    {
                        string query = "insert into r_Guest (GuestID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, DateAdded) values " +
                            "('" + Int32.Parse(p2GuestID.Text) + "', '" + p2FirstName.Text + "', '" + p2MiddleName.Text + "', '" + p2LastName.Text + "', '" + p2PhoneNumber.Text + "', '" + p2EmailAddress.Text + "', '" + DateTime.Now.ToString() + "')";
                        connection.Open();
                        using (SqliteCommand command = new SqliteCommand(query, connection))
                        {
                            command.ExecuteScalar();
                        }
                        connection.Close();
                    }
                }
                if ((addPersonInfo2.Visible == true) && (p3GuestID.Text == p3TempGuestID))
                {
                    using (SqliteConnection connection = new SqliteConnection(connectionString))
                    {
                        string query = "insert into r_Guest (GuestID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, DateAdded) values " +
                            "('" + Int32.Parse(p3GuestID.Text) + "', '" + p3FirstName.Text + "', '" + p3MiddleName.Text + "', '" + p3LastName.Text + "', '" + p3PhoneNumber.Text + "', '" + p3EmailAddress.Text + "', '" + DateTime.Now.ToString() + "')";
                        connection.Open();
                        using (SqliteCommand command = new SqliteCommand(query, connection))
                        {
                            command.ExecuteScalar();
                        }
                        connection.Close();
                    }
                }
                if ((addPersonInfo3.Visible == true) && (p4GuestID.Text == p4TempGuestID))
                {
                    using (SqliteConnection connection = new SqliteConnection(connectionString))
                    {
                        string query = "insert into r_Guest (GuestID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, DateAdded) values " +
                            "('" + Int32.Parse(p4GuestID.Text) + "', '" + p4FirstName.Text + "', '" + p4MiddleName.Text + "', '" + p4LastName.Text + "', '" + p4ContactNumber.Text + "', '" + p4EmailAddress.Text + "', '" + DateTime.Now.ToString() + "')";
                        connection.Open();
                        using (SqliteCommand command = new SqliteCommand(query, connection))
                        {
                            command.ExecuteScalar();
                        }
                        connection.Close();
                    }
                }
                if ((addPersonInfo4.Visible == true) && (p5GuestID.Text == p5TempGuestID))
                {
                    using (SqliteConnection connection = new SqliteConnection(connectionString))
                    {
                        string query = "insert into r_Guest (GuestID, FirstName, MiddleName, LastName, ContactNumber, EmailAddress, DateAdded) values " +
                            "('" + Int32.Parse(p5GuestID.Text) + "', '" + p5FirstName.Text + "', '" + p5MiddleName.Text + "', '" + p5LastName.Text + "', '" + p5ContactNumber.Text + "', '" + p5EmailAddress.Text + "', '" + DateTime.Now.ToString() + "')";
                        connection.Open();
                        using (SqliteCommand command = new SqliteCommand(query, connection))
                        {
                            command.ExecuteScalar();
                        }
                        connection.Close();
                    }
                }

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    string query = "insert into t_BookedGuest (TransactionID, GuestID, BookingID, TransactionDate) values ('" + Int32.Parse(transactionID.Text) + "', '" + Int32.Parse(guestID.Text) + "', '"
                        + Int32.Parse(bookingID.Text) + "', '" + DateTime.Now.ToString() + "')";
                    string query2 = "insert into t_BookingTransaction (ReceiptNumber, TransactionID, GuestID, TransactionDate, RoomCost, VAT, TotalCost, ModePayment) " +
                        "values ('" + ReceiptNumber + "', '" + Int32.Parse(transactionID.Text) + "', '" + Int32.Parse(guestID.Text) + "', '" + DateTime.Now.ToString() + "', '" + Int32.Parse(roomCost.Text) + "', '" + Int32.Parse(tax.Text) + "', '" + Int32.Parse(totalPrice.Text) + "', 'cash')";
                    string query3 = "insert into t_RoomStatus (RoomStatusID, TransactionID, Status, RoomID, ScheduledCheckIn, ScheduledCheckout)" +
                        "values ('" + RoomStatusID + "','" + Int32.Parse(transactionID.Text) + "','Occupied','" + RoomID + "','" + dateCheckIn.Value.ToString() + "','" + dateCheckOut.Value.ToString() + "')";
                    string query4 = "update t_RoomAvailability set Status = 'Occupied' where RoomID ='" + RoomID + "'";
                    string query5 = "insert into t_BookedGuest (TransactionID, GuestID, BookingID, TransactionDate) values ('" + (Int32.Parse(transactionID.Text) + 1) + "', '" + Int32.Parse(p2GuestID.Text) + "', '"
                        + Int32.Parse(bookingID.Text) + "', '" + DateTime.Now.ToString() + "')";
                    string query6 = "insert into t_BookedGuest (TransactionID, GuestID, BookingID, TransactionDate) values ('" + (Int32.Parse(transactionID.Text) + 2) + "', '" + Int32.Parse(p3GuestID.Text) + "', '"
                         + Int32.Parse(bookingID.Text) + "', '" + DateTime.Now.ToString() + "')";
                    string query7 = "insert into t_BookedGuest (TransactionID, GuestID, BookingID, TransactionDate) values ('" + (Int32.Parse(transactionID.Text) + 3) + "', '" + Int32.Parse(p4GuestID.Text) + "', '"
                        + Int32.Parse(bookingID.Text) + "', '" + DateTime.Now.ToString() + "')";
                    string query8 = "insert into t_BookedGuest (TransactionID, GuestID, BookingID, TransactionDate) values ('" + (Int32.Parse(transactionID.Text) + 4) + "', '" + Int32.Parse(p5GuestID.Text) + "', '"
                        + Int32.Parse(bookingID.Text) + "', '" + DateTime.Now.ToString() + "')";
                    connection.Open();
                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    if(addPersonInfo1.Visible == true || addPersonInfo2.Visible == true || addPersonInfo3.Visible == true || addPersonInfo4.Visible == true)
                    {
                        if (addPersonInfo1.Visible == true)
                        {
                            using (SqliteCommand command = new SqliteCommand(query5, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                        if (addPersonInfo2.Visible == true)
                        {
                            using (SqliteCommand command = new SqliteCommand(query6, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                        if (addPersonInfo3.Visible == true)
                        {
                            using (SqliteCommand command = new SqliteCommand(query7, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                        if (addPersonInfo4.Visible == true)
                        {
                            using (SqliteCommand command = new SqliteCommand(query8, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
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
                MessageBox.Show("Room #" + cmbRoomNumber.SelectedValue + " Booked Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                BookSuccess();
            }
            ClearP2Info();
            ClearP3Info();
            ClearP4Info();
            ClearP5Info();
            personPanel.Visible = false;
        }

        private void tabRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> clear = new List<string> { "" };
            if (tabRoomTypes.SelectedIndex == 6)
            {
                cmbRoomNumber.Enabled = false;
                dateCheckIn.Enabled = false;
                dateCheckOut.Enabled = false;
                roomCost.Text = "";
                cmbRoomNumber.DataSource = clear;
                cmbRoomNumber.SelectedIndex = 0;
            }


            else if (tabRoomTypes.SelectedIndex == 0)
            {
                roomCost.Text = RoomPrice[2].ToString();
                roomInformation.Text = description[0];
                roomInclusion.Text = inclusion[0];
                cmbRoomNumber.DataSource = SingleRoomNumber;
                selectedTab = "SingleRoom";
                cmbRoomNumber.Enabled = true;
                dateCheckIn.Enabled = true;
                dateCheckOut.Enabled = true;
                cmbRoomNumber.SelectedIndex = 0;
            }
            else if (tabRoomTypes.SelectedIndex == 1)
            {

                roomCost.Text = RoomPrice[3].ToString();
                roomInformation.Text = description[1];
                roomInclusion.Text = inclusion[1];
                cmbRoomNumber.DataSource = StandardDoubleRoomNumber;
                selectedTab = "StandardDoubleRoom";
                cmbRoomNumber.Enabled = true;
                dateCheckIn.Enabled = true;
                dateCheckOut.Enabled = true;
                cmbRoomNumber.SelectedIndex = 0;

            }
            else if (tabRoomTypes.SelectedIndex == 2)
            {

                roomCost.Text = RoomPrice[4].ToString();
                roomInformation.Text = description[2];
                roomInclusion.Text = inclusion[2];
                cmbRoomNumber.DataSource = StandardTwinRoomNumber;
                selectedTab = "StandardTwinRoom";
                cmbRoomNumber.Enabled = true;
                dateCheckIn.Enabled = true;
                dateCheckOut.Enabled = true;
                cmbRoomNumber.SelectedIndex = 0;

            }
            else if (tabRoomTypes.SelectedIndex == 3)
            {
                roomCost.Text = RoomPrice[0].ToString();
                roomInformation.Text = description[3];
                roomInclusion.Text = inclusion[3];
                cmbRoomNumber.DataSource = DeluxeDoubleRoomNumber;
                selectedTab = "DeluxeDoubleRoom";
                cmbRoomNumber.Enabled = true;
                dateCheckIn.Enabled = true;
                dateCheckOut.Enabled = true;
                cmbRoomNumber.SelectedIndex = 0;
            }
            else if (tabRoomTypes.SelectedIndex == 4)
            {
                roomCost.Text = RoomPrice[5].ToString();
                roomInformation.Text = description[4];
                roomInclusion.Text = inclusion[4];
                cmbRoomNumber.DataSource = StudioRoomNumber;
                selectedTab = "StudioRoom";
                cmbRoomNumber.Enabled = true;
                dateCheckIn.Enabled = true;
                dateCheckOut.Enabled = true;
                cmbRoomNumber.SelectedIndex = 0;
            }
            else if (tabRoomTypes.SelectedIndex == 5)
            {
                roomCost.Text = RoomPrice[1].ToString();
                roomInformation.Text = description[5];
                roomInclusion.Text = inclusion[5];
                cmbRoomNumber.DataSource = PresidentialSuiteNumber;
                selectedTab = "PresidentialSuite";
                cmbRoomNumber.Enabled = true;
                dateCheckIn.Enabled = true;
                dateCheckOut.Enabled = true;
                cmbRoomNumber.SelectedIndex = 0;
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
            if (tabRoomTypes.SelectedIndex != 6)
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



        private void dateCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dateCheckOut.MinDate = dateCheckIn.Value;
        }
        #endregion

        #region AddPersonComplexityPanel
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (personPanel.Visible == false)
            {
                personPanel.Visible = true;
                p2TempGuestID = p2GuestID.Text = (Int64.Parse(tempGuestID) + 1).ToString();
                if (tabRoomTypes.SelectedIndex == 0)
                {
                    addButton.Visible = false;
                }
                else if (tabRoomTypes.SelectedIndex == 1 || tabRoomTypes.SelectedIndex == 2 || tabRoomTypes.SelectedIndex == 3 || tabRoomTypes.SelectedIndex == 4 || tabRoomTypes.SelectedIndex == 5)
                {
                    addButton.Visible = true;
                }
            }
            else 
            { 
                personPanel.Visible = false;
                ClearP2Info();
                ClearP3Info();
                ClearP4Info();
                ClearP5Info(); 
            }
        }

        private void addPersonInfo2_VisibleChanged(object sender, EventArgs e)
        {
            if (addPersonInfo2.Visible == true)
            {
                p3TempGuestID = p3GuestID.Text = (Int64.Parse(tempGuestID) + 2).ToString();
                pictureBox3.Visible = true;
                remove2.Visible = true;
                addButton.Visible = false;
                if (tabRoomTypes.SelectedIndex == 4 || tabRoomTypes.SelectedIndex == 5)
                {
                    addButton2.Visible = true;
                }
                remove1.Visible = false;
                remove2.Visible = true;

            }
            else if (addPersonInfo2.Visible == false)
            {
                pictureBox3.Visible = false;
                addButton.Visible = true;
                addButton2.Visible = false;
                remove1.Visible = true;
                remove2.Visible = false;
            }
        }

        private void addPersonInfo3_VisibleChanged(object sender, EventArgs e)
        {
            if (addPersonInfo3.Visible == true)
            {
                p4TempGuestID = p4GuestID.Text = (Int64.Parse(tempGuestID) + 3).ToString();
                pictureBox4.Visible = true;
                addButton2.Visible = false;
                if (tabRoomTypes.SelectedIndex == 5)
                {
                    addButton3.Visible = true;
                }
                remove2.Visible = false;
                remove3.Visible = true;
            }
            else if (addPersonInfo3.Visible == false)
            {
                pictureBox4.Visible = false;
                remove2.Visible = true;
                addButton2.Visible = true;
                addButton3.Visible = false;
                remove3.Visible = false;
            }
        }

        private void addPersonInfo4_VisibleChanged(object sender, EventArgs e)
        {
            if (addPersonInfo4.Visible == true)
            {
                p5TempGuestID = p5GuestID.Text = (Int64.Parse(tempGuestID) + 4).ToString();
                pictureBox5.Visible = true;
                addButton3.Visible = false;
                remove3.Visible = false;
                remove4.Visible = true;
            }
            else if (addPersonInfo4.Visible == false)
            {
                pictureBox5.Visible = false;
                remove3.Visible = true;
                addButton3.Visible = true;
                remove4.Visible = false;
            }
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            addPersonInfo3.Visible = true;
            totalPrice.Text = (Int32.Parse(totalPrice.Text) + 200).ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addPersonInfo2.Visible = true;
            totalPrice.Text = (Int32.Parse(totalPrice.Text) + 200).ToString();
        }

        private void addButton3_Click(object sender, EventArgs e)
        {
            addPersonInfo4.Visible = true;
            totalPrice.Text = (Int32.Parse(totalPrice.Text) + 200).ToString();
        }

        private void remove1_Click(object sender, EventArgs e)
        {
            ClearP2Info();
            personPanel.Visible = false;
        }

        private void remove2_Click(object sender, EventArgs e)
        {
            ClearP3Info();
            totalPrice.Text = (Int32.Parse(totalPrice.Text) - 200).ToString();
            addPersonInfo2.Visible = false;
        }

        private void remove3_Click(object sender, EventArgs e)
        {
            ClearP4Info();
            totalPrice.Text = (Int32.Parse(totalPrice.Text) - 200).ToString();
            addPersonInfo3.Visible = false;
        }

        private void remove4_Click(object sender, EventArgs e)
        {
            ClearP5Info();
            totalPrice.Text = (Int32.Parse(totalPrice.Text) - 200).ToString();
            addPersonInfo4.Visible = false;
        }
        #endregion

        //Invoice Summary Panel includes the below information but not limited to:

        //implement policyfee records in Invoice Summary to record the collected fees from the guest/s who broke the company policy or company code of blah blah.
        //    |-- Referencing the policyfee ticket to the transcationID.

        //On booked guests, additional requests that includes fees are subject to t_additional table where it references the transactionID of the Guest.
        //    |-- 
    }
}