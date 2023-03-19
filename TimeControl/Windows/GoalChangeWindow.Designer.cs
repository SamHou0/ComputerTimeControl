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
            goalListBox = new System.Windows.Forms.ListBox();
            changeButton = new System.Windows.Forms.Button();
            addButton = new System.Windows.Forms.Button();
            goalTextBox = new System.Windows.Forms.TextBox();
            goalLabel = new System.Windows.Forms.Label();
            deleteButton = new System.Windows.Forms.Button();
            editButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // goalListBox
            // 
            goalListBox.FormattingEnabled = true;
            goalListBox.ItemHeight = 17;
            goalListBox.Location = new System.Drawing.Point(12, 12);
            goalListBox.Name = "goalListBox";
            goalListBox.Size = new System.Drawing.Size(267, 310);
            goalListBox.TabIndex = 0;
            // 
            // changeButton
            // 
            changeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            changeButton.Location = new System.Drawing.Point(285, 256);
            changeButton.Name = "changeButton";
            changeButton.Size = new System.Drawing.Size(198, 66);
            changeButton.TabIndex = 1;
            changeButton.Text = "切换";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // addButton
            // 
            addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addButton.Location = new System.Drawing.Point(285, 41);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(89, 113);
            addButton.TabIndex = 2;
            addButton.Text = "添加";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // goalTextBox
            // 
            goalTextBox.Location = new System.Drawing.Point(285, 12);
            goalTextBox.Name = "goalTextBox";
            goalTextBox.Size = new System.Drawing.Size(198, 23);
            goalTextBox.TabIndex = 3;
            // 
            // goalLabel
            // 
            goalLabel.AutoSize = true;
            goalLabel.Location = new System.Drawing.Point(285, 157);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new System.Drawing.Size(44, 17);
            goalLabel.TabIndex = 4;
            goalLabel.Text = "当前：";
            // 
            // deleteButton
            // 
            deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deleteButton.Location = new System.Drawing.Point(394, 41);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(89, 113);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "删除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            editButton.Location = new System.Drawing.Point(285, 184);
            editButton.Name = "editButton";
            editButton.Size = new System.Drawing.Size(198, 66);
            editButton.TabIndex = 6;
            editButton.Text = "编辑";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // GoalChangeWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(518, 332);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(goalLabel);
            Controls.Add(goalTextBox);
            Controls.Add(addButton);
            Controls.Add(changeButton);
            Controls.Add(goalListBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GoalChangeWindow";
            Text = "切换目标";
            TopMost = true;
            FormClosing += GoalChangeWindow_FormClosing;
            FormClosed += GoalChangeWindow_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox goalListBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox goalTextBox;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}