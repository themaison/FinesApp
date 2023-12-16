using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinesApp
{
    public static class ProtocolTable
    {
        static DataTable table = new DataTable();

        public static DataTable GetTable()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            table.Clear();

            string query = "SELECT * FROM protocol";

            DB.openConnection();

            command = new NpgsqlCommand(query, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DB.closeConnection();

            return table;
        }

        public static bool Insert(int violationId, string stsNumber, DateTime violationDate, TimeSpan violationTime, string violationPlace, int statusId)
        {
            NpgsqlCommand command;
            string query =
                "INSERT INTO protocol (violation_id, sts_number, violation_date, violation_time, violation_place, status_id) " +
                "VALUES (@violationId, @stsNumber, @violationDate, @violationTime, @violationPlace, @statusId)";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@violationId", violationId);
                command.Parameters.AddWithValue("@stsNumber", stsNumber);
                command.Parameters.AddWithValue("@violationDate", violationDate);
                command.Parameters.AddWithValue("@violationTime", violationTime);
                command.Parameters.AddWithValue("@violationPlace", violationPlace);
                command.Parameters.AddWithValue("@statusId", statusId);

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

        public static bool Update(int protocolId, int violationId, string stsNumber, DateTime violationDate, TimeSpan violationTime, string violationPlace, int statusId)
        {
            NpgsqlCommand command;
            string query =
                "UPDATE protocol SET violation_id = @violationId, sts_number = @stsNumber, violation_date = @violationDate, violation_time = @violationTime, violation_place = @violationPlace, status_id = @statusId " +
                "WHERE protocol_id = @protocolId";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@protocolId", protocolId);
                command.Parameters.AddWithValue("@violationId", violationId);
                command.Parameters.AddWithValue("@stsNumber", stsNumber);
                command.Parameters.AddWithValue("@violationDate", violationDate);
                command.Parameters.AddWithValue("@violationTime", violationTime);
                command.Parameters.AddWithValue("@violationPlace", violationPlace);
                command.Parameters.AddWithValue("@statusId", statusId);

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

        public static void Delete(int protocolId)
        {
            NpgsqlCommand command;
            string query =
                "DELETE FROM protocol " +
                "WHERE protocol_id = @protocolId";

            try
            {
                DB.openConnection();

                command = new NpgsqlCommand(query, DB.GetConnection());
                command.Parameters.AddWithValue("@protocolId", protocolId);
                command.ExecuteNonQuery();

                DB.closeConnection();
            }
            catch
            {
                DB.closeConnection();
            }
        }

        public static bool IsExistsProtocol(int protocolId)
        {
            DataTable dataTableQuery = new DataTable();
            string query =
                "SELECT * FROM protocol " +
                "WHERE protocol_id = @protocolId";

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand(query, DB.GetConnection());

            command.Parameters.AddWithValue("@protocolId", protocolId);
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
