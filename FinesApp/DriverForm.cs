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
    public partial class DriverForm : Form
    {
        public Driver driver { get; set; }
        public DriverForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void protocol_more_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverPaymentForm driverPaymenform = new DriverPaymentForm();
            driverPaymenform.Show();
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverInfoForm driverInfoForm = new DriverInfoForm();
            driverInfoForm.Show();
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverProfileForm driverProfileForm = new DriverProfileForm();
            driverProfileForm.driver = driver;
            driverProfileForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            full_name_label.Text = driver.FullName;

            String licenseNumber = driver.LicenseNumber;

            DB db = new DB();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            string query = "SELECT * FROM vehicle WHERE license_number = @licenseNumber";
            string query2 = "SELECT * FROM protocol WHERE sts_number IN (SELECT sts_number FROM vehicle WHERE license_number = @licenseNumber)";

            db.openConnection();

            command = new NpgsqlCommand(query, db.GetConnection());
            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

            adapter.SelectCommand = command;
            adapter.Fill(table1);

            violationDGV.DataSource = table1;

            command = new NpgsqlCommand(query2, db.GetConnection());
            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

            adapter.SelectCommand = command;
            adapter.Fill(table2);

            protocolDGV.DataSource = table2;

            db.closeConnection();
        }

    }
}
