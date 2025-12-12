namespace WindowsFormsApp1
{
    partial class MainForm
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
            if (disposing && searchDebounceTimer != null)
            {
                searchDebounceTimer.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.topBar = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Button();
            this.btnAddBook = new WindowsFormsApp1.ModernButton();
            this.sortButton = new WindowsFormsApp1.ModernButton();
            this.btnReport = new WindowsFormsApp1.ModernButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchIcon = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.pnlShelfContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShelfToggle = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.booksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.cmbFilterBook = new System.Windows.Forms.ComboBox();
            this.lblFilterBook = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.authMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemImport = new System.Windows.Forms.ToolStripMenuItem();
            this.itemScan = new System.Windows.Forms.ToolStripMenuItem();
            this.sortMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemSortDate = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSortBookName = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSortAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSortProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemAscending = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDescending = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDebounceTimer = new System.Windows.Forms.Timer(this.components);
            this.topBar.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.pnlFilterBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.importMenu.SuspendLayout();
            this.sortMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.topBar.Controls.Add(this.lblUsername);
            this.topBar.Controls.Add(this.userButton);
            this.topBar.Controls.Add(this.btnAddBook);
            this.topBar.Controls.Add(this.sortButton);
            this.topBar.Controls.Add(this.btnReport);
            this.topBar.Controls.Add(this.searchPanel);
            this.topBar.Controls.Add(this.logoLabel);
            this.topBar.Controls.Add(this.menuButton);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Padding = new System.Windows.Forms.Padding(10);
            this.topBar.Size = new System.Drawing.Size(1264, 70);
            this.topBar.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(1140, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 19);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Visible = false;
            // 
            // userButton
            // 
            this.userButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Location = new System.Drawing.Point(1205, 12);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(46, 46);
            this.userButton.TabIndex = 6;
            this.userButton.Text = "👤";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnAddBook.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddBook.BorderRadius = 20;
            this.btnAddBook.BorderSize = 0;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnAddBook.Location = new System.Drawing.Point(1004, 15);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 40);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "➕ Thêm sách";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.Transparent;
            this.sortButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sortButton.BorderRadius = 20;
            this.sortButton.BorderSize = 1;
            this.sortButton.FlatAppearance.BorderSize = 0;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.sortButton.ForeColor = System.Drawing.Color.White;
            this.sortButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.sortButton.Location = new System.Drawing.Point(670, 15);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(110, 40);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "⇅ Sắp xếp";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Visible = false;
            this.sortButton.Click += new System.EventHandler(this.SortButton_ClickShowMenu);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Teal;
            this.btnReport.BorderColor = System.Drawing.Color.Transparent;
            this.btnReport.BorderRadius = 20;
            this.btnReport.BorderSize = 0;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReport.Location = new System.Drawing.Point(550, 15);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(110, 40);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "🖨 Báo cáo";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_ClickHandler);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchPanel.Location = new System.Drawing.Point(200, 15);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(320, 40);
            this.searchPanel.TabIndex = 2;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchPanel_Paint);
            this.searchPanel.Click += new System.EventHandler(this.SearchPanel_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.searchBox.Location = new System.Drawing.Point(45, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(260, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Tìm kiếm sách, tác giả...";
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.searchBox.GotFocus += new System.EventHandler(this.SearchBox_GotFocus);
            this.searchBox.LostFocus += new System.EventHandler(this.SearchBox_LostFocus);
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.Transparent;
            this.searchIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.searchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.searchIcon.Location = new System.Drawing.Point(10, 8);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(30, 30);
            this.searchIcon.TabIndex = 0;
            this.searchIcon.Text = "🔍";
            this.searchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchIcon.Click += new System.EventHandler(this.SearchIcon_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(60, 18);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(86, 32);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "koodo";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.menuButton.Location = new System.Drawing.Point(15, 20);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(40, 30);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "☰";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.sidebarPanel.Controls.Add(this.pnlShelfContainer);
            this.sidebarPanel.Controls.Add(this.btnShelfToggle);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 70);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.sidebarPanel.Size = new System.Drawing.Size(250, 668);
            this.sidebarPanel.TabIndex = 1;
            // 
            // pnlShelfContainer
            // 
            this.pnlShelfContainer.AutoScroll = true;
            this.pnlShelfContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlShelfContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlShelfContainer.Location = new System.Drawing.Point(0, 345);
            this.pnlShelfContainer.Name = "pnlShelfContainer";
            this.pnlShelfContainer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlShelfContainer.Size = new System.Drawing.Size(250, 300);
            this.pnlShelfContainer.TabIndex = 1;
            this.pnlShelfContainer.WrapContents = false;
            // 
            // btnShelfToggle
            // 
            this.btnShelfToggle.BackColor = System.Drawing.Color.Transparent;
            this.btnShelfToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShelfToggle.FlatAppearance.BorderSize = 0;
            this.btnShelfToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.btnShelfToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShelfToggle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnShelfToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.btnShelfToggle.Location = new System.Drawing.Point(10, 295);
            this.btnShelfToggle.Name = "btnShelfToggle";
            this.btnShelfToggle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnShelfToggle.Size = new System.Drawing.Size(230, 45);
            this.btnShelfToggle.TabIndex = 0;
            this.btnShelfToggle.Tag = "Kệ sách";
            this.btnShelfToggle.Text = "📚  Kệ sách";
            this.btnShelfToggle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShelfToggle.UseVisualStyleBackColor = false;
            this.btnShelfToggle.Click += new System.EventHandler(this.BtnShelfToggle_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.contentPanel.Controls.Add(this.booksPanel);
            this.contentPanel.Controls.Add(this.pnlFilterBar);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(250, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1014, 668);
            this.contentPanel.TabIndex = 2;
            // 
            // booksPanel
            // 
            this.booksPanel.AutoScroll = true;
            this.booksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.booksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksPanel.Location = new System.Drawing.Point(0, 50);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Padding = new System.Windows.Forms.Padding(30);
            this.booksPanel.Size = new System.Drawing.Size(1014, 618);
            this.booksPanel.TabIndex = 1;
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.pnlFilterBar.Controls.Add(this.cmbFilterBook);
            this.pnlFilterBar.Controls.Add(this.lblFilterBook);
            this.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBar.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(1014, 50);
            this.pnlFilterBar.TabIndex = 0;
            this.pnlFilterBar.Visible = false;
            // 
            // cmbFilterBook
            // 
            this.cmbFilterBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.cmbFilterBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterBook.ForeColor = System.Drawing.Color.White;
            this.cmbFilterBook.FormattingEnabled = true;
            this.cmbFilterBook.Location = new System.Drawing.Point(802, 12);
            this.cmbFilterBook.Name = "cmbFilterBook";
            this.cmbFilterBook.Size = new System.Drawing.Size(200, 23);
            this.cmbFilterBook.TabIndex = 1;
            this.cmbFilterBook.SelectedIndexChanged += new System.EventHandler(this.CmbFilterBook_SelectedIndexChanged);
            // 
            // lblFilterBook
            // 
            this.lblFilterBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterBook.AutoSize = true;
            this.lblFilterBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.lblFilterBook.Location = new System.Drawing.Point(694, 15);
            this.lblFilterBook.Name = "lblFilterBook";
            this.lblFilterBook.Size = new System.Drawing.Size(102, 19);
            this.lblFilterBook.TabIndex = 0;
            this.lblFilterBook.Text = "Lọc theo sách:";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusState,
            this.lblStatusTotal});
            this.statusStrip.Location = new System.Drawing.Point(0, 738);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatusState
            // 
            this.lblStatusState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.lblStatusState.Name = "lblStatusState";
            this.lblStatusState.Size = new System.Drawing.Size(57, 17);
            this.lblStatusState.Text = "Sẵn sàng";
            // 
            // lblStatusTotal
            // 
            this.lblStatusTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.lblStatusTotal.Name = "lblStatusTotal";
            this.lblStatusTotal.Size = new System.Drawing.Size(1192, 17);
            this.lblStatusTotal.Spring = true;
            this.lblStatusTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // authMenu
            // 
            this.authMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.authMenu.ForeColor = System.Drawing.Color.White;
            this.authMenu.Name = "authMenu";
            this.authMenu.Renderer = new DarkMenuRenderer();
            this.authMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // importMenu
            // 
            this.importMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.importMenu.ForeColor = System.Drawing.Color.White;
            this.importMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemImport,
            this.itemScan});
            this.importMenu.Name = "importMenu";
            this.importMenu.Renderer = new DarkMenuRenderer();
            this.importMenu.Size = new System.Drawing.Size(210, 48);
            // 
            // itemImport
            // 
            this.itemImport.Name = "itemImport";
            this.itemImport.Size = new System.Drawing.Size(209, 22);
            this.itemImport.Text = "📄  Nhập file (Epub, PDF...)";
            this.itemImport.Click += new System.EventHandler(this.ItemImport_Click);
            // 
            // itemScan
            // 
            this.itemScan.Name = "itemScan";
            this.itemScan.Size = new System.Drawing.Size(209, 22);
            this.itemScan.Text = "📂  Quét thư mục";
            this.itemScan.Click += new System.EventHandler(this.ItemScan_Click);
            // 
            // sortMenu
            // 
            this.sortMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.sortMenu.ForeColor = System.Drawing.Color.White;
            this.sortMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSortDate,
            this.itemSortBookName,
            this.itemSortAuthor,
            this.itemSortProgress,
            this.toolStripSeparator1,
            this.itemAscending,
            this.itemDescending});
            this.sortMenu.Name = "sortMenu";
            this.sortMenu.Renderer = new DarkMenuRenderer();
            this.sortMenu.Size = new System.Drawing.Size(166, 142);
            // 
            // itemSortDate
            // 
            this.itemSortDate.Name = "itemSortDate";
            this.itemSortDate.Size = new System.Drawing.Size(165, 22);
            this.itemSortDate.Tag = "Date";
            this.itemSortDate.Text = "📅  Ngày thêm";
            this.itemSortDate.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // itemSortBookName
            // 
            this.itemSortBookName.Name = "itemSortBookName";
            this.itemSortBookName.Size = new System.Drawing.Size(165, 22);
            this.itemSortBookName.Tag = "Book name";
            this.itemSortBookName.Text = "📖  Tên sách";
            this.itemSortBookName.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // itemSortAuthor
            // 
            this.itemSortAuthor.Name = "itemSortAuthor";
            this.itemSortAuthor.Size = new System.Drawing.Size(165, 22);
            this.itemSortAuthor.Tag = "Author name";
            this.itemSortAuthor.Text = "✍  Tác giả";
            this.itemSortAuthor.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // itemSortProgress
            // 
            this.itemSortProgress.Name = "itemSortProgress";
            this.itemSortProgress.Size = new System.Drawing.Size(165, 22);
            this.itemSortProgress.Tag = "Reading progress";
            this.itemSortProgress.Text = "📊  Tiến độ đọc";
            this.itemSortProgress.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // itemAscending
            // 
            this.itemAscending.Name = "itemAscending";
            this.itemAscending.Size = new System.Drawing.Size(165, 22);
            this.itemAscending.Tag = "ASC";
            this.itemAscending.Text = "⬆  Tăng dần";
            this.itemAscending.Click += new System.EventHandler(this.SortDirectionMenuItem_Click);
            // 
            // itemDescending
            // 
            this.itemDescending.Name = "itemDescending";
            this.itemDescending.Size = new System.Drawing.Size(165, 22);
            this.itemDescending.Tag = "DESC";
            this.itemDescending.Text = "⬇  Giảm dần";
            this.itemDescending.Click += new System.EventHandler(this.SortDirectionMenuItem_Click);
            // 
            // searchDebounceTimer
            // 
            this.searchDebounceTimer.Interval = 300;
            this.searchDebounceTimer.Tick += new System.EventHandler(this.SearchDebounceTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1264, 760);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koodo Reader";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.pnlFilterBar.ResumeLayout(false);
            this.pnlFilterBar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.importMenu.ResumeLayout(false);
            this.sortMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchIcon;
        private ModernButton btnReport;
        private ModernButton sortButton;
        private ModernButton btnAddBook;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.FlowLayoutPanel pnlShelfContainer;
        private System.Windows.Forms.Button btnShelfToggle;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.FlowLayoutPanel booksPanel;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.ComboBox cmbFilterBook;
        private System.Windows.Forms.Label lblFilterBook;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusState;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTotal;
        private System.Windows.Forms.ContextMenuStrip authMenu;
        private System.Windows.Forms.ContextMenuStrip importMenu;
        private System.Windows.Forms.ToolStripMenuItem itemImport;
        private System.Windows.Forms.ToolStripMenuItem itemScan;
        private System.Windows.Forms.ContextMenuStrip sortMenu;
        private System.Windows.Forms.ToolStripMenuItem itemSortDate;
        private System.Windows.Forms.ToolStripMenuItem itemSortBookName;
        private System.Windows.Forms.ToolStripMenuItem itemSortAuthor;
        private System.Windows.Forms.ToolStripMenuItem itemSortProgress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemAscending;
        private System.Windows.Forms.ToolStripMenuItem itemDescending;
        private System.Windows.Forms.Timer searchDebounceTimer;
    }
}