using Npgsql;
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
    public partial class InspectorAuthForm : Form
    {
        public InspectorAuthForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String pass = passTextBox.Text;

            if (login == "" || pass == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            string query =
                "SELECT * FROM inspector " +
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
                InspectorForm inspectorForm = new InspectorForm();
                inspectorForm.Show();
            }
            else
            {
                Messages.DisplayErrorMessage("Неверный логин или пароль!");
            }
        }
    }
}
