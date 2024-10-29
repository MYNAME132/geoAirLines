using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geoAirLines
{
    public partial class Tickets : Form
    {

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iliat\OneDrive\Документы\AirLineDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false");

        private void FillPassenger()
        {
            try
            {
                // Open the connection if it's closed
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Create the command to fetch passenger IDs
                SqlCommand cmd = new SqlCommand("SELECT PassId FROM [dbo].[passenegerTb]", Con);
                SqlDataReader rdr = cmd.ExecuteReader();

                // Create a DataTable to hold the results
                DataTable dt = new DataTable();
                dt.Columns.Add("PassId", typeof(int));
                dt.Load(rdr); // Load the data from the reader into the DataTable

                // Bind the DataTable to the PassengerID dropdown
                PassengerID.ValueMember = "PassId";
                PassengerID.DataSource = dt;

                // Enable manual entry by changing DropDownStyle and AutoCompleteMode
                PassengerID.DropDownStyle = ComboBoxStyle.DropDown;
                PassengerID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                PassengerID.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show("Error fetching passengers: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void ResetGrid()
        {
            TicketID.Text = "";
            PassengerAdd.Text = "";
            PassengerID.Text = "";
            PassengerName.Text = "";
            FlightCode.Text = "";
            Nationality.Text = "";
            Gender.Text = "";
            Passport.Text = "";
            Amount.Text = "";
        }

        private void FillTocketsGrid()
        {
            try
            {
                // Open the connection
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Define the query to fetch ticket data
                string query = "SELECT * FROM [dbo].[TicketTable]";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();

                // Fill the dataset with ticket data
                sda.Fill(ds);
                TicketDGV.DataSource = ds.Tables[0]; // Bind the data to the DataGridView
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show("Error fetching tickets: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void FetchPassenger()
        {
            string passname, passpassport, gender, nationality, passaddres;
            if (PassengerID.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid passenger.");
                return;
            }

            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Query to fetch the passenger details including address
                string query = "SELECT PassName, Passport, Gender, Nationality, PassAd FROM [dbo].[passenegerTb] WHERE PassId=@PassId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@PassId", PassengerID.SelectedValue.ToString());

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                // Check if data was found
                if (data.Rows.Count > 0)
                {
                    DataRow dr = data.Rows[0];

                    passname = dr["PassName"].ToString();
                    passpassport = dr["Passport"].ToString();
                    gender = dr["Gender"].ToString();
                    nationality = dr["Nationality"].ToString();
                    passaddres = dr["PassAd"].ToString();

                    PassengerName.Text = passname;
                    Passport.Text = passpassport;
                    Gender.Text = gender;
                    Nationality.Text = nationality;
                    PassengerAdd.Text = passaddres;
                }
                else
                {
                    MessageBox.Show("No data found for the selected passenger.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching passenger data: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)  // Ensure connection is closed
                {
                    Con.Close();
                }
            }
        }


        private void FillFlightCode()
        {
            try
            {
                Con.Open();
                string query = "SELECT FlightCode FROM [dbo].[FlightTb]";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                FlightCode.DataSource = dt;
                FlightCode.DisplayMember = "FlightCode";
                FlightCode.ValueMember = "FlightCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flight codes: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public Tickets()
        {
            InitializeComponent();

        }

        private void Tickets_Load_1(object sender, EventArgs e)
        {
            FillPassenger();
            FillFlightCode();
            FillTocketsGrid();
            ResetGrid();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PassengerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FetchPassenger();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFlight addFlight = new AddFlight();
            addFlight.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the updated values from UI
            string ticketId = TicketID.Text.Trim();
            string flightCode = FlightCode.Text.Trim();
            string passengerId = PassengerID.SelectedValue?.ToString();
            string passengerName = PassengerName.Text;
            string passport = Passport.Text;
            string gender = Gender.Text;
            string nationality = Nationality.Text;
            string passAddress = PassengerAdd.Text;
            int amount;

            // Validate if TicketID and FlightCode are provided
            if (string.IsNullOrWhiteSpace(ticketId) || string.IsNullOrWhiteSpace(flightCode) || !int.TryParse(Amount.Text, out amount))
            {
                MessageBox.Show("Please enter valid Ticket ID, Flight Code, and Amount.");
                return;
            }

            try
            {
                Con.Open();

                // Check if TicketID exists in TicketTable
                string checkQuery = "SELECT COUNT(1) FROM [dbo].[TicketTable] WHERE TicketId = @TicketId";
                SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                checkCmd.Parameters.AddWithValue("@TicketId", ticketId);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // Update the ticket information in TicketTable
                    string query = "UPDATE [dbo].[TicketTable] " +
                                         "SET FlightCode = @FlightCode, PassID = @PassID, PassName = @PassName, " +
                                         "Passport = @Passport, Gender = @Gender, Nationality = @Nationality, " +
                                         "PassAdd = @PassAdd, Amount = @Amount " +
                                         "WHERE TicketId = @TicketId";

                    SqlCommand updateCmd = new SqlCommand(query, Con);
                    updateCmd.Parameters.AddWithValue("@FlightCode", flightCode);
                    updateCmd.Parameters.AddWithValue("@PassID", passengerId);
                    updateCmd.Parameters.AddWithValue("@PassName", passengerName);
                    updateCmd.Parameters.AddWithValue("@Passport", passport);
                    updateCmd.Parameters.AddWithValue("@Gender", gender);
                    updateCmd.Parameters.AddWithValue("@Nationality", nationality);
                    updateCmd.Parameters.AddWithValue("@PassAdd", passAddress);
                    updateCmd.Parameters.AddWithValue("@Amount", amount);
                    updateCmd.Parameters.AddWithValue("@TicketId", ticketId);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ticket updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please check the entered details.");
                    }
                }
                else
                {
                    // Insert the new ticket information in TicketTable
                    string query = "INSERT INTO [dbo].[TicketTable] " +
                                         "(TicketId, FlightCode, PassID, PassName, Passport, Gender, Nationality, PassAdd, Amount) " +
                                         "VALUES (@TicketId, @FlightCode, @PassID, @PassName, @Passport, @Gender, @Nationality, @PassAdd, @Amount)";

                    SqlCommand insertCmd = new SqlCommand(query, Con);
                    insertCmd.Parameters.AddWithValue("@TicketId", ticketId);
                    insertCmd.Parameters.AddWithValue("@FlightCode", flightCode);
                    insertCmd.Parameters.AddWithValue("@PassID", passengerId);
                    insertCmd.Parameters.AddWithValue("@PassName", passengerName);
                    insertCmd.Parameters.AddWithValue("@Passport", passport);
                    insertCmd.Parameters.AddWithValue("@Gender", gender);
                    insertCmd.Parameters.AddWithValue("@Nationality", nationality);
                    insertCmd.Parameters.AddWithValue("@PassAdd", passAddress);
                    insertCmd.Parameters.AddWithValue("@Amount", amount);

                    int rowsInserted = insertCmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("New ticket added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Insertion failed. Please check the entered details.");
                    }
                }

                FillTocketsGrid(); // Refresh the grid to reflect the changes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void TicketDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillTocketsGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TicketID.Text == "")
            {
                MessageBox.Show("Enter ID");
            }
            try
            {
                Con.Open();
                string query = "delete from [dbo].[TicketTable] where TicketId=" + TicketID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("deleted succsefully");
                FillTocketsGrid();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void FlightCode_Leave(object sender, EventArgs e)
        {
            string userInput = FlightCode.Text.Trim();

            try
            {
                Con.Open();

                // Query to check if flight code exists in the database
                string query = "SELECT COUNT(1) FROM [dbo].[FlightTb] WHERE FlightCode = @FlightCode";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@FlightCode", userInput);

                // Execute the query and check if any record exists
                int count = (int)cmd.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("The entered flight code does not exist in the database.");
                }
                else
                {
                    MessageBox.Show("Flight code exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking flight code: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}