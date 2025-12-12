using System;

namespace WindowsFormsApp1.Models
{
    /// <summary>
    /// Model ð?i di?n cho m?c tiêu ð?c sách
    /// </summary>
    public class ReadingGoal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string GoalType { get; set; } // DAILY_MINUTES, MONTHLY_BOOKS, YEARLY_BOOKS
        public int TargetValue { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CompletedDate { get; set; }
    }

    /// <summary>
    /// Streak (Chu?i ngày ð?c liên t?c)
    /// </summary>
    public class ReadingStreak
    {
        public int UserId { get; set; }
        public int CurrentStreak { get; set; }
        public int LongestStreak { get; set; }
        public DateTime LastReadDate { get; set; }
    }

    /// <summary>
    /// Th?ng kê ð?c sách theo ngày
    /// </summary>
    public class DailyReadingStats
    {
        public DateTime Date { get; set; }
        public int TotalMinutes { get; set; }
        public int BooksRead { get; set; }
    }
}
