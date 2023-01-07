
namespace TimeControl.Windows
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.startButton = new System.Windows.Forms.Button();
            this.timeBox = new System.Windows.Forms.NumericUpDown();
            this.controlTab = new System.Windows.Forms.TabControl();
            this.startNow = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.whiteProcessBox = new System.Windows.Forms.TextBox();
            this.deepFocusPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.deepTimeInput = new System.Windows.Forms.NumericUpDown();
            this.deepStartButton = new System.Windows.Forms.Button();
            this.processMonitor = new System.Windows.Forms.TabPage();
            this.resetButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.autoRefreshBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.appAddButton = new System.Windows.Forms.Button();
            this.usageBox = new System.Windows.Forms.ListBox();
            this.shutdownTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.shutdownRemoveButton = new System.Windows.Forms.Button();
            this.shutdownSetButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endShutdownMinute = new System.Windows.Forms.NumericUpDown();
            this.endShutdownHour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.startShutdownMinute = new System.Windows.Forms.NumericUpDown();
            this.startShutdownHour = new System.Windows.Forms.NumericUpDown();
            this.appProtect = new System.Windows.Forms.TabPage();
            this.unlockPasswordRemoveButton = new System.Windows.Forms.Button();
            this.removeBootButton = new System.Windows.Forms.Button();
            this.addBootButton = new System.Windows.Forms.Button();
            this.unlockPasswordSetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unlockPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressPage = new System.Windows.Forms.TabPage();
            this.encourageLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.settingPage = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.autoResetBox = new System.Windows.Forms.CheckBox();
            this.helpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.giteeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processMonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.fileSaveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            this.controlTab.SuspendLayout();
            this.startNow.SuspendLayout();
            this.deepFocusPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deepTimeInput)).BeginInit();
            this.processMonitor.SuspendLayout();
            this.shutdownTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endShutdownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endShutdownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startShutdownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startShutdownHour)).BeginInit();
            this.appProtect.SuspendLayout();
            this.dataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.progressPage.SuspendLayout();
            this.settingPage.SuspendLayout();
            this.iconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(239, 218);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(145, 82);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "启动屏保（分）";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(255, 189);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.timeBox.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.timeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(117, 23);
            this.timeBox.TabIndex = 1;
            this.timeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // controlTab
            // 
            this.controlTab.Controls.Add(this.startNow);
            this.controlTab.Controls.Add(this.deepFocusPage);
            this.controlTab.Controls.Add(this.processMonitor);
            this.controlTab.Controls.Add(this.shutdownTab);
            this.controlTab.Controls.Add(this.appProtect);
            this.controlTab.Controls.Add(this.dataPage);
            this.controlTab.Controls.Add(this.progressPage);
            this.controlTab.Controls.Add(this.settingPage);
            this.controlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlTab.Location = new System.Drawing.Point(0, 0);
            this.controlTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.controlTab.Name = "controlTab";
            this.controlTab.SelectedIndex = 0;
            this.controlTab.Size = new System.Drawing.Size(622, 382);
            this.controlTab.TabIndex = 2;
            // 
            // startNow
            // 
            this.startNow.Controls.Add(this.label5);
            this.startNow.Controls.Add(this.whiteProcessBox);
            this.startNow.Controls.Add(this.startButton);
            this.startNow.Controls.Add(this.timeBox);
            this.startNow.Location = new System.Drawing.Point(4, 26);
            this.startNow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startNow.Name = "startNow";
            this.startNow.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startNow.Size = new System.Drawing.Size(614, 352);
            this.startNow.TabIndex = 0;
            this.startNow.Text = "专注屏保";
            this.startNow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "白名单应用路径（一行一个）";
            // 
            // whiteProcessBox
            // 
            this.whiteProcessBox.Location = new System.Drawing.Point(161, 49);
            this.whiteProcessBox.Multiline = true;
            this.whiteProcessBox.Name = "whiteProcessBox";
            this.whiteProcessBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.whiteProcessBox.Size = new System.Drawing.Size(298, 134);
            this.whiteProcessBox.TabIndex = 2;
            this.whiteProcessBox.TextChanged += new System.EventHandler(this.WhiteProcessBox_TextChanged);
            // 
            // deepFocusPage
            // 
            this.deepFocusPage.Controls.Add(this.label9);
            this.deepFocusPage.Controls.Add(this.deepTimeInput);
            this.deepFocusPage.Controls.Add(this.deepStartButton);
            this.deepFocusPage.Location = new System.Drawing.Point(4, 26);
            this.deepFocusPage.Name = "deepFocusPage";
            this.deepFocusPage.Size = new System.Drawing.Size(614, 352);
            this.deepFocusPage.TabIndex = 6;
            this.deepFocusPage.Text = "深度专注";
            this.deepFocusPage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(64, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(488, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "启动屏保后，计算机将立刻关机，并在持续时间内开机时自动关闭。（必须设置开机启动）";
            // 
            // deepTimeInput
            // 
            this.deepTimeInput.Location = new System.Drawing.Point(246, 176);
            this.deepTimeInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deepTimeInput.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.deepTimeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deepTimeInput.Name = "deepTimeInput";
            this.deepTimeInput.Size = new System.Drawing.Size(117, 23);
            this.deepTimeInput.TabIndex = 2;
            this.deepTimeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deepStartButton
            // 
            this.deepStartButton.Location = new System.Drawing.Point(229, 218);
            this.deepStartButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deepStartButton.Name = "deepStartButton";
            this.deepStartButton.Size = new System.Drawing.Size(145, 82);
            this.deepStartButton.TabIndex = 1;
            this.deepStartButton.Text = "启动屏保（分）";
            this.deepStartButton.UseVisualStyleBackColor = true;
            this.deepStartButton.Click += new System.EventHandler(this.deepStartButton_Click);
            // 
            // processMonitor
            // 
            this.processMonitor.Controls.Add(this.resetButton);
            this.processMonitor.Controls.Add(this.clearButton);
            this.processMonitor.Controls.Add(this.autoRefreshBox);
            this.processMonitor.Controls.Add(this.refreshButton);
            this.processMonitor.Controls.Add(this.removeButton);
            this.processMonitor.Controls.Add(this.appAddButton);
            this.processMonitor.Controls.Add(this.usageBox);
            this.processMonitor.Location = new System.Drawing.Point(4, 26);
            this.processMonitor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.processMonitor.Name = "processMonitor";
            this.processMonitor.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.processMonitor.Size = new System.Drawing.Size(614, 352);
            this.processMonitor.TabIndex = 1;
            this.processMonitor.Text = "进程计时";
            this.processMonitor.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(411, 134);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(111, 39);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "重置进程时间";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(411, 270);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 38);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "删除所有监控";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // autoRefreshBox
            // 
            this.autoRefreshBox.AutoSize = true;
            this.autoRefreshBox.Location = new System.Drawing.Point(433, 50);
            this.autoRefreshBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.autoRefreshBox.Name = "autoRefreshBox";
            this.autoRefreshBox.Size = new System.Drawing.Size(75, 21);
            this.autoRefreshBox.TabIndex = 6;
            this.autoRefreshBox.Text = "自动刷新";
            this.autoRefreshBox.UseVisualStyleBackColor = true;
            this.autoRefreshBox.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(411, 179);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(111, 43);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "刷新";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(411, 228);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(111, 36);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "删除所选监控";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // appAddButton
            // 
            this.appAddButton.Location = new System.Drawing.Point(411, 77);
            this.appAddButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appAddButton.Name = "appAddButton";
            this.appAddButton.Size = new System.Drawing.Size(111, 51);
            this.appAddButton.TabIndex = 1;
            this.appAddButton.Text = "添加监控";
            this.appAddButton.UseVisualStyleBackColor = true;
            this.appAddButton.Click += new System.EventHandler(this.AppAddButton_Click);
            // 
            // usageBox
            // 
            this.usageBox.FormattingEnabled = true;
            this.usageBox.ItemHeight = 17;
            this.usageBox.Location = new System.Drawing.Point(5, 5);
            this.usageBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.usageBox.Name = "usageBox";
            this.usageBox.Size = new System.Drawing.Size(331, 344);
            this.usageBox.TabIndex = 0;
            // 
            // shutdownTab
            // 
            this.shutdownTab.Controls.Add(this.label8);
            this.shutdownTab.Controls.Add(this.shutdownRemoveButton);
            this.shutdownTab.Controls.Add(this.shutdownSetButton);
            this.shutdownTab.Controls.Add(this.label12);
            this.shutdownTab.Controls.Add(this.label10);
            this.shutdownTab.Controls.Add(this.label11);
            this.shutdownTab.Controls.Add(this.label7);
            this.shutdownTab.Controls.Add(this.label6);
            this.shutdownTab.Controls.Add(this.endShutdownMinute);
            this.shutdownTab.Controls.Add(this.endShutdownHour);
            this.shutdownTab.Controls.Add(this.label4);
            this.shutdownTab.Controls.Add(this.startShutdownMinute);
            this.shutdownTab.Controls.Add(this.startShutdownHour);
            this.shutdownTab.Location = new System.Drawing.Point(4, 26);
            this.shutdownTab.Name = "shutdownTab";
            this.shutdownTab.Padding = new System.Windows.Forms.Padding(3);
            this.shutdownTab.Size = new System.Drawing.Size(614, 352);
            this.shutdownTab.TabIndex = 4;
            this.shutdownTab.Text = "自动关机";
            this.shutdownTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(493, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "开机启动通过windows计划任务实现！若电脑被误完全锁定，请关闭TimeControlBoot任务";
            // 
            // shutdownRemoveButton
            // 
            this.shutdownRemoveButton.Location = new System.Drawing.Point(416, 118);
            this.shutdownRemoveButton.Name = "shutdownRemoveButton";
            this.shutdownRemoveButton.Size = new System.Drawing.Size(190, 81);
            this.shutdownRemoveButton.TabIndex = 15;
            this.shutdownRemoveButton.Text = "移除";
            this.shutdownRemoveButton.UseVisualStyleBackColor = true;
            this.shutdownRemoveButton.Click += new System.EventHandler(this.shutdownRemoveButton_Click);
            // 
            // shutdownSetButton
            // 
            this.shutdownSetButton.Location = new System.Drawing.Point(416, 31);
            this.shutdownSetButton.Name = "shutdownSetButton";
            this.shutdownSetButton.Size = new System.Drawing.Size(190, 81);
            this.shutdownSetButton.TabIndex = 14;
            this.shutdownSetButton.Text = "设置";
            this.shutdownSetButton.UseVisualStyleBackColor = true;
            this.shutdownSetButton.Click += new System.EventHandler(this.shutdownSetButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "到";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "分";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "时";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "时";
            // 
            // endShutdownMinute
            // 
            this.endShutdownMinute.Location = new System.Drawing.Point(245, 60);
            this.endShutdownMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.endShutdownMinute.Name = "endShutdownMinute";
            this.endShutdownMinute.Size = new System.Drawing.Size(120, 23);
            this.endShutdownMinute.TabIndex = 5;
            // 
            // endShutdownHour
            // 
            this.endShutdownHour.Location = new System.Drawing.Point(245, 31);
            this.endShutdownHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.endShutdownHour.Name = "endShutdownHour";
            this.endShutdownHour.Size = new System.Drawing.Size(120, 23);
            this.endShutdownHour.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "在此时段内开机后自动关闭电脑（必须设为开机启动才生效）";
            // 
            // startShutdownMinute
            // 
            this.startShutdownMinute.Location = new System.Drawing.Point(8, 60);
            this.startShutdownMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.startShutdownMinute.Name = "startShutdownMinute";
            this.startShutdownMinute.Size = new System.Drawing.Size(120, 23);
            this.startShutdownMinute.TabIndex = 1;
            // 
            // startShutdownHour
            // 
            this.startShutdownHour.Location = new System.Drawing.Point(8, 31);
            this.startShutdownHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.startShutdownHour.Name = "startShutdownHour";
            this.startShutdownHour.Size = new System.Drawing.Size(120, 23);
            this.startShutdownHour.TabIndex = 0;
            // 
            // appProtect
            // 
            this.appProtect.Controls.Add(this.unlockPasswordRemoveButton);
            this.appProtect.Controls.Add(this.removeBootButton);
            this.appProtect.Controls.Add(this.addBootButton);
            this.appProtect.Controls.Add(this.unlockPasswordSetButton);
            this.appProtect.Controls.Add(this.label2);
            this.appProtect.Controls.Add(this.unlockPasswordBox);
            this.appProtect.Controls.Add(this.label1);
            this.appProtect.Location = new System.Drawing.Point(4, 26);
            this.appProtect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appProtect.Name = "appProtect";
            this.appProtect.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appProtect.Size = new System.Drawing.Size(614, 352);
            this.appProtect.TabIndex = 3;
            this.appProtect.Text = "程序保护";
            this.appProtect.UseVisualStyleBackColor = true;
            // 
            // unlockPasswordRemoveButton
            // 
            this.unlockPasswordRemoveButton.Location = new System.Drawing.Point(102, 34);
            this.unlockPasswordRemoveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.unlockPasswordRemoveButton.Name = "unlockPasswordRemoveButton";
            this.unlockPasswordRemoveButton.Size = new System.Drawing.Size(93, 37);
            this.unlockPasswordRemoveButton.TabIndex = 10;
            this.unlockPasswordRemoveButton.Text = "移除";
            this.unlockPasswordRemoveButton.UseVisualStyleBackColor = true;
            this.unlockPasswordRemoveButton.Click += new System.EventHandler(this.UnlockPasswordRemoveButton_Click);
            // 
            // removeBootButton
            // 
            this.removeBootButton.Location = new System.Drawing.Point(177, 283);
            this.removeBootButton.Name = "removeBootButton";
            this.removeBootButton.Size = new System.Drawing.Size(163, 61);
            this.removeBootButton.TabIndex = 9;
            this.removeBootButton.Text = "移除开机启动";
            this.removeBootButton.UseVisualStyleBackColor = true;
            this.removeBootButton.Click += new System.EventHandler(this.RemoveBootButton_Click);
            // 
            // addBootButton
            // 
            this.addBootButton.Location = new System.Drawing.Point(8, 283);
            this.addBootButton.Name = "addBootButton";
            this.addBootButton.Size = new System.Drawing.Size(163, 61);
            this.addBootButton.TabIndex = 8;
            this.addBootButton.Text = "添加开机启动";
            this.addBootButton.UseVisualStyleBackColor = true;
            this.addBootButton.Click += new System.EventHandler(this.AddBootButton_Click);
            // 
            // unlockPasswordSetButton
            // 
            this.unlockPasswordSetButton.Location = new System.Drawing.Point(5, 33);
            this.unlockPasswordSetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.unlockPasswordSetButton.Name = "unlockPasswordSetButton";
            this.unlockPasswordSetButton.Size = new System.Drawing.Size(93, 37);
            this.unlockPasswordSetButton.TabIndex = 7;
            this.unlockPasswordSetButton.Text = "设置";
            this.unlockPasswordSetButton.UseVisualStyleBackColor = true;
            this.unlockPasswordSetButton.Click += new System.EventHandler(this.UnloackPasswordSetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(153, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "设置管理码后，在屏保时可以凭管理码解锁。且退出程序需要输入管理码。";
            // 
            // unlockPasswordBox
            // 
            this.unlockPasswordBox.Location = new System.Drawing.Point(51, 5);
            this.unlockPasswordBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.unlockPasswordBox.Name = "unlockPasswordBox";
            this.unlockPasswordBox.Size = new System.Drawing.Size(98, 23);
            this.unlockPasswordBox.TabIndex = 5;
            this.unlockPasswordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "管理码";
            // 
            // dataPage
            // 
            this.dataPage.Controls.Add(this.dataGridView);
            this.dataPage.Location = new System.Drawing.Point(4, 26);
            this.dataPage.Name = "dataPage";
            this.dataPage.Size = new System.Drawing.Size(614, 352);
            this.dataPage.TabIndex = 5;
            this.dataPage.Text = "数据分析";
            this.dataPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeColumn,
            this.nameColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(614, 352);
            this.dataGridView.TabIndex = 0;
            // 
            // timeColumn
            // 
            this.timeColumn.HeaderText = "时间";
            this.timeColumn.Name = "timeColumn";
            this.timeColumn.ReadOnly = true;
            this.timeColumn.Width = 415;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "名称";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 153;
            // 
            // progressPage
            // 
            this.progressPage.Controls.Add(this.encourageLabel);
            this.progressPage.Controls.Add(this.progressLabel);
            this.progressPage.Controls.Add(this.levelLabel);
            this.progressPage.Controls.Add(this.progressBar);
            this.progressPage.Location = new System.Drawing.Point(4, 26);
            this.progressPage.Name = "progressPage";
            this.progressPage.Size = new System.Drawing.Size(614, 352);
            this.progressPage.TabIndex = 7;
            this.progressPage.Text = "我的进度";
            this.progressPage.UseVisualStyleBackColor = true;
            // 
            // encourageLabel
            // 
            this.encourageLabel.ForeColor = System.Drawing.Color.Red;
            this.encourageLabel.Location = new System.Drawing.Point(155, 94);
            this.encourageLabel.Name = "encourageLabel";
            this.encourageLabel.Size = new System.Drawing.Size(305, 119);
            this.encourageLabel.TabIndex = 4;
            this.encourageLabel.Text = "听说只要专注等级达到100级，能力就会有巨大的成长！";
            this.encourageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(210, 270);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(183, 17);
            this.progressLabel.TabIndex = 3;
            this.progressLabel.Text = "进入下一级还需要专注0.000小时";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(253, 213);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(113, 17);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "当前等级：0/100级";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(124, 233);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(358, 34);
            this.progressBar.TabIndex = 0;
            // 
            // settingPage
            // 
            this.settingPage.Controls.Add(this.label13);
            this.settingPage.Controls.Add(this.autoResetBox);
            this.settingPage.Controls.Add(this.helpLinkLabel);
            this.settingPage.Controls.Add(this.giteeLinkLabel);
            this.settingPage.Controls.Add(this.githubLinkLabel);
            this.settingPage.Controls.Add(this.linkLabel1);
            this.settingPage.Controls.Add(this.label3);
            this.settingPage.Location = new System.Drawing.Point(4, 26);
            this.settingPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.settingPage.Name = "settingPage";
            this.settingPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.settingPage.Size = new System.Drawing.Size(614, 352);
            this.settingPage.TabIndex = 2;
            this.settingPage.Text = "设置";
            this.settingPage.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.LightCoral;
            this.label13.Location = new System.Drawing.Point(485, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "你的设置将自动保存";
            // 
            // autoResetBox
            // 
            this.autoResetBox.AutoSize = true;
            this.autoResetBox.Location = new System.Drawing.Point(8, 6);
            this.autoResetBox.Name = "autoResetBox";
            this.autoResetBox.Size = new System.Drawing.Size(255, 21);
            this.autoResetBox.TabIndex = 8;
            this.autoResetBox.Text = "新的一天开始时，自动重置进程计时的时间";
            this.autoResetBox.UseVisualStyleBackColor = true;
            this.autoResetBox.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // helpLinkLabel
            // 
            this.helpLinkLabel.AutoSize = true;
            this.helpLinkLabel.Location = new System.Drawing.Point(577, 332);
            this.helpLinkLabel.Name = "helpLinkLabel";
            this.helpLinkLabel.Size = new System.Drawing.Size(32, 17);
            this.helpLinkLabel.TabIndex = 7;
            this.helpLinkLabel.TabStop = true;
            this.helpLinkLabel.Text = "帮助";
            this.helpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLinkLabel_LinkClicked);
            // 
            // giteeLinkLabel
            // 
            this.giteeLinkLabel.AutoSize = true;
            this.giteeLinkLabel.Location = new System.Drawing.Point(5, 330);
            this.giteeLinkLabel.Name = "giteeLinkLabel";
            this.giteeLinkLabel.Size = new System.Drawing.Size(37, 17);
            this.giteeLinkLabel.TabIndex = 6;
            this.giteeLinkLabel.TabStop = true;
            this.giteeLinkLabel.Text = "gitee";
            this.giteeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GiteeLinkLabel_LinkClicked);
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Location = new System.Drawing.Point(5, 305);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(45, 17);
            this.githubLinkLabel.TabIndex = 5;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "github";
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(578, 3);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "链接";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "图标来自icon8!";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.iconContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Computer Time Control";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // iconContextMenuStrip
            // 
            this.iconContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.iconContextMenuStrip.Name = "contextMenuStrip";
            this.iconContextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // processMonitorTimer
            // 
            this.processMonitorTimer.Interval = 1000;
            this.processMonitorTimer.Tick += new System.EventHandler(this.ProcessMonitorTimer_Tick);
            // 
            // fileSaveTimer
            // 
            this.fileSaveTimer.Interval = 300000;
            this.fileSaveTimer.Tick += new System.EventHandler(this.FileSaveTimer_Tick);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 382);
            this.Controls.Add(this.controlTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanel";
            this.Text = "时间管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanel_FormClosing);
            this.Shown += new System.EventHandler(this.ControlPanel_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            this.controlTab.ResumeLayout(false);
            this.startNow.ResumeLayout(false);
            this.startNow.PerformLayout();
            this.deepFocusPage.ResumeLayout(false);
            this.deepFocusPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deepTimeInput)).EndInit();
            this.processMonitor.ResumeLayout(false);
            this.processMonitor.PerformLayout();
            this.shutdownTab.ResumeLayout(false);
            this.shutdownTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endShutdownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endShutdownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startShutdownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startShutdownHour)).EndInit();
            this.appProtect.ResumeLayout(false);
            this.appProtect.PerformLayout();
            this.dataPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.progressPage.ResumeLayout(false);
            this.progressPage.PerformLayout();
            this.settingPage.ResumeLayout(false);
            this.settingPage.PerformLayout();
            this.iconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.TabControl controlTab;
        private System.Windows.Forms.TabPage startNow;
        private System.Windows.Forms.TabPage processMonitor;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip iconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TabPage settingPage;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox usageBox;
        private System.Windows.Forms.Button appAddButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Timer processMonitorTimer;
        private System.Windows.Forms.TabPage appProtect;
        private System.Windows.Forms.Button unlockPasswordSetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unlockPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.CheckBox autoRefreshBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer fileSaveTimer;
        private System.Windows.Forms.LinkLabel giteeLinkLabel;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.TextBox whiteProcessBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBootButton;
        private System.Windows.Forms.Button removeBootButton;
        private System.Windows.Forms.LinkLabel helpLinkLabel;
        private System.Windows.Forms.Button unlockPasswordRemoveButton;
        private System.Windows.Forms.TabPage shutdownTab;
        private System.Windows.Forms.Button shutdownSetButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown endShutdownMinute;
        private System.Windows.Forms.NumericUpDown endShutdownHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown startShutdownMinute;
        private System.Windows.Forms.NumericUpDown startShutdownHour;
        private System.Windows.Forms.Button shutdownRemoveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage deepFocusPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown deepTimeInput;
        private System.Windows.Forms.Button deepStartButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.TabPage progressPage;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label encourageLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox autoResetBox;
    }
}