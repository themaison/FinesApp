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
    }
}
