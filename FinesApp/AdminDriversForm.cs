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

            DB db = new DB();
            DataTable driversTable = db.GetTableFromDB("driver");
            driverDGV.DataSource = driversTable;
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
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

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

        }

        private void update_box_button_Click(object sender, EventArgs e)
        {

        }
    }
}
