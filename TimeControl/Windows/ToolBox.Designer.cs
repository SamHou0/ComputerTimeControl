namespace TimeControl.Windows
{
    partial class ToolBox
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
            this.whiteListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.noteLocationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // whiteListBox
            // 
            this.whiteListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.whiteListBox.FormattingEnabled = true;
            this.whiteListBox.ItemHeight = 17;
            this.whiteListBox.Location = new System.Drawing.Point(0, 0);
            this.whiteListBox.Name = "whiteListBox";
            this.whiteListBox.Size = new System.Drawing.Size(359, 450);
            this.whiteListBox.TabIndex = 0;
            this.whiteListBox.DoubleClick += new System.EventHandler(this.whiteListBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "左侧双击打开白名单，下面的文本框可以用来记些东西";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(672, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(116, 17);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "当前时间：00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(365, 52);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.noteTextBox.Size = new System.Drawing.Size(423, 398);
            this.noteTextBox.TabIndex = 3;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // noteLocationLabel
            // 
            this.noteLocationLabel.AutoSize = true;
            this.noteLocationLabel.Location = new System.Drawing.Point(365, 32);
            this.noteLocationLabel.Name = "noteLocationLabel";
            this.noteLocationLabel.Size = new System.Drawing.Size(68, 17);
            this.noteLocationLabel.TabIndex = 4;
            this.noteLocationLabel.Text = "文件位置：";
            // 
            // ToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteLocationLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.whiteListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ToolBox";
            this.Text = "工具箱";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox whiteListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label noteLocationLabel;
    }
}