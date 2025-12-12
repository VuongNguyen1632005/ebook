using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class EditProfileForm : Form
    {
        public User UpdatedUser { get; private set; }
        private User _currentUser;

        public EditProfileForm(User currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
            ApplyStyles();
            LoadUserData();
        }

        private void ApplyStyles()
        {
            // Bo góc cho các input containers
            UIHelper.RoundPanel(pnlUsernameContainer, 8);
            UIHelper.RoundPanel(pnlDisplayContainer, 8);
            UIHelper.RoundPanel(pnlEmailContainer, 8);
            UIHelper.RoundPanel(pnlPassContainer, 8);

            // Bo góc cho buttons
            UIHelper.RoundButton(btnSave, 8);
            UIHelper.RoundButton(btnCancel, 8);

            // Enable double buffering để giảm flickering
            this.DoubleBuffered = true;
        }

        private void LoadUserData()
        {
            if (_currentUser == null) return;
            txtUsername.Text = _currentUser.Username;
            txtDisplay.Text = _currentUser.DisplayName;
            txtEmail.Text = _currentUser.Email;
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
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        #endregion

        #region Event Handlers - Buttons

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDisplay.Text))
            {
                MessageBox.Show("Tên hiển thị không được để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDisplay.Focus();
                return;
            }

            try
            {
                string newPass = string.IsNullOrWhiteSpace(txtNewPass.Text) ? null : txtNewPass.Text;
                DataManager.Instance.UpdateUserProfile(_currentUser.Id, txtDisplay.Text.Trim(), txtEmail.Text.Trim(), newPass);

                UpdatedUser = new User
                {
                    Id = _currentUser.Id,
                    Username = _currentUser.Username,
                    DisplayName = txtDisplay.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                MessageBox.Show("Đã cập nhật hồ sơ thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi cập nhật",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Form Paint - Border

        private void EditProfileForm_Paint(object sender, PaintEventArgs e)
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