using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class DriverPaymentForm : Form
    {
        public Driver driver { get; set; }
        public Protocol protocol { get; set; }

        //public int protocolId { get; set; }
        public DriverPaymentForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverForm driverForm = new DriverForm();
            driverForm.driver = driver;
            driverForm.Show();
        }

        private void DriverPaymentForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            string query = "SELECT protocol.violation_id, violation.violation_name, protocol.sts_number, protocol.violation_date, protocol.violation_time, protocol.violation_place, payment_status.status_name, violation.fine_amount " +
                "FROM protocol " +
                "INNER JOIN violation ON protocol.violation_id = violation.violation_id " +
                "INNER JOIN payment_status ON protocol.status_id = payment_status.status_id " +
                "WHERE protocol.protocol_id = @protocolId";

            db.openConnection();

            command = new NpgsqlCommand(query, db.GetConnection());
            command.Parameters.AddWithValue("@protocolId", protocol.ProtocolId);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                violation_id_label.Text = "ID Нарушения: " + row[0].ToString();
                violation_name_label.Text = row[1].ToString();
                sts_number_label.Text = row[2].ToString();
                violation_date_label.Text = Convert.ToDateTime(row[3]).ToString("dd.MM.yyyy");
                violation_time_label.Text = row[4].ToString();
                violation_place_label.Text = row[5].ToString();
                status_label.Text = row[6].ToString();
                fine_cost_label.Text = row[7].ToString() + "₽";


                if (protocol.StatusId == 1)
                {
                    status_label.ForeColor = Color.Red;
                }
                else if (protocol.StatusId == 2)
                {
                    payButton.Enabled = false;
                    status_label.ForeColor = Color.Green;
                }
                else if (protocol.StatusId == 3)
                {
                    payButton.Enabled = false;
                    status_label.ForeColor = Color.Yellow;
                }
                else
                {
                    status_label.ForeColor = Color.Black;
                }
            }

            db.closeConnection();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            int newStatusId = 2;

            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            string updateQuery = 
                "UPDATE protocol SET status_id = @newStatusId " +
                "WHERE protocol_id = @protocolId";

            string statusQuery =
               "SELECT status_name " +
               "FROM payment_status " +
               "WHERE status_id = @newStatusId";

            db.openConnection();

            command = new NpgsqlCommand(updateQuery, db.GetConnection());
            command.Parameters.AddWithValue("@newStatusId", newStatusId);
            command.Parameters.AddWithValue("@protocolId", protocol.ProtocolId);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                command = new NpgsqlCommand(statusQuery, db.GetConnection());
                command.Parameters.AddWithValue("@newStatusId", newStatusId);

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    status_label.Text = row["status_name"].ToString();
                }

                status_label.ForeColor = Color.Green;
                payButton.Enabled = false;
                MessageBox.Show("Штраф успешно оплачен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Оплата не удалась!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            db.closeConnection();
        }
    }
}
