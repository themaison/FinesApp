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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAuthForm adminAuthForm = new AdminAuthForm();
            adminAuthForm.Show();
        }

        private void inspectorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectorAuthForm inspectorAuthForm = new InspectorAuthForm();
            inspectorAuthForm.Show();
        }

        private void driverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverAuthForm driverAuthForm = new DriverAuthForm();
            driverAuthForm.Show();
        }
    }
}
