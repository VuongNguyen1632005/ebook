using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Forms
{
    public partial class ReadingGoalsForm : Form
    {
        private readonly int userId;
        private Label lblTodayMinutes;
        private Label lblMonthlyBooks;
        private Label lblYearlyBooks;
        private Label lblCurrentStreak;
        private Label lblLongestStreak;
        private ProgressBar progDailyGoal;
        private ProgressBar progMonthlyGoal;
        private ProgressBar progYearlyGoal;
        private Panel pnlWeeklyChart;

        public ReadingGoalsForm(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            CreateDynamicUI();
            LoadStatistics();
        }

        private void CreateDynamicUI()
        {
            mainContainer.Controls.Clear();

            // === 1. STREAK CARD ===
            Panel pnlStreak = CreateModernCard("CHUOI NGAY DOC LIEN TUC", Color.FromArgb(231, 76, 60));

            FlowLayoutPanel streakContent = new FlowLayoutPanel
            {
                Location = new Point(30, 60),
                Size = new Size(780, 80),
                FlowDirection = FlowDirection.LeftToRight
            };

            Panel streakLeft = new Panel { Width = 400, Height = 80 };
            lblCurrentStreak = new Label
            {
                Text = "0 ngay",
                Font = new Font("Segoe UI", 42, FontStyle.Bold),
                ForeColor = Color.FromArgb(231, 76, 60),
                AutoSize = true,
                Location = new Point(0, 0)
            };
            streakLeft.Controls.Add(lblCurrentStreak);

            Panel streakRight = new Panel { Width = 350, Height = 80 };
            lblLongestStreak = new Label
            {
                Text = "Ky luc: 0 ngay",
                Font = new Font("Segoe UI", 13),
                ForeColor = Color.FromArgb(127, 140, 141),
                AutoSize = true,
                Location = new Point(0, 30)
            };
            streakRight.Controls.Add(lblLongestStreak);

            streakContent.Controls.Add(streakLeft);
            streakContent.Controls.Add(streakRight);
            pnlStreak.Controls.Add(streakContent);
            mainContainer.Controls.Add(pnlStreak);

            // === 2. DAILY GOAL CARD ===
            Panel pnlDaily = CreateModernCard("MUC TIEU HOM NAY", Color.FromArgb(46, 204, 113));

            lblTodayMinutes = new Label
            {
                Text = "0 / 30 phut",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(46, 204, 113),
                Location = new Point(30, 60),
                AutoSize = true
            };
            pnlDaily.Controls.Add(lblTodayMinutes);

            progDailyGoal = CreateModernProgressBar(30, 95, Color.FromArgb(46, 204, 113));
            pnlDaily.Controls.Add(progDailyGoal);

            Button btnSetDailyGoal = CreateModernButton("Dat muc tieu", Color.FromArgb(46, 204, 113), 650, 55);
            btnSetDailyGoal.Click += BtnSetDailyGoal_Click;
            pnlDaily.Controls.Add(btnSetDailyGoal);

            mainContainer.Controls.Add(pnlDaily);

            // === 3. MONTHLY GOAL CARD ===
            Panel pnlMonthly = CreateModernCard("MUC TIEU THANG NAY", Color.FromArgb(241, 196, 15));

            lblMonthlyBooks = new Label
            {
                Text = "0 / 3 cuon",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(241, 196, 15),
                Location = new Point(30, 60),
                AutoSize = true
            };
            pnlMonthly.Controls.Add(lblMonthlyBooks);

            progMonthlyGoal = CreateModernProgressBar(30, 95, Color.FromArgb(241, 196, 15));
            pnlMonthly.Controls.Add(progMonthlyGoal);

            Button btnSetMonthlyGoal = CreateModernButton("Dat muc tieu", Color.FromArgb(241, 196, 15), 650, 55);
            btnSetMonthlyGoal.Click += BtnSetMonthlyGoal_Click;
            pnlMonthly.Controls.Add(btnSetMonthlyGoal);

            mainContainer.Controls.Add(pnlMonthly);

            // === 4. YEARLY GOAL CARD ===
            Panel pnlYearly = CreateModernCard("MUC TIEU NAM NAY", Color.FromArgb(155, 89, 182));

            lblYearlyBooks = new Label
            {
                Text = "0 / 12 cuon",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(155, 89, 182),
                Location = new Point(30, 60),
                AutoSize = true
            };
            pnlYearly.Controls.Add(lblYearlyBooks);

            progYearlyGoal = CreateModernProgressBar(30, 95, Color.FromArgb(155, 89, 182));
            pnlYearly.Controls.Add(progYearlyGoal);

            Button btnSetYearlyGoal = CreateModernButton("Dat muc tieu", Color.FromArgb(155, 89, 182), 650, 55);
            btnSetYearlyGoal.Click += BtnSetYearlyGoal_Click;
            pnlYearly.Controls.Add(btnSetYearlyGoal);

            mainContainer.Controls.Add(pnlYearly);

            // === 5. WEEKLY CHART ===
            Panel pnlWeekly = CreateModernCard("THONG KE 7 NGAY GAN NHAT", Color.FromArgb(52, 152, 219));
            pnlWeekly.Height = 200;

            pnlWeeklyChart = new Panel
            {
                Location = new Point(30, 60),
                Size = new Size(800, 120),
                BackColor = Color.Transparent
            };
            pnlWeekly.Controls.Add(pnlWeeklyChart);

            mainContainer.Controls.Add(pnlWeekly);
        }

        private Panel CreateModernCard(string title, Color accentColor)
        {
            Panel card = new Panel
            {
                Size = new Size(840, 150),
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 20)
            };

            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                {
                    Rectangle shadowRect = new Rectangle(3, 3, card.Width - 3, card.Height - 3);
                    e.Graphics.FillRectangle(shadowBrush, shadowRect);
                }

                using (SolidBrush cardBrush = new SolidBrush(Color.White))
                {
                    Rectangle cardRect = new Rectangle(0, 0, card.Width - 3, card.Height - 3);
                    e.Graphics.FillRectangle(cardBrush, cardRect);
                }

                using (SolidBrush accentBrush = new SolidBrush(accentColor))
                {
                    Rectangle accentRect = new Rectangle(0, 0, 5, card.Height - 3);
                    e.Graphics.FillRectangle(accentBrush, accentRect);
                }

                using (Pen borderPen = new Pen(Color.FromArgb(230, 230, 230), 1))
                {
                    Rectangle borderRect = new Rectangle(0, 0, card.Width - 4, card.Height - 4);
                    e.Graphics.DrawRectangle(borderPen, borderRect);
                }
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(20, 15),
                AutoSize = true
            };
            card.Controls.Add(lblTitle);

            return card;
        }

        private ProgressBar CreateModernProgressBar(int x, int y, Color barColor)
        {
            ProgressBar prog = new ProgressBar
            {
                Location = new Point(x, y),
                Size = new Size(600, 18),
                Style = ProgressBarStyle.Continuous,
                Maximum = 100,
                Value = 0
            };

            return prog;
        }

        private Button CreateModernButton(string text, Color bgColor, int x, int y)
        {
            Button btn = new Button
            {
                Location = new Point(x, y),
                Size = new Size(160, 45),
                FlatStyle = FlatStyle.Flat,
                BackColor = bgColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Text = text
            };

            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(
                Math.Max(0, bgColor.R - 20),
                Math.Max(0, bgColor.G - 20),
                Math.Max(0, bgColor.B - 20)
            );

            return btn;
        }

        private void LoadStatistics()
        {
            try
            {
                var streak = DataManager.Instance.GetReadingStreak(userId);
                lblCurrentStreak.Text = $"{streak.CurrentStreak} ngay";
                lblLongestStreak.Text = $"Ky luc: {streak.LongestStreak} ngay";

                int todayMinutes = DataManager.Instance.GetTodayReadingMinutes(userId);
                var dailyGoals = DataManager.Instance.GetActiveGoals(userId)
                    .FirstOrDefault(g => g.GoalType == "DAILY_MINUTES");

                int targetMinutes = dailyGoals?.TargetValue ?? 30;
                lblTodayMinutes.Text = $"{todayMinutes} / {targetMinutes} phut";
                progDailyGoal.Value = Math.Min(100, (int)((double)todayMinutes / targetMinutes * 100));

                int monthlyBooks = DataManager.Instance.GetMonthlyBooksRead(userId);
                var monthlyGoals = DataManager.Instance.GetActiveGoals(userId)
                    .FirstOrDefault(g => g.GoalType == "MONTHLY_BOOKS");

                int targetMonthlyBooks = monthlyGoals?.TargetValue ?? 3;
                lblMonthlyBooks.Text = $"{monthlyBooks} / {targetMonthlyBooks} cuon";
                progMonthlyGoal.Value = Math.Min(100, (int)((double)monthlyBooks / targetMonthlyBooks * 100));

                int booksRead = DataManager.Instance.GetYearlyBooksRead(userId);
                var yearlyGoals = DataManager.Instance.GetActiveGoals(userId)
                    .FirstOrDefault(g => g.GoalType == "YEARLY_BOOKS");

                int targetBooks = yearlyGoals?.TargetValue ?? 12;
                lblYearlyBooks.Text = $"{booksRead} / {targetBooks} cuon";
                progYearlyGoal.Value = Math.Min(100, (int)((double)booksRead / targetBooks * 100));

                LoadWeeklyChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tai thong ke: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWeeklyChart()
        {
            pnlWeeklyChart.Controls.Clear();
            var weeklyStats = DataManager.Instance.GetWeeklyStats(userId);

            int barWidth = 90;
            int maxHeight = 100;
            int spacing = 10;

            for (int i = 6; i >= 0; i--)
            {
                var date = DateTime.Today.AddDays(-i);
                var stat = weeklyStats.FirstOrDefault(s => s.Date.Date == date.Date);
                int minutes = stat?.TotalMinutes ?? 0;

                int xPos = (6 - i) * (barWidth + spacing);

                Panel barContainer = new Panel
                {
                    Location = new Point(xPos, 0),
                    Size = new Size(barWidth, maxHeight + 30),
                    BackColor = Color.Transparent
                };

                int barHeight = Math.Max(5, Math.Min(maxHeight, (int)((double)minutes / 60 * maxHeight)));

                Panel bar = new Panel
                {
                    Location = new Point(20, maxHeight - barHeight),
                    Size = new Size(50, barHeight),
                    BackColor = minutes >= 30 ? Color.FromArgb(46, 204, 113) : Color.FromArgb(189, 195, 199)
                };

                barContainer.Controls.Add(bar);

                Label lblMinutes = new Label
                {
                    Text = minutes + "p",
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    ForeColor = Color.FromArgb(52, 73, 94),
                    AutoSize = true,
                    Location = new Point(28, maxHeight - barHeight - 18)
                };
                barContainer.Controls.Add(lblMinutes);

                Label lblDate = new Label
                {
                    Text = date.ToString("dd/MM"),
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.FromArgb(127, 140, 141),
                    AutoSize = true,
                    Location = new Point(20, maxHeight + 5)
                };
                barContainer.Controls.Add(lblDate);

                pnlWeeklyChart.Controls.Add(barContainer);
            }
        }

        private void BtnExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                var reportService = new WindowsFormsApp1.Services.ReportService();

                var streak = DataManager.Instance.GetReadingStreak(userId);
                int todayMinutes = DataManager.Instance.GetTodayReadingMinutes(userId);
                int monthlyBooks = DataManager.Instance.GetMonthlyBooksRead(userId);
                int yearlyBooks = DataManager.Instance.GetYearlyBooksRead(userId);
                var weeklyStats = DataManager.Instance.GetWeeklyStats(userId);
                var goals = DataManager.Instance.GetActiveGoals(userId);

                reportService.CreateGoalsReport(userId, streak, todayMinutes, monthlyBooks, yearlyBooks, weeklyStats, goals);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi xuat bao cao: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowGoalDialog(string goalType, string prompt, int defaultValue, int minValue, int maxValue)
        {
            using (var form = new GoalInputForm(goalType, prompt, defaultValue, minValue, maxValue))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    var oldGoals = DataManager.Instance.GetActiveGoals(userId)
                        .Where(g => g.GoalType == goalType).ToList();
                    foreach (var g in oldGoals)
                    {
                        DataManager.Instance.UpdateGoal(g.Id, false);
                    }

                    DataManager.Instance.CreateReadingGoal(userId, goalType, form.TargetValue);
                    MessageBox.Show($"Da dat muc tieu thanh cong!", "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStatistics();
                }
            }
        }

        private void BtnSetDailyGoal_Click(object sender, EventArgs e)
        {
            ShowGoalDialog("DAILY_MINUTES", "Dat muc tieu doc hang ngay (phut):", 30, 10, 300);
        }

        private void BtnSetMonthlyGoal_Click(object sender, EventArgs e)
        {
            ShowGoalDialog("MONTHLY_BOOKS", "Dat muc tieu doc trong thang (cuon):", 3, 1, 30);
        }

        private void BtnSetYearlyGoal_Click(object sender, EventArgs e)
        {
            ShowGoalDialog("YEARLY_BOOKS", "Dat muc tieu doc trong nam (cuon):", 12, 1, 100);
        }
    }

    public class GoalInputForm : Form
    {
        public int TargetValue { get; private set; }
        private NumericUpDown numValue;

        public GoalInputForm(string goalType, string prompt, int defaultValue, int minValue, int maxValue)
        {
            this.Text = "Dat muc tieu";
            this.Size = new Size(450, 250);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(45, 45, 48);

            Color accentColor;
            switch (goalType)
            {
                case "DAILY_MINUTES":
                    accentColor = Color.FromArgb(46, 204, 113);
                    break;
                case "MONTHLY_BOOKS":
                    accentColor = Color.FromArgb(241, 196, 15);
                    break;
                case "YEARLY_BOOKS":
                    accentColor = Color.FromArgb(155, 89, 182);
                    break;
                default:
                    accentColor = Color.FromArgb(0, 120, 215);
                    break;
            }

            // Header
            Panel pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = accentColor
            };

            Label lblTitle = new Label
            {
                Text = "Dat Muc Tieu",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(15, 12),
                AutoSize = true
            };
            pnlHeader.Controls.Add(lblTitle);
            this.Controls.Add(pnlHeader);

            // Prompt
            Label lblPrompt = new Label
            {
                Text = prompt,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                Location = new Point(20, 70),
                AutoSize = true
            };
            this.Controls.Add(lblPrompt);

            // NumericUpDown
            numValue = new NumericUpDown
            {
                Location = new Point(20, 100),
                Size = new Size(400, 35),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Minimum = minValue,
                Maximum = maxValue,
                Value = defaultValue,
                BackColor = Color.FromArgb(60, 60, 60),
                ForeColor = accentColor,
                TextAlign = HorizontalAlignment.Center
            };
            this.Controls.Add(numValue);

            // Buttons
            Button btnOK = new Button
            {
                Text = "LUU",
                Location = new Point(230, 155),
                Size = new Size(190, 45),
                BackColor = accentColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Click += (s, e) =>
            {
                TargetValue = (int)numValue.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
            this.Controls.Add(btnOK);

            Button btnCancel = new Button
            {
                Text = "Huy",
                Location = new Point(20, 155),
                Size = new Size(190, 45),
                BackColor = Color.FromArgb(80, 80, 80),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Cancel
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }
    }
}
