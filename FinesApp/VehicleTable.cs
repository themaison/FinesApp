using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinesApp
{
    public static class VehicleTable
    {
        static DataTable table = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM vehicle";

            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }

        public static bool Insert(string stsNumber, string brand, string model, int yearOfManufacture, string stateNumber, string licenseNumber)
        {
            NpgsqlCommand command;
            string query =
                "INSERT INTO vehicle (sts_number, brand, model, year_of_manufacture, state_number, license_number) " +
                "VALUES (@stsNumber, @brand, @model, @yearOfManufacture, @stateNumber, @licenseNumber)";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@stsNumber", stsNumber);
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@yearOfManufacture", yearOfManufacture);
                command.Parameters.AddWithValue("@stateNumber", stateNumber);
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

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

        public static bool Update(string stsNumber, string brand, string model, int yearOfManufacture, string stateNumber, string licenseNumber)
        {
            NpgsqlCommand command;
            string query =
                "UPDATE vehicle SET brand = @brand, model = @model, year_of_manufacture = @yearOfManufacture, state_number = @stateNumber, license_number = @licenseNumber " +
                "WHERE sts_number = @stsNumber";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@stsNumber", stsNumber);
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@yearOfManufacture", yearOfManufacture);
                command.Parameters.AddWithValue("@stateNumber", stateNumber);
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

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

        public static bool UpdateWithPrimary(string oldStsNumber, string newStsNumber, string brand, string model, int yearOfManufacture, string stateNumber, string licenseNumber)
        {
            NpgsqlCommand command;
            string query =
                "UPDATE vehicle SET sts_number = @newStsNumber, brand = @brand, model = @model, year_of_manufacture = @yearOfManufacture, state_number = @stateNumber, license_number = @licenseNumber " +
                "WHERE sts_number = @oldStsNumber";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@oldStsNumber", oldStsNumber);
                command.Parameters.AddWithValue("@newStsNumber", newStsNumber);
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@yearOfManufacture", yearOfManufacture);
                command.Parameters.AddWithValue("@stateNumber", stateNumber);
                command.Parameters.AddWithValue("@licenseNumber", licenseNumber);

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


        public static void Delete(string stsNumber)
        {
            NpgsqlCommand command;
            string query =
                "DELETE FROM vehicle " +
                "WHERE sts_number = @stsNumber";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@stsNumber", stsNumber);
                command.ExecuteNonQuery();

                DB.closeConnection();
            }
            catch
            {
                DB.closeConnection();
            }
        }

        public static bool IsExistsVehicle(string stsNumber)
        {
            DataTable dataTableQuery = new DataTable();
            string query =
                "SELECT * FROM vehicle " +
                "WHERE sts_number = @stsNumber";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@stsNumber", stsNumber);
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
