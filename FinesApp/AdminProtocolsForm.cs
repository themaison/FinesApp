﻿using System;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class AdminProtocolsForm : Form
    {
        public AdminProtocolsForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void AdminProtocolsForm_Load(object sender, EventArgs e)
        {
            insert_protocol_box.Visible = false;
            update_protocol_box.Visible = false;

            protocolDGV.DataSource = ProtocolTable.GetTable();

            if (protocolDGV.RowCount < 1)
            {
                update_box_button.Enabled = false;
                delete_button.Enabled = false;
            }
            else
            {
                update_box_button.Enabled = true;
                delete_button.Enabled = true;
            }
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            insert_protocol_box.Visible = true;
            update_protocol_box.Visible = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update_protocol_box.Visible = true;
            insert_protocol_box.Visible = false;

            DataGridViewRow row = protocolDGV.CurrentRow;

            String violationID = row.Cells["violation_id"].Value.ToString();
            String stsNumber = row.Cells["sts_number"].Value.ToString();
            String violationDate = row.Cells["violation_date"].Value.ToString();
            String violationTime = row.Cells["violation_time"].Value.ToString();
            String violationPlace = row.Cells["violation_place"].Value.ToString();
            String statusID = row.Cells["status_id"].Value.ToString();

            update_tb1.Text = violationID;
            update_tb2.Text = stsNumber;
            update_dp1.Text = violationDate;
            update_dp2.Text = violationTime;
            update_tb3.Text = violationPlace;
            update_tb4.Text = statusID;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int protocolID = (int)protocolDGV.CurrentRow.Cells[0].Value;
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные?");
                if (dr == DialogResult.Yes)
                {
                    ProtocolTable.Delete(protocolID);
                    protocolDGV.DataSource = ProtocolTable.GetTable();
                    Messages.DisplayInfoMessage("Данные успешно удалены!");
                }
            }
            catch
            {
                Messages.DisplayErrorMessage("Ошибка при удалении данных!");
            }
        }

        private void insert_cancel_box_button_Click(object sender, EventArgs e)
        {
            insert_protocol_box.Visible = false;
        }

        private void update_cancel_box_button_Click(object sender, EventArgs e)
        {
            update_protocol_box.Visible = false;
        }

        private void insert_box_button_Click(object sender, EventArgs e)
        {
            String violationIDStr = insert_tb1.Text;
            String stsNumberStr = insert_tb2.Text;
            String violationDateStr = insert_dp1.Value.ToString();
            String violationTimeStr = insert_dp2.Value.TimeOfDay.ToString(@"hh\:mm\:ss");
            String violationPlaceStr = insert_tb3.Text;
            String statusIDStr = insert_tb4.Text;


            int violationID;
            String stsNumber;
            DateTime violationDate;
            TimeSpan violationTime;
            TimeSpan fixedViolationTime;
            String violationPlace;
            int statusID;


            if (violationIDStr == "" || stsNumberStr == "" || violationDateStr == "" ||
                violationTimeStr == "" || violationPlaceStr == "" || statusIDStr == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }
            else
            {
                if (!Int32.TryParse(violationIDStr, out violationID))
                {
                    Messages.DisplayErrorMessage("Кажется вы ввели слишком большое число!");
                    return;
                }

                stsNumber = insert_tb2.Text;
                violationDate = insert_dp1.Value;
                violationTime = insert_dp2.Value.TimeOfDay;
                fixedViolationTime = new TimeSpan(violationTime.Hours, violationTime.Minutes, violationTime.Seconds);
                violationPlace = insert_tb3.Text;

                if (!Int32.TryParse(statusIDStr, out statusID))
                {
                    Messages.DisplayErrorMessage("Кажется вы ввели слишком большое число!");
                    return;
                }

            }

            if (ProtocolTable.Insert(violationID, stsNumber, violationDate, fixedViolationTime, violationPlace, statusID))
            {
                insert_tb1.Text = "";
                insert_tb2.Text = "";
                insert_dp1.Text = "";
                insert_dp2.Text = "";
                insert_tb3.Text = "";
                insert_tb4.Text = "";

                insert_protocol_box.Visible = false;

                protocolDGV.DataSource = ProtocolTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_box_button_Click(object sender, EventArgs e)
        {
            String violationIDStr = update_tb1.Text;
            String stsNumberStr = update_tb2.Text;
            String violationDateStr = update_dp1.Value.ToString();
            String violationTimeStr = update_dp2.Value.TimeOfDay.ToString(@"hh\:mm\:ss");
            String violationPlaceStr = update_tb3.Text;
            String statusIDStr = update_tb4.Text;

            int violationID;
            String stsNumber;
            DateTime violationDate;
            TimeSpan violationTime;
            TimeSpan fixedViolationTime;
            String violationPlace;
            int statusID;

            int currentProtocolID = (int)protocolDGV.CurrentRow.Cells[0].Value;

            if (violationIDStr == "" || stsNumberStr == "" || violationDateStr == "" ||
                violationTimeStr == "" || violationPlaceStr == "" || statusIDStr == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }
            else
            {
                if (!Int32.TryParse(violationIDStr, out violationID))
                {
                    Messages.DisplayErrorMessage("Кажется вы ввели слишком большое число!");
                    return;
                }

                stsNumber = update_tb2.Text;
                violationDate = update_dp1.Value;
                violationTime = update_dp2.Value.TimeOfDay;
                fixedViolationTime = new TimeSpan(violationTime.Hours, violationTime.Minutes, violationTime.Seconds);
                violationPlace = update_tb3.Text;

                if (!Int32.TryParse(statusIDStr, out statusID))
                {
                    Messages.DisplayErrorMessage("Кажется вы ввели слишком большое число!");
                    return;
                }
            }

            if (ProtocolTable.Update(currentProtocolID, violationID, stsNumber, violationDate, fixedViolationTime, violationPlace, statusID))
            {
                protocolDGV.DataSource = ProtocolTable.GetTable();
                update_protocol_box.Visible = false;
                Messages.DisplayInfoMessage("Данные успешно обновлены!");
            }
            else
            {
                Messages.DisplayErrorMessage("Ошибка при изменении данных!");
            }
        }

        private void protocolDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (protocolDGV.SelectedRows.Count > 0 && update_protocol_box.Visible == true)
            {
                DataGridViewRow row = protocolDGV.SelectedRows[0];

                String violationID = row.Cells["violation_id"].Value.ToString();
                String stsNumber = row.Cells["sts_number"].Value.ToString();
                String violationDate = row.Cells["violation_date"].Value.ToString();
                String violationTime = row.Cells["violation_time"].Value.ToString();
                String violationPlace = row.Cells["violation_place"].Value.ToString();
                String statusID = row.Cells["status_id"].Value.ToString();

                update_tb1.Text = violationID;
                update_tb2.Text = stsNumber;
                update_dp1.Text = violationDate;
                update_dp2.Text = violationTime;
                update_tb3.Text = violationPlace;
                update_tb4.Text = statusID;
            }
        }

        private void insert_tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void insert_tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void insert_tb3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void insert_tb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void update_tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void update_tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void update_tb3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void update_tb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
