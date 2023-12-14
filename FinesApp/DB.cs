using System;
using System.Data;
using Npgsql;

namespace FinesApp
{
    public static class DB
    {
        static string DBConnect = "Server=localhost; Port=5432; User Id=postgres; Database=fines;";
        static NpgsqlConnection conn = new NpgsqlConnection(DBConnect);
        

        public static void openConnection() { 
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            return conn;
        }
    }
}
