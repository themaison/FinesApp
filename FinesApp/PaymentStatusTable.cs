﻿using Npgsql;
using System;
using System.Data;

namespace FinesApp
{
    public static class PaymentStatusTable
    {
        static DataTable table = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM payment_status";

            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }

        public static bool Insert(string statusName)
        {
            NpgsqlCommand command;
            string query =
                "INSERT INTO payment_status (status_name) " +
                "VALUES (@statusName)";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@statusName", statusName);

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

        public static bool Update(int statusId, string statusName)
        {
            NpgsqlCommand command;
            string query =
                "UPDATE payment_status SET status_name = @statusName " +
                "WHERE status_id = @statusId";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@statusId", statusId);
                command.Parameters.AddWithValue("@statusName", statusName);

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

        public static void Delete(int statusId)
        {
            NpgsqlCommand command;
            string query =
                "DELETE FROM payment_status " +
                "WHERE status_id = @statusId";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@statusId", statusId);
                command.ExecuteNonQuery();

                DB.closeConnection();
            }
            catch
            {
                DB.closeConnection();
            }
        }

        public static bool IsExistsPaymentStatus(String statusName)
        {
            DataTable dataTableQuery = new DataTable();
            string query =
                "SELECT * FROM payment_status " +
                "WHERE status_name = @statusName";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@statusName", statusName);
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
