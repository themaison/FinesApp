using System;
using System.Windows.Forms;

namespace FinesApp
{
    public partial class AdminVehiclesForm : Form
    {
        public AdminVehiclesForm()
        {
            InitializeComponent();
        }

        private void to_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            insert_vehicle_box.Visible = true;
            update_vehicle_box.Visible = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update_vehicle_box.Visible = true;
            insert_vehicle_box.Visible = false;

            DataGridViewRow row = vehicleDGV.CurrentRow;

            String stsNumber = row.Cells[0].Value.ToString();
            String stateNumber = row.Cells[1].Value.ToString();
            String licenseNumber = row.Cells[2].Value.ToString();
            String yearOfManufacture = row.Cells[3].Value.ToString();
            String brand = row.Cells[4].Value.ToString();
            String model = row.Cells[5].Value.ToString();

            update_tb1.Text = stsNumber;
            update_tb2.Text = stateNumber;
            update_tb3.Text = licenseNumber;
            update_tb4.Text = yearOfManufacture;
            update_tb5.Text = brand;
            update_tb6.Text = model;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                String stsNumber = vehicleDGV.CurrentRow.Cells[0].Value.ToString();
                DialogResult dr = Messages.DisplayQuestionMessage("Вы действительно хотите удалить данные?");
                if (dr == DialogResult.Yes)
                {
                    VehicleTable.Delete(stsNumber);
                    vehicleDGV.DataSource = VehicleTable.GetTable();
                    Messages.DisplayInfoMessage("Данные успешно удалены!");
                }
            }
            catch
            {
                Messages.DisplayErrorMessage("Ошибка при удалении данных!");
            }
        }

        private void AdminVehiclesForm_Load(object sender, EventArgs e)
        {
            insert_vehicle_box.Visible = false;
            update_vehicle_box.Visible = false;

            vehicleDGV.DataSource = VehicleTable.GetTable();

            if (vehicleDGV.RowCount < 1)
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
            insert_vehicle_box.Visible = false;
        }

        private void update_cancel_box_button_Click(object sender, EventArgs e)
        {
            update_vehicle_box.Visible = false;
        }

        private void insert_box_button_Click(object sender, EventArgs e)
        {
            String yearOfManufactureStr = insert_tb4.Text;

            String stsNumber = insert_tb1.Text;
            String stateNumber = insert_tb2.Text;
            String licenseNumber = insert_tb3.Text;
            String brand = insert_tb5.Text;
            String model = insert_tb6.Text;
            int yearOfManufacture;

            if (stsNumber == "" || brand == "" || model == "" ||
               yearOfManufactureStr == "" ||stateNumber == "" || licenseNumber == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля!");
                return;
            }
            else
            {
                //Валидация
                yearOfManufacture = Convert.ToInt32(yearOfManufactureStr);
            }

            if (VehicleTable.IsExistsVehicle(stsNumber))
            {
                insert_tb1.Text = "";
                Messages.DisplayErrorMessage("Такой номер СТС уже существует!");
                return;
            }

            if (VehicleTable.Insert(stsNumber, brand, model, yearOfManufacture, stateNumber, licenseNumber))
            {
                insert_vehicle_box.Visible = false;
                vehicleDGV.DataSource = VehicleTable.GetTable();
                Messages.DisplayInfoMessage("Данные успешно добавлены!");
            }
            else
                Messages.DisplayErrorMessage("Ошибка при добавлении данных!");
        }

        private void update_box_button_Click(object sender, EventArgs e)
        {
            String yearOfManufactureStr = insert_tb4.Text;

            String stsNumber = update_tb1.Text;
            String stateNumber = update_tb2.Text;
            String licenseNumber = update_tb3.Text;
            String brand = update_tb5.Text;
            String model = update_tb6.Text;
            int yearOfManufacture;

            String currentStsNumber = vehicleDGV.CurrentRow.Cells[0].Value.ToString();

            if (stsNumber == "" || brand == "" || model == "" ||
                yearOfManufactureStr == "" || stateNumber == "" || licenseNumber == "")
            {
                Messages.DisplayErrorMessage("Заполните все поля ДАДАДАД!");
                return;
            }
            else
            {
                //Валидация
                yearOfManufacture = Convert.ToInt32(yearOfManufactureStr);
            }

            if (stsNumber == currentStsNumber)
            {
                if (VehicleTable.Update(currentStsNumber, brand, model, yearOfManufacture, stateNumber, licenseNumber))
                {
                    vehicleDGV.DataSource = VehicleTable.GetTable();
                    update_vehicle_box.Visible = false;
                    Messages.DisplayInfoMessage("Данные успешно обновлены!");
                }
                else
                {
                    Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                }
            }
            else
            {
                if (VehicleTable.IsExistsVehicle(stsNumber))
                {
                    update_tb1.Text = "";
                    Messages.DisplayErrorMessage("Такой номер СТС уже существует!");
                }

                else
                {
                    if (VehicleTable.UpdateWithPrimary(currentStsNumber, stsNumber, brand, model, yearOfManufacture, stateNumber, licenseNumber))
                    {
                        vehicleDGV.DataSource = VehicleTable.GetTable();
                        update_vehicle_box.Visible = false;
                        Messages.DisplayInfoMessage("Данные успешно обновлены!");
                    }
                    else
                    {
                        Messages.DisplayErrorMessage("Ошибка при изменении данных!");
                    }
                }
            }
        }

        private void vehicleDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (vehicleDGV.SelectedRows.Count > 0 && update_vehicle_box.Visible == true)
            {
                DataGridViewRow row = vehicleDGV.SelectedRows[0];

                String stsNumber = row.Cells[0].Value.ToString();
                String brand = row.Cells[1].Value.ToString();
                String model = row.Cells[2].Value.ToString();
                String yearOfManufacture = row.Cells[3].Value.ToString();
                String stateNumber = row.Cells[4].Value.ToString();
                String licenseNumber = row.Cells[5].Value.ToString();

                update_tb1.Text = stsNumber;
                update_tb2.Text = brand;
                update_tb3.Text = model;
                update_tb4.Text = yearOfManufacture;
                update_tb5.Text = stateNumber;
                update_tb6.Text = licenseNumber;
            }
        }
    }
}
