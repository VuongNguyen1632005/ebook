using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Constants;

namespace WindowsFormsApp1.Services
{
    /// <summary>
    /// Service quản lý nhắc nhở đọc sách tự động
    /// </summary>
    public class ReadingReminderService
    {
        private static ReadingReminderService _instance;
        private System.Threading.Timer _reminderTimer;
        private int _userId;
        private bool _isRunning;

        public static ReadingReminderService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReadingReminderService();
                return _instance;
            }
        }

        private ReadingReminderService()
        {
            _isRunning = false;
        }

        /// <summary>
        /// Bắt đầu service nhắc nhở (gọi khi user đăng nhập)
        /// </summary>
        public void Start(int userId)
        {
            if (_isRunning)
                Stop();

            _userId = userId;
            _isRunning = true;

            // Kiểm tra theo interval đã định nghĩa trong constants
            _reminderTimer = new System.Threading.Timer(
                CheckAndSendReminder, 
                null, 
                TimeSpan.Zero, 
                TimeSpan.FromHours(AppConstants.REMINDER_CHECK_INTERVAL_HOURS)
            );
        }

        /// <summary>
        /// Dừng service
        /// </summary>
        public void Stop()
        {
            if (_reminderTimer != null)
            {
                _reminderTimer.Dispose();
                _reminderTimer = null;
            }
            _isRunning = false;
        }

        /// <summary>
        /// Kiểm tra và gửi nhắc nhở
        /// </summary>
        private void CheckAndSendReminder(object state)
        {
            try
            {
                // Chỉ nhắc nhở trong khung giờ quy định
                int currentHour = DateTime.Now.Hour;
                if (currentHour < AppConstants.REMINDER_START_HOUR || 
                    currentHour > AppConstants.REMINDER_END_HOUR)
                    return;

                // Kiểm tra xem hôm nay đã đọc chưa
                bool hasReadToday = DataManager.Instance.HasReadToday(_userId);
                
                if (!hasReadToday)
                {
                    // Kiểm tra xem đã gửi nhắc nhở hôm nay chưa
                    var notifications = DataManager.Instance.GetUnreadNotifications(_userId);
                    bool alreadyNotifiedToday = false;

                    foreach (var notif in notifications)
                    {
                        if (notif.Contains("Đừng quên đọc sách hôm nay"))
                        {
                            alreadyNotifiedToday = true;
                            break;
                        }
                    }

                    if (!alreadyNotifiedToday)
                    {
                        string message = GetRandomReminderMessage();
                        DataManager.Instance.CreateNotification(_userId, message);
                        
                        // Hiển thị notification trên UI (chạy trên UI thread)
                        ShowNotificationBalloon(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi service nhắc nhở: " + ex.Message);
            }
        }

        /// <summary>
        /// Lấy tin nhắn nhắc nhở ngẫu nhiên
        /// </summary>
        private string GetRandomReminderMessage()
        {
            string[] messages = new string[]
            {
                "📚 Đừng quên đọc sách hôm nay! Chỉ cần 30 phút thôi.",
                "⏰ Đã đến giờ đọc sách rồi đấy! Hãy duy trì streak của bạn.",
                "🔥 Streak của bạn đang chờ đấy! Hãy đọc sách ngay hôm nay.",
                "💡 Một ngày không đọc sách là một ngày lãng phí! Hãy bắt đầu ngay.",
                "📖 Kiến thức đang chờ bạn! Hãy mở một cuốn sách ngay hôm nay.",
                "🎯 Đừng để mục tiêu của bạn bị phá vỡ! Hãy đọc sách ngay."
            };

            Random random = new Random();
            return messages[random.Next(messages.Length)];
        }

        /// <summary>
        /// Hiển thị notification balloon (Windows Notification)
        /// </summary>
        private void ShowNotificationBalloon(string message)
        {
            try
            {
                // Tạo NotifyIcon tạm thời để hiển thị notification
                NotifyIcon notifyIcon = new NotifyIcon
                {
                    Visible = true,
                    Icon = System.Drawing.SystemIcons.Information,
                    BalloonTipTitle = "Nhắc nhở đọc sách",
                    BalloonTipText = message,
                    BalloonTipIcon = ToolTipIcon.Info
                };

                notifyIcon.ShowBalloonTip(AppConstants.NOTIFICATION_DISPLAY_TIME);

                // Xóa sau thời gian quy định
                Task.Delay(AppConstants.NOTIFICATION_CLEANUP_TIME).ContinueWith(t =>
                {
                    notifyIcon.Visible = false;
                    notifyIcon.Dispose();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hiển thị notification: " + ex.Message);
            }
        }

        /// <summary>
        /// Gửi nhắc nhở thủ công (nếu cần)
        /// </summary>
        public void SendManualReminder(string message)
        {
            try
            {
                DataManager.Instance.CreateNotification(_userId, message);
                ShowNotificationBalloon(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi gửi nhắc nhở: " + ex.Message);
            }
        }
    }
}
