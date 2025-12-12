namespace WindowsFormsApp1.Forms
{
    partial class RegisterForm
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlConfirmContainer = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirmIcon = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.pnlPassContainer = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPassIcon = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pnlEmailContainer = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailIcon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlNameContainer = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameIcon = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlUserContainer = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.titleBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.pnlConfirmContainer.SuspendLayout();
            this.pnlPassContainer.SuspendLayout();
            this.pnlEmailContainer.SuspendLayout();
            this.pnlNameContainer.SuspendLayout();
            this.pnlUserContainer.SuspendLayout();
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
            this.mainPanel.Controls.Add(this.lblLogin);
            this.mainPanel.Controls.Add(this.pnlDivider);
            this.mainPanel.Controls.Add(this.btnRegister);
            this.mainPanel.Controls.Add(this.pnlConfirmContainer);
            this.mainPanel.Controls.Add(this.lblConfirm);
            this.mainPanel.Controls.Add(this.pnlPassContainer);
            this.mainPanel.Controls.Add(this.lblPass);
            this.mainPanel.Controls.Add(this.pnlEmailContainer);
            this.mainPanel.Controls.Add(this.lblEmail);
            this.mainPanel.Controls.Add(this.pnlNameContainer);
            this.mainPanel.Controls.Add(this.lblName);
            this.mainPanel.Controls.Add(this.pnlUserContainer);
            this.mainPanel.Controls.Add(this.lblUser);
            this.mainPanel.Controls.Add(this.lblSubtitle);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.lblIcon);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(1, 37);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(50, 15, 50, 25);
            this.mainPanel.Size = new System.Drawing.Size(478, 712);
            this.mainPanel.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblLogin.Location = new System.Drawing.Point(50, 660);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(378, 28);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Đã có tài khoản? Đăng nhập ngay";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.LblLogin_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.LblLogin_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.LblLogin_MouseLeave);
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.pnlDivider.Location = new System.Drawing.Point(50, 640);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(378, 1);
            this.pnlDivider.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(50, 572);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(378, 52);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "ĐĂNG KÝ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.btnRegister.MouseEnter += new System.EventHandler(this.BtnRegister_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.BtnRegister_MouseLeave);
            // 
            // pnlConfirmContainer
            // 
            this.pnlConfirmContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlConfirmContainer.Controls.Add(this.txtConfirm);
            this.pnlConfirmContainer.Controls.Add(this.lblConfirmIcon);
            this.pnlConfirmContainer.Location = new System.Drawing.Point(50, 510);
            this.pnlConfirmContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlConfirmContainer.Name = "pnlConfirmContainer";
            this.pnlConfirmContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlConfirmContainer.Size = new System.Drawing.Size(378, 46);
            this.pnlConfirmContainer.TabIndex = 12;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirm.ForeColor = System.Drawing.Color.White;
            this.txtConfirm.Location = new System.Drawing.Point(45, 13);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '●';
            this.txtConfirm.Size = new System.Drawing.Size(325, 20);
            this.txtConfirm.TabIndex = 1;
            // 
            // lblConfirmIcon
            // 
            this.lblConfirmIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.lblConfirmIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblConfirmIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblConfirmIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblConfirmIcon.Location = new System.Drawing.Point(1, 1);
            this.lblConfirmIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmIcon.Name = "lblConfirmIcon";
            this.lblConfirmIcon.Size = new System.Drawing.Size(44, 44);
            this.lblConfirmIcon.TabIndex = 0;
            this.lblConfirmIcon.Text = "✔";
            this.lblConfirmIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblConfirm.Location = new System.Drawing.Point(50, 490);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(143, 15);
            this.lblConfirm.TabIndex = 11;
            this.lblConfirm.Text = "XÁC NHẬN MẬT KHẨU *";
            // 
            // pnlPassContainer
            // 
            this.pnlPassContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlPassContainer.Controls.Add(this.txtPass);
            this.pnlPassContainer.Controls.Add(this.lblPassIcon);
            this.pnlPassContainer.Location = new System.Drawing.Point(50, 434);
            this.pnlPassContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPassContainer.Name = "pnlPassContainer";
            this.pnlPassContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPassContainer.Size = new System.Drawing.Size(378, 46);
            this.pnlPassContainer.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(45, 13);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(325, 20);
            this.txtPass.TabIndex = 1;
            // 
            // lblPassIcon
            // 
            this.lblPassIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.lblPassIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPassIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblPassIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblPassIcon.Location = new System.Drawing.Point(1, 1);
            this.lblPassIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassIcon.Name = "lblPassIcon";
            this.lblPassIcon.Size = new System.Drawing.Size(44, 44);
            this.lblPassIcon.TabIndex = 0;
            this.lblPassIcon.Text = "🔒";
            this.lblPassIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblPass.Location = new System.Drawing.Point(50, 414);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(79, 15);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "MẬT KHẨU *";
            // 
            // pnlEmailContainer
            // 
            this.pnlEmailContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlEmailContainer.Controls.Add(this.txtEmail);
            this.pnlEmailContainer.Controls.Add(this.lblEmailIcon);
            this.pnlEmailContainer.Location = new System.Drawing.Point(50, 358);
            this.pnlEmailContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmailContainer.Name = "pnlEmailContainer";
            this.pnlEmailContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlEmailContainer.Size = new System.Drawing.Size(378, 46);
            this.pnlEmailContainer.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(45, 13);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmailIcon
            // 
            this.lblEmailIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.lblEmailIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmailIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblEmailIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblEmailIcon.Location = new System.Drawing.Point(1, 1);
            this.lblEmailIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailIcon.Name = "lblEmailIcon";
            this.lblEmailIcon.Size = new System.Drawing.Size(44, 44);
            this.lblEmailIcon.TabIndex = 0;
            this.lblEmailIcon.Text = "📧";
            this.lblEmailIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblEmail.Location = new System.Drawing.Point(50, 338);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "EMAIL";
            // 
            // pnlNameContainer
            // 
            this.pnlNameContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlNameContainer.Controls.Add(this.txtName);
            this.pnlNameContainer.Controls.Add(this.lblNameIcon);
            this.pnlNameContainer.Location = new System.Drawing.Point(50, 282);
            this.pnlNameContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNameContainer.Name = "pnlNameContainer";
            this.pnlNameContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlNameContainer.Size = new System.Drawing.Size(378, 46);
            this.pnlNameContainer.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(45, 13);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(325, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblNameIcon
            // 
            this.lblNameIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.lblNameIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNameIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblNameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblNameIcon.Location = new System.Drawing.Point(1, 1);
            this.lblNameIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameIcon.Name = "lblNameIcon";
            this.lblNameIcon.Size = new System.Drawing.Size(44, 44);
            this.lblNameIcon.TabIndex = 0;
            this.lblNameIcon.Text = "🏷";
            this.lblNameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblName.Location = new System.Drawing.Point(50, 262);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "TÊN HIỂN THỊ";
            // 
            // pnlUserContainer
            // 
            this.pnlUserContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlUserContainer.Controls.Add(this.txtUser);
            this.pnlUserContainer.Controls.Add(this.lblUserIcon);
            this.pnlUserContainer.Location = new System.Drawing.Point(50, 206);
            this.pnlUserContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserContainer.Name = "pnlUserContainer";
            this.pnlUserContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlUserContainer.Size = new System.Drawing.Size(378, 46);
            this.pnlUserContainer.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(45, 13);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(325, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.lblUserIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUserIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblUserIcon.Location = new System.Drawing.Point(1, 1);
            this.lblUserIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(44, 44);
            this.lblUserIcon.TabIndex = 0;
            this.lblUserIcon.Text = "👤";
            this.lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblUser.Location = new System.Drawing.Point(50, 186);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(112, 15);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "TÊN ĐĂNG NHẬP *";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(50, 138);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(378, 28);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Điền thông tin để tạo tài khoản";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 95);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(378, 43);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tạo Tài Khoản Mới";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 36F);
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblIcon.Location = new System.Drawing.Point(50, 15);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(378, 80);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "📝";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(480, 750);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titleBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koodo Reader - Đăng Ký";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RegisterForm_Paint);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.pnlConfirmContainer.ResumeLayout(false);
            this.pnlConfirmContainer.PerformLayout();
            this.pnlPassContainer.ResumeLayout(false);
            this.pnlPassContainer.PerformLayout();
            this.pnlEmailContainer.ResumeLayout(false);
            this.pnlEmailContainer.PerformLayout();
            this.pnlNameContainer.ResumeLayout(false);
            this.pnlNameContainer.PerformLayout();
            this.pnlUserContainer.ResumeLayout(false);
            this.pnlUserContainer.PerformLayout();
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
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlNameContainer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameIcon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlEmailContainer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailIcon;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Panel pnlPassContainer;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassIcon;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Panel pnlConfirmContainer;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirmIcon;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlDivider;
    }
}
