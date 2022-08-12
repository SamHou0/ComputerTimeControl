namespace TimeControl
{
    partial class TimeInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.timeSecondBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timeMinuteBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeSecondBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinuteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入进程限时，1则表示不限制时间（秒）,0表示禁用";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(108, 119);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(86, 45);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // timeSecondBox
            // 
            this.timeSecondBox.Location = new System.Drawing.Point(161, 74);
            this.timeSecondBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.timeSecondBox.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.timeSecondBox.Name = "timeSecondBox";
            this.timeSecondBox.Size = new System.Drawing.Size(100, 23);
            this.timeSecondBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "分钟";
            // 
            // timeMinuteBox
            // 
            this.timeMinuteBox.Location = new System.Drawing.Point(11, 74);
            this.timeMinuteBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.timeMinuteBox.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.timeMinuteBox.Name = "timeMinuteBox";
            this.timeMinuteBox.Size = new System.Drawing.Size(108, 23);
            this.timeMinuteBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "秒";
            // 
            // TimeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 185);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeMinuteBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeSecondBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TimeInput";
            this.Text = "TimeInput";
            ((System.ComponentModel.ISupportInitialize)(this.timeSecondBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinuteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown timeSecondBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timeMinuteBox;
        private System.Windows.Forms.Label label3;
    }
}