using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2
{
    public static class DbConnection
    {
        private static readonly string connectionString =
            "Server=localhost;" +
            "Database=GymManagementSystem;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}