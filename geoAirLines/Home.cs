using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geoAirLines
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPassinger addPassinger = new AddPassinger();
            addPassinger.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFlight addFlight = new AddFlight();
            addFlight.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewPassenger viewPassenger = new ViewPassenger();
            viewPassenger.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FlightTable table = new FlightTable();
            table.Show();
            this.Hide();
        }
    }
}
