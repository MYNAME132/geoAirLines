using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace geoAirLines
{
    public partial class FlightTable : Form
    {

        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iliat\OneDrive\Документы\AirLineDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false");

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FillFlightGrid()
        {
            Con.Open();
            string query = "select * from  [dbo].[FlightTb]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDVG.DataSource = ds.Tables[0];
            Con.Close();
        }

        public FlightTable()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FlightCode.Text) ||
                          string.IsNullOrWhiteSpace(FlightDate.Text) ||
                          string.IsNullOrWhiteSpace(FlightSeats.Text) ||
                          string.IsNullOrWhiteSpace(FlightDate.Text) ||
                          Destinetion.SelectedItem == null ||
                          Source.SelectedItem == null) 
            {
                MessageBox.Show("Please fill in all fields, including destination and source.");
                return;
            }

            try
            {
                Con.Open();

                string query = "UPDATE [dbo].[FlightTb] " +
                               "SET Flightsrc=@Flightsrc, FlightDate=@FlightDate, FlightDes=@FlightDes, Flightcap=@Flightcap " +
                               "WHERE FlightCode=@FlightCode";

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@FlightCode", FlightCode.Text);
                cmd.Parameters.AddWithValue("@Flightcap", FlightSeats.Text);
                cmd.Parameters.AddWithValue("@FlightDate", FlightDate.Text);
                cmd.Parameters.AddWithValue("@Flightsrc", Source.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@FlightDes", Destinetion.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight information updated successfully");

                Con.Close();
                FillFlightGrid();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void FlightTable_Load(object sender, EventArgs e)
        {
            FillFlightGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FlightCode.Text == "")
            {
                MessageBox.Show("enter Flight ID to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from [dbo].[FlightTb] where FlightCode=" + FlightCode.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Flight deleted sucsesfully");
                    FillFlightGrid();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void FlightDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FlightDVG.CurrentRow != null)
            {
                FlightCode.Text = FlightDVG.CurrentRow.Cells[0].Value.ToString();
                Source.Text = FlightDVG.CurrentRow.Cells[1].Value.ToString();
                Destinetion.Text = FlightDVG.CurrentRow.Cells[2].Value.ToString();
                FlightDate.Text = FlightDVG.CurrentRow.Cells[3].Value.ToString();
                FlightSeats.Text = FlightDVG.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFlight AddFlight = new AddFlight();
            AddFlight.Show();
            this.Hide();
        }
    }
}
