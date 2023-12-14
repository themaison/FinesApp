using Npgsql;
using System;
using System.Data;
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
            if (protocolDGV.RowCount == 0)
            {
                MessageBox.Show("Список протоколов пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();
                DriverPaymentForm driverPaymentForm = new DriverPaymentForm();
                driverPaymentForm.driver = driver;

                DataGridViewRow ds = protocolDGV.CurrentRow;
                int protocol_id = (int)ds.Cells["protocol_id"].Value;

                DataTable table = new DataTable();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                NpgsqlCommand command;

                string query = 
                    "SELECT * FROM protocol " +
                    "WHERE protocol.protocol_id = @protocolId";

                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@protocolId", protocol_id);

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    driverPaymentForm.protocol = new Protocol(
                        (int)row[0],
                        (int)row[1],
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString(),
                        row[5].ToString(),
                        (int)row[6]
                    );
                }

                DB.closeConnection();

                driverPaymentForm.Show();
            }
        }


        private void info_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverInfoForm driverInfoForm = new DriverInfoForm();
            driverInfoForm.driver = driver;
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
            DriverAuthForm driverAuthForm = new DriverAuthForm();
            driverAuthForm.Show();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            full_name_label.Text = driver.FullName;

            String licenseNumber = driver.LicenseNumber;

            DataTable driverTable = new DataTable();
            DataTable protocolTable = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            string drivers_query = 
                "SELECT * FROM vehicle " +
                "WHERE license_number = @licenseNumber";
            
            string protocols_query = 
                "SELECT protocol.protocol_id, violation.violation_name, protocol.sts_number, protocol.violation_date, protocol.violation_time, protocol.violation_place, payment_status.status_name " +
                "FROM protocol " +
                "INNER JOIN violation ON protocol.violation_id = violation.violation_id " +
                "INNER JOIN payment_status ON protocol.status_id = payment_status.status_id " +
                "WHERE sts_number IN (" +
                "SELECT sts_number " +
                "FROM vehicle " +
                "WHERE license_number = @licenseNumber)";

            DB.openConnection();

            command = new NpgsqlCommand(drivers_query, DB.GetConnection());
            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

            adapter.SelectCommand = command;
            adapter.Fill(driverTable);

            vehicleDGV.DataSource = driverTable;

            command = new NpgsqlCommand(protocols_query, DB.GetConnection());
            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

            adapter.SelectCommand = command;
            adapter.Fill(protocolTable);

            protocolDGV.DataSource = protocolTable;

            protocol_more_button.Enabled = protocolDGV.RowCount > 0;

            DB.closeConnection();
        }
    }
}
