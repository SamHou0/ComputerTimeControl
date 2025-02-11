﻿
namespace TimeControl.Windows
{
    partial class Lock
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.unlockLabel = new System.Windows.Forms.Label();
            this.unlockPasswordBox = new System.Windows.Forms.TextBox();
            this.unlockButton = new System.Windows.Forms.Button();
            this.toolBoxButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "已锁定！";
            this.label1.UseWaitCursor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(66, 259);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(490, 52);
            this.progressBar.TabIndex = 1;
            this.progressBar.UseWaitCursor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // unlockLabel
            // 
            this.unlockLabel.AutoSize = true;
            this.unlockLabel.Location = new System.Drawing.Point(227, 240);
            this.unlockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unlockLabel.Name = "unlockLabel";
            this.unlockLabel.Size = new System.Drawing.Size(164, 17);
            this.unlockLabel.TabIndex = 2;
            this.unlockLabel.Text = "时间到！关闭窗口退出屏保。";
            this.unlockLabel.UseWaitCursor = true;
            this.unlockLabel.Visible = false;
            // 
            // unlockPasswordBox
            // 
            this.unlockPasswordBox.Location = new System.Drawing.Point(9, 10);
            this.unlockPasswordBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.unlockPasswordBox.Name = "unlockPasswordBox";
            this.unlockPasswordBox.Size = new System.Drawing.Size(98, 23);
            this.unlockPasswordBox.TabIndex = 3;
            this.unlockPasswordBox.UseSystemPasswordChar = true;
            this.unlockPasswordBox.UseWaitCursor = true;
            // 
            // unlockButton
            // 
            this.unlockButton.Location = new System.Drawing.Point(112, 11);
            this.unlockButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(120, 25);
            this.unlockButton.TabIndex = 4;
            this.unlockButton.Text = "使用该管理码解锁";
            this.unlockButton.UseVisualStyleBackColor = true;
            this.unlockButton.UseWaitCursor = true;
            this.unlockButton.Click += new System.EventHandler(this.UnlockButton_Click);
            // 
            // toolBoxButton
            // 
            this.toolBoxButton.Location = new System.Drawing.Point(458, 10);
            this.toolBoxButton.Name = "toolBoxButton";
            this.toolBoxButton.Size = new System.Drawing.Size(140, 80);
            this.toolBoxButton.TabIndex = 5;
            this.toolBoxButton.Text = "打开百宝箱";
            this.toolBoxButton.UseVisualStyleBackColor = true;
            this.toolBoxButton.UseWaitCursor = true;
            this.toolBoxButton.Click += new System.EventHandler(this.ToolBoxButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(242, 190);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(124, 50);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "0:0:0/0:0:0";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLabel.UseWaitCursor = true;
            // 
            // changeButton
            // 
            this.changeButton.ForeColor = System.Drawing.Color.Red;
            this.changeButton.Location = new System.Drawing.Point(9, 39);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(223, 51);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "切换为深度专注";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // Lock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 349);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.toolBoxButton);
            this.Controls.Add(this.unlockButton);
            this.Controls.Add(this.unlockPasswordBox);
            this.Controls.Add(this.unlockLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 388);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(626, 388);
            this.Name = "Lock";
            this.Text = "屏保";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lock_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label unlockLabel;
        private System.Windows.Forms.TextBox unlockPasswordBox;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.Button toolBoxButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button changeButton;
    }
}