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
    public partial class InspectorForm : Form
    {
        public InspectorForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectorAuthForm inspectorAuthForm = new InspectorAuthForm();
            inspectorAuthForm.Show();
        }

        private void read_info_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectorReadableDataForm inspectorReadableDataForm = new InspectorReadableDataForm();
            inspectorReadableDataForm.Show();
        }

        private void protocols_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectorProtocolsForm protocolsForm = new InspectorProtocolsForm();
            protocolsForm.Show();
        }

        private void volations_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectorViolationsForm violationsForm = new InspectorViolationsForm();
            violationsForm.Show();
        }
    }
}
