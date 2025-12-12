namespace WindowsFormsApp1.Forms
{
    partial class PasswordPromptForm
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
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pnlPasswordContainer = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPasswordIcon = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSecurityIcon = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlPasswordContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblHeaderIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(448, 48);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblHeaderIcon.Location = new System.Drawing.Point(12, 8);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(32, 32);
            this.lblHeaderIcon.TabIndex = 2;
            this.lblHeaderIcon.Text = "🔐";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.Location = new System.Drawing.Point(402, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(48, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Xác thực bảo mật";
            // 
            // lblSecurityIcon
            // 
            this.lblSecurityIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 42F);
            this.lblSecurityIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblSecurityIcon.Location = new System.Drawing.Point(150, 60);
            this.lblSecurityIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecurityIcon.Name = "lblSecurityIcon";
            this.lblSecurityIcon.Size = new System.Drawing.Size(150, 85);
            this.lblSecurityIcon.TabIndex = 1;
            this.lblSecurityIcon.Text = "🛡️";
            this.lblSecurityIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblInstruction.Location = new System.Drawing.Point(30, 150);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(390, 40);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Để bảo vệ tài khoản, vui lòng nhập mật khẩu hiện tại của bạn để tiếp tục.";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPasswordContainer
            // 
            this.pnlPasswordContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pnlPasswordContainer.Controls.Add(this.txtPass);
            this.pnlPasswordContainer.Controls.Add(this.lblPasswordIcon);
            this.pnlPasswordContainer.Location = new System.Drawing.Point(30, 200);
            this.pnlPasswordContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPasswordContainer.Name = "pnlPasswordContainer";
            this.pnlPasswordContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPasswordContainer.Size = new System.Drawing.Size(390, 46);
            this.pnlPasswordContainer.TabIndex = 3;
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
            this.txtPass.Size = new System.Drawing.Size(337, 20);
            this.txtPass.TabIndex = 1;
            // 
            // lblPasswordIcon
            // 
            this.lblPasswordIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.lblPasswordIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPasswordIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblPasswordIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblPasswordIcon.Location = new System.Drawing.Point(1, 1);
            this.lblPasswordIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordIcon.Name = "lblPasswordIcon";
            this.lblPasswordIcon.Size = new System.Drawing.Size(44, 44);
            this.lblPasswordIcon.TabIndex = 0;
            this.lblPasswordIcon.Text = "🔑";
            this.lblPasswordIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(230, 265);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(190, 44);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Xác Nhận";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            this.btnOK.MouseEnter += new System.EventHandler(this.BtnOK_MouseEnter);
            this.btnOK.MouseLeave += new System.EventHandler(this.BtnOK_MouseLeave);
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
            this.btnCancel.Location = new System.Drawing.Point(30, 265);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 44);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy Bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.BtnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.BtnCancel_MouseLeave);
            // 
            // PasswordPromptForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlPasswordContainer);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblSecurityIcon);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PasswordPromptForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xác thực bảo mật";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PasswordPromptForm_Paint);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlPasswordContainer.ResumeLayout(false);
            this.pnlPasswordContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblSecurityIcon;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Panel pnlPasswordContainer;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPasswordIcon;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
