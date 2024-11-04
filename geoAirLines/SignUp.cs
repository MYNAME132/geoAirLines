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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace geoAirLines
{
    public partial class SignUp : Form
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iliat\OneDrive\Документы\AirLinesDb.mdf;Integrated Security=True;Connect Timeout=30");

        public SignUp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int GetLatestUserId()
        {
            int userId = 0;
            try
            {
                Con.Open();
                string query = "SELECT ISNULL(MAX(UserId), 0) FROM [dbo].[UserTb]";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    userId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during retrieving latest UserId: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            string password = Password.Text;

            // Simple validation
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            int userId = GetLatestUserId() + 1;

            // SQL query for inserting a new user
            string query = "INSERT INTO [dbo].[UserTb] (UserId, UserName, Password) VALUES (@UserId, @UserName, @Password)";

            try
            {
                Con.Open();
                using (SqlCommand command = new SqlCommand(query, Con))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);

                    int result = command.ExecuteNonQuery();
                    if (RepeatPassword.Text != Password.Text)
                    {
                        MessageBox.Show("Enter right passowred");
                        return;
                    }

                    if (result > 0)
                    {
                        MessageBox.Show("User registered successfully.");
                        MessageBox.Show("Your user ID is " + userId);
                    }
                    else
                    {
                        MessageBox.Show("Sign up failed.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}