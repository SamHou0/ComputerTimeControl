using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl.Windows
{
    public partial class BootStopWindow : Form
    {
        int screenNumber;
        private int seconds = 0;
        public BootStopWindow(int screenNumber)
        {
            InitializeComponent();
            this.screenNumber = screenNumber;
        }

        private void BootStopWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (seconds < 60)
            {
                e.Cancel = true;
            }
        }

        private void BootTimer_Tick(object sender, EventArgs e)
        {
            Focus();
            seconds++;
            if (seconds >= 60)
            {
                Close();
            }
            infoLabel.Text = (60-seconds).ToString();
            Process[] processes = Process.GetProcessesByName("Taskmgr");
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private void BootStopWindow_Shown(object sender, EventArgs e)
        {
            Location = Screen.AllScreens[screenNumber].Bounds.Location;
            Width = Screen.AllScreens[screenNumber].Bounds.Width;
            Height = Screen.AllScreens[screenNumber].Bounds.Height;
            infoLabel.Top = Height / 2 - infoLabel.Height / 2;
            infoLabel.Left = Width / 2 - infoLabel.Width / 2;
        }
    }
}
