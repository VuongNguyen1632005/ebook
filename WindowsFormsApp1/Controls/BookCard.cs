using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controls
{
    public partial class BookCard : UserControl
    {
        private Book _book;

        public event EventHandler BookClicked;
        public event EventHandler MenuClicked;
        public event EventHandler RestoreClicked;
        public event EventHandler PermanentDeleteClicked;

        private PictureBox coverBox;
        private Label titleLabel;
        private Label progressLabel;
        private Button menuButton;
        private Button restoreButton;
        private Button deleteButton;
        private Panel infoPanel;
        private Panel deletedOverlay;
        private FlowLayoutPanel overlayButtonsPanel;

        // Button style map
        private Dictionary<Button, Tuple<Color, Color, string>> actionButtonStyles = new Dictionary<Button, Tuple<Color, Color, string>>();

        // Colors
        private readonly Color clrRestoreNormal = Color.FromArgb(46, 125, 50);
        private readonly Color clrRestoreHover = Color.FromArgb(76, 175, 80);
        private readonly Color clrDeleteNormal = Color.FromArgb(198, 40, 40);
        private readonly Color clrDeleteHover = Color.FromArgb(229, 57, 53);

        public BookCard()
        {
            InitializeCustomComponents();

            this.Click += (s, e) => BookClicked?.Invoke(this, e);
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.Transparent;
            this.Size = new Size(150, 240);
            this.Margin = new Padding(15);
        }

        public Book Book
        {
            get => _book;
            set
            {
                _book = value;
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            if (_book == null) return;

            titleLabel.Text = _book.Title ?? "";

            if (_book.TotalPages > 0)
                progressLabel.Text = $"{_book.Progress:0.00}%";
            else
                progressLabel.Text = "0.00%";

            bool isDeleted = _book.IsDeleted;

            progressLabel.Visible = !isDeleted;
            menuButton.Visible = !isDeleted;

            if (deletedOverlay != null)
            {
                deletedOverlay.Visible = isDeleted;
                if (isDeleted) deletedOverlay.BringToFront();
            }

            if (overlayButtonsPanel != null)
            {
                overlayButtonsPanel.Visible = isDeleted;
                if (isDeleted)
                {
                    overlayButtonsPanel.BringToFront();
                    overlayButtonsPanel.Left = Math.Max(8, (coverBox.Width - overlayButtonsPanel.Width) / 2);
                    overlayButtonsPanel.Top = Math.Max((coverBox.Height - overlayButtonsPanel.Height) / 2 + 12, 8);
                }
            }

            if (deletedOverlay != null) deletedOverlay.Invalidate();

            // Load image
            bool imageLoaded = false;
            string imagePath = _book.CoverImagePath;

            if (!string.IsNullOrEmpty(imagePath))
            {
                if (File.Exists(imagePath))
                {
                    LoadImageSafe(imagePath);
                    imageLoaded = true;
                }
                else
                {
                    try
                    {
                        string fileName = Path.GetFileName(imagePath);
                        string localPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CoverImages", fileName);
                        if (File.Exists(localPath))
                        {
                            LoadImageSafe(localPath);
                            imageLoaded = true;
                        }
                    }
                    catch { }
                }
            }

            if (!imageLoaded)
            {
                coverBox.Image = null;
                coverBox.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void LoadImageSafe(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    if (coverBox.Image != null) coverBox.Image.Dispose();
                    coverBox.Image = Image.FromStream(fs);
                }
            }
            catch { coverBox.Image = null; }
        }

        private void InitializeCustomComponents()
        {
            // Cover
            coverBox = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 190,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.FromArgb(60, 60, 60)
            };
            coverBox.Click += (s, e) => BookClicked?.Invoke(this, e);

            // Overlay
            deletedOverlay = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(150, 15, 15, 15),
                Visible = false
            };
            deletedOverlay.Paint += DeletedOverlay_Paint;

            overlayButtonsPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Visible = false,
                Padding = new Padding(6),
                BackColor = Color.Transparent
            };

            // Restore button
            restoreButton = new Button
            {
                Text = "Khôi phục",
                Size = new Size(110, 36),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 4, 0, 6)
            };
            restoreButton.FlatAppearance.BorderSize = 0;
            restoreButton.Click += (s, e) => RestoreClicked?.Invoke(this, EventArgs.Empty);

            // Delete button (stacked under restore)
            deleteButton = new Button
            {
                Text = "Xóa",
                Size = new Size(110, 36),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 6, 0, 4)
            };
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Click += (s, e) => PermanentDeleteClicked?.Invoke(this, EventArgs.Empty);

            RegisterActionButtonStyle(restoreButton, clrRestoreNormal, clrRestoreHover, "↺");
            RegisterActionButtonStyle(deleteButton, clrDeleteNormal, clrDeleteHover, "✕");

            overlayButtonsPanel.Controls.Add(restoreButton);
            overlayButtonsPanel.Controls.Add(deleteButton);

            // Position overlay buttons when cover size changes
            coverBox.SizeChanged += (s, e) =>
            {
                overlayButtonsPanel.Left = Math.Max(8, (coverBox.Width - overlayButtonsPanel.Width) / 2);
                overlayButtonsPanel.Top = Math.Max((coverBox.Height - overlayButtonsPanel.Height) / 2 + 12, 8);
                if (deletedOverlay != null) deletedOverlay.BringToFront();
            };

            deletedOverlay.Controls.Add(overlayButtonsPanel);
            coverBox.Controls.Add(deletedOverlay);

            // Info panel
            infoPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 6, 0, 0) };

            titleLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 22,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White,
                AutoEllipsis = true,
                Text = "Book Title"
            };

            titleLabel.Click += (s, e) => BookClicked?.Invoke(this, e);

            var bottomRow = new Panel { Dock = DockStyle.Top, Height = 20 };

            progressLabel = new Label
            {
                Dock = DockStyle.Left,
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Gray,
                Text = "0.00%",
                TextAlign = ContentAlignment.MiddleLeft
            };

            menuButton = new Button
            {
                Text = "...",
                Dock = DockStyle.Right,
                Width = 30,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Gray,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleRight,
                Cursor = Cursors.Hand
            };
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.Click += (s, e) => MenuClicked?.Invoke(this, e);

            bottomRow.Controls.Add(menuButton);
            bottomRow.Controls.Add(progressLabel);

            infoPanel.Controls.Add(bottomRow);
            infoPanel.Controls.Add(titleLabel);

            this.Controls.Add(infoPanel);
            this.Controls.Add(coverBox);
        }

        private void DeletedOverlay_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var panel = sender as Panel;
            if (panel == null || !panel.Visible) return;

            // draw shadowed title
            string text = "ĐÃ XÓA\nTHÙNG RÁC";
            using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near })
            {
                var rectText = new Rectangle(0, 12, panel.Width, 48);
                using (var shadowBrush = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
                {
                    var shadowRect = rectText;
                    shadowRect.Offset(1, 2);
                    using (var font = new Font("Segoe UI", 10, FontStyle.Bold))
                        g.DrawString(text, font, shadowBrush, shadowRect, sf);
                }
                using (var fore = new SolidBrush(Color.White))
                using (var font = new Font("Segoe UI", 10, FontStyle.Bold))
                    g.DrawString(text, font, fore, rectText, sf);
            }

            // draw rounded background behind buttons
            if (overlayButtonsPanel != null && overlayButtonsPanel.Visible)
            {
                var bgWidth = overlayButtonsPanel.Width + overlayButtonsPanel.Padding.Horizontal;
                var bgHeight = overlayButtonsPanel.Height + overlayButtonsPanel.Padding.Vertical;
                int bgLeft = overlayButtonsPanel.Left - 8;
                int bgTop = overlayButtonsPanel.Top - 6;
                var bgRect = new Rectangle(bgLeft, bgTop, Math.Max(80, bgWidth + 16), Math.Max(48, bgHeight + 12));

                using (var path = RoundedRect(bgRect, 10))
                using (var brush = new SolidBrush(Color.FromArgb(220, 30, 30, 30)))
                using (var pen = new Pen(Color.FromArgb(60, 0, 0, 0)))
                {
                    g.FillPath(brush, path);
                    g.DrawPath(pen, path);
                }
            }
        }

        private void RegisterActionButtonStyle(Button btn, Color baseColor, Color hoverColor, string icon)
        {
            actionButtonStyles[btn] = Tuple.Create(baseColor, hoverColor, icon);

            btn.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new Rectangle(0, 0, btn.Width, btn.Height);

                bool hover = btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position));
                var colors = actionButtonStyles[btn];
                Color c1 = hover ? colors.Item2 : colors.Item1;
                Color c2 = ControlPaint.Light(c1);

                using (var brush = new LinearGradientBrush(rect, c2, c1, 90f))
                using (var path = RoundedRect(rect, 10))
                using (var pen = new Pen(Color.FromArgb(60, 0, 0, 0)))
                {
                    g.FillPath(brush, path);
                    g.DrawPath(pen, path);
                }

                var iconText = actionButtonStyles[btn].Item3 + " ";
                var txt = iconText + btn.Text;
                using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                using (var fore = new SolidBrush(btn.ForeColor))
                {
                    g.DrawString(txt, btn.Font, fore, rect, sf);
                }
            };

            btn.MouseEnter += (s, e) => btn.Invalidate();
            btn.MouseLeave += (s, e) => btn.Invalidate();

            btn.BackColor = Color.Transparent;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int dia = radius * 2;
            path.AddArc(rect.Left, rect.Top, dia, dia, 180, 90);
            path.AddArc(rect.Right - dia, rect.Top, dia, dia, 270, 90);
            path.AddArc(rect.Right - dia, rect.Bottom - dia, dia, dia, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - dia, dia, dia, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void SetRoundedRegion(Control ctrl, int radius)
        {
            try
            {
                var path = new GraphicsPath();
                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddArc(ctrl.Width - radius * 2 - 1, 0, radius * 2, radius * 2, 270, 90);
                path.AddArc(ctrl.Width - radius * 2 - 1, ctrl.Height - radius * 2 - 1, radius * 2, radius * 2, 0, 90);
                path.AddArc(0, ctrl.Height - radius * 2 - 1, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();
                ctrl.Region = new Region(path);
            }
            catch { }
        }
    }
}