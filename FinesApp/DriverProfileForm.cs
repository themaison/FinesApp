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
    public partial class DriverProfileForm : Form
    {
        public Driver driver { get; set; }
        public DriverProfileForm()
        {
            InitializeComponent();
        }

        private void DriverProfileForm_Load(object sender, EventArgs e)
        {
            license_number_label.Text = driver.LicenseNumber;
            fio_label.Text = driver.FullName;
            gender_label.Text = driver.Gender;
            data1_label.Text = driver.BirthDate.Date.ToShortDateString();
            data2_label.Text = driver.LicenseIssueDate.Date.ToShortDateString();
            data3_label.Text = driver.LicenseValidity.Date.ToShortDateString();
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
