namespace TimeControl.Windows
{
    partial class GoalChangeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalChangeWindow));
            this.goalListBox = new System.Windows.Forms.ListBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.goalTextBox = new System.Windows.Forms.TextBox();
            this.goalLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goalListBox
            // 
            this.goalListBox.FormattingEnabled = true;
            this.goalListBox.ItemHeight = 17;
            this.goalListBox.Location = new System.Drawing.Point(12, 12);
            this.goalListBox.Name = "goalListBox";
            this.goalListBox.Size = new System.Drawing.Size(267, 310);
            this.goalListBox.TabIndex = 0;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(285, 207);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(198, 115);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "切换";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(285, 41);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 113);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // goalTextBox
            // 
            this.goalTextBox.Location = new System.Drawing.Point(285, 12);
            this.goalTextBox.Name = "goalTextBox";
            this.goalTextBox.Size = new System.Drawing.Size(198, 23);
            this.goalTextBox.TabIndex = 3;
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Location = new System.Drawing.Point(296, 172);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(44, 17);
            this.goalLabel.TabIndex = 4;
            this.goalLabel.Text = "当前：";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(394, 41);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 113);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // GoalChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 332);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.goalTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.goalListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoalChangeWindow";
            this.Text = "切换目标";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoalChangeWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GoalChangeWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox goalListBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox goalTextBox;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}