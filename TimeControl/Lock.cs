using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TimeControl
{
    public partial class Lock : Form
    {
        private bool usePassword = true;
        private string unlockPasswordHash;
        private string processLocation;
        private readonly DateTime startTime;
        private readonly TimeSpan targetTimeSpan;

        public Lock(int minutes, string unlockPasswordHash, string processLocation)
        {
            InitializeComponent();

            targetTimeSpan = new TimeSpan(0, 0, minutes, 0);
            startTime = DateTime.Now;

            File.WriteAllText(TimeControlFile.WhiteAppLocation, processLocation);
            File.AppendAllText(TimeControlFile.TempTimeFile, startTime.ToString() + Environment.NewLine);
            File.AppendAllText(TimeControlFile.TempTimeFile, targetTimeSpan.ToString());

            Init(unlockPasswordHash, processLocation);
        }
        public Lock(string unlockPasswordHash, string processLocation)
        {
            InitializeComponent();

            string[] strings = File.ReadAllLines(TimeControlFile.TempTimeFile);
            startTime = DateTime.Parse(strings[0]);
            targetTimeSpan = TimeSpan.Parse(strings[1]);

            Init(unlockPasswordHash, processLocation);
        }
        private void Init(string unlockPasswordHash,string processLocation)
        {
            if (string.IsNullOrEmpty(unlockPasswordHash))
            { usePassword = false; }
            this.unlockPasswordHash = unlockPasswordHash;
            this.processLocation = processLocation;
            progressBar.Maximum = (int)targetTimeSpan.TotalSeconds;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - startTime;
            timeLabel.Text = 
                @$"{timeSpan.Hours}:{timeSpan.Minutes}:{timeSpan.Seconds}/{targetTimeSpan.Hours}:{targetTimeSpan.Minutes}:{targetTimeSpan.Seconds}";
            if(timeSpan>=targetTimeSpan)
            {
                timer.Stop();
                unlockLabel.Visible = true;
                progressBar.Value = progressBar.Maximum;
                return;
            }
            progressBar.Value = (int)timeSpan.TotalSeconds;
            Process[] processes = Process.GetProcessesByName("Taskmgr");
            foreach (Process process in processes)
            {
                process.Kill();
                MessageBox.Show("想结束进程？不存在的。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Lock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (progressBar.Value != progressBar.Maximum)
            {
                e.Cancel = true;
                MessageBox.Show("时间还没到呢！再等等吧。（点击继续）", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            File.Delete(TimeControlFile.TempTimeFile);
        }

        private void UnlockButton_Click(object sender, EventArgs e)
        {
            if (usePassword == true)
            {
                if (Password.ComputeHash(unlockPasswordBox.Text) == unlockPasswordHash)
                {
                    progressBar.Value = progressBar.Maximum;
                    Close();
                }
                else
                    MessageBox.Show("管理码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("你没有设置管理码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void startProcessButton_Click(object sender, EventArgs e)
        {
            Dllimport.STARTUPINFO sTARTUPINFO = new();
            sTARTUPINFO.lpDesktop = "Lock";
            Dllimport.PROCESS_INFORMATION pROCESS_INFORMATION = new();
            Dllimport.CreateProcess(processLocation, null, IntPtr.Zero, IntPtr.Zero, true, 0, IntPtr.Zero, null, ref sTARTUPINFO,
                ref pROCESS_INFORMATION);
        }
    }
}
