
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
            this.startButton = new System.Windows.Forms.Button();
            this.timeChooser = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(294, 282);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 71);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "立即开始！（分钟）";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeChooser
            // 
            this.timeChooser.Location = new System.Drawing.Point(294, 152);
            this.timeChooser.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.timeChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeChooser.Name = "timeChooser";
            this.timeChooser.Size = new System.Drawing.Size(164, 25);
            this.timeChooser.TabIndex = 1;
            this.timeChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(190, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "为了让你专注于要做的事情上，任务管理器将被禁止！";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeChooser);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            ((System.ComponentModel.ISupportInitialize)(this.timeChooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown timeChooser;
        private System.Windows.Forms.Label label1;
    }
}