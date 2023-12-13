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
    }
}
