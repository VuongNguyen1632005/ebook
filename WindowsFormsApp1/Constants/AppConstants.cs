namespace WindowsFormsApp1.Constants
{
    /// <summary>
    /// Các h?ng s? dùng chung trong ?ng d?ng
    /// </summary>
    public static class AppConstants
    {
        // Thý m?c
        public const string COVER_IMAGES_FOLDER = "CoverImages";
        
        // File extensions
        public const string EPUB_EXT = ".epub";
        public const string PDF_EXT = ".pdf";
        public const string TXT_EXT = ".txt";
        public const string MOBI_EXT = ".mobi";
        
        // Goal types
        public const string GOAL_DAILY_MINUTES = "DAILY_MINUTES";
        public const string GOAL_MONTHLY_BOOKS = "MONTHLY_BOOKS";
        public const string GOAL_YEARLY_BOOKS = "YEARLY_BOOKS";
        
        // Default values
        public const int DEFAULT_DAILY_MINUTES = 30;
        public const int DEFAULT_MONTHLY_BOOKS = 3;
        public const int DEFAULT_YEARLY_BOOKS = 12;
        
        // Image limits
        public const int MAX_IMAGES_PER_CHAPTER = 20;
        public const int MAX_IMAGES_PER_PAGE = 10;
        public const int MAX_IMAGE_WIDTH = 3000;
        public const int MAX_IMAGE_HEIGHT = 3000;
        
        // Notifications
        public const int NOTIFICATION_DISPLAY_TIME = 5000; // ms
        public const int NOTIFICATION_CLEANUP_TIME = 10000; // ms
        
        // Reading reminders
        public const int REMINDER_START_HOUR = 8;
        public const int REMINDER_END_HOUR = 22;
        public const int REMINDER_CHECK_INTERVAL_HOURS = 1;
    }
}
