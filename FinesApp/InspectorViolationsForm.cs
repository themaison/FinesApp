using System;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class InspectorViolationsForm : Form
    {
        public InspectorViolationsForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            InspectorForm inspectorForm = new InspectorForm();
            inspectorForm.Show();
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

            DataGridViewRow row  = violationDGV.CurrentRow;

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

        private void InspectorViolationsForm_Load(object sender, EventArgs e)
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
            String violationNameStr = insert_tb1.Text;
            String fineAmountStr = insert_tb2.Text;

            String violationName;
            int fineAmount;


            if (violationNameStr == "" || fineAmountStr == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            //Валидация
            else
            {
                violationName = insert_tb1.Text;
                fineAmount = Convert.ToInt32(insert_tb2.Text);
            }

            if (ViolationTable.IsExistsViolation(violationName))
            {
                insert_tb1.Text = "";
                Messages.DisplayErrorMessage("Такое нарушение уже существует!");
                return;
            }

            if (ViolationTable.Insert(violationName, fineAmount))
            {
                insert_violation_box.Visible = false;
                violationDGV.DataSource = ViolationTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_box_button_Click(object sender, EventArgs e)
        {
            String violationNameStr = insert_tb1.Text;
            String fineAmountStr = insert_tb2.Text;

            String violationName = update_tb1.Text;
            int fineAmount = Convert.ToInt32(update_tb2.Text);

            int currentViolationID = (int)violationDGV.CurrentRow.Cells[0].Value;
            String currentViolationName = (String)violationDGV.CurrentRow.Cells[1].Value;

            if (violationName == currentViolationName)
            {
                if (violationNameStr == "" || fineAmountStr == "")
                {
                    Messages.DisplayErrorMessage("Заполните все поля!");
                    return;
                }
                //Валидация
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
            else
            {
                if (ViolationTable.IsExistsViolation(violationName))
                {
                    update_tb1.Text = "";
                    Messages.DisplayErrorMessage("Такое нарушение уже существует!");
                }

                else
                {
                    if (violationName == "" || fineAmount.ToString() == "")
                    {
                        Messages.DisplayErrorMessage("Заполните все поля!");
                        return;
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

                return;
            }
        }

        private void violationDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (violationDGV.SelectedRows.Count > 0 && update_violation_box.Visible == true)
            {
                //update_violation_box.Visible = true;
                insert_violation_box.Visible = false;

                DataGridViewRow row = violationDGV.SelectedRows[0];

                String violationName = row.Cells[1].Value.ToString();
                String fineAmount = row.Cells[2].Value.ToString();

                update_tb1.Text = violationName;
                update_tb2.Text = fineAmount;
            }
        }
    }
}
