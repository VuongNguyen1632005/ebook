using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class AddShelfDialog : Form
    {
        public string ShelfName => txtName.Text.Trim();
        public string ShelfDescription => txtDescription.Text.Trim();

        public AddShelfDialog()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            // Bo góc cho input containers
            UIHelper.RoundPanel(pnlNameContainer, 8);
            UIHelper.RoundPanel(pnlDescContainer, 8);

            // Bo góc cho buttons
            UIHelper.RoundButton(btnCreate, 8);
            UIHelper.RoundButton(btnCancel, 8);

            // Enable double buffering
            this.DoubleBuffered = true;

            // Subscribe paint event
            this.Paint += AddShelfDialog_Paint;
            pnlHeader.MouseDown += PnlHeader_MouseDown;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui l?ng nh?p tên k? sách!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region Form Paint - Border

        private void AddShelfDialog_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            // V? border gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0), 
                new Point(this.Width, this.Height),
                Color.FromArgb(0, 120, 215),
                Color.FromArgb(100, 160, 220)))
            using (Pen pen = new Pen(brush, 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        #endregion

        #region Win32 API for Dragging

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion
    }
}
