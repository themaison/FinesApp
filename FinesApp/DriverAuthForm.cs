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

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM protocol WHERE sts_number IN (SELECT sts_number FROM vehicle WHERE license_number = @licenseNumber)", db.GetConnection());
            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Неверный номер в/у!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
