﻿using Npgsql;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinesApp
{
    public partial class AdminDriversForm : Form
    {
        public AdminDriversForm()
        {
            InitializeComponent();
        }

        private void AdminDriversForm_Load(object sender, EventArgs e)
        {
            insert_driver_box.Visible = false;
            update_driver_box.Visible=false;

            driverDGV.DataSource = DriverTable.GetTable();

            if (driverDGV.RowCount < 1)
            {
                update_box_button.Enabled = false;
                delete_button.Enabled = false;
            }
            else
            {
                update_box_button.Enabled = true;
                delete_button.Enabled = true;
            }
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            insert_driver_box.Visible = true;
            update_driver_box.Visible = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update_driver_box.Visible = true;
            insert_driver_box.Visible = false;

            DataGridViewRow ds = driverDGV.CurrentRow;

            String licenseNumber = ds.Cells[0].Value.ToString();
            String fullName = ds.Cells[1].Value.ToString();
            String gender = ds.Cells[2].Value.ToString();
            DateTime birthDate = (DateTime)ds.Cells[3].Value;
            DateTime licenseIssueDate = (DateTime)ds.Cells[4].Value;
            DateTime licenseValidityDate = (DateTime)ds.Cells[5].Value;

            update_tb1.Text = licenseNumber;
            update_tb2.Text = fullName;
            update_dp1.Value = birthDate;
            update_dp2.Value = licenseIssueDate;
            update_dp3.Value = licenseValidityDate;

            if (gender == "Мужской")
            {
                male_update_rb.Checked = true;
            }
            else
            {
                female_update_rb.Checked = true;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                String licenseNumber = driverDGV.CurrentRow.Cells[0].Value.ToString();
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные?");
                if (dr == DialogResult.Yes)
                {
                    DriverTable.Delete(licenseNumber);
                    driverDGV.DataSource = DriverTable.GetTable();
                    Messages.DisplayInfoMessage("Данные успешно удалены!");
                }
            }
            catch {
                Messages.DisplayErrorMessage("Ошибка при удалении данных!");
            }
        }

        private void insert_cancel_box_button_Click(object sender, EventArgs e)
        {
            insert_driver_box.Visible = false;
        }

        private void update_cancel_box_button_Click(object sender, EventArgs e)
        {
            update_driver_box.Visible = false;
        }


        private void insert_box_button_Click(object sender, EventArgs e)
        {
            String licenseNumber = insert_tb1.Text;
            String fullName = insert_tb2.Text;
            String gender = "";
            DateTime birthDate = insert_dp1.Value;
            DateTime licenseIssueDate = insert_dp2.Value;
            DateTime licenseValidityDate = insert_dp3.Value;

            if (male_insert_rb.Checked)
            {
                gender = "Мужской";
            }
            else if (female_insert_rb.Checked)
            {
                gender = "Женский";
            }

            if (licenseNumber=="" || fullName=="" || gender=="")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (DriverTable.IsExistsDriver(licenseNumber))
            {
                insert_tb1.Text = "";
                Messages.DisplayErrorMessage("Такой номер в/у уже существует!");
                return;
            }

            if (DriverTable.Insert(licenseNumber, fullName, gender, birthDate, licenseIssueDate, licenseValidityDate))
            {
                insert_tb1.Text = "";
                insert_tb2.Text = "";

                insert_driver_box.Visible = false;

                driverDGV.DataSource = DriverTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_box_button_Click(object sender, EventArgs e)
        {
            String licenseNumber = update_tb1.Text;
            String fullName = update_tb2.Text;
            String gender;
            DateTime birthDate = update_dp1.Value;
            DateTime licenseIssueDate = update_dp2.Value;
            DateTime licenseValidityDate = update_dp3.Value;
            gender = male_update_rb.Checked ? "Мужской" : "Женский";

            String currentLicenseNumber = driverDGV.CurrentRow.Cells[0].Value.ToString();

            if (licenseNumber == "" || fullName == "" || gender == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (licenseNumber == currentLicenseNumber)
            {
                if (DriverTable.Update(currentLicenseNumber, fullName, gender, birthDate, licenseIssueDate, licenseValidityDate))
                {
                    driverDGV.DataSource = DriverTable.GetTable();
                    update_driver_box.Visible = false;
                    Messages.DisplayInfoMessage("Данные успешно обновлены!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                }
            }
            else
            {
                if (DriverTable.IsExistsDriver(licenseNumber))
                {
                    update_tb1.Text = "";
                    Messages.DisplayErrorMessage("Такой номер в/у уже существует!");
                }

                else
                {
                    if (DriverTable.UpdateWithPrimary(currentLicenseNumber, licenseNumber, fullName, gender, birthDate, licenseIssueDate, licenseValidityDate))
                    {
                        driverDGV.DataSource = DriverTable.GetTable();
                        update_driver_box.Visible = false;
                        Messages.DisplayInfoMessage("Данные успешно обновлены!");
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                    }
                }
            }
        }

        private void driverDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (driverDGV.SelectedRows.Count > 0 && update_driver_box.Visible == true)
            {
                DataGridViewRow row = driverDGV.SelectedRows[0];

                String licenseNumber = row.Cells[0].Value.ToString();
                String fullName = row.Cells[1].Value.ToString();
                String gender = row.Cells[2].Value.ToString();
                DateTime birthDate = (DateTime)row.Cells[3].Value;
                DateTime licenseIssueDate = (DateTime)row.Cells[4].Value;
                DateTime licenseValidityDate = (DateTime)row.Cells[5].Value;

                update_tb1.Text = licenseNumber;
                update_tb2.Text = fullName;
                update_dp1.Value = birthDate;
                update_dp2.Value = licenseIssueDate;
                update_dp3.Value = licenseValidityDate;

                if (gender == "Мужской")
                {
                    male_update_rb.Checked = true;
                }
                else
                {
                    female_update_rb.Checked = true;
                }
            }
        }

        private void update_tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void update_tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[А-Яа-я\s]") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void insert_tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void insert_tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[А-Яа-я\s]") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
