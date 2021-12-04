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
        private int minutes;
        public Lock(int minutes)
        {
            InitializeComponent();
            this.minutes = minutes;
            progressBar.Maximum = minutes * 60;
        }

        private void timer_Tick(object sender, EventArgs e)
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
    }
}
