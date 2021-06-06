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
        private int time;
        private int Progress;
        private bool close = false;
        private bool stopTskmanager;
        public Lock(int time,bool stopTskmanager)
        {
            this.time = time;
            this.stopTskmanager = stopTskmanager;
            InitializeComponent();
        }

        private void Lock_Load(object sender, EventArgs e)
        {
            TimeControl.AutoSize.ProgressBarAutoSize(this,progressBar,50);
            TimeControl.AutoSize.LabelAutoSize(this,label2,Height/2);
            TimeControl.AutoSize.LabelAutoSize(this,label1,50+progressBar.Height);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Progress += 1;
            UpdateProgress();
            Process[] processes = Process.GetProcesses();
            if (stopTskmanager==true)
            {
                for (int i = 0; i < processes.Length; i++)
                {
                    if (processes[i].ProcessName== "Taskmgr")
                    {
                        processes[i].Kill();
                    }
                }
            }
        }
        private void UpdateProgress()
        {
            if (progressBar.Value<100)
            {
                progressBar.Value = Progress * 100 / time;
            }
            else
            {
                timer.Stop();
                MessageBox.Show("你已经专注了" + time);
                close = true;
                Close();
            }
        }

        private void Lock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
            {
                e.Cancel=true;
            }
        }
        
    }
}
