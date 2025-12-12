using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class PasswordPromptForm : Form
    {
        public bool IsVerified { get; private set; } = false;

        public PasswordPromptForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            // Bo góc cho input container
            UIHelper.RoundPanel(pnlPasswordContainer, 8);

            // Bo góc cho buttons
            UIHelper.RoundButton(btnOK, 8);
            UIHelper.RoundButton(btnCancel, 8);

            // Enable double buffering
            this.DoubleBuffered = true;
        }

        #region Event Handlers - Header

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(232, 17, 35);
            btnClose.ForeColor = Color.White;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.FromArgb(160, 160, 160);
        }

        #endregion

        #region Event Handlers - Buttons

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

            int currentUid = DataManager.Instance.GetCurrentUser();
            if (DataManager.Instance.VerifyCurrentPassword(currentUid, txtPass.Text))
            {
                IsVerified = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng!", "Lỗi xác thực", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void BtnOK_MouseEnter(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.FromArgb(0, 100, 180);
        }

        private void BtnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(80, 80, 85);
        }

        private void BtnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(60, 60, 65);
        }

        #endregion

        #region Form Paint - Border

        private void PasswordPromptForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            // Vẽ border gradient
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

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion
    }
}