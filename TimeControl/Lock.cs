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

namespace TimeControl
{
    public partial class Lock : Form
    {
        private bool usePassword = true;
        private string unlockPasswordHash;
        public Lock(int minutes,string unlockPasswordHash)
        {
            InitializeComponent();
            progressBar.Maximum = minutes * 60;
            if (!string.IsNullOrEmpty(unlockPasswordHash))
            { usePassword = false; }
            this.unlockPasswordHash = unlockPasswordHash;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            if (progressBar.Value==progressBar.Maximum)
            {
                timer.Stop();
                unlockLabel.Visible = true;
            }
            Process[] processes= Process.GetProcessesByName("Taskmgr");
            foreach (Process process in processes)
            {
                process.Kill();
                MessageBox.Show("想结束进程？不存在的。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Lock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (progressBar.Value!=progressBar.Maximum)
            {
                e.Cancel = true;
                MessageBox.Show("时间还没到呢！再等等吧。（点击继续）", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
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
    }
}
