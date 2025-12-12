using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1.Utils
{
    /// <summary>
    /// Helper class cho các thao tác UI
    /// </summary>
    public static class UIHelper
    {
        /// <summary>
        /// T?o GraphicsPath cho h?nh ch? nh?t bo góc
        /// </summary>
        public static GraphicsPath GetRoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();
            
            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Top left arc
            path.AddArc(arc, 180, 90);
            
            // Top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            
            // Bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            
            // Bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// T?o màu hover (sáng hõn)
        /// </summary>
        public static Color GetHoverColor(Color baseColor)
        {
            return ControlPaint.Light(baseColor);
        }

        /// <summary>
        /// T?o màu pressed (t?i hõn)
        /// </summary>
        public static Color GetPressedColor(Color baseColor)
        {
            return ControlPaint.Dark(baseColor);
        }

        /// <summary>
        /// Bo góc cho Panel
        /// </summary>
        public static void RoundPanel(Panel panel, int radius)
        {
            if (panel == null) return;
            panel.Region = new Region(GetRoundedRectangle(new Rectangle(0, 0, panel.Width, panel.Height), radius));
        }

        /// <summary>
        /// Bo góc cho Button
        /// </summary>
        public static void RoundButton(Button button, int radius)
        {
            if (button == null) return;
            button.Region = new Region(GetRoundedRectangle(new Rectangle(0, 0, button.Width, button.Height), radius));
        }

        /// <summary>
        /// Áp d?ng style cho input container
        /// </summary>
        public static void StyleInputContainer(Panel container, int radius = 6)
        {
            if (container == null) return;
            RoundPanel(container, radius);
            container.Padding = new Padding(1);
        }

        /// <summary>
        /// Áp d?ng style cho primary button
        /// </summary>
        public static void StylePrimaryButton(Button button, int radius = 6)
        {
            if (button == null) return;
            RoundButton(button, radius);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(0, 120, 215);
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Áp d?ng style cho secondary button  
        /// </summary>
        public static void StyleSecondaryButton(Button button, int radius = 6)
        {
            if (button == null) return;
            RoundButton(button, radius);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(60, 60, 65);
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// V? border v?i gradient
        /// </summary>
        public static void DrawGradientBorder(Graphics g, Rectangle bounds, Color startColor, Color endColor, int width = 2)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(bounds, startColor, endColor, 45f))
            using (Pen pen = new Pen(brush, width))
            {
                g.DrawRectangle(pen, 0, 0, bounds.Width - 1, bounds.Height - 1);
            }
        }
    }
}
