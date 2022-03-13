namespace TimeControl
{
    partial class LimitWarningWindow
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(12, 9);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(523, 89);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "应用 即将达到时间限制，请保存所有工作，然后提前关闭进程";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(109, 126);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(305, 68);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "立即强制关闭（请确保已保存任何文件）";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LimitWarningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 224);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.displayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LimitWarningWindow";
            this.Text = "应用即将达到时间限制";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button closeButton;
    }
}