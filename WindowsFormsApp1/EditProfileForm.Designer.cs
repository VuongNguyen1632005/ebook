namespace WindowsFormsApp1.Forms
{
    partial class EditProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlUsernameContainer = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameIcon = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.pnlDisplayContainer = new System.Windows.Forms.Panel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblDisplayIcon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlEmailContainer = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailIcon = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.pnlPassContainer = new System.Windows.Forms.Panel();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblPassIcon = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlUsernameContainer.SuspendLayout();
            this.pnlDisplayContainer.SuspendLayout();
            this.pnlEmailContainer.SuspendLayout();
            this.pnlPassContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(640, 69);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(579, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 69);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(77, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hồ Sơ Người Dùng";
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location = new System.Drawing.Point(20, 12);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(53, 47);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "👤";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblUsername.Location = new System.Drawing.Point(40, 92);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(130, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "TÊN ĐĂNG NHẬP";
            // 
            // pnlUsernameContainer
            // 
            this.pnlUsernameContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.pnlUsernameContainer.Controls.Add(this.txtUsername);
            this.pnlUsernameContainer.Controls.Add(this.lblUsernameIcon);
            this.pnlUsernameContainer.Location = new System.Drawing.Point(40, 117);
            this.pnlUsernameContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUsernameContainer.Name = "pnlUsernameContainer";
            this.pnlUsernameContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlUsernameContainer.Size = new System.Drawing.Size(560, 54);
            this.pnlUsernameContainer.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtUsername.Location = new System.Drawing.Point(57, 15);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(495, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsernameIcon
            // 
            this.lblUsernameIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.lblUsernameIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUsernameIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblUsernameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblUsernameIcon.Location = new System.Drawing.Point(1, 1);
            this.lblUsernameIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsernameIcon.Name = "lblUsernameIcon";
            this.lblUsernameIcon.Size = new System.Drawing.Size(56, 52);
            this.lblUsernameIcon.TabIndex = 0;
            this.lblUsernameIcon.Text = "🔒";
            this.lblUsernameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblDisplayName.Location = new System.Drawing.Point(40, 187);
            this.lblDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(103, 20);
            this.lblDisplayName.TabIndex = 3;
            this.lblDisplayName.Text = "TÊN HIỂN THỊ";
            // 
            // pnlDisplayContainer
            // 
            this.pnlDisplayContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlDisplayContainer.Controls.Add(this.txtDisplay);
            this.pnlDisplayContainer.Controls.Add(this.lblDisplayIcon);
            this.pnlDisplayContainer.Location = new System.Drawing.Point(40, 212);
            this.pnlDisplayContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisplayContainer.Name = "pnlDisplayContainer";
            this.pnlDisplayContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlDisplayContainer.Size = new System.Drawing.Size(560, 54);
            this.pnlDisplayContainer.TabIndex = 4;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDisplay.ForeColor = System.Drawing.Color.White;
            this.txtDisplay.Location = new System.Drawing.Point(57, 15);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(495, 25);
            this.txtDisplay.TabIndex = 1;
            // 
            // lblDisplayIcon
            // 
            this.lblDisplayIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lblDisplayIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDisplayIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblDisplayIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblDisplayIcon.Location = new System.Drawing.Point(1, 1);
            this.lblDisplayIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblDisplayIcon.Name = "lblDisplayIcon";
            this.lblDisplayIcon.Size = new System.Drawing.Size(56, 52);
            this.lblDisplayIcon.TabIndex = 0;
            this.lblDisplayIcon.Text = "🏷";
            this.lblDisplayIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblEmail.Location = new System.Drawing.Point(40, 283);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "EMAIL LIÊN HỆ";
            // 
            // pnlEmailContainer
            // 
            this.pnlEmailContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlEmailContainer.Controls.Add(this.txtEmail);
            this.pnlEmailContainer.Controls.Add(this.lblEmailIcon);
            this.pnlEmailContainer.Location = new System.Drawing.Point(40, 308);
            this.pnlEmailContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEmailContainer.Name = "pnlEmailContainer";
            this.pnlEmailContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlEmailContainer.Size = new System.Drawing.Size(560, 54);
            this.pnlEmailContainer.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(57, 15);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(495, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmailIcon
            // 
            this.lblEmailIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lblEmailIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmailIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblEmailIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblEmailIcon.Location = new System.Drawing.Point(1, 1);
            this.lblEmailIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmailIcon.Name = "lblEmailIcon";
            this.lblEmailIcon.Size = new System.Drawing.Size(56, 52);
            this.lblEmailIcon.TabIndex = 0;
            this.lblEmailIcon.Text = "📧";
            this.lblEmailIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.pnlSeparator.Location = new System.Drawing.Point(40, 388);
            this.pnlSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(560, 1);
            this.pnlSeparator.TabIndex = 7;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblNewPass.Location = new System.Drawing.Point(40, 409);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(298, 20);
            this.lblNewPass.TabIndex = 8;
            this.lblNewPass.Text = "MẬT KHẨU MỚI (Bỏ trống nếu không đổi)";
            // 
            // pnlPassContainer
            // 
            this.pnlPassContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlPassContainer.Controls.Add(this.txtNewPass);
            this.pnlPassContainer.Controls.Add(this.lblPassIcon);
            this.pnlPassContainer.Location = new System.Drawing.Point(40, 433);
            this.pnlPassContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPassContainer.Name = "pnlPassContainer";
            this.pnlPassContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPassContainer.Size = new System.Drawing.Size(560, 54);
            this.pnlPassContainer.TabIndex = 9;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPass.ForeColor = System.Drawing.Color.White;
            this.txtNewPass.Location = new System.Drawing.Point(57, 15);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.Size = new System.Drawing.Size(495, 25);
            this.txtNewPass.TabIndex = 1;
            // 
            // lblPassIcon
            // 
            this.lblPassIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lblPassIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPassIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblPassIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblPassIcon.Location = new System.Drawing.Point(1, 1);
            this.lblPassIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassIcon.Name = "lblPassIcon";
            this.lblPassIcon.Size = new System.Drawing.Size(56, 52);
            this.lblPassIcon.TabIndex = 0;
            this.lblPassIcon.Text = "🔑";
            this.lblPassIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(327, 514);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(273, 57);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "LƯU THAY ĐỔI";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(40, 514);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(273, 57);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // EditProfileForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(640, 597);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlPassContainer);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlEmailContainer);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pnlDisplayContainer);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.pnlUsernameContainer);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditProfileForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hồ Sơ Người Dùng";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditProfileForm_Paint);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlUsernameContainer.ResumeLayout(false);
            this.pnlUsernameContainer.PerformLayout();
            this.pnlDisplayContainer.ResumeLayout(false);
            this.pnlDisplayContainer.PerformLayout();
            this.pnlEmailContainer.ResumeLayout(false);
            this.pnlEmailContainer.PerformLayout();
            this.pnlPassContainer.ResumeLayout(false);
            this.pnlPassContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUsernameContainer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsernameIcon;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Panel pnlDisplayContainer;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblDisplayIcon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlEmailContainer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailIcon;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Panel pnlPassContainer;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblPassIcon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
