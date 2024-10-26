using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace geoAirLines
{
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iliat\OneDrive\Документы\AirLineDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false");

        private void FillPassengerGrid()
        {
            Con.Open();
            string query = "select * from  [dbo].[passenegerTb]";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            FillPassengerGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPassinger addpas = new();
            addpas.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "")
            {
                MessageBox.Show("enter passenger ID to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from [dbo].[passenegerTb] where PassId=" + PassId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("passenger deleted sucsesfully");
                    FillPassengerGrid();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassName.Text = "";
            Pasport.Text = "";
            Gender.SelectedItem = "";
            Nationality.SelectedItem = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassId.Text) ||
                string.IsNullOrWhiteSpace(PassName.Text) ||
                string.IsNullOrWhiteSpace(Pasport.Text) ||
                string.IsNullOrWhiteSpace(PassAdd.Text) ||
                Nationality.SelectedItem == null ||
                Gender.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields, including Nationality and Gender.");
                return;
            }
            try
            {
                Con.Open();

                // Prepare the SQL update query
                string query = "UPDATE [dbo].[PassenegerTb] " +
                               "SET PassName=@PassName, Passport=@Passport, PassAd=@PassAd, Nationality=@Nationality, Gender=@Gender " +
                               "WHERE PassId=@PassId";

                SqlCommand cmd = new SqlCommand(query, Con);

                // Set the parameters for the query
                cmd.Parameters.AddWithValue("@PassId", PassId.Text); 
                cmd.Parameters.AddWithValue("@PassName", PassName.Text);
                cmd.Parameters.AddWithValue("@Passport", Pasport.Text);
                cmd.Parameters.AddWithValue("@PassAd", PassAdd.Text);
                cmd.Parameters.AddWithValue("@Nationality", Nationality.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Gender", Gender.SelectedItem.ToString());

                // Execute the query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Passenger information updated successfully");

                Con.Close();
                FillPassengerGrid();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close(); // Ensure connection is closed even if there's an error
            }
        }
        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PassengerDGV.CurrentRow != null)
            {
                // Transfer the values from the grid to the text fields
                PassId.Text = PassengerDGV.CurrentRow.Cells[0].Value.ToString();
                PassName.Text = PassengerDGV.CurrentRow.Cells[1].Value.ToString();
                Pasport.Text = PassengerDGV.CurrentRow.Cells[2].Value.ToString();
                PassAdd.Text = PassengerDGV.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row.");
            }
        }

    }
}
