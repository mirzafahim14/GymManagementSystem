using System;
using System.Windows.Forms;

namespace gymmanagementsystem_2
{
    public class DatabaseTest
    {
        public static void TestConnection()
        {
            try
            {
                object result = DbHelper.ExecuteScalar(
                    "SELECT DB_NAME();"
                );

                MessageBox.Show(
                    "Database Connected Successfully!\n\n" +
                    "Current Database: " + result.ToString(),
                    "SQL Server Connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Connection Failed!\n\n" +
                    ex.Message,
                    "SQL Server Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}