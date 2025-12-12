using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class AddToShelfDialog : Form
    {
        public int SelectedShelfId { get; private set; } = -1;
        public string NewShelfName { get; private set; } = null;

        public AddToShelfDialog()
        {
            InitializeComponent();
            ApplyStyles();
            LoadShelves();
        }

        private void ApplyStyles()
        {
            // Bo góc cho input containers
            UIHelper.RoundPanel(pnlSelectContainer, 8);
            UIHelper.RoundPanel(pnlNewContainer, 8);

            // Bo góc cho buttons
            UIHelper.RoundButton(btnConfirm, 8);
            UIHelper.RoundButton(btnCancel, 8);

            // Enable double buffering
            this.DoubleBuffered = true;
        }

        private void LoadShelves()
        {
            var shelves = DataManager.Instance.GetShelvesList();
            shelves.Insert(0, new Shelf { Id = -1, Name = "-- Chọn kệ có sẵn --" });

            cmbShelves.DataSource = shelves;
            cmbShelves.DisplayMember = "Name";
            cmbShelves.ValueMember = "Id";
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
            this.DialogResult = DialogResult.Cancel;
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
            btnClose.ForeColor = Color.Gray;
        }

        #endregion

        #region Event Handlers - Buttons

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string newName = txtNewShelf.Text.Trim();

            // Priority 1: If new shelf name entered -> Create new shelf
            if (!string.IsNullOrEmpty(newName))
            {
                NewShelfName = newName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            // Priority 2: If existing shelf selected
            else if (cmbShelves.SelectedIndex > 0)
            {
                SelectedShelfId = (int)cmbShelves.SelectedValue;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một kệ hoặc nhập tên kệ mới.", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Form Paint - Border

        private void AddToShelfDialog_Paint(object sender, PaintEventArgs e)
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

        private void txtNewShelf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}