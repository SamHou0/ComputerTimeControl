
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
            this.processMonitor = new System.Windows.Forms.TabPage();
            this.resetButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.autoRefreshBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.processNameBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.appAddButton = new System.Windows.Forms.Button();
            this.usageBox = new System.Windows.Forms.ListBox();
            this.about = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.unloackPasswordSetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.unlockPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processMonitorTimer = new System.Windows.Forms.Timer(this.components);
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
            this.startButton.Location = new System.Drawing.Point(307, 257);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(187, 96);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "启动屏保（分）";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(324, 163);
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
            this.timeBox.Size = new System.Drawing.Size(150, 27);
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
            this.controlTab.Location = new System.Drawing.Point(2, 1);
            this.controlTab.Name = "controlTab";
            this.controlTab.SelectedIndex = 0;
            this.controlTab.Size = new System.Drawing.Size(802, 449);
            this.controlTab.TabIndex = 2;
            // 
            // startNow
            // 
            this.startNow.Controls.Add(this.startButton);
            this.startNow.Controls.Add(this.timeBox);
            this.startNow.Location = new System.Drawing.Point(4, 29);
            this.startNow.Name = "startNow";
            this.startNow.Padding = new System.Windows.Forms.Padding(3);
            this.startNow.Size = new System.Drawing.Size(794, 416);
            this.startNow.TabIndex = 0;
            this.startNow.Text = "专注屏保";
            this.startNow.UseVisualStyleBackColor = true;
            // 
            // processMonitor
            // 
            this.processMonitor.Controls.Add(this.resetButton);
            this.processMonitor.Controls.Add(this.clearButton);
            this.processMonitor.Controls.Add(this.autoRefreshBox);
            this.processMonitor.Controls.Add(this.refreshButton);
            this.processMonitor.Controls.Add(this.processNameBox);
            this.processMonitor.Controls.Add(this.removeButton);
            this.processMonitor.Controls.Add(this.appAddButton);
            this.processMonitor.Controls.Add(this.usageBox);
            this.processMonitor.Location = new System.Drawing.Point(4, 29);
            this.processMonitor.Name = "processMonitor";
            this.processMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.processMonitor.Size = new System.Drawing.Size(794, 416);
            this.processMonitor.TabIndex = 1;
            this.processMonitor.Text = "进程计时";
            this.processMonitor.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(528, 26);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(143, 46);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "重置进程时间";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(528, 318);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(143, 45);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "删除所有监控";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // autoRefreshBox
            // 
            this.autoRefreshBox.AutoSize = true;
            this.autoRefreshBox.Location = new System.Drawing.Point(557, 78);
            this.autoRefreshBox.Name = "autoRefreshBox";
            this.autoRefreshBox.Size = new System.Drawing.Size(91, 24);
            this.autoRefreshBox.TabIndex = 6;
            this.autoRefreshBox.Text = "自动刷新";
            this.autoRefreshBox.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(528, 156);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(143, 51);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "刷新";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // processNameBox
            // 
            this.processNameBox.Location = new System.Drawing.Point(528, 213);
            this.processNameBox.Name = "processNameBox";
            this.processNameBox.Size = new System.Drawing.Size(143, 27);
            this.processNameBox.TabIndex = 4;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(528, 108);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(143, 42);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "删除所选监控";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // appAddButton
            // 
            this.appAddButton.Location = new System.Drawing.Point(528, 246);
            this.appAddButton.Name = "appAddButton";
            this.appAddButton.Size = new System.Drawing.Size(143, 66);
            this.appAddButton.TabIndex = 1;
            this.appAddButton.Text = "根据名称添加";
            this.appAddButton.UseVisualStyleBackColor = true;
            this.appAddButton.Click += new System.EventHandler(this.AppAddButton_Click);
            // 
            // usageBox
            // 
            this.usageBox.FormattingEnabled = true;
            this.usageBox.ItemHeight = 20;
            this.usageBox.Location = new System.Drawing.Point(6, 6);
            this.usageBox.Name = "usageBox";
            this.usageBox.Size = new System.Drawing.Size(424, 404);
            this.usageBox.TabIndex = 0;
            // 
            // about
            // 
            this.about.Controls.Add(this.linkLabel1);
            this.about.Controls.Add(this.label3);
            this.about.Location = new System.Drawing.Point(4, 29);
            this.about.Name = "about";
            this.about.Padding = new System.Windows.Forms.Padding(3);
            this.about.Size = new System.Drawing.Size(794, 416);
            this.about.TabIndex = 2;
            this.about.Text = "关于";
            this.about.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(355, 86);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "链接";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "图标来自icon8!";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.unloackPasswordSetButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.unlockPasswordBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 416);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "程序保护";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // unloackPasswordSetButton
            // 
            this.unloackPasswordSetButton.Location = new System.Drawing.Point(6, 39);
            this.unloackPasswordSetButton.Name = "unloackPasswordSetButton";
            this.unloackPasswordSetButton.Size = new System.Drawing.Size(120, 44);
            this.unloackPasswordSetButton.TabIndex = 7;
            this.unloackPasswordSetButton.Text = "设置";
            this.unloackPasswordSetButton.UseVisualStyleBackColor = true;
            this.unloackPasswordSetButton.Click += new System.EventHandler(this.UnloackPasswordSetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "设置管理码后，在屏保时可以凭管理码解锁。且退出程序需要输入管理码。";
            // 
            // unlockPasswordBox
            // 
            this.unlockPasswordBox.Location = new System.Drawing.Point(66, 6);
            this.unlockPasswordBox.Name = "unlockPasswordBox";
            this.unlockPasswordBox.Size = new System.Drawing.Size(125, 27);
            this.unlockPasswordBox.TabIndex = 5;
            this.unlockPasswordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
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
            this.contextMenuStrip.Size = new System.Drawing.Size(109, 28);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // processMonitorTimer
            // 
            this.processMonitorTimer.Interval = 1000;
            this.processMonitorTimer.Tick += new System.EventHandler(this.ProcessMonitorTimer_Tick);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanel_FormClosing);
            this.Shown += new System.EventHandler(this.ControlPanel_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            this.controlTab.ResumeLayout(false);
            this.startNow.ResumeLayout(false);
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
        private System.Windows.Forms.Button unloackPasswordSetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unlockPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox processNameBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.CheckBox autoRefreshBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resetButton;
    }
}