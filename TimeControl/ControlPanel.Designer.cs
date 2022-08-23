
namespace TimeControl
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
            this.processMonitor = new System.Windows.Forms.TabPage();
            this.resetButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.autoRefreshBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.appAddButton = new System.Windows.Forms.Button();
            this.usageBox = new System.Windows.Forms.ListBox();
            this.about = new System.Windows.Forms.TabPage();
            this.giteeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.authorButton = new System.Windows.Forms.Button();
            this.coinLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.removeBootButton = new System.Windows.Forms.Button();
            this.addBootButton = new System.Windows.Forms.Button();
            this.unlockPasswordSetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unlockPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processMonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.fileSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.helpLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            this.controlTab.SuspendLayout();
            this.startNow.SuspendLayout();
            this.processMonitor.SuspendLayout();
            this.about.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
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
            this.timeBox.Location = new System.Drawing.Point(252, 139);
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
            this.controlTab.Controls.Add(this.processMonitor);
            this.controlTab.Controls.Add(this.about);
            this.controlTab.Controls.Add(this.tabPage1);
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
            this.label5.Location = new System.Drawing.Point(266, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "白名单应用路径";
            // 
            // whiteProcessBox
            // 
            this.whiteProcessBox.Location = new System.Drawing.Point(161, 110);
            this.whiteProcessBox.Name = "whiteProcessBox";
            this.whiteProcessBox.Size = new System.Drawing.Size(304, 23);
            this.whiteProcessBox.TabIndex = 2;
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
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
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
            // about
            // 
            this.about.Controls.Add(this.helpLinkLabel);
            this.about.Controls.Add(this.giteeLinkLabel);
            this.about.Controls.Add(this.githubLinkLabel);
            this.about.Controls.Add(this.authorButton);
            this.about.Controls.Add(this.coinLabel);
            this.about.Controls.Add(this.label4);
            this.about.Controls.Add(this.linkLabel1);
            this.about.Controls.Add(this.label3);
            this.about.Location = new System.Drawing.Point(4, 26);
            this.about.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.about.Name = "about";
            this.about.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.about.Size = new System.Drawing.Size(614, 352);
            this.about.TabIndex = 2;
            this.about.Text = "关于";
            this.about.UseVisualStyleBackColor = true;
            // 
            // giteeLinkLabel
            // 
            this.giteeLinkLabel.AutoSize = true;
            this.giteeLinkLabel.Location = new System.Drawing.Point(102, 330);
            this.giteeLinkLabel.Name = "giteeLinkLabel";
            this.giteeLinkLabel.Size = new System.Drawing.Size(37, 17);
            this.giteeLinkLabel.TabIndex = 6;
            this.giteeLinkLabel.TabStop = true;
            this.giteeLinkLabel.Text = "gitee";
            this.giteeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.giteeLinkLabel_LinkClicked);
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Location = new System.Drawing.Point(102, 305);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(45, 17);
            this.githubLinkLabel.TabIndex = 5;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "github";
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLinkLabel_LinkClicked);
            // 
            // authorButton
            // 
            this.authorButton.Location = new System.Drawing.Point(5, 305);
            this.authorButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(92, 46);
            this.authorButton.TabIndex = 4;
            this.authorButton.Text = "作者的话";
            this.authorButton.UseVisualStyleBackColor = true;
            this.authorButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Location = new System.Drawing.Point(40, 3);
            this.coinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(15, 17);
            this.coinLabel.TabIndex = 3;
            this.coinLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "金币";
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.removeBootButton);
            this.tabPage1.Controls.Add(this.addBootButton);
            this.tabPage1.Controls.Add(this.unlockPasswordSetButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.unlockPasswordBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(614, 352);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "程序保护";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // removeBootButton
            // 
            this.removeBootButton.Location = new System.Drawing.Point(177, 283);
            this.removeBootButton.Name = "removeBootButton";
            this.removeBootButton.Size = new System.Drawing.Size(163, 61);
            this.removeBootButton.TabIndex = 9;
            this.removeBootButton.Text = "移除开机启动";
            this.removeBootButton.UseVisualStyleBackColor = true;
            this.removeBootButton.Click += new System.EventHandler(this.removeBootButton_Click);
            // 
            // addBootButton
            // 
            this.addBootButton.Location = new System.Drawing.Point(8, 283);
            this.addBootButton.Name = "addBootButton";
            this.addBootButton.Size = new System.Drawing.Size(163, 61);
            this.addBootButton.TabIndex = 8;
            this.addBootButton.Text = "添加开机启动";
            this.addBootButton.UseVisualStyleBackColor = true;
            this.addBootButton.Click += new System.EventHandler(this.addBootButton_Click);
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
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Computer Time Control";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 26);
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
            this.fileSaveTimer.Tick += new System.EventHandler(this.fileSaveTimer_Tick);
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
            this.helpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLinkLabel_LinkClicked);
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
            this.Text = "ControlPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanel_FormClosing);
            this.Shown += new System.EventHandler(this.ControlPanel_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            this.controlTab.ResumeLayout(false);
            this.startNow.ResumeLayout(false);
            this.startNow.PerformLayout();
            this.processMonitor.ResumeLayout(false);
            this.processMonitor.PerformLayout();
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.TabControl controlTab;
        private System.Windows.Forms.TabPage startNow;
        private System.Windows.Forms.TabPage processMonitor;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox usageBox;
        private System.Windows.Forms.Button appAddButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Timer processMonitorTimer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button unlockPasswordSetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unlockPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.CheckBox autoRefreshBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.Timer fileSaveTimer;
        private System.Windows.Forms.LinkLabel giteeLinkLabel;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.TextBox whiteProcessBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBootButton;
        private System.Windows.Forms.Button removeBootButton;
        private System.Windows.Forms.LinkLabel helpLinkLabel;
    }
}