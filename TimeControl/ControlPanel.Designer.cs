
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unlockPasswordBox = new System.Windows.Forms.TextBox();
            this.processMonitor = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.appAddButton = new System.Windows.Forms.Button();
            this.usageBox = new System.Windows.Forms.ListBox();
            this.about = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundProcessMonitor = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            this.controlTab.SuspendLayout();
            this.startNow.SuspendLayout();
            this.processMonitor.SuspendLayout();
            this.about.SuspendLayout();
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
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
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
            this.controlTab.Location = new System.Drawing.Point(2, 1);
            this.controlTab.Name = "controlTab";
            this.controlTab.SelectedIndex = 0;
            this.controlTab.Size = new System.Drawing.Size(802, 449);
            this.controlTab.TabIndex = 2;
            // 
            // startNow
            // 
            this.startNow.Controls.Add(this.label2);
            this.startNow.Controls.Add(this.label1);
            this.startNow.Controls.Add(this.unlockPasswordBox);
            this.startNow.Controls.Add(this.startButton);
            this.startNow.Controls.Add(this.timeBox);
            this.startNow.Location = new System.Drawing.Point(4, 29);
            this.startNow.Name = "startNow";
            this.startNow.Padding = new System.Windows.Forms.Padding(3);
            this.startNow.Size = new System.Drawing.Size(794, 416);
            this.startNow.TabIndex = 0;
            this.startNow.Text = "立即启动";
            this.startNow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "设置管理码后，在屏保时可以凭管理码解锁。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "管理码";
            // 
            // unlockPasswordBox
            // 
            this.unlockPasswordBox.Location = new System.Drawing.Point(66, 6);
            this.unlockPasswordBox.Name = "unlockPasswordBox";
            this.unlockPasswordBox.Size = new System.Drawing.Size(125, 27);
            this.unlockPasswordBox.TabIndex = 2;
            this.unlockPasswordBox.UseSystemPasswordChar = true;
            // 
            // processMonitor
            // 
            this.processMonitor.Controls.Add(this.refreshButton);
            this.processMonitor.Controls.Add(this.removeButton);
            this.processMonitor.Controls.Add(this.appAddButton);
            this.processMonitor.Controls.Add(this.usageBox);
            this.processMonitor.Location = new System.Drawing.Point(4, 29);
            this.processMonitor.Name = "processMonitor";
            this.processMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.processMonitor.Size = new System.Drawing.Size(794, 416);
            this.processMonitor.TabIndex = 1;
            this.processMonitor.Text = "进程监测";
            this.processMonitor.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(528, 205);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(143, 47);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "刷新";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(528, 108);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(143, 42);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "删除所有监控";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // appAddButton
            // 
            this.appAddButton.Location = new System.Drawing.Point(528, 331);
            this.appAddButton.Name = "appAddButton";
            this.appAddButton.Size = new System.Drawing.Size(143, 57);
            this.appAddButton.TabIndex = 1;
            this.appAddButton.Text = "添加打开的窗口";
            this.appAddButton.UseVisualStyleBackColor = true;
            this.appAddButton.Click += new System.EventHandler(this.appAddButton_Click);
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
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Computer Time Control";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
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
            // backgroundProcessMonitor
            // 
            this.backgroundProcessMonitor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundProcessMonitor_DoWork);
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
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            this.controlTab.ResumeLayout(false);
            this.startNow.ResumeLayout(false);
            this.startNow.PerformLayout();
            this.processMonitor.ResumeLayout(false);
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.TabControl controlTab;
        private System.Windows.Forms.TabPage startNow;
        private System.Windows.Forms.TabPage processMonitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unlockPasswordBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundProcessMonitor;
        private System.Windows.Forms.ListBox usageBox;
        private System.Windows.Forms.Button appAddButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button refreshButton;
    }
}