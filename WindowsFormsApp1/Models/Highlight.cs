using System;

namespace WindowsFormsApp1.Models
{
    /// <summary>
    /// Model ð?i di?n cho highlight/note trong sách
    /// </summary>
    public class Highlight
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string BookTitle { get; set; }
        
        public string SelectedText { get; set; }
        public string Note { get; set; }
        public string ColorHex { get; set; }
        
        public int ChapterIndex { get; set; }
        public int StartIndex { get; set; }
        public int Length { get; set; }
        
        public DateTime DateCreated { get; set; }
    }
}
