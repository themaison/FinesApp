using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace FinesApp
{
    class DB
    {
        static string DBConnect = "Server=localhost; Port=5432; User Id=postgres; Database=fines;";
        NpgsqlConnection conn = new NpgsqlConnection(DBConnect);
        NpgsqlCommand cmd = new NpgsqlCommand();
        

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

        public void DoQuery(string query)
        {
            openConnection();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
            }

            cmd.Dispose();
            conn.Close();
        }
    }
}
