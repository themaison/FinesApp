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
    public partial class InspectorProtocolsForm : Form
    {
        public InspectorProtocolsForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectorForm inspectorForm = new InspectorForm();
            inspectorForm.Show();
        }
    }
}
