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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private SqlConnection Con = DatabaseConnection.GetConnection();
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Simple validation
            if (string.IsNullOrEmpty(UserName.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(UserId.Text))
            {
                MessageBox.Show("Please enter UserId, username, and password.");
                return;
            }

            try
            {
                Con.Open();
                string query = "SELECT COUNT(1) FROM [dbo].[UserTb] WHERE UserName = @UserName AND Password = @Password AND UserId = @UserId";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@UserId", UserId.Text);
                    cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }
    }
}