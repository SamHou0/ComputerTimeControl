
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            startButton = new System.Windows.Forms.Button();
            timeBox = new System.Windows.Forms.NumericUpDown();
            controlTab = new System.Windows.Forms.TabControl();
            focus = new System.Windows.Forms.TabPage();
            label5 = new System.Windows.Forms.Label();
            whiteProcessBox = new System.Windows.Forms.TextBox();
            deepFocus = new System.Windows.Forms.TabPage();
            label9 = new System.Windows.Forms.Label();
            deepTimeInput = new System.Windows.Forms.NumericUpDown();
            deepStartButton = new System.Windows.Forms.Button();
            title = new System.Windows.Forms.TabPage();
            titleTextBox = new System.Windows.Forms.TextBox();
            removeTitleButton = new System.Windows.Forms.Button();
            addTitleButton = new System.Windows.Forms.Button();
            titleListBox = new System.Windows.Forms.ListBox();
            processMonitor = new System.Windows.Forms.TabPage();
            resetButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            autoRefreshBox = new System.Windows.Forms.CheckBox();
            refreshButton = new System.Windows.Forms.Button();
            removeButton = new System.Windows.Forms.Button();
            appAddButton = new System.Windows.Forms.Button();
            usageBox = new System.Windows.Forms.ListBox();
            shutdown = new System.Windows.Forms.TabPage();
            label8 = new System.Windows.Forms.Label();
            shutdownRemoveButton = new System.Windows.Forms.Button();
            shutdownSetButton = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            endShutdownMinute = new System.Windows.Forms.NumericUpDown();
            endShutdownHour = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            startShutdownMinute = new System.Windows.Forms.NumericUpDown();
            startShutdownHour = new System.Windows.Forms.NumericUpDown();
            appProtect = new System.Windows.Forms.TabPage();
            enableButton = new System.Windows.Forms.Button();
            stopCheckBox = new System.Windows.Forms.CheckBox();
            unlockPasswordRemoveButton = new System.Windows.Forms.Button();
            removeBootButton = new System.Windows.Forms.Button();
            addBootButton = new System.Windows.Forms.Button();
            unlockPasswordSetButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            unlockPasswordBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            data = new System.Windows.Forms.TabPage();
            dataGridView = new System.Windows.Forms.DataGridView();
            timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            progress = new System.Windows.Forms.TabPage();
            goalLabel = new System.Windows.Forms.Label();
            encourageLabel = new System.Windows.Forms.Label();
            progressLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            setting = new System.Windows.Forms.TabPage();
            versionLabel = new System.Windows.Forms.Label();
            goalChangeButton = new System.Windows.Forms.Button();
            dataDirButton = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            autoResetBox = new System.Windows.Forms.CheckBox();
            helpLinkLabel = new System.Windows.Forms.LinkLabel();
            giteeLinkLabel = new System.Windows.Forms.LinkLabel();
            githubLinkLabel = new System.Windows.Forms.LinkLabel();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            label3 = new System.Windows.Forms.Label();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            iconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            processMonitorTimer = new System.Windows.Forms.Timer(components);
            fileSaveTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)timeBox).BeginInit();
            controlTab.SuspendLayout();
            focus.SuspendLayout();
            deepFocus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deepTimeInput).BeginInit();
            title.SuspendLayout();
            processMonitor.SuspendLayout();
            shutdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)endShutdownMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endShutdownHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startShutdownMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startShutdownHour).BeginInit();
            appProtect.SuspendLayout();
            data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            progress.SuspendLayout();
            setting.SuspendLayout();
            iconContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new System.Drawing.Point(239, 218);
            startButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(145, 82);
            startButton.TabIndex = 0;
            startButton.Text = "启动屏保（分）";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // timeBox
            // 
            timeBox.Location = new System.Drawing.Point(255, 189);
            timeBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            timeBox.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            timeBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            timeBox.Name = "timeBox";
            timeBox.Size = new System.Drawing.Size(117, 23);
            timeBox.TabIndex = 1;
            timeBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // controlTab
            // 
            controlTab.Controls.Add(focus);
            controlTab.Controls.Add(deepFocus);
            controlTab.Controls.Add(title);
            controlTab.Controls.Add(processMonitor);
            controlTab.Controls.Add(shutdown);
            controlTab.Controls.Add(appProtect);
            controlTab.Controls.Add(data);
            controlTab.Controls.Add(progress);
            controlTab.Controls.Add(setting);
            controlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            controlTab.Location = new System.Drawing.Point(0, 0);
            controlTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            controlTab.Name = "controlTab";
            controlTab.SelectedIndex = 0;
            controlTab.Size = new System.Drawing.Size(622, 382);
            controlTab.TabIndex = 2;
            // 
            // focus
            // 
            focus.Controls.Add(label5);
            focus.Controls.Add(whiteProcessBox);
            focus.Controls.Add(startButton);
            focus.Controls.Add(timeBox);
            focus.Location = new System.Drawing.Point(4, 26);
            focus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            focus.Name = "focus";
            focus.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            focus.Size = new System.Drawing.Size(614, 352);
            focus.TabIndex = 0;
            focus.Text = "专注屏保";
            focus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(230, 29);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(164, 17);
            label5.TabIndex = 3;
            label5.Text = "白名单应用路径（一行一个）";
            // 
            // whiteProcessBox
            // 
            whiteProcessBox.Location = new System.Drawing.Point(161, 49);
            whiteProcessBox.Multiline = true;
            whiteProcessBox.Name = "whiteProcessBox";
            whiteProcessBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            whiteProcessBox.Size = new System.Drawing.Size(298, 134);
            whiteProcessBox.TabIndex = 2;
            whiteProcessBox.TextChanged += WhiteProcessBox_TextChanged;
            // 
            // deepFocus
            // 
            deepFocus.Controls.Add(label9);
            deepFocus.Controls.Add(deepTimeInput);
            deepFocus.Controls.Add(deepStartButton);
            deepFocus.Location = new System.Drawing.Point(4, 26);
            deepFocus.Name = "deepFocus";
            deepFocus.Size = new System.Drawing.Size(614, 352);
            deepFocus.TabIndex = 6;
            deepFocus.Text = "深度专注";
            deepFocus.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Location = new System.Drawing.Point(64, 126);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(488, 17);
            label9.TabIndex = 3;
            label9.Text = "启动屏保后，计算机将立刻关机，并在持续时间内开机时自动关闭。（必须设置开机启动）";
            // 
            // deepTimeInput
            // 
            deepTimeInput.Location = new System.Drawing.Point(246, 176);
            deepTimeInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            deepTimeInput.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            deepTimeInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            deepTimeInput.Name = "deepTimeInput";
            deepTimeInput.Size = new System.Drawing.Size(117, 23);
            deepTimeInput.TabIndex = 2;
            deepTimeInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // deepStartButton
            // 
            deepStartButton.Location = new System.Drawing.Point(229, 218);
            deepStartButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            deepStartButton.Name = "deepStartButton";
            deepStartButton.Size = new System.Drawing.Size(145, 82);
            deepStartButton.TabIndex = 1;
            deepStartButton.Text = "启动屏保（分）";
            deepStartButton.UseVisualStyleBackColor = true;
            deepStartButton.Click += DeepStartButton_Click;
            // 
            // title
            // 
            title.Controls.Add(titleTextBox);
            title.Controls.Add(removeTitleButton);
            title.Controls.Add(addTitleButton);
            title.Controls.Add(titleListBox);
            title.Location = new System.Drawing.Point(4, 26);
            title.Name = "title";
            title.Padding = new System.Windows.Forms.Padding(3);
            title.Size = new System.Drawing.Size(614, 352);
            title.TabIndex = 8;
            title.Text = "标题检测";
            title.UseVisualStyleBackColor = true;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new System.Drawing.Point(389, 86);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new System.Drawing.Size(187, 23);
            titleTextBox.TabIndex = 3;
            // 
            // removeTitleButton
            // 
            removeTitleButton.Location = new System.Drawing.Point(389, 223);
            removeTitleButton.Name = "removeTitleButton";
            removeTitleButton.Size = new System.Drawing.Size(187, 79);
            removeTitleButton.TabIndex = 2;
            removeTitleButton.Text = "移除此标题关键词";
            removeTitleButton.UseVisualStyleBackColor = true;
            removeTitleButton.Click += RemoveTitleButton_Click;
            // 
            // addTitleButton
            // 
            addTitleButton.Location = new System.Drawing.Point(389, 115);
            addTitleButton.Name = "addTitleButton";
            addTitleButton.Size = new System.Drawing.Size(187, 79);
            addTitleButton.TabIndex = 1;
            addTitleButton.Text = "添加此标题关键词";
            addTitleButton.UseVisualStyleBackColor = true;
            addTitleButton.Click += AddTitleButton_Click;
            // 
            // titleListBox
            // 
            titleListBox.FormattingEnabled = true;
            titleListBox.ItemHeight = 17;
            titleListBox.Location = new System.Drawing.Point(8, 6);
            titleListBox.Name = "titleListBox";
            titleListBox.Size = new System.Drawing.Size(343, 344);
            titleListBox.TabIndex = 0;
            // 
            // processMonitor
            // 
            processMonitor.Controls.Add(resetButton);
            processMonitor.Controls.Add(clearButton);
            processMonitor.Controls.Add(autoRefreshBox);
            processMonitor.Controls.Add(refreshButton);
            processMonitor.Controls.Add(removeButton);
            processMonitor.Controls.Add(appAddButton);
            processMonitor.Controls.Add(usageBox);
            processMonitor.Location = new System.Drawing.Point(4, 26);
            processMonitor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            processMonitor.Name = "processMonitor";
            processMonitor.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            processMonitor.Size = new System.Drawing.Size(614, 352);
            processMonitor.TabIndex = 1;
            processMonitor.Text = "进程计时";
            processMonitor.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(411, 134);
            resetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(111, 39);
            resetButton.TabIndex = 8;
            resetButton.Text = "重置进程时间";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(411, 270);
            clearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(111, 38);
            clearButton.TabIndex = 7;
            clearButton.Text = "删除所有监控";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // autoRefreshBox
            // 
            autoRefreshBox.AutoSize = true;
            autoRefreshBox.Location = new System.Drawing.Point(433, 50);
            autoRefreshBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            autoRefreshBox.Name = "autoRefreshBox";
            autoRefreshBox.Size = new System.Drawing.Size(75, 21);
            autoRefreshBox.TabIndex = 6;
            autoRefreshBox.Text = "自动刷新";
            autoRefreshBox.UseVisualStyleBackColor = true;
            autoRefreshBox.CheckedChanged += SettingsChanged;
            // 
            // refreshButton
            // 
            refreshButton.Location = new System.Drawing.Point(411, 179);
            refreshButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new System.Drawing.Size(111, 43);
            refreshButton.TabIndex = 5;
            refreshButton.Text = "刷新";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += RefreshButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new System.Drawing.Point(411, 228);
            removeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            removeButton.Name = "removeButton";
            removeButton.Size = new System.Drawing.Size(111, 36);
            removeButton.TabIndex = 2;
            removeButton.Text = "删除所选监控";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += RemoveButton_Click;
            // 
            // appAddButton
            // 
            appAddButton.Location = new System.Drawing.Point(411, 77);
            appAddButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            appAddButton.Name = "appAddButton";
            appAddButton.Size = new System.Drawing.Size(111, 51);
            appAddButton.TabIndex = 1;
            appAddButton.Text = "添加监控";
            appAddButton.UseVisualStyleBackColor = true;
            appAddButton.Click += AppAddButton_Click;
            // 
            // usageBox
            // 
            usageBox.FormattingEnabled = true;
            usageBox.ItemHeight = 17;
            usageBox.Location = new System.Drawing.Point(5, 5);
            usageBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            usageBox.Name = "usageBox";
            usageBox.Size = new System.Drawing.Size(331, 344);
            usageBox.TabIndex = 0;
            // 
            // shutdown
            // 
            shutdown.Controls.Add(label8);
            shutdown.Controls.Add(shutdownRemoveButton);
            shutdown.Controls.Add(shutdownSetButton);
            shutdown.Controls.Add(label12);
            shutdown.Controls.Add(label10);
            shutdown.Controls.Add(label11);
            shutdown.Controls.Add(label7);
            shutdown.Controls.Add(label6);
            shutdown.Controls.Add(endShutdownMinute);
            shutdown.Controls.Add(endShutdownHour);
            shutdown.Controls.Add(label4);
            shutdown.Controls.Add(startShutdownMinute);
            shutdown.Controls.Add(startShutdownHour);
            shutdown.Location = new System.Drawing.Point(4, 26);
            shutdown.Name = "shutdown";
            shutdown.Padding = new System.Windows.Forms.Padding(3);
            shutdown.Size = new System.Drawing.Size(614, 352);
            shutdown.TabIndex = 4;
            shutdown.Text = "自动关机";
            shutdown.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(44, 330);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(493, 17);
            label8.TabIndex = 16;
            label8.Text = "开机启动通过windows计划任务实现！若电脑被误完全锁定，请关闭TimeControlBoot任务";
            // 
            // shutdownRemoveButton
            // 
            shutdownRemoveButton.Location = new System.Drawing.Point(416, 118);
            shutdownRemoveButton.Name = "shutdownRemoveButton";
            shutdownRemoveButton.Size = new System.Drawing.Size(190, 81);
            shutdownRemoveButton.TabIndex = 15;
            shutdownRemoveButton.Text = "移除";
            shutdownRemoveButton.UseVisualStyleBackColor = true;
            shutdownRemoveButton.Click += ShutdownRemoveButton_Click;
            // 
            // shutdownSetButton
            // 
            shutdownSetButton.Location = new System.Drawing.Point(416, 31);
            shutdownSetButton.Name = "shutdownSetButton";
            shutdownSetButton.Size = new System.Drawing.Size(190, 81);
            shutdownSetButton.TabIndex = 14;
            shutdownSetButton.Text = "设置";
            shutdownSetButton.UseVisualStyleBackColor = true;
            shutdownSetButton.Click += ShutdownSetButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(183, 51);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(20, 17);
            label12.TabIndex = 13;
            label12.Text = "到";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(371, 62);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(20, 17);
            label10.TabIndex = 11;
            label10.Text = "分";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(371, 33);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(20, 17);
            label11.TabIndex = 10;
            label11.Text = "时";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(134, 62);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(20, 17);
            label7.TabIndex = 8;
            label7.Text = "分";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(134, 33);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(20, 17);
            label6.TabIndex = 7;
            label6.Text = "时";
            // 
            // endShutdownMinute
            // 
            endShutdownMinute.Location = new System.Drawing.Point(245, 60);
            endShutdownMinute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            endShutdownMinute.Name = "endShutdownMinute";
            endShutdownMinute.Size = new System.Drawing.Size(120, 23);
            endShutdownMinute.TabIndex = 5;
            // 
            // endShutdownHour
            // 
            endShutdownHour.Location = new System.Drawing.Point(245, 31);
            endShutdownHour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            endShutdownHour.Name = "endShutdownHour";
            endShutdownHour.Size = new System.Drawing.Size(120, 23);
            endShutdownHour.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Tomato;
            label4.Location = new System.Drawing.Point(8, 7);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(332, 17);
            label4.TabIndex = 3;
            label4.Text = "在此时段内开机后自动关闭电脑（必须设为开机启动才生效）";
            // 
            // startShutdownMinute
            // 
            startShutdownMinute.Location = new System.Drawing.Point(8, 60);
            startShutdownMinute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            startShutdownMinute.Name = "startShutdownMinute";
            startShutdownMinute.Size = new System.Drawing.Size(120, 23);
            startShutdownMinute.TabIndex = 1;
            // 
            // startShutdownHour
            // 
            startShutdownHour.Location = new System.Drawing.Point(8, 31);
            startShutdownHour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            startShutdownHour.Name = "startShutdownHour";
            startShutdownHour.Size = new System.Drawing.Size(120, 23);
            startShutdownHour.TabIndex = 0;
            // 
            // appProtect
            // 
            appProtect.Controls.Add(enableButton);
            appProtect.Controls.Add(stopCheckBox);
            appProtect.Controls.Add(unlockPasswordRemoveButton);
            appProtect.Controls.Add(removeBootButton);
            appProtect.Controls.Add(addBootButton);
            appProtect.Controls.Add(unlockPasswordSetButton);
            appProtect.Controls.Add(label2);
            appProtect.Controls.Add(unlockPasswordBox);
            appProtect.Controls.Add(label1);
            appProtect.Location = new System.Drawing.Point(4, 26);
            appProtect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            appProtect.Name = "appProtect";
            appProtect.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            appProtect.Size = new System.Drawing.Size(614, 352);
            appProtect.TabIndex = 3;
            appProtect.Text = "程序保护";
            appProtect.UseVisualStyleBackColor = true;
            // 
            // enableButton
            // 
            enableButton.Location = new System.Drawing.Point(346, 283);
            enableButton.Name = "enableButton";
            enableButton.Size = new System.Drawing.Size(260, 61);
            enableButton.TabIndex = 12;
            enableButton.Text = "修改不可用设置";
            enableButton.UseVisualStyleBackColor = true;
            enableButton.Click += EnableButton_Click;
            // 
            // stopCheckBox
            // 
            stopCheckBox.AutoSize = true;
            stopCheckBox.Location = new System.Drawing.Point(5, 76);
            stopCheckBox.Name = "stopCheckBox";
            stopCheckBox.Size = new System.Drawing.Size(274, 21);
            stopCheckBox.TabIndex = 11;
            stopCheckBox.Text = "修改设置前，要求等待1分钟（与管理码并存）";
            stopCheckBox.UseVisualStyleBackColor = true;
            stopCheckBox.CheckedChanged += StopCheckBox_CheckedChanged;
            // 
            // unlockPasswordRemoveButton
            // 
            unlockPasswordRemoveButton.Location = new System.Drawing.Point(102, 34);
            unlockPasswordRemoveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            unlockPasswordRemoveButton.Name = "unlockPasswordRemoveButton";
            unlockPasswordRemoveButton.Size = new System.Drawing.Size(93, 37);
            unlockPasswordRemoveButton.TabIndex = 10;
            unlockPasswordRemoveButton.Text = "移除";
            unlockPasswordRemoveButton.UseVisualStyleBackColor = true;
            unlockPasswordRemoveButton.Click += UnlockPasswordRemoveButton_Click;
            // 
            // removeBootButton
            // 
            removeBootButton.Location = new System.Drawing.Point(177, 283);
            removeBootButton.Name = "removeBootButton";
            removeBootButton.Size = new System.Drawing.Size(163, 61);
            removeBootButton.TabIndex = 9;
            removeBootButton.Text = "移除开机启动";
            removeBootButton.UseVisualStyleBackColor = true;
            removeBootButton.Click += RemoveBootButton_Click;
            // 
            // addBootButton
            // 
            addBootButton.Location = new System.Drawing.Point(8, 283);
            addBootButton.Name = "addBootButton";
            addBootButton.Size = new System.Drawing.Size(163, 61);
            addBootButton.TabIndex = 8;
            addBootButton.Text = "添加开机启动";
            addBootButton.UseVisualStyleBackColor = true;
            addBootButton.Click += AddBootButton_Click;
            // 
            // unlockPasswordSetButton
            // 
            unlockPasswordSetButton.Location = new System.Drawing.Point(5, 33);
            unlockPasswordSetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            unlockPasswordSetButton.Name = "unlockPasswordSetButton";
            unlockPasswordSetButton.Size = new System.Drawing.Size(93, 37);
            unlockPasswordSetButton.TabIndex = 7;
            unlockPasswordSetButton.Text = "设置";
            unlockPasswordSetButton.UseVisualStyleBackColor = true;
            unlockPasswordSetButton.Click += UnloackPasswordSetButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(153, 8);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(404, 17);
            label2.TabIndex = 6;
            label2.Text = "设置管理码后，在屏保时可以凭管理码解锁。且退出程序需要输入管理码。";
            // 
            // unlockPasswordBox
            // 
            unlockPasswordBox.Location = new System.Drawing.Point(51, 5);
            unlockPasswordBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            unlockPasswordBox.Name = "unlockPasswordBox";
            unlockPasswordBox.Size = new System.Drawing.Size(98, 23);
            unlockPasswordBox.TabIndex = 5;
            unlockPasswordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 8);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 17);
            label1.TabIndex = 4;
            label1.Text = "管理码";
            // 
            // data
            // 
            data.Controls.Add(dataGridView);
            data.Location = new System.Drawing.Point(4, 26);
            data.Name = "data";
            data.Size = new System.Drawing.Size(614, 352);
            data.TabIndex = 5;
            data.Text = "数据分析";
            data.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { timeColumn, nameColumn });
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new System.Drawing.Size(614, 352);
            dataGridView.TabIndex = 0;
            // 
            // timeColumn
            // 
            timeColumn.HeaderText = "时间";
            timeColumn.Name = "timeColumn";
            timeColumn.ReadOnly = true;
            timeColumn.Width = 415;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "名称";
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            nameColumn.Width = 153;
            // 
            // progress
            // 
            progress.Controls.Add(goalLabel);
            progress.Controls.Add(encourageLabel);
            progress.Controls.Add(progressLabel);
            progress.Controls.Add(levelLabel);
            progress.Controls.Add(progressBar);
            progress.Location = new System.Drawing.Point(4, 26);
            progress.Name = "progress";
            progress.Size = new System.Drawing.Size(614, 352);
            progress.TabIndex = 7;
            progress.Text = "我的进度";
            progress.UseVisualStyleBackColor = true;
            // 
            // goalLabel
            // 
            goalLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            goalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            goalLabel.Location = new System.Drawing.Point(155, 0);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new System.Drawing.Size(305, 139);
            goalLabel.TabIndex = 5;
            goalLabel.Text = "目标文本";
            goalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // encourageLabel
            // 
            encourageLabel.ForeColor = System.Drawing.Color.Red;
            encourageLabel.Location = new System.Drawing.Point(155, 94);
            encourageLabel.Name = "encourageLabel";
            encourageLabel.Size = new System.Drawing.Size(305, 119);
            encourageLabel.TabIndex = 4;
            encourageLabel.Text = "听说只要专注等级达到100级，能力就会有巨大的成长！";
            encourageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new System.Drawing.Point(210, 270);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new System.Drawing.Size(183, 17);
            progressLabel.TabIndex = 3;
            progressLabel.Text = "进入下一级还需要专注0.000小时";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(253, 213);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(113, 17);
            levelLabel.TabIndex = 2;
            levelLabel.Text = "当前等级：0/100级";
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(124, 233);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(358, 34);
            progressBar.TabIndex = 0;
            // 
            // setting
            // 
            setting.Controls.Add(versionLabel);
            setting.Controls.Add(goalChangeButton);
            setting.Controls.Add(dataDirButton);
            setting.Controls.Add(label13);
            setting.Controls.Add(autoResetBox);
            setting.Controls.Add(helpLinkLabel);
            setting.Controls.Add(giteeLinkLabel);
            setting.Controls.Add(githubLinkLabel);
            setting.Controls.Add(linkLabel1);
            setting.Controls.Add(label3);
            setting.Location = new System.Drawing.Point(4, 26);
            setting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            setting.Name = "setting";
            setting.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            setting.Size = new System.Drawing.Size(614, 352);
            setting.TabIndex = 2;
            setting.Text = "设置";
            setting.UseVisualStyleBackColor = true;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(49, 329);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(71, 17);
            versionLabel.TabIndex = 12;
            versionLabel.Text = "版本：0.0.0";
            // 
            // goalChangeButton
            // 
            goalChangeButton.Location = new System.Drawing.Point(484, 109);
            goalChangeButton.Name = "goalChangeButton";
            goalChangeButton.Size = new System.Drawing.Size(117, 53);
            goalChangeButton.TabIndex = 11;
            goalChangeButton.Text = "设置/切换目标";
            goalChangeButton.UseVisualStyleBackColor = true;
            goalChangeButton.Click += GoalChangeButton_Click;
            // 
            // dataDirButton
            // 
            dataDirButton.Location = new System.Drawing.Point(484, 49);
            dataDirButton.Name = "dataDirButton";
            dataDirButton.Size = new System.Drawing.Size(117, 54);
            dataDirButton.TabIndex = 10;
            dataDirButton.Text = "打开数据文件夹";
            dataDirButton.UseVisualStyleBackColor = true;
            dataDirButton.Click += DataDirButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = System.Drawing.Color.LightCoral;
            label13.Location = new System.Drawing.Point(485, 29);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(116, 17);
            label13.TabIndex = 9;
            label13.Text = "你的设置将自动保存";
            // 
            // autoResetBox
            // 
            autoResetBox.AutoSize = true;
            autoResetBox.Location = new System.Drawing.Point(8, 6);
            autoResetBox.Name = "autoResetBox";
            autoResetBox.Size = new System.Drawing.Size(255, 21);
            autoResetBox.TabIndex = 8;
            autoResetBox.Text = "新的一天开始时，自动重置进程计时的时间";
            autoResetBox.UseVisualStyleBackColor = true;
            autoResetBox.CheckedChanged += SettingsChanged;
            // 
            // helpLinkLabel
            // 
            helpLinkLabel.AutoSize = true;
            helpLinkLabel.Location = new System.Drawing.Point(577, 332);
            helpLinkLabel.Name = "helpLinkLabel";
            helpLinkLabel.Size = new System.Drawing.Size(32, 17);
            helpLinkLabel.TabIndex = 7;
            helpLinkLabel.TabStop = true;
            helpLinkLabel.Text = "帮助";
            helpLinkLabel.LinkClicked += HelpLinkLabel_LinkClicked;
            // 
            // giteeLinkLabel
            // 
            giteeLinkLabel.AutoSize = true;
            giteeLinkLabel.Location = new System.Drawing.Point(5, 330);
            giteeLinkLabel.Name = "giteeLinkLabel";
            giteeLinkLabel.Size = new System.Drawing.Size(37, 17);
            giteeLinkLabel.TabIndex = 6;
            giteeLinkLabel.TabStop = true;
            giteeLinkLabel.Text = "gitee";
            giteeLinkLabel.LinkClicked += GiteeLinkLabel_LinkClicked;
            // 
            // githubLinkLabel
            // 
            githubLinkLabel.AutoSize = true;
            githubLinkLabel.Location = new System.Drawing.Point(5, 305);
            githubLinkLabel.Name = "githubLinkLabel";
            githubLinkLabel.Size = new System.Drawing.Size(45, 17);
            githubLinkLabel.TabIndex = 5;
            githubLinkLabel.TabStop = true;
            githubLinkLabel.Text = "github";
            githubLinkLabel.LinkClicked += GithubLinkLabel_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(578, 3);
            linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(32, 17);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "链接";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(485, 3);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 17);
            label3.TabIndex = 0;
            label3.Text = "图标来自icon8!";
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = iconContextMenuStrip;
            notifyIcon.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Computer Time Control";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            // 
            // iconContextMenuStrip
            // 
            iconContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            iconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ExitToolStripMenuItem });
            iconContextMenuStrip.Name = "contextMenuStrip";
            iconContextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            ExitToolStripMenuItem.Text = "退出";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // processMonitorTimer
            // 
            processMonitorTimer.Interval = 1000;
            processMonitorTimer.Tick += ProcessMonitorTimer_Tick;
            // 
            // fileSaveTimer
            // 
            fileSaveTimer.Interval = 300000;
            fileSaveTimer.Tick += FileSaveTimer_Tick;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(622, 382);
            Controls.Add(controlTab);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ControlPanel";
            Text = "时间管理";
            FormClosing += ControlPanel_FormClosing;
            Shown += ControlPanel_Shown;
            ((System.ComponentModel.ISupportInitialize)timeBox).EndInit();
            controlTab.ResumeLayout(false);
            focus.ResumeLayout(false);
            focus.PerformLayout();
            deepFocus.ResumeLayout(false);
            deepFocus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deepTimeInput).EndInit();
            title.ResumeLayout(false);
            title.PerformLayout();
            processMonitor.ResumeLayout(false);
            processMonitor.PerformLayout();
            shutdown.ResumeLayout(false);
            shutdown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)endShutdownMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)endShutdownHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)startShutdownMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)startShutdownHour).EndInit();
            appProtect.ResumeLayout(false);
            appProtect.PerformLayout();
            data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            progress.ResumeLayout(false);
            progress.PerformLayout();
            setting.ResumeLayout(false);
            setting.PerformLayout();
            iconContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.TabControl controlTab;
        private System.Windows.Forms.TabPage focus;
        private System.Windows.Forms.TabPage processMonitor;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip iconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TabPage setting;
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
        private System.Windows.Forms.TabPage shutdown;
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
        private System.Windows.Forms.TabPage data;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage deepFocus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown deepTimeInput;
        private System.Windows.Forms.Button deepStartButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.TabPage progress;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label encourageLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox autoResetBox;
        private System.Windows.Forms.Button dataDirButton;
        private System.Windows.Forms.Button goalChangeButton;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TabPage title;
        private System.Windows.Forms.ListBox titleListBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button removeTitleButton;
        private System.Windows.Forms.Button addTitleButton;
        private System.Windows.Forms.CheckBox stopCheckBox;
        private System.Windows.Forms.Button enableButton;
    }
}