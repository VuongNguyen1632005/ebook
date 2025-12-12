namespace WindowsFormsApp1.Forms
{
    partial class ReadingGoalsForm
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
            this.btnExportReport = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.btnExportReport);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblHeaderIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.White;
            this.lblHeaderIcon.Location = new System.Drawing.Point(20, 15);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(60, 60);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "\U0001F4CA";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(85, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(290, 37);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "THONG KE DOC SACH";
            // 
            // btnExportReport
            // 
            this.btnExportReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnExportReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportReport.FlatAppearance.BorderSize = 0;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportReport.ForeColor = System.Drawing.Color.White;
            this.btnExportReport.Location = new System.Drawing.Point(720, 25);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(160, 45);
            this.btnExportReport.TabIndex = 2;
            this.btnExportReport.Text = "XUAT BAO CAO";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.BtnExportReport_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.AutoScroll = true;
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainContainer.Location = new System.Drawing.Point(0, 90);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(25);
            this.mainContainer.Size = new System.Drawing.Size(900, 710);
            this.mainContainer.TabIndex = 1;
            this.mainContainer.WrapContents = false;
            // 
            // ReadingGoalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReadingGoalsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muc tieu doc sach";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.FlowLayoutPanel mainContainer;
    }
}
