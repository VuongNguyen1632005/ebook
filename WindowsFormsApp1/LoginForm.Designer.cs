namespace WindowsFormsApp1.Forms
{
    partial class LoginForm
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
            this.titleBar = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlPassContainer = new System.Windows.Forms.Panel();
            this.pnlPassBorder = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlPassIcon = new System.Windows.Forms.Panel();
            this.lblPassIcon = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pnlUserContainer = new System.Windows.Forms.Panel();
            this.pnlUserBorder = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlUserIcon = new System.Windows.Forms.Panel();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.titleBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.pnlPassContainer.SuspendLayout();
            this.pnlPassIcon.SuspendLayout();
            this.pnlUserContainer.SuspendLayout();
            this.pnlUserIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.titleBar.Controls.Add(this.lblAppName);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(1, 1);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(478, 36);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblAppName.Location = new System.Drawing.Point(12, 10);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(82, 15);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Koodo Reader";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnClose.Location = new System.Drawing.Point(432, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.mainPanel.Controls.Add(this.pnlDivider);
            this.mainPanel.Controls.Add(this.lblForgotPassword);
            this.mainPanel.Controls.Add(this.chkRemember);
            this.mainPanel.Controls.Add(this.lblRegister);
            this.mainPanel.Controls.Add(this.btnLogin);
            this.mainPanel.Controls.Add(this.pnlPassContainer);
            this.mainPanel.Controls.Add(this.lblPass);
            this.mainPanel.Controls.Add(this.pnlUserContainer);
            this.mainPanel.Controls.Add(this.lblUser);
            this.mainPanel.Controls.Add(this.lblSubtitle);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.lblIcon);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(1, 37);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(50, 20, 50, 30);
            this.mainPanel.Size = new System.Drawing.Size(478, 562);
            this.mainPanel.TabIndex = 1;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.pnlDivider.Location = new System.Drawing.Point(50, 478);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(378, 1);
            this.pnlDivider.TabIndex = 11;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(295, 372);
            this.lblForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(100, 15);
            this.lblForgotPassword.TabIndex = 8;
            this.lblForgotPassword.Text = "Quen mat khau?";
            this.lblForgotPassword.Click += new System.EventHandler(this.LblForgotPassword_Click);
            this.lblForgotPassword.MouseEnter += new System.EventHandler(this.LblForgotPassword_MouseEnter);
            this.lblForgotPassword.MouseLeave += new System.EventHandler(this.LblForgotPassword_MouseLeave);
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.chkRemember.Location = new System.Drawing.Point(50, 371);
            this.chkRemember.Margin = new System.Windows.Forms.Padding(4);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(91, 19);
            this.chkRemember.TabIndex = 7;
            this.chkRemember.Text = "Ghi nho toi";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // lblRegister
            // 
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblRegister.Location = new System.Drawing.Point(50, 498);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(378, 28);
            this.lblRegister.TabIndex = 10;
            this.lblRegister.Text = "Chua co tai khoan? Dang ky ngay";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegister.Click += new System.EventHandler(this.LblRegister_Click);
            this.lblRegister.MouseEnter += new System.EventHandler(this.LblRegister_MouseEnter);
            this.lblRegister.MouseLeave += new System.EventHandler(this.LblRegister_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 408);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(378, 52);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            // 
            // pnlPassContainer
            // 
            this.pnlPassContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlPassContainer.Controls.Add(this.txtPass);
            this.pnlPassContainer.Controls.Add(this.pnlPassIcon);
            this.pnlPassContainer.Location = new System.Drawing.Point(50, 310);
            this.pnlPassContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPassContainer.Name = "pnlPassContainer";
            this.pnlPassContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPassContainer.Size = new System.Drawing.Size(378, 48);
            this.pnlPassContainer.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(49, 14);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(320, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // pnlPassIcon
            // 
            this.pnlPassIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlPassIcon.Controls.Add(this.lblPassIcon);
            this.pnlPassIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPassIcon.Location = new System.Drawing.Point(1, 1);
            this.pnlPassIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPassIcon.Name = "pnlPassIcon";
            this.pnlPassIcon.Size = new System.Drawing.Size(48, 46);
            this.pnlPassIcon.TabIndex = 0;
            // 
            // lblPassIcon
            // 
            this.lblPassIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblPassIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblPassIcon.Location = new System.Drawing.Point(0, 0);
            this.lblPassIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassIcon.Name = "lblPassIcon";
            this.lblPassIcon.Size = new System.Drawing.Size(48, 46);
            this.lblPassIcon.TabIndex = 0;
            this.lblPassIcon.Text = "🔒";
            this.lblPassIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblPass.Location = new System.Drawing.Point(50, 288);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 15);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "MẬT KHẨU";
            // 
            // pnlUserContainer
            // 
            this.pnlUserContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlUserContainer.Controls.Add(this.txtUser);
            this.pnlUserContainer.Controls.Add(this.pnlUserIcon);
            this.pnlUserContainer.Location = new System.Drawing.Point(50, 228);
            this.pnlUserContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserContainer.Name = "pnlUserContainer";
            this.pnlUserContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlUserContainer.Size = new System.Drawing.Size(378, 48);
            this.pnlUserContainer.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(49, 14);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(320, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // pnlUserIcon
            // 
            this.pnlUserIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlUserIcon.Controls.Add(this.lblUserIcon);
            this.pnlUserIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserIcon.Location = new System.Drawing.Point(1, 1);
            this.pnlUserIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserIcon.Name = "pnlUserIcon";
            this.pnlUserIcon.Size = new System.Drawing.Size(48, 46);
            this.pnlUserIcon.TabIndex = 0;
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblUserIcon.Location = new System.Drawing.Point(0, 0);
            this.lblUserIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(48, 46);
            this.lblUserIcon.TabIndex = 0;
            this.lblUserIcon.Text = "👤";
            this.lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblUser.Location = new System.Drawing.Point(50, 206);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(99, 15);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "TÊN ĐĂNG NHẬP";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(50, 158);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(378, 28);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Đăng nhập để tiếp tục đọc sách";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 110);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Chào mừng trở lại!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 42F);
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblIcon.Location = new System.Drawing.Point(50, 20);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(378, 90);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "📚";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(480, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titleBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koodo Reader - Đăng Nhập";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.pnlPassContainer.ResumeLayout(false);
            this.pnlPassContainer.PerformLayout();
            this.pnlPassIcon.ResumeLayout(false);
            this.pnlUserContainer.ResumeLayout(false);
            this.pnlUserContainer.PerformLayout();
            this.pnlUserIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlUserContainer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pnlUserIcon;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Panel pnlPassContainer;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlPassIcon;
        private System.Windows.Forms.Label lblPassIcon;
        private System.Windows.Forms.Panel pnlPassBorder;
        private System.Windows.Forms.Panel pnlUserBorder;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Panel pnlDivider;
    }
}
