namespace WindowsFormsApp1.Forms
{
    partial class EditBookForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitleContainer = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitleIcon = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pnlAuthorContainer = new System.Windows.Forms.Panel();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthorIcon = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pnlDescContainer = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDescIcon = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlTitleContainer.SuspendLayout();
            this.pnlAuthorContainer.SuspendLayout();
            this.pnlDescContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblHeaderIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(520, 56);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.White;
            this.lblHeaderIcon.Location = new System.Drawing.Point(15, 10);
            this.lblHeaderIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(40, 38);
            this.lblHeaderIcon.TabIndex = 2;
            this.lblHeaderIcon.Text = "✏️";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.Location = new System.Drawing.Point(474, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 56);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(58, 15);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Sửa Thông Tin Sách";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 75);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TIÊU ĐỀ SÁCH *";
            // 
            // pnlTitleContainer
            // 
            this.pnlTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlTitleContainer.Controls.Add(this.txtTitle);
            this.pnlTitleContainer.Controls.Add(this.lblTitleIcon);
            this.pnlTitleContainer.Location = new System.Drawing.Point(30, 95);
            this.pnlTitleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleContainer.Name = "pnlTitleContainer";
            this.pnlTitleContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTitleContainer.Size = new System.Drawing.Size(460, 46);
            this.pnlTitleContainer.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(45, 13);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(407, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitleIcon
            // 
            this.lblTitleIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lblTitleIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitleIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblTitleIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblTitleIcon.Location = new System.Drawing.Point(1, 1);
            this.lblTitleIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleIcon.Name = "lblTitleIcon";
            this.lblTitleIcon.Size = new System.Drawing.Size(44, 44);
            this.lblTitleIcon.TabIndex = 0;
            this.lblTitleIcon.Text = "📖";
            this.lblTitleIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblAuthor.Location = new System.Drawing.Point(30, 155);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(58, 15);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "TÁC GIẢ";
            // 
            // pnlAuthorContainer
            // 
            this.pnlAuthorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlAuthorContainer.Controls.Add(this.txtAuthor);
            this.pnlAuthorContainer.Controls.Add(this.lblAuthorIcon);
            this.pnlAuthorContainer.Location = new System.Drawing.Point(30, 175);
            this.pnlAuthorContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAuthorContainer.Name = "pnlAuthorContainer";
            this.pnlAuthorContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlAuthorContainer.Size = new System.Drawing.Size(460, 46);
            this.pnlAuthorContainer.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(45, 13);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(407, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblAuthorIcon
            // 
            this.lblAuthorIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lblAuthorIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAuthorIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblAuthorIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblAuthorIcon.Location = new System.Drawing.Point(1, 1);
            this.lblAuthorIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblAuthorIcon.Name = "lblAuthorIcon";
            this.lblAuthorIcon.Size = new System.Drawing.Size(44, 44);
            this.lblAuthorIcon.TabIndex = 0;
            this.lblAuthorIcon.Text = "✍";
            this.lblAuthorIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblDesc.Location = new System.Drawing.Point(30, 235);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(49, 15);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "MÔ TẢ";
            // 
            // pnlDescContainer
            // 
            this.pnlDescContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlDescContainer.Controls.Add(this.txtDesc);
            this.pnlDescContainer.Controls.Add(this.lblDescIcon);
            this.pnlDescContainer.Location = new System.Drawing.Point(30, 255);
            this.pnlDescContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDescContainer.Name = "pnlDescContainer";
            this.pnlDescContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlDescContainer.Size = new System.Drawing.Size(460, 110);
            this.pnlDescContainer.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(45, 1);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(414, 108);
            this.txtDesc.TabIndex = 1;
            // 
            // lblDescIcon
            // 
            this.lblDescIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lblDescIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblDescIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblDescIcon.Location = new System.Drawing.Point(1, 1);
            this.lblDescIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescIcon.Name = "lblDescIcon";
            this.lblDescIcon.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblDescIcon.Size = new System.Drawing.Size(44, 108);
            this.lblDescIcon.TabIndex = 0;
            this.lblDescIcon.Text = "📝";
            this.lblDescIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(265, 385);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 48);
            this.btnSave.TabIndex = 7;
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
            this.btnCancel.Location = new System.Drawing.Point(30, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(225, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // EditBookForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(520, 455);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlDescContainer);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pnlAuthorContainer);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.pnlTitleContainer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditBookForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa Thông Tin Sách";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditBookForm_Paint);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTitleContainer.ResumeLayout(false);
            this.pnlTitleContainer.PerformLayout();
            this.pnlAuthorContainer.ResumeLayout(false);
            this.pnlAuthorContainer.PerformLayout();
            this.pnlDescContainer.ResumeLayout(false);
            this.pnlDescContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitleContainer;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitleIcon;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Panel pnlAuthorContainer;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthorIcon;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel pnlDescContainer;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDescIcon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
