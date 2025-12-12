using System;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp1.Utils
{
    /// <summary>
    /// Helper class cho các thao tác v?i file
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// Load ?nh an toàn, tránh file lock
        /// </summary>
        public static Image LoadImageSafe(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return null;

                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(fs);
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Ki?m tra file có ph?i là ebook không
        /// </summary>
        public static bool IsEbookFile(string filePath)
        {
            string ext = Path.GetExtension(filePath).ToLower();
            return ext == ".epub" || ext == ".pdf" || ext == ".txt" || ext == ".mobi";
        }

        /// <summary>
        /// L?y tên file không có extension
        /// </summary>
        public static string GetFileNameWithoutExtension(string filePath)
        {
            return Path.GetFileNameWithoutExtension(filePath);
        }

        /// <summary>
        /// Ð?m b?o thý m?c t?n t?i
        /// </summary>
        public static void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
