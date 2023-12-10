using Npgsql;
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

            //string query = "SELECT * FROM protocol WHERE sts_number IN (SELECT sts_number FROM vehicle WHERE license_number = @licenseNumber)";
            string query = "SELECT * FROM driver WHERE license_number = @licenseNumber";
            NpgsqlCommand command = new NpgsqlCommand(query, db.GetConnection());
            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
