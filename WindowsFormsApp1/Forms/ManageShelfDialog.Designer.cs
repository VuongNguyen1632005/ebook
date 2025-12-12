namespace WindowsFormsApp1.Forms
{
    partial class ManageShelfDialog
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
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlList.SuspendLayout();
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
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(420, 55);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location = new System.Drawing.Point(12, 10);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(40, 35);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "\U0001F4DA";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(55, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quan Ly Ke Sach";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(380, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 55);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlList.Controls.Add(this.lblEmpty);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlList.Location = new System.Drawing.Point(0, 55);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlList.Size = new System.Drawing.Size(420, 395);
            this.pnlList.TabIndex = 1;
            this.pnlList.WrapContents = false;
            // 
            // lblEmpty
            // 
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmpty.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpty.Location = new System.Drawing.Point(18, 10);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(380, 50);
            this.lblEmpty.TabIndex = 0;
            this.lblEmpty.Text = "Chua co ke sach nao. Hay tao ke sach moi!";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpty.Visible = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(0, 450);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(420, 50);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "+ Tao Ke Sach Moi";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // ManageShelfDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(420, 500);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageShelfDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quan Ly Ke Sach";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ManageShelfDialog_Paint);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.FlowLayoutPanel pnlList;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Button btnAddNew;
    }
}
