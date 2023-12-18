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
        }

        private void driverRegisterButtonClick(object sender, EventArgs e)
        {
            String licenseNumber = licenseNumberTextBox.Text;
            String fullName = fioTextBox.Text;
            String gender = "";
            DateTime birthDate = birthDatePicker.Value;
            DateTime licenseIssueDate = licenseIssueDatePicker.Value;
            DateTime licenseValidityDate = licenseValidityDatePicker.Value;

            if (maleRB.Checked)
            {
                gender = "Мужской";
            }
            else if (femaleRB.Checked)
            {
                gender = "Женский";
            }

            if (licenseNumber == "" || fullName == "" || gender == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (DriverTable.IsExistsDriver(licenseNumber))
            {
                licenseNumberTextBox.Text = "";
                Messages.DisplayErrorMessage("Такой номер в/у уже существует!");
                return;
            }

            if (DriverTable.Insert(licenseNumber, fullName, gender, birthDate, licenseIssueDate, licenseValidityDate))
            {
                licenseNumberTextBox.Text = "";
                fioTextBox.Text = "";
                //birthDatePicker.Value = DateTime.MinValue;
                //licenseIssueDatePicker.Value = DateTime.MinValue;
                //licenseValidityDatePicker.Value = DateTime.MinValue;

                this.Hide();
                DriverAuthForm driverAuthForm = new DriverAuthForm();
                driverAuthForm.Show();
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");








            //String licenseNumber = licenseNumberTextBox.Text;
            //String fullName = fioTextBox.Text;
            //String gender = "";
            //DateTime birthDate = birthDatePicker.Value;
            //DateTime licenseIssueDate = licenseIssueDatePicker.Value;
            //DateTime licenseValidityDate = licenseValidityDatePicker.Value;

            //if (maleRB.Checked)
            //{
            //    gender = "Мужской";
            //}
            //else if (femaleRB.Checked)
            //{
            //    gender = "Женский";
            //}

            //if (licenseNumber == "" || fullName == "" || gender == "" || birthDate == DateTime.MinValue || licenseIssueDate == DateTime.MinValue || licenseValidityDate == DateTime.MinValue)
            //{
            //    Messages.DisplayErrorMessage("Заполните все поля!");
            //    return;
            //}

            //if (DriverTable.IsExistsDriver(licenseNumber))
            //{
            //    licenseNumberTextBox.Text = "";
            //    Messages.DisplayErrorMessage("Такой номер в/у уже существует!");
            //    return;
            //}

            //if (DriverTable.Insert(licenseNumber, fullName, gender, birthDate, licenseIssueDate, licenseValidityDate))
            //{
            //    this.Hide();
            //    DriverAuthForm driverAuthForm = new DriverAuthForm();
            //    driverAuthForm.Show();
            //}
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverAuthForm driverAuthForm = new DriverAuthForm();
            driverAuthForm.Show();
        }

        private void licenseNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[А-Яа-я\s]") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
