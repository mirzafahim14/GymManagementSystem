using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gymmanagementsystem_2
{
    public class HashGenerator
    {
        public static void Generate()
        {
            string password = "1234";

            // Generate new hash
            string newHash = PasswordHasher.HashPassword(password);

            // Database connection
            string connectionString =
                "Server=localhost;Database=GymManagementSystem;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    "UPDATE Users " +
                    "SET PasswordHash = @PasswordHash " +
                    "WHERE Username = 'admin'";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@PasswordHash",
                        newHash
                    );

                    int rows = command.ExecuteNonQuery();

                    if (rows == 1)
                    {
                        // Read hash back from database
                        string dbHash = "";

                        string selectQuery =
                            "SELECT PasswordHash " +
                            "FROM Users " +
                            "WHERE Username = 'admin'";

                        using (SqlCommand selectCommand =
                            new SqlCommand(selectQuery, connection))
                        {
                            object result =
                                selectCommand.ExecuteScalar();

                            if (result != null)
                            {
                                dbHash = result.ToString();
                            }
                        }

                        // Verify password
                        bool verified =
                            PasswordHasher.VerifyPassword(
                                password,
                                dbHash
                            );

                        MessageBox.Show(
                            "Admin Password Updated!\n\n" +
                            "Username: admin\n" +
                            "Password: 1234\n\n" +
                            "Database Verification: " +
                            verified,
                            "Password Test",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Admin user was not found.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }
    }
}