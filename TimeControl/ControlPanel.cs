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
        private string unlockPasswordHash = "";//密码哈希值，用作比对
        private AppController appController;//列表、计时控制器
        private GameController gameController;
        public ControlPanel(bool hide)
        {
            InitializeComponent();
            this.hide = hide;
            if (!Directory.Exists(TimeControlFile.BaseLocation))
            {
                Directory.CreateDirectory(TimeControlFile.BaseLocation);
            }
            if (File.Exists(TimeControlFile.PassLocation))//加载密码哈希值
            {
                unlockPasswordHash = File.ReadAllText(TimeControlFile.PassLocation);
                PasswordSet();
            }
            appController = new(usageBox, processMonitorTimer);
            fileSaveTimer.Start();
            gameController = new(coinLabel);
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
            gameController.AddCoin(Convert.ToInt32(timeBox.Value) / 60);
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)//打开界面
        {
            Show();
        }

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)//处理关闭逻辑
        {
            appController.Save();
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
            if (!string.IsNullOrEmpty( unlockPasswordHash))//检测是否设置了管理码
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

        private void AppAddButton_Click(object sender, EventArgs e)//添加进程
        {
            if (processNameBox.Text.ToLower() == "timecontrol" ||
                processNameBox.Text.ToLower() == "timecontrolconsole")
            {
                return;
            }
            TimeInput timeInput = new(appController, processNameBox.Text);//打开进程限时控制窗口
            timeInput.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)//移除窗口
        {
            //检测密码设置
            if (PasswordCheck())
            {
                appController.Remove();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)//重新获取所有软件所用时间
        {
            appController.Refresh();
        }

        private void ProcessMonitorTimer_Tick(object sender, EventArgs e)
        {
            appController.Run();
            if (autoRefreshBox.Checked)
                appController.Refresh();
            if (Process.GetProcessesByName("TimeControlConsole").Length == 0)//检查保护程序状态
            {
                ProcessStartInfo process = new();
                process.FileName = "TimeControlConsole.exe";
                Process.Start(process);
            }
        }
        private void ForceClose()//可以正常关闭
        {
            isClosable = true;
            processMonitorTimer.Stop();
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
        private void UnloackPasswordSetButton_Click(object sender, EventArgs e)//保存密码
        {

            unlockPasswordHash = Password.ComputeHash( unlockPasswordBox.Text);//保存哈希值
            File.WriteAllText(TimeControlFile.PassLocation, unlockPasswordHash.ToString());//保存哈希值到文件
            PasswordSet();
        }
        private void PasswordSet()//密码设置后调用
        {
            unlockPasswordBox.Text = "";
            unlockPasswordBox.Enabled = false;
            unloackPasswordSetButton.Enabled = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)//移除所有的已添加窗口
        {
            if (PasswordCheck())
            {
                appController.RemoveAll();
            }
        }
        private bool PasswordCheck()//检测密码是否正确
        {
            if (!string.IsNullOrEmpty( unlockPasswordHash))
            {
                PasswordInput passwordInput = new(unlockPasswordHash);
                if (passwordInput.ShowDialog() == DialogResult.OK)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            appController.Reset();
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.words);
        }

        private void fileSaveTimer_Tick(object sender, EventArgs e)
        {
            processMonitorTimer.Stop();
            appController.Save();
            processMonitorTimer.Start();
        }

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/SamHou0/ComputerTimeControl");
        }

        private void giteeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://gitee.com/Sam-Hou/ComputerTimeControl");
        }
    }
}
