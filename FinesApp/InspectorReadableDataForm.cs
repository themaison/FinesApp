﻿using System;
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
    public partial class InspectorReadableDataForm : Form
    {
        public InspectorReadableDataForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectorForm inspectorForm = new InspectorForm();
            inspectorForm.Show();
        }

        private void InspectorReadableDataForm_Load(object sender, EventArgs e)
        {
            driverDGV.DataSource = DriverTable.GetTable();
            vehicleDGV.DataSource = VehicleTable.GetTable();
            paymentStatusDGV.DataSource = PaymentStatusTable.GetTable();
        }
    }
}
