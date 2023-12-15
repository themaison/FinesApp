using Npgsql;
using System;
using System.Data;
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
            //DataTable table1 = new DataTable();
            //DataTable table2 = new DataTable();

            //NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            //NpgsqlCommand command;

            //string query = "SELECT * FROM violation";
            //string query2 = "SELECT * FROM payment_status";

            //DB.openConnection();

            //command = new NpgsqlCommand(query, DB.GetConnection());

            //adapter.SelectCommand = command;
            //adapter.Fill(table1);

            //violationDGV.DataSource = table1;

            //command = new NpgsqlCommand(query2, DB.GetConnection());

            //adapter.SelectCommand = command;
            //adapter.Fill(table2);

            //paymentStatusDGV.DataSource = table2;

            //DB.closeConnection();

            violationDGV.DataSource = ViolationTable.GetTable();
            paymentStatusDGV.DataSource = PaymentStatusTable.GetTable();
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
