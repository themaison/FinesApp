using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class AdminAuthForm : Form
    {
        public AdminAuthForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void authButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String pass = passTextBox.Text;

            if (login=="" || pass == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            string query = 
                "SELECT * FROM administrator " +
                "WHERE login = @login AND password = @pass";

            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());
            
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@pass", pass);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else
            {
                Messages.DisplayErrorMessage("Неверный логин или пароль!");
            }
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
