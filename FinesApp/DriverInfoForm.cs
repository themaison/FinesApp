using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class DriverInfoForm : Form
    {
        public Driver driver { get; set; }
        public DriverInfoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DriverInfoForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            string query = "SELECT * FROM violation";
            string query2 = "SELECT * FROM payment_status";

            db.openConnection();

            command = new NpgsqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table1);

            violationDGV.DataSource = table1;

            command = new NpgsqlCommand(query2, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table2);

            paymentStatusDGV.DataSource = table2;

            db.closeConnection();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {

            this.Hide();
            DriverForm driverForm = new DriverForm();
            driverForm.driver = driver;
            driverForm.Show();
        }
    }
}
