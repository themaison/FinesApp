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

        private void DriverPaymentForm_Load(object sender, EventArgs e)
        {
            violation_id_label.Text = protocol.ViolationId.ToString();
            sts_number_label.Text = protocol.StsNumber.ToString();
            violation_date_label.Text = protocol.ViolationDate.ToString();
            violation_time_label.Text = protocol.ViolationTime.ToString();
            violation_place_label.Text = protocol.ViolationPlace.ToString();
        }
    }
}
