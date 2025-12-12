using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Data
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        // Chuỗi kết nối đến database QL_ebook
        private string connectionString = @"Data Source=(local);Initial Catalog=QL_ebook;Integrated Security=True";

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null) instance = new DatabaseConnection();
                return instance;
            }
        }

        private DatabaseConnection() { }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}