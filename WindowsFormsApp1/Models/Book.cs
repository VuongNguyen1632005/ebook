using System;

namespace WindowsFormsApp1.Models
{
    /// <summary>
    /// Model ð?i di?n cho m?t cu?n sách trong h? th?ng
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string CoverImagePath { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }

        // Các trý?ng m?i
        public string MD5 { get; set; }
        public int FileSizeKB { get; set; }
        public int Rating { get; set; }

        public bool IsFavorite { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateAdded { get; set; }
        public double Progress { get; set; }

        public Book()
        {
            DateAdded = DateTime.Now;
            Author = "Unknown Author";
            Title = "Untitled";
            IsFavorite = false;
            IsDeleted = false;
        }

        public string GetProgressText()
        {
            return $"{Progress:F1}%";
        }
    }
}
