using System.Data;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2
{
    public static class DbHelper
    {
        // =========================================================
        // SELECT QUERY
        // =========================================================
        public static DataTable ExecuteQuery(
            string query,
            params SqlParameter[] parameters)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = DbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                adapter.Fill(table);
            }

            return table;
        }


        // =========================================================
        // INSERT / UPDATE / DELETE
        // =========================================================
        public static int ExecuteNonQuery(
            string query,
            params SqlParameter[] parameters)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();

                return command.ExecuteNonQuery();
            }
        }


        // =========================================================
        // SINGLE VALUE
        // =========================================================
        public static object ExecuteScalar(
            string query,
            params SqlParameter[] parameters)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();

                return command.ExecuteScalar();
            }
        }
    }
}