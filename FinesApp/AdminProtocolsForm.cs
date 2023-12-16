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

            DataGridViewRow ds = protocolDGV.CurrentRow;

            String violationID = ds.Cells[1].Value.ToString();
            String stsNumber = ds.Cells[2].Value.ToString();
            String violationDate = ds.Cells[3].Value.ToString();
            String violationTime = ds.Cells[4].Value.ToString();
            String violationPlace = ds.Cells[5].Value.ToString();
            String statusID = ds.Cells[6].Value.ToString();

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
            String violationTimeStr = insert_dp2.Value.TimeOfDay.ToString();
            String violationPlaceStr = insert_tb3.Text;
            String statusIDStr = insert_tb4.Text;


            int violationID;
            String stsNumber;
            DateTime violationDate;
            TimeSpan violationTime;
            String violationPlace;
            int statusID;


            if (violationIDStr == "" || stsNumberStr == "" || violationDateStr == "" ||
                violationTimeStr == "" || violationPlaceStr == "" || statusIDStr == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }

            //Валидация
            else
            {
                violationID = Convert.ToInt32(insert_tb1.Text);
                stsNumber = insert_tb2.Text;
                violationDate = insert_dp1.Value;
                violationTime = insert_dp2.Value.TimeOfDay;
                violationPlace = insert_tb3.Text;
                statusID = Convert.ToInt32(insert_tb4.Text);

            }

            //if (ProtocolTable.IsExistsProtocol(protocolID))
            //{
            //    insert_tb1.Text = "";
            //    Messages.DisplayErrorMessage("Такой протокол уже существует!");
            //    return;
            //}

            if (ProtocolTable.Insert(violationID, stsNumber, violationDate, violationTime, violationPlace, statusID))
            {
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
            String violationTimeStr = update_dp2.Value.TimeOfDay.ToString();
            String violationPlaceStr = update_tb3.Text;
            String statusIDStr = update_tb4.Text;


            int violationID = Convert.ToInt32(update_tb1.Text);
            String stsNumber = update_tb2.Text;
            DateTime violationDate = update_dp1.Value;
            TimeSpan violationTime = update_dp2.Value.TimeOfDay;
            String violationPlace = update_tb3.Text;
            int statusID = Convert.ToInt32(update_tb4.Text);

            int currentProtocolID = (int)protocolDGV.CurrentRow.Cells[1].Value;

            if (violationIDStr == "" || stsNumberStr == "" || violationDateStr == "" ||
                violationTimeStr == "" || violationPlaceStr == "" || statusIDStr == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }
            //Добавить валидацию
            else
            {
                if (ProtocolTable.Update(currentProtocolID, violationID, stsNumber, violationDate, violationTime, violationPlace, statusID))
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
        }

        private void protocolDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (protocolDGV.SelectedRows.Count > 0 && update_protocol_box.Visible == true)
            {
                //update_protocol_box.Visible = true;
                insert_protocol_box.Visible = false;

                DataGridViewRow row = protocolDGV.SelectedRows[0];

                String violationID = row.Cells[1].Value.ToString();
                String stsNumber = row.Cells[2].Value.ToString();
                String violationDate = row.Cells[3].Value.ToString();
                String violationTime = row.Cells[4].Value.ToString();
                String violationPlace = row.Cells[5].Value.ToString();
                String statusID = row.Cells[6].Value.ToString();

                update_tb1.Text = violationID;
                update_tb2.Text = stsNumber;
                update_dp1.Text = violationDate;
                update_dp2.Text = violationTime;
                update_tb3.Text = violationPlace;
                update_tb4.Text = statusID;
            }
        }
    }
}
