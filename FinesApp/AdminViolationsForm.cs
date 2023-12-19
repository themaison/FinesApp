using System;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class AdminViolationsForm : Form
    {
        public AdminViolationsForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void AdminViolationsForm_Load(object sender, EventArgs e)
        {
            insert_violation_box.Visible = false;
            update_violation_box.Visible = false;

            violationDGV.DataSource = ViolationTable.GetTable();

            if (violationDGV.RowCount < 1)
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
            insert_violation_box.Visible = true;
            update_violation_box.Visible = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update_violation_box.Visible = true;
            insert_violation_box.Visible = false;

            DataGridViewRow row = violationDGV.CurrentRow;

            String violationName = row.Cells[1].Value.ToString();
            String fineAmount = row.Cells[2].Value.ToString();

            update_tb1.Text = violationName;
            update_tb2.Text = fineAmount;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int violationID = (int)violationDGV.CurrentRow.Cells[0].Value;
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные?");
                if (dr == DialogResult.Yes)
                {
                    ViolationTable.Delete(violationID);
                    violationDGV.DataSource = ViolationTable.GetTable();
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
            insert_violation_box.Visible = false;
        }

        private void update_cancel_box_button_Click(object sender, EventArgs e)
        {
            update_violation_box.Visible = false;
        }

        private void insert_box_button_Click(object sender, EventArgs e)
        {
            String violationName = insert_tb1.Text;
            String fineAmountStr = insert_tb2.Text;
            int fineAmount;


            if (violationName == "" || fineAmountStr == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }
            else
            {
                if (!Int32.TryParse(fineAmountStr, out fineAmount))
                {
                    Messages.DisplayErrorMessage("Кажется вы ввели слишком большое число!");
                    return;
                }
            }

            if (ViolationTable.IsExistsViolation(violationName))
            {
                insert_tb1.Text = "";
                Messages.DisplayErrorMessage("Такое нарушение уже существует!");
                return;
            }

            if (ViolationTable.Insert(violationName, fineAmount))
            {

                insert_tb1.Text = "";
                insert_tb2.Text = "";
                insert_violation_box.Visible = false;

                violationDGV.DataSource = ViolationTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_box_button_Click(object sender, EventArgs e)
        {
            String fineAmountStr = update_tb2.Text;
            String violationName = update_tb1.Text;
            int fineAmount;

            int currentViolationID = (int)violationDGV.CurrentRow.Cells[0].Value;
            String currentViolationName = (String)violationDGV.CurrentRow.Cells[1].Value;

            if (violationName == "" || fineAmountStr == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }
            else
            {
                if (!Int32.TryParse(fineAmountStr, out fineAmount))
                {
                    Messages.DisplayErrorMessage("Кажется вы ввели слишком большое число!");
                    return;
                }
            }

            if (violationName == currentViolationName)
            {
                if (ViolationTable.Update(currentViolationID, violationName, fineAmount))
                {
                    violationDGV.DataSource = ViolationTable.GetTable();
                    update_violation_box.Visible = false;
                    Messages.DisplayInfoMessage("Данные успешно обновлены!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                }
            }
            else
            {
                if (ViolationTable.IsExistsViolation(violationName))
                {
                    update_tb1.Text = "";
                    Messages.DisplayErrorMessage("Такое нарушение уже существует!");
                }

                else
                {
                    if (ViolationTable.Update(currentViolationID, violationName, fineAmount))
                    {
                        violationDGV.DataSource = ViolationTable.GetTable();
                        update_violation_box.Visible = false;
                        Messages.DisplayInfoMessage("Данные успешно обновлены!");
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                    }
                }
            }
        }

        private void violationDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (violationDGV.SelectedRows.Count > 0 && update_violation_box.Visible == true)
            {
                DataGridViewRow row = violationDGV.SelectedRows[0];

                String violationName = row.Cells[1].Value.ToString();
                String fineAmount = row.Cells[2].Value.ToString();

                update_tb1.Text = violationName;
                update_tb2.Text = fineAmount;
            }
        }

        private void insert_tb1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void insert_tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void update_tb1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void update_tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
