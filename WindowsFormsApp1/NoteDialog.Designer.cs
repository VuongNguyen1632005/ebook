namespace WindowsFormsApp1.Forms
{
    partial class NoteDialog
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.pnlNoteContainer = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlNoteContainer.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(420, 52);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location = new System.Drawing.Point(12, 10);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(36, 32);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "📝";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(52, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Thêm Ghi Chú";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblPrompt.Location = new System.Drawing.Point(25, 68);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(152, 17);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Nhập suy nghĩ của bạn:";
            // 
            // pnlNoteContainer
            // 
            this.pnlNoteContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.pnlNoteContainer.Controls.Add(this.txtNote);
            this.pnlNoteContainer.Location = new System.Drawing.Point(25, 92);
            this.pnlNoteContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNoteContainer.Name = "pnlNoteContainer";
            this.pnlNoteContainer.Padding = new System.Windows.Forms.Padding(8);
            this.pnlNoteContainer.Size = new System.Drawing.Size(370, 110);
            this.pnlNoteContainer.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNote.ForeColor = System.Drawing.Color.White;
            this.txtNote.Location = new System.Drawing.Point(8, 8);
            this.txtNote.Margin = new System.Windows.Forms.Padding(0);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(354, 94);
            this.txtNote.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(215, 220);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu Ghi Chú";
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
            this.btnCancel.Location = new System.Drawing.Point(25, 220);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // NoteDialog
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(420, 285);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlNoteContainer);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Ghi Chú";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNoteContainer.ResumeLayout(false);
            this.pnlNoteContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Panel pnlNoteContainer;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}