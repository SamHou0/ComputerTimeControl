using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace TimeControl
{
    public partial class ControlPanel : Form
    {
        private bool hide = false;//指示启动后是否需要隐藏
        private bool isClosable = false;//指示当前是否可以关闭
        List<App> appList = new();//所有监控软件列表
        private int unlockPasswordHash = 0;//密码哈希值，用作比对
        public ControlPanel(bool hide)
        {
            InitializeComponent();
            this.hide = hide;
            if (File.Exists(PasswordFile.tcPassLocation))//加载密码哈希值
            {
                unlockPasswordHash = Convert.ToInt32(File.ReadAllText(PasswordFile.tcPassLocation));
            }
        }

        private void StartButton_Click(object sender, EventArgs e)//启动屏保程序
        {
            IntPtr nowDesktop = Dllimport.GetThreadDesktop(Dllimport.GetCurrentThreadId());
            IntPtr newDesktop = Dllimport.CreateDesktop("Lock", null, null, 0, Dllimport.ACCESS_MASK.GENERIC_ALL, IntPtr.Zero);
            Dllimport.SwitchDesktop(newDesktop);
            Task.Factory.StartNew(() =>
            {
                Dllimport.SetThreadDesktop(newDesktop);
                Lock _lock = new(Convert.ToInt32(timeBox.Value), unlockPasswordHash);
                Application.Run(_lock);
            }).Wait();
            Dllimport.SwitchDesktop(nowDesktop);
            Dllimport.CloseDesktop(newDesktop);
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)//打开界面
        {
            Show();
        }

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)//处理关闭逻辑
        {
            if (!isClosable)//隐藏窗口
            {
                e.Cancel = true;
                Hide();
            }
            else//退出前关闭保护进程
            {
                Process[] processes = Process.GetProcessesByName("TimeControlConsole");
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)//正常退出程序
        {
            PasswordInput passwordInput = new(unlockPasswordHash);
            if (unlockPasswordHash != 0)//检测是否设置了管理码
            {
                if (passwordInput.ShowDialog() == DialogResult.OK)
                    ForceClose();
            }
            else
                ForceClose();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//添加链接
        {
            Process.Start("explorer.exe", "https://icons8.com/icon/19614/icon");
        }

        private void AppAddButton_Click(object sender, EventArgs e)//添加打开的窗口
        {
            processMonitorTimer.Stop();
            Process[] processes=Process.GetProcessesByName(processNameBox.Text);
            try
            {
                foreach (Process process in processes)
                {
                    appList.Add(new App(process.ProcessName, process.MainModule.FileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误",ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            CalculateTime();
        }

        private void RemoveButton_Click(object sender, EventArgs e)//移除所有的已添加窗口
        {
            if (usageBox.SelectedIndex >=0)
                appList.RemoveAt(usageBox.SelectedIndex);
            CalculateTime();
        }

        private void RefreshButton_Click(object sender, EventArgs e)//重新获取所有软件所用时间
        {
            CalculateTime();
        }

        private void ProcessMonitorTimer_Tick(object sender, EventArgs e)
        {
            foreach (App app in appList)//计算进程时间
            {
                if (Process.GetProcessesByName(app.Name).Length != 0)
                { app.Run(); }
            }
            if (Process.GetProcessesByName("TimeControlConsole").Length == 0)//检查保护程序状态
            {
                ProcessStartInfo process = new();
                process.FileName = "TimeControlConsole.exe";
                Process.Start(process);
            }
        }
        private void CalculateTime()//将进程时间推送到ListBox控件
        {
            processMonitorTimer.Stop();
            ListBoxController.Refresh(usageBox, appList);
            processMonitorTimer.Start();
        }
        private void ForceClose()//可以正常关闭
        {
            isClosable = true;
            Close();
        }
        private void ControlPanel_Shown(object sender, EventArgs e)//启动隐藏参数支持
        {
            if (hide)
            {
                Hide();
            }

            processMonitorTimer.Start();
        }
        private void unloackPassWordSetButton_Click(object sender, EventArgs e)//保存密码
        {
            unlockPasswordHash = unlockPasswordBox.Text.GetHashCode();//保存哈希值
            unlockPasswordBox.Text = "";
            unlockPasswordBox.Enabled = false;
            unloackPassWordSetButton.Enabled = false;
            File.WriteAllText(PasswordFile.tcPassLocation, unlockPasswordHash.ToString());//保存哈希值到文件
        }
    }
}
