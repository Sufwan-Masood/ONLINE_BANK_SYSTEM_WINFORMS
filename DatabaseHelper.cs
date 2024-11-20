using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SE_bank
{
    public class DatabaseHelper
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        // Constructor to initialize the connection string
        public DatabaseHelper()
        {

        }

        // Executes a non-query command (e.g., INSERT, UPDATE, DELETE)
        public void ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Retrieves data and returns it as a DataTable
        public DataTable GetData(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        // Retrieves a single scalar value (e.g., COUNT, SUM, etc.)
        public object GetScalarValue(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            object result = command.ExecuteScalar();
            connection.Close();
            return result;
        }
        public static bool AddUser(string query)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch { return false; }

        }
        public static DataTable DB_Authenticate(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public static object DB_getBalance(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            object result = command.ExecuteScalar();
            connection.Close();
            return result;

        }
        public static bool DB_update(string query)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
               int r = command.ExecuteNonQuery();
                connection.Close();
                if (r != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }

        }

    }
}

