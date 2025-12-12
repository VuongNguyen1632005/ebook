using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class LoginForm : Form
    {
        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            // Bo góc cho các input containers
            UIHelper.RoundPanel(pnlUserContainer, 8);
            UIHelper.RoundPanel(pnlPassContainer, 8);

            // Bo góc cho button login
            UIHelper.RoundButton(btnLogin, 8);

            // Enable double buffering
            this.DoubleBuffered = true;
        }

        #region Event Handlers - Title Bar

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
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

        #region Event Handlers - TextBox Focus Effects

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            pnlUserContainer.BackColor = Color.FromArgb(55, 55, 60);
            pnlUserIcon.BackColor = Color.FromArgb(55, 55, 60);
            txtUser.BackColor = Color.FromArgb(55, 55, 60);
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            pnlUserContainer.BackColor = Color.FromArgb(45, 45, 50);
            pnlUserIcon.BackColor = Color.FromArgb(45, 45, 50);
            txtUser.BackColor = Color.FromArgb(45, 45, 50);
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            pnlPassContainer.BackColor = Color.FromArgb(55, 55, 60);
            pnlPassIcon.BackColor = Color.FromArgb(55, 55, 60);
            txtPass.BackColor = Color.FromArgb(55, 55, 60);
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            pnlPassContainer.BackColor = Color.FromArgb(45, 45, 50);
            pnlPassIcon.BackColor = Color.FromArgb(45, 45, 50);
            txtPass.BackColor = Color.FromArgb(45, 45, 50);
        }

        #endregion

        #region Event Handlers - Buttons & Links

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = DataManager.Instance.Login(txtUser.Text, txtPass.Text);
            if (user != null)
            {
                LoggedInUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(0, 100, 180);
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void LblRegister_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterForm())
            {
                var result = registerForm.ShowDialog();
                if (result == DialogResult.OK && registerForm.RegisteredUser != null)
                {
                    LoggedInUser = registerForm.RegisteredUser;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void LblRegister_MouseEnter(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.FromArgb(100, 160, 220);
        }

        private void LblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.FromArgb(140, 140, 140);
        }

        private void LblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LblForgotPassword_MouseEnter(object sender, EventArgs e)
        {
            lblForgotPassword.Font = new Font(lblForgotPassword.Font, FontStyle.Underline);
        }

        private void LblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPassword.Font = new Font(lblForgotPassword.Font, FontStyle.Regular);
        }

        #endregion

        #region Form Paint - Border

        private void LoginForm_Paint(object sender, PaintEventArgs e)
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