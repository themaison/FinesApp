using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace FinesApp
{
    public static class DriverTable
    {
        static Messages msg = new Messages();
        static DB db = new DB();
        static DataTable table = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM driver";

            db.openConnection();

            command = new NpgsqlCommand(query, db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.closeConnection();

            return table;
        }

        public static bool Insert(string licenseNumber, string fullName, string gender, DateTime birthDate, DateTime licenseIssueDate, DateTime licenseValidityDate)
        {
            NpgsqlCommand command;
            string query =
                "INSERT INTO driver (license_number, full_name, gender, birth_date, license_issue_date, license_validity) " +
                "VALUES (@licenseNumber, @fullName, @gender, @birthDate, @licenseIssueDate, @licenseValidityDate)";

            try
            {
                db.openConnection();

                command = new NpgsqlCommand(query, db.GetConnection());
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@birthDate", birthDate);
                command.Parameters.AddWithValue("@licenseIssueDate", licenseIssueDate);
                command.Parameters.AddWithValue("@licenseValidityDate", licenseValidityDate);

                if (command.ExecuteNonQuery() > 0)
                {
                    msg.DisplayInfoMessage("Водитель успешно добавлен!");
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch
            {
                msg.DisplayErrorMessage("Ошибка при добавлении данных!");
                db.closeConnection();
                return false;
            }
        }


        public static bool Update(string licenseNumber, string fullName, string gender, DateTime birthDate, DateTime licenseIssueDate, DateTime licenseValidityDate)
        {
            NpgsqlCommand command;
            string query = 
                "UPDATE driver SET full_name = @fullName, gender = @gender, birth_date = @birthDate, license_issue_date = @licenseIssueDate, license_validity = @licenseValidityDate " +
                "WHERE license_number = @licenseNumber";

            try
            {
                db.openConnection();

                command = new NpgsqlCommand(query, db.GetConnection());
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@birthDate", birthDate);
                command.Parameters.AddWithValue("@licenseIssueDate", licenseIssueDate);
                command.Parameters.AddWithValue("@licenseValidityDate", licenseValidityDate);

                if (command.ExecuteNonQuery() > 0)
                {
                    msg.DisplayInfoMessage("Данные водителя успешно изменены!");
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch
            {
                msg.DisplayErrorMessage("Ошибка при изменении данных!");
                db.closeConnection();
                return false;
            }
        }

        public static void Delete(string licenseNumber)
        {
            NpgsqlCommand command;
            string query = 
                "DELETE FROM driver " +
                "WHERE license_number = @licenseNumber";

            try
            {
                db.openConnection();

                command = new NpgsqlCommand(query, db.GetConnection());
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                command.ExecuteNonQuery();

                db.closeConnection();
            }
            catch
            {
                msg.DisplayErrorMessage("Ошибка при удалении данных!");
                db.closeConnection();
            }
        }

        public static Boolean IsExistsDriver(String licenseNumber)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            string query = "SELECT * FROM driver WHERE license_number = @licenseNumber";
            NpgsqlCommand command = new NpgsqlCommand(query, db.GetConnection());

            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                msg.DisplayErrorMessage("Такой номер в/у уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
