using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp1.Utils
{
    /// <summary>
    /// Helper class cho các ch?c nãng b?o m?t
    /// </summary>
    public static class SecurityHelper
    {
        /// <summary>
        /// Hash m?t kh?u s? d?ng SHA256
        /// </summary>
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
