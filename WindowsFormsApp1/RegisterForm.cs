using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class RegisterForm : Form
    {
        public User RegisteredUser { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            // Bo góc cho các input containers
            UIHelper.RoundPanel(pnlUserContainer, 8);
            UIHelper.RoundPanel(pnlNameContainer, 8);
            UIHelper.RoundPanel(pnlEmailContainer, 8);
            UIHelper.RoundPanel(pnlPassContainer, 8);
            UIHelper.RoundPanel(pnlConfirmContainer, 8);

            // Bo góc cho button
            UIHelper.RoundButton(btnRegister, 8);

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

        #region Event Handlers - Register Button

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

            if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirm.Clear();
                txtConfirm.Focus();
                return;
            }

            if (txtPass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }

            try
            {
                var user = DataManager.Instance.Register(
                    txtUser.Text.Trim(), 
                    txtPass.Text, 
                    txtName.Text.Trim(), 
                    txtEmail.Text.Trim()
                );
                
                RegisteredUser = user;
                MessageBox.Show("Đăng ký thành công!", "Thành công", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Đăng Ký", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(0, 100, 180);
        }

        private void BtnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(0, 120, 215);
        }

        #endregion

        #region Event Handlers - Login Link

        private void LblLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void LblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.FromArgb(100, 160, 220);
        }

        private void LblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.FromArgb(140, 140, 140);
        }

        #endregion

        #region Form Paint - Border

        private void RegisterForm_Paint(object sender, PaintEventArgs e)
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