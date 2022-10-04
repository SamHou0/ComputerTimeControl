using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class Lock : Form
    {
        private bool usePassword = true;
        private string unlockPasswordHash;
        private string[] processLocation;
        private bool isClosable = false;
        private readonly DateTime startTime;
        private readonly TimeSpan targetTimeSpan;

        public Lock(int minutes, string unlockPasswordHash)
        {
            InitializeComponent();

            targetTimeSpan = new TimeSpan(0, 0, minutes, 0);
            startTime = DateTime.Now;
            File.AppendAllText(TimeControlFile.TempTimeFile, startTime.ToString() + Environment.NewLine);
            File.AppendAllText(TimeControlFile.TempTimeFile, targetTimeSpan.ToString());

            Init(unlockPasswordHash);
        }

        public Lock(string unlockPasswordHash)
        {
            InitializeComponent();

            string[] strings = File.ReadAllLines(TimeControlFile.TempTimeFile);
            startTime = DateTime.Parse(strings[0]);
            targetTimeSpan = TimeSpan.Parse(strings[1]);

            Init(unlockPasswordHash);
        }

        private void Init(string unlockPasswordHash)
        {
            processLocation = File.ReadAllLines(TimeControlFile.WhiteAppLocation);
            if (string.IsNullOrEmpty(unlockPasswordHash))
            { usePassword = false; }
            this.unlockPasswordHash = unlockPasswordHash;
            progressBar.Maximum = (int)targetTimeSpan.TotalSeconds;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - startTime;
            timeLabel.Text =
                @$"{timeSpan.Hours}:{timeSpan.Minutes}:{timeSpan.Seconds}/{targetTimeSpan.Hours}:{targetTimeSpan.Minutes}:{targetTimeSpan.Seconds}";
            if (timeSpan >= targetTimeSpan)
            {
                unlockLabel.Visible = true;
                progressBar.Value = progressBar.Maximum;
                ForceClose();
            }
            else
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
            if (!isClosable)
            {
                e.Cancel = true;
                MessageBox.Show("时间还没到呢！再等等吧。（点击继续）", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
                File.Delete(TimeControlFile.TempTimeFile);
        }

        private void UnlockButton_Click(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                ForceClose();
            }
            if (usePassword == true)
            {
                if (Password.ComputeHash(unlockPasswordBox.Text) == unlockPasswordHash)
                {
                    ForceClose();
                }
                else
                    MessageBox.Show("管理码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("你没有设置管理码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ForceClose()
        {
            isClosable = true;
            Close();
        }

        private void ToolBoxButton_Click(object sender, EventArgs e)
        {
            ToolBox toolBox = new(processLocation);
            toolBox.ShowDialog();
        }
    }
}