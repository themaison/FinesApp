﻿using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class DriverAuthForm : Form
    {
        public DriverAuthForm()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DriverAuthForm_Load(object sender, EventArgs e)
        {

        }

        private void driverLoginButton_Click(object sender, EventArgs e)
        {
            String licenseNumber = licenseNumberTextBox.Text;

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
                this.Hide();
                DriverForm  driverForm = new DriverForm();

                db.openConnection();
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Driver driver = new Driver(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDateTime(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5)
                    );

                    driverForm.driver = driver;
                }
                reader.Close();
                db.closeConnection();

                driverForm.Show();
            }
            else
            {
                MessageBox.Show("Такого номера в/у несуществует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void licenseNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            DriverRegisterForm  driverRegisterForm = new DriverRegisterForm();
            driverRegisterForm.Show();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
