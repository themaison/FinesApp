using System;
using System.Data;
using Npgsql;

namespace FinesApp
{
    class DB
    {
        static string DBConnect = "Server=localhost; Port=5432; User Id=postgres; Database=fines;";
        NpgsqlConnection conn = new NpgsqlConnection(DBConnect);
        

        public void openConnection() { 
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return conn;
        }

        public DataTable GetTableFromDB(String tableName)
        {
            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command;

            string query = "SELECT * FROM " + tableName;

            this.openConnection();

            command = new NpgsqlCommand(query, this.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            this.closeConnection();

            return table;
        }
    }
}
