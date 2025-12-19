using System;

namespace WindowsFormsApp1.Models
{
 
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

  
    public class ReadingStreak
    {
        public int UserId { get; set; }
        public int CurrentStreak { get; set; }
        public int LongestStreak { get; set; }
        public DateTime LastReadDate { get; set; }
    }

  
    public class DailyReadingStats
    {
        public DateTime Date { get; set; }
        public int TotalMinutes { get; set; }
        public int BooksRead { get; set; }
    }
}
