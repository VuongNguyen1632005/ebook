using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class EditBookForm : Form
    {
        public bool IsUpdated { get; private set; } = false;
        private Book _book;

        public EditBookForm(Book book)
        {
            _book = book;
            InitializeComponent();
            ApplyStyles();
            LoadData();
        }

        private void ApplyStyles()
        {
            // Bo góc cho input containers
            UIHelper.RoundPanel(pnlTitleContainer, 8);
            UIHelper.RoundPanel(pnlAuthorContainer, 8);
            UIHelper.RoundPanel(pnlDescContainer, 8);

            // Bo góc cho buttons
            UIHelper.RoundButton(btnSave, 8);
            UIHelper.RoundButton(btnCancel, 8);

            // Enable double buffering
            this.DoubleBuffered = true;
        }

        private void LoadData()
        {
            if (_book == null) return;
            txtTitle.Text = _book.Title;
            txtAuthor.Text = _book.Author;
            txtDesc.Text = _book.Description;
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
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Tiêu đề không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            try
            {
                DataManager.Instance.UpdateBookInfo(
                    _book.Id,
                    txtTitle.Text.Trim(),
                    txtAuthor.Text.Trim(),
                    txtDesc.Text.Trim()
                );

                IsUpdated = true;
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
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

        private void EditBookForm_Paint(object sender, PaintEventArgs e)
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