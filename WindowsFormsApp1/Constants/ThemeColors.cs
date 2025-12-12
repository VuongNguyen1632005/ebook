using System.Drawing;

namespace WindowsFormsApp1.Constants
{
    /// <summary>
    /// Ð?nh ngh?a các màu s?c cho theme
    /// </summary>
    public static class ThemeColors
    {
        // Dark Theme Colors
        public static readonly Color Background = Color.FromArgb(32, 33, 36);
        public static readonly Color Sidebar = Color.FromArgb(25, 25, 27);
        public static readonly Color TopBar = Color.FromArgb(40, 41, 45);
        public static readonly Color Accent = Color.FromArgb(138, 180, 248);
        public static readonly Color TextActive = Color.White;
        public static readonly Color TextInactive = Color.FromArgb(154, 160, 166);
        public static readonly Color Hover = Color.FromArgb(60, 64, 67);
        public static readonly Color CardBackground = Color.FromArgb(45, 45, 48);
        
        // Semantic Colors
        public static readonly Color Success = Color.FromArgb(76, 175, 80);
        public static readonly Color Warning = Color.FromArgb(255, 152, 0);
        public static readonly Color Error = Color.FromArgb(244, 67, 54);
        public static readonly Color Info = Color.FromArgb(33, 150, 243);
        
        // Button Colors
        public static readonly Color PrimaryButton = Color.FromArgb(0, 120, 215);
        public static readonly Color SecondaryButton = Color.FromArgb(60, 64, 67);
        public static readonly Color DangerButton = Color.FromArgb(234, 67, 53);
    }
}
