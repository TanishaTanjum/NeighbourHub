using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NeighbourHub
{
    public static class Database
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["NeighbourHubDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable Query(string query, params SqlParameter[] parameters)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                adapter.Fill(table);
            }

            return table;
        }

        public static int Execute(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();

                return command.ExecuteNonQuery();
            }
        }
    }
}