using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geoAirLines
{
    public partial class AddFlight : Form
    {

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iliat\OneDrive\Документы\AirLineDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false");

        public AddFlight()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FlightCode.Text == "" || FlightSeats.Text == "" || Destinetion.Text == "" || Source.Text == "" || FlightDate.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO [dbo].[FlightTb](FlightCode, Flightsrc, FlightDes, FlightDate, FlightCap) " +
                                   "VALUES (@FlightCode, @Flightsrc, @FlightDes, @FlightDate, @FlightCap)";


                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@FlightCode", FlightCode.Text);
                    cmd.Parameters.AddWithValue("@Flightsrc", Source.Text);
                    cmd.Parameters.AddWithValue("@FlightDes", Destinetion.Text);
                    cmd.Parameters.AddWithValue("@FlightDate", FlightDate.Text);
                    cmd.Parameters.AddWithValue("@FlightCap", FlightSeats.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Flight information recorded successfully.");

                    Con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FlightTable FlightTb = new FlightTable();
            FlightTb.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home home= new Home();
            home.Show();
            this.Hide();
        }
    }
}
