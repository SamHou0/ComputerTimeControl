using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeControl.AppControl;
using TimeControl.Data;
using TimeControl.Properties;
using TimeControl.Tools;
using Windows.ApplicationModel.Contacts;
using Windows.UI;

namespace TimeControl.Windows
{
    public partial class ControlPanel : Form
    {
        private bool hide = false;//指示启动后是否需要隐藏
        private bool isClosable = false;//指示当前是否可以关闭
        private string unlockPasswordHash = "";//密码哈希值，用作比对
        private AppController appController;//列表、计时控制器
        private TimeData timeData;//数据
        private bool isLoaded;//指示加载是否已经完成
        public ControlPanel(bool hide)
        {
            isLoaded = false;
            Process[] processes = Process.GetProcessesByName("TimeControl");
            if (processes.Length > 1)
            {
                if (MessageBox.Show(
                    "当前已经启动TimeControl，不能启动多个实例，是否要重新启动？",
                "提示",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
                {
                    foreach (Process process in processes)
                    {
                        if (process.Id != Environment.ProcessId)
                            process.Kill();
                    }
                }
                else
                    Environment.Exit(0);
            }
            InitializeComponent();
            InitializeSettings();
            this.hide = hide;
            //数据记录
            if (File.Exists(TCFile.SavedData))
            {
                timeData = TCFile.ReadTimeData();
                RefreshAndSaveData();
            }
            else
            {
                Directory.CreateDirectory(TCFile.SavedDataDir);
                timeData = new() { GoalName="FirstGoal"};
                RefreshAndSaveData();
            }
            //屏保
            if (File.Exists(TCFile.WhiteAppLocation))
                whiteProcessBox.Text = File.ReadAllText(TCFile.WhiteAppLocation);
            if (File.Exists(TCFile.TempTimeFile))
            {
                MessageBox.Show("恢复屏保");
                StartLock(unlockPasswordHash);
            }
            //深度专注
            if (File.Exists(TCFile.DeepTempTimeFile))
            {
                string[] deepTimeFileStr = File.ReadAllLines(TCFile.DeepTempTimeFile);
                TimeSpan deepFocusTime = DateTime.Now -
                    DateTime.Parse(deepTimeFileStr[0]);
                if (deepFocusTime < TimeSpan.Parse(deepTimeFileStr[1]))
                {
                    SystemControl.Shutdown();
                    Application.Exit();
                }
                else
                {
                    File.Delete(TCFile.DeepTempTimeFile);
                    ShowAndSave(deepFocusTime);
                    RefreshAndSaveData();
                }
            }
            //程序计时
            if (!Directory.Exists(TCFile.BaseLocation))
            {
                Directory.CreateDirectory(TCFile.BaseLocation);
            }
            appController = new(usageBox, processMonitorTimer);
            if ((Directory.GetLastWriteTime(TCFile.TimeFileDirectory).ToString("yyyy-MM-dd")
                != DateTime.Now.ToString("yyyy-MM-dd"))
                && autoResetBox.Checked)
                appController.Reset();
            fileSaveTimer.Start();
            //自动关机
            if (File.Exists(TCFile.ShutdownSpan))
            {
                string[] shutdownTimeLines = File.ReadAllLines(TCFile.ShutdownSpan);
                TimeOnly startTime = TimeOnly.Parse(shutdownTimeLines[0]);
                TimeOnly endTime = TimeOnly.Parse(shutdownTimeLines[1]);
                TimeOnly now = TimeOnly.FromDateTime(DateTime.Now);
                if (now >= startTime && now <= endTime)
                {
                    SystemControl.Shutdown();
                }
                Application.Exit();
            }
            //密码
            if (File.Exists(TCFile.PassLocation))//加载密码哈希值
            {
                unlockPasswordHash = File.ReadAllText(TCFile.PassLocation);
                PasswordSet();
            }
            else
                unlockPasswordRemoveButton.Enabled = false;
            isLoaded = true;
        }

        #region Form

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
            if (!string.IsNullOrEmpty(unlockPasswordHash))//检测是否设置了管理码
            {
                if (passwordInput.ShowDialog() == DialogResult.OK)
                    ForceClose();
            }
            else
                ForceClose();
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

        #endregion Form

        #region LockPage

        private void StartButton_Click(object sender, EventArgs e)//启动屏保程序
        {
            StartLock(unlockPasswordHash, (int)timeBox.Value);
        }

        private void StartLock(string unlockPasswordHash, int minutes = 0)
        {
            IntPtr nowDesktop = Dllimport.GetThreadDesktop(Dllimport.GetCurrentThreadId());
            IntPtr newDesktop = Dllimport.CreateDesktop("Lock", null, null, 0, Dllimport.ACCESS_MASK.GENERIC_ALL, IntPtr.Zero);
            Dllimport.SwitchDesktop(newDesktop);
            Task.Factory.StartNew(() =>
            {
                Dllimport.SetThreadDesktop(newDesktop);
                Lock _lock;
                if (minutes != 0)
                    _lock = new(minutes, unlockPasswordHash);
                else
                    _lock = new(unlockPasswordHash);
                Application.Run(_lock);
            }).Wait();
            Dllimport.SwitchDesktop(nowDesktop);
            Dllimport.CloseDesktop(newDesktop);
            int index = dataGridView.Rows.Add();
            ShowAndSave(Lock.TempTimeSpan);
        }

        private void ShowAndSave(TimeSpan timeSpan)
        {
            ResultWindow resultWindow = new(timeSpan);
            resultWindow.ShowDialog();
            if (ResultWindow.IsSave == true)
                timeData.AddTime(timeSpan);
            RefreshAndSaveData();
        }

        private void WhiteProcessBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(TCFile.WhiteAppLocation, whiteProcessBox.Text);
        }

        #endregion

        #region DeepLockPage
        private void deepStartButton_Click(object sender, EventArgs e)
        {
            TimeSpan deepTime = new(0, (int)deepTimeInput.Value, 0);
            File.WriteAllText(TCFile.DeepTempTimeFile, DateTime.Now + Environment.NewLine + deepTime);
            SystemControl.Shutdown();
            Application.Exit();
        }
        #endregion

        #region ProcessPage

        private void FileSaveTimer_Tick(object sender, EventArgs e)
        {
            processMonitorTimer.Stop();
            appController.Save();
            processMonitorTimer.Start();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//添加链接
        {
            Process.Start("explorer.exe", "https://icons8.com/icon/19614/icon");
        }

        private void ClearButton_Click(object sender, EventArgs e)//移除所有的已添加窗口
        {
            if (PasswordCheck())
            {
                appController.RemoveAll();
            }
        }

        private void AppAddButton_Click(object sender, EventArgs e)//添加进程
        {
            TimeInput timeInput = new(appController);//打开进程限时控制窗口
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            appController.Reset();
        }

        #endregion

        #region ShutdownPage
        private void shutdownSetButton_Click(object sender, EventArgs e)
        {
            TimeOnly startTime = new((int)startShutdownHour.Value,
                (int)startShutdownMinute.Value, 0);
            TimeOnly endTime = new((int)endShutdownHour.Value,
                (int)endShutdownMinute.Value, 0);
            if (startTime < endTime)
                File.WriteAllText(TCFile.ShutdownSpan,
                    startTime + Environment.NewLine + endTime);
            else
                MessageBox.Show("时间输入非法。", "错误"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void shutdownRemoveButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(TCFile.ShutdownSpan))
                File.Delete(TCFile.ShutdownSpan);
        }
        #endregion

        #region ProtectPage

        #region Password

        private void UnloackPasswordSetButton_Click(object sender, EventArgs e)//保存密码
        {
            unlockPasswordHash = Password.ComputeHash(unlockPasswordBox.Text);//保存哈希值
            File.WriteAllText(TCFile.PassLocation, unlockPasswordHash.ToString());//保存哈希值到文件
            PasswordSet();
        }

        private void UnlockPasswordRemoveButton_Click(object sender, EventArgs e)
        {
            if (PasswordCheck())
            {
                File.Delete(TCFile.PassLocation);
                unlockPasswordHash = "";
                unlockPasswordBox.Text = "";
                unlockPasswordBox.Enabled = true;
                unlockPasswordSetButton.Enabled = true;
                unlockPasswordRemoveButton.Enabled = false;
                removeBootButton.Enabled = true;
            }
        }

        private void PasswordSet()//密码设置后调用
        {
            unlockPasswordBox.Text = "";
            unlockPasswordBox.Enabled = false;
            unlockPasswordSetButton.Enabled = false;
            unlockPasswordRemoveButton.Enabled = true;
            removeBootButton.Enabled = false;
        }

        private bool PasswordCheck()//检测密码是否正确
        {
            if (!string.IsNullOrEmpty(unlockPasswordHash))
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

        #endregion

        private void AddBootButton_Click(object sender, EventArgs e)
        {
            TaskSchedulerControl.AddBoot();
        }

        private void RemoveBootButton_Click(object sender, EventArgs e)
        {
            TaskSchedulerControl.RemoveBoot();
        }

        #endregion

        #region DataPage
        private void RefreshAndSaveData()
        {
            //刷新列表
            //普通屏保
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add(timeData.LockTime, "普通屏保");
            //深度专注屏保
            dataGridView.Rows.Add(timeData.DeepLockTime, "深度专注屏保");
            //更新进度
            ShowProgress(timeData);
            //保存
            TCFile.SaveTimeData(timeData);
        }

        #endregion

        #region ProgressPage
        private void ShowProgress(TimeData timeData)
        {
            goalLabel.Text = timeData.GoalName;
            TimeSpan timeSpan = timeData.GetTimeSum();
            int level = 1;
            TimeSpan targetTimeSpan = new(0, 0, 0);
            while (level < 100)
            {
                targetTimeSpan = new TimeSpan(level, 0, 0);
                if (timeSpan > targetTimeSpan)
                {
                    level++;
                    timeSpan -= targetTimeSpan;
                }
                else
                    break;
            }

            progressLabel.Text = $"进入下一级还需要专注{Math.Round((targetTimeSpan - timeSpan).TotalHours, 3)}小时";
            levelLabel.Text = $"当前等级：{level}/100级";
            progressBar.Value = Convert.ToInt32((timeSpan / targetTimeSpan) * 100);
            if (level == 100)
            {
                encourageLabel.Text = "恭喜通关！你可以通过删除TimeControl文件夹里的SavedData.xml来重新开始！";
                progressLabel.Visible = false;
                progressBar.Value = 100;
            }
        }
        #endregion

        #region SettingPage

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/SamHou0/ComputerTimeControl");
        }

        private void GiteeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://gitee.com/Sam-Hou/ComputerTimeControl");
        }

        private void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe",
                "https://gitee.com/Sam-Hou/ComputerTimeControl/wikis/%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98&%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E");
        }
        private void SettingsChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                Settings.Default.AutoReset = autoResetBox.Checked;
                Settings.Default.AutoRefresh = autoRefreshBox.Checked;
                Settings.Default.Save();
            }
        }
        private void InitializeSettings()
        {
            autoResetBox.Checked = Settings.Default.AutoReset;
            autoRefreshBox.Checked = Settings.Default.AutoRefresh;
        }
        private void dataDirButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe",TCFile.BaseLocation);
        }
        private void goalChangeButton_Click(object sender, EventArgs e)
        {
            GoalChangeWindow goalChangeWindow = new();
            goalChangeWindow.ShowDialog();
        }
        #endregion

    }
}