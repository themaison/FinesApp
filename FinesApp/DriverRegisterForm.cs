using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinesApp
{
    public partial class DriverRegisterForm : Form
    {
        public DriverRegisterForm()
        {
            InitializeComponent();
            //licenseNumberTextBox.Text = "ХХХХХХХХХХ";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void licenseNumberEnter(object sender, EventArgs e)
        {
            //if (licenseNumberTextBox.Text == "ХХХХХХХХХХ")
            //{
            //    licenseNumberTextBox.Text = "";
            //    licenseNumberTextBox.ForeColor = Color.Black;
            //}
        }

        private void licenseNumberLeave(object sender, EventArgs e)
        {
            //if (licenseNumberTextBox.Text == "")
            //{
            //    licenseNumberTextBox.Text = "ХХХХХХХХХХ";
            //    licenseNumberTextBox.ForeColor = Color.Gray;
            //}
        }

        private void driverRegisterButtonClick(object sender, EventArgs e)
        {
            String licenseNumber = licenseNumberTextBox.Text;
            String fullName = fioTextBox.Text;
            String gender = "";
            DateTime birthDate = birthDatePicker.Value;
            DateTime licenseIssueDate = licenseIssueDatePicker.Value;
            DateTime licenseValidityDate = licenseValidityDatePicker.Value;

            gender = maleRB.Checked ? "Мужской" : (femaleRB.Checked ? "Женский" : "");

            if (string.IsNullOrEmpty(licenseNumber) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(gender) || birthDate == DateTime.MinValue || licenseIssueDate == DateTime.MinValue || licenseValidityDate == DateTime.MinValue)
                {
                MessageBox.Show("Есть незаполненные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (IsDriverExists(licenseNumber))
            {
                return;
            }


                DB db = new DB();

            string query = "INSERT INTO driver (license_number, full_name, gender, birth_date, license_issue_date, license_validity) VALUES (@licenseNumber, @fullName, @gender, @birthDate, @licenseIssueDate, @licenseValidityDate)";

            NpgsqlCommand command = new NpgsqlCommand(query, db.GetConnection());
            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
            command.Parameters.AddWithValue("@fullName", fullName);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@birthDate", birthDate);
            command.Parameters.AddWithValue("@licenseIssueDate", licenseIssueDate);
            command.Parameters.AddWithValue("@licenseValidityDate", licenseValidityDate);


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Водитель успешно зарегистирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                DriverAuthForm driverAuthForm = new DriverAuthForm();
                driverAuthForm.Show();
            }
            else
            {
                MessageBox.Show("Упс... Регистрация не удалась!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            db.closeConnection();
        }

        public Boolean IsDriverExists(String licenseNumber)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            string query = "SELECT * FROM driver WHERE license_number = @licenseNumber";
            NpgsqlCommand command = new NpgsqlCommand(query, db.GetConnection());

            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой номер в/у уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
