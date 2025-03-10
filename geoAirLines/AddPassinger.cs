﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;


namespace geoAirLines
{
    public partial class AddPassinger : Form
    {
        public AddPassinger()
        {
            InitializeComponent();
        }
        private SqlConnection Con = DatabaseConnection.GetConnection();

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PhoneTb.Text == "" || PassName.Text == "" || PassportTb.Text == "" || PassAd.Text == "")
            {
                MessageBox.Show("fill the blanks");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO [dbo].[PassengerTb](PassId, PassName, Passport, PassAd, Nationality, Gender) " +
                    "VALUES (@PassId, @PassName, @Passport, @PassAd, @Nationality, @Gender)";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PassId", PassId.Text);
                    cmd.Parameters.AddWithValue("@PassName", PassName.Text);
                    cmd.Parameters.AddWithValue("@Passport", PassportTb.Text);
                    cmd.Parameters.AddWithValue("@PassAd", PassAd.Text);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Gender", Gender.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passenger recorded succesfully");
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
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ViewPassenger viewPassenger = new ViewPassenger();
            viewPassenger.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassName.Text = "";
            PassportTb.Text = "";
            PassAd.Text = "";
            PhoneTb.Text = "";
            Nationality.Text = "";
            Gender.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void PassId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}