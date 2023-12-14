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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAuthForm adminAuthForm = new AdminAuthForm();
            adminAuthForm.Show();
        }

        private void drivers_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDriversForm driversForm = new AdminDriversForm();
            driversForm.Show();
        }

        private void vehicles_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminVehiclesForm vehiclesForm = new AdminVehiclesForm();
            vehiclesForm.Show();
        }

        private void protocols_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProtocolsForm protocolsForm = new AdminProtocolsForm();
            protocolsForm.Show();
        }

        private void volations_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminVolationsForm volationsForm = new AdminVolationsForm();
            volationsForm.Show();
        }

        private void payment_statuses_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPaymentStatusesForm paymentStatusesForm = new AdminPaymentStatusesForm();
            paymentStatusesForm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
