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
    public partial class AdminPaymentStatusesForm : Form
    {
        public AdminPaymentStatusesForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void AdminPaymentStatusesForm_Load(object sender, EventArgs e)
        {
            insert_payment_status_box.Visible = false;
            update_payment_status_box.Visible = false;

            paymentStatusDGV.DataSource = PaymentStatusTable.GetTable();

            if (paymentStatusDGV.RowCount < 1)
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
            insert_payment_status_box.Visible = true;
            update_payment_status_box.Visible = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update_payment_status_box.Visible = true;
            insert_payment_status_box.Visible = false;

            DataGridViewRow row = paymentStatusDGV.CurrentRow;

            String statusName = row.Cells[1].Value.ToString();

            update_tb1.Text = statusName;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int statusID = (int)paymentStatusDGV.CurrentRow.Cells[0].Value;
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные?");
                if (dr == DialogResult.Yes)
                {
                    PaymentStatusTable.Delete(statusID);
                    paymentStatusDGV.DataSource = PaymentStatusTable.GetTable();
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
            insert_payment_status_box.Visible = false;
        }

        private void update_cancel_box_button_Click(object sender, EventArgs e)
        {
            update_payment_status_box.Visible = false;
        }

        private void insert_box_button_Click(object sender, EventArgs e)
        {
            String statusName = insert_tb1.Text;


            if (statusName == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            if (PaymentStatusTable.IsExistsPaymentStatus(statusName))
            {
                insert_tb1.Text = "";
                Messages.DisplayErrorMessage("Такой статус уже существует!");
                return;
            }

            if (PaymentStatusTable.Insert(statusName))
            {
                insert_payment_status_box.Visible = false;
                paymentStatusDGV.DataSource = PaymentStatusTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_box_button_Click(object sender, EventArgs e)
        {
            String statusName = update_tb1.Text;


            int currentStatusID = (int)paymentStatusDGV.CurrentRow.Cells[0].Value;
            String currentStatusName = (String)paymentStatusDGV.CurrentRow.Cells[1].Value;

            if (statusName == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }
            //Валидация

            if (statusName == currentStatusName)
            {
                if (PaymentStatusTable.Update(currentStatusID, statusName))
                {
                    paymentStatusDGV.DataSource = PaymentStatusTable.GetTable();
                    update_payment_status_box.Visible = false;
                    Messages.DisplayInfoMessage("Данные успешно обновлены!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                }
            }
            else
            {
                if (PaymentStatusTable.IsExistsPaymentStatus(statusName))
                {
                    update_tb1.Text = "";
                    Messages.DisplayErrorMessage("Такой статус уже существует!");
                }

                else
                {
                    if (PaymentStatusTable.Update(currentStatusID, statusName))
                    {
                        paymentStatusDGV.DataSource = PaymentStatusTable.GetTable();
                        update_payment_status_box.Visible = false;
                        Messages.DisplayInfoMessage("Данные успешно обновлены!");
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                    }
                }
            }
        }

        private void paymentStatusDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (paymentStatusDGV.SelectedRows.Count > 0 && update_payment_status_box.Visible == true)
            {
                DataGridViewRow row = paymentStatusDGV.SelectedRows[0];

                String statusName = row.Cells[1].Value.ToString();

                update_tb1.Text = statusName;
            }
        }
    }
}
