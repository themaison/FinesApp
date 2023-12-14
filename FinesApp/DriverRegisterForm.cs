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

            if (DriverTable.IsExistsDriver(licenseNumber))
            {
                licenseNumberTextBox.Text = "";
                return;
            }

            if (DriverTable.Insert(licenseNumber, fullName, gender, birthDate, licenseIssueDate, licenseValidityDate))
            {
                this.Hide();
                DriverAuthForm driverAuthForm = new DriverAuthForm();
                driverAuthForm.Show();
            }
        }

        private void licenseNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void licenseValidityDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverAuthForm driverAuthForm = new DriverAuthForm();
            driverAuthForm.Show();
        }
    }
}
