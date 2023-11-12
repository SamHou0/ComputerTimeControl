namespace TimeControl.Windows
{
    partial class BootStopWindow
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
            components = new System.ComponentModel.Container();
            bootTimer = new System.Windows.Forms.Timer(components);
            infoLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // bootTimer
            // 
            bootTimer.Enabled = true;
            bootTimer.Interval = 1000;
            bootTimer.Tick += BootTimer_Tick;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            infoLabel.Location = new System.Drawing.Point(374, 180);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(47, 35);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "60";
            // 
            // BootStopWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(infoLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BootStopWindow";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "BootStopWindow";
            TopMost = true;
            FormClosing += BootStopWindow_FormClosing;
            Shown += BootStopWindow_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer bootTimer;
        private System.Windows.Forms.Label infoLabel;
    }
}