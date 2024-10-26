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
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from [dbo].[passenegerTb]", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PassengerID.ValueMember = "PassId";
            PassengerID.DataSource = dt;

            Con.Close();
        }


        private void FillTocketsGrid()
        {
            Con.Open();
            string query = "select * from  [dbo].[TicketTable]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
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
            MessageBox.Show($"TicketID: {TicketID.Text}, Amount: {Amount.Text}, PassengerID: {PassengerID.SelectedValue}, FlightCode: {FlightCode.Text}");

            if (string.IsNullOrWhiteSpace(TicketID.Text) ||
                string.IsNullOrWhiteSpace(Amount.Text) ||
                PassengerID.SelectedValue == null ||
                FlightCode.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all required fields and ensure selections are valid.");
                return;
            }

            try
            {
                Con.Open();

                string query = "INSERT INTO [dbo].[TicketTable] " +
                               "(TicketId, FlightCode, PassID, PassName, Passport, Gender, Nationality, PassAdd, Amount) " +
                               "VALUES (@TicketId, @FlightCode, @PassID, @PassName, @Passport, @Gender, @Nationality, @PassAdd, @Amount)";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@TicketId", TicketID.Text);
                cmd.Parameters.AddWithValue("@FlightCode", FlightCode.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PassID", PassengerID.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PassName", PassengerName.Text);
                cmd.Parameters.AddWithValue("@Passport", Passport.Text);
                cmd.Parameters.AddWithValue("@Gender", Gender.Text);
                cmd.Parameters.AddWithValue("@Nationality", Nationality.Text);
                cmd.Parameters.AddWithValue("@PassAdd", PassengerAdd.Text);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(Amount.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ticket added successfully");
                Con.Close();
                FillTocketsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
        private void TicketDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillTocketsGrid();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}