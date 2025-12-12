using System;

namespace WindowsFormsApp1.Data
{
    public class ReadingGoal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string GoalType { get; set; } // "DAILY_MINUTES", "MONTHLY_BOOKS" ho?c "YEARLY_BOOKS"
        public int TargetValue { get; set; } // 30 phút, 3 cu?n/tháng ho?c 12 cu?n/nãm
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CompletedDate { get; set; }
    }

    public class ReadingSession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int DurationMinutes { get; set; } // Tính toán t? StartTime - EndTime
        public DateTime SessionDate { get; set; } // Ngày ð?c (ð? tính streak)
    }

    public class ReadingStreak
    {
        public int UserId { get; set; }
        public int CurrentStreak { get; set; } // S? ngày ð?c liên t?c hi?n t?i
        public int LongestStreak { get; set; } // K? l?c streak dài nh?t
        public DateTime LastReadDate { get; set; } // Ngày ð?c g?n nh?t
    }

    public class DailyReadingStats
    {
        public DateTime Date { get; set; }
        public int TotalMinutes { get; set; }
        public int BooksRead { get; set; }
        public bool GoalAchieved { get; set; }
    }
}
