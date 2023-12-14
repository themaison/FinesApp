using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinesApp
{
    public static class ViolationTable
    {
        static DataTable table = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM violation";

            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }

        public static bool Insert(int violationId, string violationName, int fineAmount)
        {
            NpgsqlCommand command;
            string query =
                "INSERT INTO violation (violation_id, violation_name, fine_amount) " +
                "VALUES (@violationId, @violationName, @fineAmount)";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@violationId", violationId);
                command.Parameters.AddWithValue("@violationName", violationName);
                command.Parameters.AddWithValue("@fineAmount", fineAmount);

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

        public static bool Update(int violationId, string violationName, int fineAmount)
        {
            NpgsqlCommand command;
            string query =
                "UPDATE violation SET violation_name = @violationName, fine_amount = @fineAmount " +
                "WHERE violation_id = @violationId";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@violationId", violationId);
                command.Parameters.AddWithValue("@violationName", violationName);
                command.Parameters.AddWithValue("@fineAmount", fineAmount);

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

        public static void Delete(int violationId)
        {
            NpgsqlCommand command;
            string query =
                "DELETE FROM violation " +
                "WHERE violation_id = @violationId";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@violationId", violationId);
                command.ExecuteNonQuery();

                DB.closeConnection();
            }
            catch
            {
                DB.closeConnection();
            }
        }

        public static bool IsExistsViolation(int violationId)
        {
            DataTable dataTableQuery = new DataTable();
            string query =
                "SELECT * FROM violation " +
                "WHERE violation_id = @violationId";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@violationId", violationId);
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
