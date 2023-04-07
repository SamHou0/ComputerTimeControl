namespace TimeControl.Windows
{
    partial class Planner
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
            taskListBox = new System.Windows.Forms.ListBox();
            taskNameTextBox = new System.Windows.Forms.TextBox();
            addButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            deepFocusBox = new System.Windows.Forms.CheckBox();
            focusBox = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            timeBox = new System.Windows.Forms.NumericUpDown();
            deleteButton = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeBox).BeginInit();
            SuspendLayout();
            // 
            // taskListBox
            // 
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 17;
            taskListBox.Location = new System.Drawing.Point(12, 12);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new System.Drawing.Size(421, 429);
            taskListBox.TabIndex = 0;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new System.Drawing.Point(506, 89);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new System.Drawing.Size(224, 23);
            taskNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new System.Drawing.Point(537, 233);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(170, 87);
            addButton.TabIndex = 2;
            addButton.Text = "添加";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(592, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 17);
            label1.TabIndex = 3;
            label1.Text = "任务名称";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deepFocusBox);
            groupBox1.Controls.Add(focusBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(timeBox);
            groupBox1.Location = new System.Drawing.Point(475, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(298, 109);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "计划设定";
            // 
            // deepFocusBox
            // 
            deepFocusBox.AutoSize = true;
            deepFocusBox.Location = new System.Drawing.Point(50, 78);
            deepFocusBox.Name = "deepFocusBox";
            deepFocusBox.Size = new System.Drawing.Size(243, 21);
            deepFocusBox.TabIndex = 3;
            deepFocusBox.Text = "屏保设为深度专注（必须勾选上方选项）";
            deepFocusBox.UseVisualStyleBackColor = true;
            // 
            // focusBox
            // 
            focusBox.AutoSize = true;
            focusBox.Location = new System.Drawing.Point(31, 51);
            focusBox.Name = "focusBox";
            focusBox.Size = new System.Drawing.Size(123, 21);
            focusBox.TabIndex = 2;
            focusBox.Text = "自动启动专注屏保";
            focusBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(187, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 17);
            label2.TabIndex = 1;
            label2.Text = "预估时间（分）";
            // 
            // timeBox
            // 
            timeBox.Location = new System.Drawing.Point(31, 22);
            timeBox.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            timeBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            timeBox.Name = "timeBox";
            timeBox.Size = new System.Drawing.Size(120, 23);
            timeBox.TabIndex = 0;
            timeBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(537, 335);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(170, 87);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "删除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // Planner
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(taskNameTextBox);
            Controls.Add(taskListBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Planner";
            ShowIcon = false;
            Text = "计划编辑器";
            TopMost = true;
            FormClosed += Planner_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.CheckBox deepFocusBox;
        private System.Windows.Forms.CheckBox focusBox;
        private System.Windows.Forms.Button deleteButton;
    }
}