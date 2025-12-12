using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Utils;

namespace WindowsFormsApp1.Forms
{
    public partial class ManageShelfDialog : Form
    {
        public ManageShelfDialog()
        {
            InitializeComponent();
            ApplyStyles();
            LoadShelves();
        }

        private void ApplyStyles()
        {
            // Bo góc cho button
            UIHelper.RoundButton(btnAddNew, 8);

            // Enable double buffering
            this.DoubleBuffered = true;
        }

        private void LoadShelves()
        {
            pnlList.Controls.Clear();
            var shelves = DataManager.Instance.GetShelvesList();

            if (shelves.Count == 0)
            {
                lblEmpty.Visible = true;
                pnlList.Controls.Add(lblEmpty);
            }
            else
            {
                lblEmpty.Visible = false;
                foreach (var shelf in shelves)
                {
                    pnlList.Controls.Add(CreateShelfItem(shelf));
                }
            }
        }

        private Panel CreateShelfItem(Shelf shelf)
        {
            Panel pnl = new Panel
            {
                Size = new Size(385, 55),
                BackColor = Color.FromArgb(50, 50, 55),
                Margin = new Padding(0, 0, 0, 8),
                Padding = new Padding(10, 0, 10, 0)
            };

            // Bo góc cho panel item
            pnl.Paint += (s, e) =>
            {
                using (GraphicsPath path = UIHelper.GetRoundedRectangle(new Rectangle(0, 0, pnl.Width, pnl.Height), 8))
                {
                    pnl.Region = new Region(path);
                }
            };

            // Shelf icon
            Label lblShelfIcon = new Label
            {
                Text = "📚",
                Font = new Font("Segoe UI Emoji", 14),
                ForeColor = Color.FromArgb(100, 160, 220),
                Location = new Point(10, 12),
                Size = new Size(35, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Name Label
            Label lblName = new Label
            {
                Text = shelf.Name,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.White,
                Location = new Point(50, 15),
                AutoSize = true,
                MaximumSize = new Size(200, 0)
            };

            // Edit TextBox (Hidden initially)
            TextBox txtEdit = new TextBox
            {
                Text = shelf.Name,
                Font = new Font("Segoe UI", 11),
                Location = new Point(50, 12),
                Width = 200,
                Visible = false,
                BackColor = Color.FromArgb(60, 60, 65),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Buttons
            Button btnDelete = CreateIconButton("🗑️", 345);
            Button btnEdit = CreateIconButton("✏️", 305);
            Button btnSave = CreateIconButton("✓", 305);
            btnSave.Visible = false;
            btnSave.ForeColor = Color.FromArgb(76, 175, 80);

            // Events
            btnDelete.Click += (s, e) =>
            {
                if (MessageBox.Show($"Xóa kệ sách '{shelf.Name}'?", "Xác nhận", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DataManager.Instance.DeleteShelf(shelf.Id);
                        LoadShelves();
                    }
                    catch (Exception ex) 
                    { 
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
            };

            btnEdit.Click += (s, e) =>
            {
                lblName.Visible = false;
                txtEdit.Visible = true;
                btnEdit.Visible = false;
                btnSave.Visible = true;
                txtEdit.Focus();
                txtEdit.SelectAll();
            };

            btnSave.Click += (s, e) =>
            {
                string newName = txtEdit.Text.Trim();
                if (!string.IsNullOrEmpty(newName))
                {
                    try
                    {
                        DataManager.Instance.RenameShelf(shelf.Id, newName);
                        LoadShelves();
                    }
                    catch (Exception ex) 
                    { 
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
            };

            txtEdit.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.PerformClick();
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    lblName.Visible = true;
                    txtEdit.Visible = false;
                    btnEdit.Visible = true;
                    btnSave.Visible = false;
                }
            };

            pnl.Controls.AddRange(new Control[] { lblShelfIcon, lblName, txtEdit, btnDelete, btnEdit, btnSave });

            // Hover effect
            pnl.MouseEnter += (s, e) => pnl.BackColor = Color.FromArgb(60, 60, 65);
            pnl.MouseLeave += (s, e) => pnl.BackColor = Color.FromArgb(50, 50, 55);

            return pnl;
        }

        private Button CreateIconButton(string text, int x)
        {
            Button btn = new Button
            {
                Text = text,
                Location = new Point(x, 12),
                Size = new Size(35, 30),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(140, 140, 140),
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Emoji", 12),
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.MouseEnter += (s, e) => btn.ForeColor = Color.White;
            btn.MouseLeave += (s, e) => btn.ForeColor = Color.FromArgb(140, 140, 140);
            return btn;
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

        #region Event Handlers - Add New

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using (var dlg = new AddShelfDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataManager.Instance.AddShelf(dlg.ShelfName, dlg.ShelfDescription);
                        LoadShelves();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        #region Form Paint - Border

        private void ManageShelfDialog_Paint(object sender, PaintEventArgs e)
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

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion
    }
}
