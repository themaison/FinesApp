using Npgsql;
using System;
using System.Data;

namespace FinesApp
{
    public static class DriverTable
    {
        static DataTable table = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM driver";

            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

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
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@birthDate", birthDate);
                command.Parameters.AddWithValue("@licenseIssueDate", licenseIssueDate);
                command.Parameters.AddWithValue("@licenseValidityDate", licenseValidityDate);

                if (command.ExecuteNonQuery() > 0)
                {
                    DB.closeConnection();
                    return true;
                }
                else
                {
                    DB.closeConnection();
                    return false;
                }
            }
            catch
            {
                DB.closeConnection();
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
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@birthDate", birthDate);
                command.Parameters.AddWithValue("@licenseIssueDate", licenseIssueDate);
                command.Parameters.AddWithValue("@licenseValidityDate", licenseValidityDate);

                if (command.ExecuteNonQuery() > 0)
                {
                    DB.closeConnection();
                    return true;
                }
                else
                {
                    DB.closeConnection();
                    return false;
                }
            }
            catch
            {
                DB.closeConnection();
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
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                command.ExecuteNonQuery();

                DB.closeConnection();
            }
            catch
            {
                DB.closeConnection();
            }
        }

        public static bool IsExistsDriver(String licenseNumber)
        {
            DataTable dataTableQuery = new DataTable();
            string query = 
                "SELECT * FROM driver " +
                "WHERE license_number = @licenseNumber";


            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
            adapter.SelectCommand = command;
            adapter.Fill(dataTableQuery);

            if (dataTableQuery.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
