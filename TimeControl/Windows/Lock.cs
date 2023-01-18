using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class Lock : Form
    {
        public static TimeSpan TempTimeSpan;
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
            File.AppendAllText(TCFile.TempTimeFile, startTime.ToString() + Environment.NewLine);
            File.AppendAllText(TCFile.TempTimeFile, targetTimeSpan.ToString());

            Init(unlockPasswordHash);
        }

        public Lock(string unlockPasswordHash)
        {
            InitializeComponent();

            string[] strings = File.ReadAllLines(TCFile.TempTimeFile);
            startTime = DateTime.Parse(strings[0]);
            targetTimeSpan = TimeSpan.Parse(strings[1]);

            Init(unlockPasswordHash);
        }

        private void Init(string unlockPasswordHash)
        {
            processLocation = File.ReadAllLines(TCFile.WhiteAppLocation);
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
                changeButton.Visible = false;
                progressBar.Value = progressBar.Maximum;
                isClosable = true;
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
            {
                File.Delete(TCFile.TempTimeFile);
                TempTimeSpan = DateTime.Now - startTime;
                SystemControl.Shutdown();
            }
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

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("切换为深度专注后，整个专注将被标记为深度专注。这将不可撤销！确实要这么做吗？", 
                "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                File.Move(TCFile.TempTimeFile, TCFile.DeepTempTimeFile);
            }
        }
    }
}