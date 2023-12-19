using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class DriverInfoForm : Form
    {
        public Driver driver { get; set; }
        public DriverInfoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DriverInfoForm_Load(object sender, EventArgs e)
        {
            violationDGV.DataSource = ViolationTable.GetTable();
            paymentStatusDGV.DataSource = PaymentStatusTable.GetTable();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {

            this.Hide();
            DriverForm driverForm = new DriverForm();
            driverForm.driver = driver;
            driverForm.Show();
        }
    }
}
