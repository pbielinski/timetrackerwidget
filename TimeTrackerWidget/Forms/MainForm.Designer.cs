namespace TimeTrackerWidget.forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainTop = new System.Windows.Forms.Panel();
            this.panelComment = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.panelRedmineWidget = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxRedmineActivity = new System.Windows.Forms.ComboBox();
            this.textBoxRedmineIssueNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPaymoWidget = new System.Windows.Forms.Panel();
            this.pictureBoxPaymoLoad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPaymoProjects = new System.Windows.Forms.ComboBox();
            this.comboBoxPaymoTasks = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.runTaskButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRunnerTask = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkerPaymoProjects = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTimerLogs = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.uiEventEdit1 = new TimeTrackerWidget.Forms.UI.UIEventEdit();
            this.uitImerLogs = new TimeTrackerWidget.Forms.UITImerLogs();
            this.panelAll.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMainTop.SuspendLayout();
            this.panelComment.SuspendLayout();
            this.panelRedmineWidget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelPaymoWidget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaymoLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.panelMain);
            this.panelAll.Controls.Add(this.uitImerLogs);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 24);
            this.panelAll.Margin = new System.Windows.Forms.Padding(0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(338, 282);
            this.panelAll.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelMainTop);
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(338, 282);
            this.panelMain.TabIndex = 0;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.panelComment);
            this.panelMainTop.Controls.Add(this.panelRedmineWidget);
            this.panelMainTop.Controls.Add(this.panelPaymoWidget);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Size = new System.Drawing.Size(338, 240);
            this.panelMainTop.TabIndex = 11;
            // 
            // panelComment
            // 
            this.panelComment.Controls.Add(this.label6);
            this.panelComment.Controls.Add(this.commentTextBox);
            this.panelComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComment.Location = new System.Drawing.Point(0, 72);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(338, 168);
            this.panelComment.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(7, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Komentarz";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commentTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentTextBox.Location = new System.Drawing.Point(10, 20);
            this.commentTextBox.MaxLength = 255;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.commentTextBox.Size = new System.Drawing.Size(319, 142);
            this.commentTextBox.TabIndex = 9;
            this.commentTextBox.Text = "";
            // 
            // panelRedmineWidget
            // 
            this.panelRedmineWidget.BackColor = System.Drawing.Color.Orange;
            this.panelRedmineWidget.Controls.Add(this.pictureBox2);
            this.panelRedmineWidget.Controls.Add(this.button1);
            this.panelRedmineWidget.Controls.Add(this.comboBoxRedmineActivity);
            this.panelRedmineWidget.Controls.Add(this.textBoxRedmineIssueNo);
            this.panelRedmineWidget.Controls.Add(this.label4);
            this.panelRedmineWidget.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRedmineWidget.Location = new System.Drawing.Point(0, 36);
            this.panelRedmineWidget.Name = "panelRedmineWidget";
            this.panelRedmineWidget.Size = new System.Drawing.Size(338, 36);
            this.panelRedmineWidget.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TimeTrackerWidget.Properties.Resources.redmine_fluid_icon;
            this.pictureBox2.Location = new System.Drawing.Point(10, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Image = global::TimeTrackerWidget.Properties.Resources.navarrowright;
            this.button1.Location = new System.Drawing.Point(159, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 27);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxRedmineActivity
            // 
            this.comboBoxRedmineActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRedmineActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRedmineActivity.Location = new System.Drawing.Point(196, 5);
            this.comboBoxRedmineActivity.Name = "comboBoxRedmineActivity";
            this.comboBoxRedmineActivity.Size = new System.Drawing.Size(137, 28);
            this.comboBoxRedmineActivity.TabIndex = 18;
            // 
            // textBoxRedmineIssueNo
            // 
            this.textBoxRedmineIssueNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRedmineIssueNo.Location = new System.Drawing.Point(70, 7);
            this.textBoxRedmineIssueNo.Name = "textBoxRedmineIssueNo";
            this.textBoxRedmineIssueNo.Size = new System.Drawing.Size(83, 26);
            this.textBoxRedmineIssueNo.TabIndex = 16;
            this.textBoxRedmineIssueNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRedmineIssueNo_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "#";
            // 
            // panelPaymoWidget
            // 
            this.panelPaymoWidget.BackColor = System.Drawing.Color.LawnGreen;
            this.panelPaymoWidget.Controls.Add(this.pictureBoxPaymoLoad);
            this.panelPaymoWidget.Controls.Add(this.pictureBox1);
            this.panelPaymoWidget.Controls.Add(this.comboBoxPaymoProjects);
            this.panelPaymoWidget.Controls.Add(this.comboBoxPaymoTasks);
            this.panelPaymoWidget.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaymoWidget.Location = new System.Drawing.Point(0, 0);
            this.panelPaymoWidget.Name = "panelPaymoWidget";
            this.panelPaymoWidget.Size = new System.Drawing.Size(338, 36);
            this.panelPaymoWidget.TabIndex = 11;
            // 
            // pictureBoxPaymoLoad
            // 
            this.pictureBoxPaymoLoad.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBoxPaymoLoad.Image = global::TimeTrackerWidget.Properties.Resources._8_0;
            this.pictureBoxPaymoLoad.Location = new System.Drawing.Point(41, 3);
            this.pictureBoxPaymoLoad.Name = "pictureBoxPaymoLoad";
            this.pictureBoxPaymoLoad.Size = new System.Drawing.Size(297, 30);
            this.pictureBoxPaymoLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPaymoLoad.TabIndex = 22;
            this.pictureBoxPaymoLoad.TabStop = false;
            this.pictureBoxPaymoLoad.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxPaymoProjects
            // 
            this.comboBoxPaymoProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymoProjects.Enabled = false;
            this.comboBoxPaymoProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPaymoProjects.Location = new System.Drawing.Point(41, 5);
            this.comboBoxPaymoProjects.Name = "comboBoxPaymoProjects";
            this.comboBoxPaymoProjects.Size = new System.Drawing.Size(120, 28);
            this.comboBoxPaymoProjects.TabIndex = 19;
            this.comboBoxPaymoProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymoProjects_SelectedIndexChanged);
            // 
            // comboBoxPaymoTasks
            // 
            this.comboBoxPaymoTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymoTasks.Enabled = false;
            this.comboBoxPaymoTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPaymoTasks.Location = new System.Drawing.Point(167, 5);
            this.comboBoxPaymoTasks.Name = "comboBoxPaymoTasks";
            this.comboBoxPaymoTasks.Size = new System.Drawing.Size(166, 28);
            this.comboBoxPaymoTasks.TabIndex = 18;
            this.comboBoxPaymoTasks.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymoTasks_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelTimer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.runTaskButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 240);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 42);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelTimer
            // 
            this.labelTimer.BackColor = System.Drawing.SystemColors.Control;
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimer.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(3, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(226, 42);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runTaskButton
            // 
            this.runTaskButton.BackColor = System.Drawing.SystemColors.Control;
            this.runTaskButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runTaskButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.runTaskButton.ImageIndex = 0;
            this.runTaskButton.ImageList = this.imageList1;
            this.runTaskButton.Location = new System.Drawing.Point(235, 3);
            this.runTaskButton.Name = "runTaskButton";
            this.runTaskButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.runTaskButton.Size = new System.Drawing.Size(100, 36);
            this.runTaskButton.TabIndex = 2;
            this.runTaskButton.Text = "START ";
            this.runTaskButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.runTaskButton.UseVisualStyleBackColor = false;
            this.runTaskButton.Click += new System.EventHandler(this.runTaskButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1420406368_play-circle-full-24.png");
            this.imageList1.Images.SetKeyName(1, "1420406397_stop-24.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem,
            this.zamknijToolStripMenuItem1});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.zamknijToolStripMenuItem.Text = "Ustawienia";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem1
            // 
            this.zamknijToolStripMenuItem1.Name = "zamknijToolStripMenuItem1";
            this.zamknijToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.zamknijToolStripMenuItem1.Text = "Zamknij";
            this.zamknijToolStripMenuItem1.Click += new System.EventHandler(this.zamknijToolStripMenuItem1_Click);
            // 
            // timerRunnerTask
            // 
            this.timerRunnerTask.Interval = 1000;
            this.timerRunnerTask.Tick += new System.EventHandler(this.timerRunnerTask_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TimeTrackerWidget";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.toolStripSeparator1,
            this.close});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 54);
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(116, 22);
            this.open.Text = "Otwórz";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(116, 22);
            this.close.Text = "Zamknij";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // backgroundWorkerPaymoProjects
            // 
            this.backgroundWorkerPaymoProjects.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorkerPaymoProjects.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 50);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonTimerLogs, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonTimer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(338, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonTimerLogs
            // 
            this.buttonTimerLogs.BackColor = System.Drawing.Color.DarkGray;
            this.buttonTimerLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimerLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTimerLogs.FlatAppearance.BorderSize = 0;
            this.buttonTimerLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerLogs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTimerLogs.Image = global::TimeTrackerWidget.Properties.Resources.listrounded;
            this.buttonTimerLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimerLogs.Location = new System.Drawing.Point(169, 0);
            this.buttonTimerLogs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTimerLogs.Name = "buttonTimerLogs";
            this.buttonTimerLogs.Size = new System.Drawing.Size(169, 50);
            this.buttonTimerLogs.TabIndex = 1;
            this.buttonTimerLogs.Text = "Ewidencja\r\nczasu";
            this.buttonTimerLogs.UseVisualStyleBackColor = false;
            this.buttonTimerLogs.Click += new System.EventHandler(this.buttonTimerLogs_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.BackColor = System.Drawing.Color.DarkGray;
            this.buttonTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTimer.FlatAppearance.BorderSize = 0;
            this.buttonTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTimer.Image = global::TimeTrackerWidget.Properties.Resources.stopwatch;
            this.buttonTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimer.Location = new System.Drawing.Point(0, 0);
            this.buttonTimer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(169, 50);
            this.buttonTimer.TabIndex = 0;
            this.buttonTimer.Text = "Timer";
            this.buttonTimer.UseVisualStyleBackColor = false;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // uiEventEdit1
            // 
            this.uiEventEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiEventEdit1.Location = new System.Drawing.Point(0, 24);
            this.uiEventEdit1.Name = "uiEventEdit1";
            this.uiEventEdit1.Size = new System.Drawing.Size(338, 282);
            this.uiEventEdit1.TabIndex = 4;
            this.uiEventEdit1.Visible = false;
            this.uiEventEdit1.OnSaveClick += new System.EventHandler(this.uiEventEdit1_OnSaveClick);
            this.uiEventEdit1.OnDeleteClick += new System.EventHandler(this.uiEventEdit1_OnDeleteClick);
            this.uiEventEdit1.OnCancelClick += new System.EventHandler(this.uiEventEdit1_OnCancelClick);
            // 
            // uitImerLogs
            // 
            this.uitImerLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uitImerLogs.Location = new System.Drawing.Point(0, 0);
            this.uitImerLogs.Name = "uitImerLogs";
            this.uitImerLogs.Size = new System.Drawing.Size(338, 282);
            this.uitImerLogs.TabIndex = 3;
            this.uitImerLogs.OnRowClick += new TimeTrackerWidget.Forms.UI.UIEntryLogRow.EventClick(this.uitImerLogs_OnRowClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 356);
            this.Controls.Add(this.uiEventEdit1);
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TimeTrackerWidget";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelAll.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMainTop.ResumeLayout(false);
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            this.panelRedmineWidget.ResumeLayout(false);
            this.panelRedmineWidget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelPaymoWidget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaymoLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button runTaskButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem1;
        private System.Windows.Forms.Timer timerRunnerTask;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelMainTop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panelComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox commentTextBox;
        private System.Windows.Forms.Panel panelRedmineWidget;
        private System.Windows.Forms.ComboBox comboBoxRedmineActivity;
        private System.Windows.Forms.TextBox textBoxRedmineIssueNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelPaymoWidget;
        private System.Windows.Forms.ComboBox comboBoxPaymoProjects;
        private System.Windows.Forms.ComboBox comboBoxPaymoTasks;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPaymoProjects;
        private System.Windows.Forms.PictureBox pictureBoxPaymoLoad;
        private System.Windows.Forms.Button button1;
        private Forms.UITImerLogs uitImerLogs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonTimerLogs;
        private System.Windows.Forms.Button buttonTimer;
        private Forms.UI.UIEventEdit uiEventEdit1;
    }
}

