using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class AdminDriversForm : Form
    {
        public AdminDriversForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminDriversForm_Load(object sender, EventArgs e)
        {
            insert_driver_box.Visible = false;
            update_driver_box.Visible=false;

            driverDGV.DataSource = DriverTable.GetTable();

            if (driverDGV.RowCount < 1)
            {
                insert_box_button.Enabled = false;
                update_box_button.Enabled = false;
                delete_button.Enabled = false;
            }
            else
            {
                insert_box_button.Enabled = true;
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
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить данные?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DriverTable.Delete(licenseNumber);
                    driverDGV.DataSource = DriverTable.GetTable();
                    MessageBox.Show("Данные успешно удалены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch {
                MessageBox.Show("Ошибка при удалении!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            String gender;
            DateTime birthDate = insert_dp1.Value;
            DateTime licenseIssueDate = insert_dp2.Value;
            DateTime licenseValidityDate = insert_dp3.Value;

            gender = male_insert_rb.Checked ? "Мужской" : "Женский";

            if (string.IsNullOrEmpty(licenseNumber) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(gender) || birthDate == DateTime.MinValue || licenseIssueDate == DateTime.MinValue || licenseValidityDate == DateTime.MinValue)
            {
                MessageBox.Show("Есть незаполненные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (DriverTable.IsExistsDriver(licenseNumber))
            {
                insert_tb1.Text = "";
                return;
            }

            if (DriverTable.Insert(licenseNumber, fullName, gender, birthDate, licenseIssueDate, licenseValidityDate))
            {
                insert_driver_box.Visible = false;
                driverDGV.DataSource = DriverTable.GetTable();
            }
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
            
            if (licenseNumber == currentLicenseNumber)
            {
                if (String.IsNullOrEmpty(licenseNumber) || String.IsNullOrEmpty(fullName) || String.IsNullOrEmpty(gender) || birthDate == DateTime.MinValue || licenseIssueDate == DateTime.MinValue || licenseValidityDate == DateTime.MinValue)
                {
                    MessageBox.Show("Есть незаполненные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (DriverTable.Update(licenseNumber, fullName, gender, birthDate, licenseIssueDate, licenseValidityDate))
                    {
                        driverDGV.DataSource = DriverTable.GetTable();
                        update_tb1.Text = "";
                        update_tb2.Text = "";
                        male_insert_rb.Checked = false;
                        female_update_rb.Checked = false;
                    }
                }
            }
            else
            {
                if (DriverTable.IsExistsDriver(licenseNumber))
                {
                    update_tb1.Text = "";
                }
               
                return;
            }
        }
    }
}
