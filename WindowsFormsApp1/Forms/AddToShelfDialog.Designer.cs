namespace WindowsFormsApp1.Forms
{
    partial class AddToShelfDialog
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.pnlSelectContainer = new System.Windows.Forms.Panel();
            this.cmbShelves = new System.Windows.Forms.ComboBox();
            this.lblSelectIcon = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.pnlNewContainer = new System.Windows.Forms.Panel();
            this.txtNewShelf = new System.Windows.Forms.TextBox();
            this.lblNewIcon = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlSelectContainer.SuspendLayout();
            this.pnlNewContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(560, 62);
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
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(507, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 62);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(73, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Them vao Ke Sach";
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblIcon.Location = new System.Drawing.Point(16, 10);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(53, 43);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "📚";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSelect.Location = new System.Drawing.Point(27, 80);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(133, 20);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "CHON KE CO SAN";
            // 
            // pnlSelectContainer
            // 
            this.pnlSelectContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.pnlSelectContainer.Controls.Add(this.cmbShelves);
            this.pnlSelectContainer.Controls.Add(this.lblSelectIcon);
            this.pnlSelectContainer.Location = new System.Drawing.Point(27, 105);
            this.pnlSelectContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSelectContainer.Name = "pnlSelectContainer";
            this.pnlSelectContainer.Size = new System.Drawing.Size(507, 34);
            this.pnlSelectContainer.TabIndex = 2;
            // 
            // cmbShelves
            // 
            this.cmbShelves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.cmbShelves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbShelves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShelves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbShelves.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbShelves.ForeColor = System.Drawing.Color.White;
            this.cmbShelves.FormattingEnabled = true;
            this.cmbShelves.Location = new System.Drawing.Point(53, 0);
            this.cmbShelves.Margin = new System.Windows.Forms.Padding(4);
            this.cmbShelves.Name = "cmbShelves";
            this.cmbShelves.Size = new System.Drawing.Size(454, 33);
            this.cmbShelves.TabIndex = 1;
            // 
            // lblSelectIcon
            // 
            this.lblSelectIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.lblSelectIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSelectIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblSelectIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblSelectIcon.Location = new System.Drawing.Point(0, 0);
            this.lblSelectIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectIcon.Name = "lblSelectIcon";
            this.lblSelectIcon.Size = new System.Drawing.Size(53, 34);
            this.lblSelectIcon.TabIndex = 0;
            this.lblSelectIcon.Text = "📖";
            this.lblSelectIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivider
            // 
            this.lblDivider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDivider.ForeColor = System.Drawing.Color.Gray;
            this.lblDivider.Location = new System.Drawing.Point(27, 166);
            this.lblDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(507, 25);
            this.lblDivider.TabIndex = 3;
            this.lblDivider.Text = "------------------------ HOAC TAO MOI ------------------------";
            this.lblDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblNew.Location = new System.Drawing.Point(27, 203);
            this.lblNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(137, 20);
            this.lblNew.TabIndex = 4;
            this.lblNew.Text = "TEN KE SACH MOI";
            // 
            // pnlNewContainer
            // 
            this.pnlNewContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.pnlNewContainer.Controls.Add(this.txtNewShelf);
            this.pnlNewContainer.Controls.Add(this.lblNewIcon);
            this.pnlNewContainer.Location = new System.Drawing.Point(27, 228);
            this.pnlNewContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNewContainer.Name = "pnlNewContainer";
            this.pnlNewContainer.Size = new System.Drawing.Size(507, 35);
            this.pnlNewContainer.TabIndex = 5;
            // 
            // txtNewShelf
            // 
            this.txtNewShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.txtNewShelf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewShelf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewShelf.ForeColor = System.Drawing.Color.White;
            this.txtNewShelf.Location = new System.Drawing.Point(53, 0);
            this.txtNewShelf.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewShelf.Name = "txtNewShelf";
            this.txtNewShelf.Size = new System.Drawing.Size(454, 27);
            this.txtNewShelf.TabIndex = 1;
            this.txtNewShelf.TextChanged += new System.EventHandler(this.txtNewShelf_TextChanged);
            // 
            // lblNewIcon
            // 
            this.lblNewIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.lblNewIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNewIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblNewIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblNewIcon.Location = new System.Drawing.Point(0, 0);
            this.lblNewIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewIcon.Name = "lblNewIcon";
            this.lblNewIcon.Size = new System.Drawing.Size(53, 35);
            this.lblNewIcon.TabIndex = 0;
            this.lblNewIcon.Text = "➕";
            this.lblNewIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(293, 302);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(240, 52);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Xac Nhan";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(27, 302);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 52);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Huy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddToShelfDialog
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(560, 375);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlNewContainer);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.pnlSelectContainer);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddToShelfDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Them vao Ke Sach";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddToShelfDialog_Paint);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSelectContainer.ResumeLayout(false);
            this.pnlNewContainer.ResumeLayout(false);
            this.pnlNewContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Panel pnlSelectContainer;
        private System.Windows.Forms.ComboBox cmbShelves;
        private System.Windows.Forms.Label lblSelectIcon;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Panel pnlNewContainer;
        private System.Windows.Forms.TextBox txtNewShelf;
        private System.Windows.Forms.Label lblNewIcon;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}