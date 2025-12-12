namespace WindowsFormsApp1.Forms
{
    partial class AddShelfDialog
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlNameContainer = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameIcon = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlDescContainer = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescIcon = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlNameContainer.SuspendLayout();
            this.pnlDescContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(480, 56);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(58, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tạo Kệ Sách Mới";
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location = new System.Drawing.Point(15, 10);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(40, 38);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "📚";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblName.Location = new System.Drawing.Point(30, 75);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "TÊN KỆ SÁCH *";
            // 
            // pnlNameContainer
            // 
            this.pnlNameContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlNameContainer.Controls.Add(this.txtName);
            this.pnlNameContainer.Controls.Add(this.lblNameIcon);
            this.pnlNameContainer.Location = new System.Drawing.Point(30, 95);
            this.pnlNameContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNameContainer.Name = "pnlNameContainer";
            this.pnlNameContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlNameContainer.Size = new System.Drawing.Size(420, 46);
            this.pnlNameContainer.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(45, 13);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(367, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblNameIcon
            // 
            this.lblNameIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.lblNameIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNameIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.lblNameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.lblNameIcon.Location = new System.Drawing.Point(1, 1);
            this.lblNameIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameIcon.Name = "lblNameIcon";
            this.lblNameIcon.Size = new System.Drawing.Size(44, 44);
            this.lblNameIcon.TabIndex = 0;
            this.lblNameIcon.Text = "📖";
            this.lblNameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblDescription.Location = new System.Drawing.Point(30, 155);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "MÔ TẢ (Tùy chọn)";
            // 
            // pnlDescContainer
            // 
            this.pnlDescContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlDescContainer.Controls.Add(this.txtDescription);
            this.pnlDescContainer.Controls.Add(this.lblDescIcon);
            this.pnlDescContainer.Location = new System.Drawing.Point(30, 175);
            this.pnlDescContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDescContainer.Name = "pnlDescContainer";
            this.pnlDescContainer.Padding = new System.Windows.Forms.Padding(1);
            this.pnlDescContainer.Size = new System.Drawing.Size(420, 80);
            this.pnlDescContainer.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(45, 1);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(374, 78);
            this.txtDescription.TabIndex = 1;
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
            this.lblDescIcon.Size = new System.Drawing.Size(44, 78);
            this.lblDescIcon.TabIndex = 0;
            this.lblDescIcon.Text = "📝";
            this.lblDescIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(245, 278);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(205, 46);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Tạo Kệ Sách";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(30, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 46);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddShelfDialog
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 345);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlDescContainer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pnlNameContainer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddShelfDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo Kệ Sách Mới";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNameContainer.ResumeLayout(false);
            this.pnlNameContainer.PerformLayout();
            this.pnlDescContainer.ResumeLayout(false);
            this.pnlDescContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlNameContainer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameIcon;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlDescContainer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescIcon;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}
