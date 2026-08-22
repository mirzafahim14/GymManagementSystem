using System;
using System.Security.Cryptography;

namespace gymmanagementsystem_2
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            const int iterations = 100000;

            byte[] salt = new byte[16];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            using (Rfc2898DeriveBytes pbkdf2 =
                new Rfc2898DeriveBytes(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                return iterations + "." +
                       Convert.ToBase64String(salt) + "." +
                       Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(
            string password,
            string storedHash)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(storedHash))
                {
                    return false;
                }

                string[] parts = storedHash.Split('.');

                if (parts.Length != 3)
                    return false;

                int iterations = int.Parse(parts[0]);

                byte[] salt =
                    Convert.FromBase64String(parts[1]);

                byte[] storedPasswordHash =
                    Convert.FromBase64String(parts[2]);

                using (Rfc2898DeriveBytes pbkdf2 =
                    new Rfc2898DeriveBytes(
                        password,
                        salt,
                        iterations,
                        HashAlgorithmName.SHA256))
                {
                    byte[] calculatedHash =
                        pbkdf2.GetBytes(storedPasswordHash.Length);

                    if (calculatedHash.Length !=
                        storedPasswordHash.Length)
                    {
                        return false;
                    }

                    for (int i = 0;
                         i < calculatedHash.Length;
                         i++)
                    {
                        if (calculatedHash[i] !=
                            storedPasswordHash[i])
                        {
                            return false;
                        }
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}