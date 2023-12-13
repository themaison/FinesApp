using System;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class DriverPaymentForm : Form
    {
        public Driver driver { get; set; }
        public Protocol protocol { get; set; }
        public DriverPaymentForm()
        {
            InitializeComponent();
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
