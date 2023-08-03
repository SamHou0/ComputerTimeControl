using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TimeControl.AppControl;
using TimeControl.Properties;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class ControlPanel : Form
    {
        private bool hide = false;
        private bool isClosable = false;

        private AppController appController;//Controller for list and apps.
        private bool isLoaded;//Show the state of initialization.
        private bool isChangeable = true;
        private List<Data.Task> tasks;

        public ControlPanel(bool hide)
        {
            isLoaded = false;
            CheckCurrentProcess();
            InitializeComponent();
            versionLabel.Text = $"版本：{Assembly.GetExecutingAssembly().GetName().Version}";
            InitializeSettings();
            this.hide = hide;
            if (!Directory.Exists(TCFile.BaseLocation))
            {
                Directory.CreateDirectory(TCFile.BaseLocation);
            }
            //Tasks
            ReadTasks();
            //Data recording
            InitializeData();
            //Lock
            InitializeFocus();
            //DeepFocus
            InitializeDeepFocus();
            //Titles Monitor
            InitTitles();
            //Process monitor
            StartMonitor();
            //Auto shutdown
            CheckShutdown();
            //Password
            InitializePassword();
        }

        #region Form

        private static void CheckCurrentProcess()
        {
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
                DisableSet();
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
            PasswordInput passwordInput = new();
            if (!string.IsNullOrEmpty(Password.unlockPasswordHash))//检测是否设置了管理码
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

        #region PlanPage

        private void PlannerButton_Click(object sender, EventArgs e)
        {
            Planner planner = new Planner(tasks);
            planner.ShowDialog();
            ReadTasks();
        }

        private void ReadTasks()
        {
            if (File.Exists(TCFile.TaskLocation))
            {
                tasks = TCFile.ReadTasks();
            }
            else { tasks = null; }
            RefreshTasks();
        }

        private void RefreshTasks()
        {
            taskListBox.Items.Clear();
            if (tasks != null)
            {
                foreach (Data.Task task in tasks)
                {
                    taskListBox.Items.Add(task);
                }
            }
            TCFile.SaveTasks(tasks);
        }

        private void EndTaskButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                tasks[taskListBox.SelectedIndex].EndTask();
                tasks.RemoveAt(taskListBox.SelectedIndex);
            }
            RefreshTasks();
        }

        private void TaskStartButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex >= 0)
            {
                if (tasks[taskListBox.SelectedIndex].RunTask())
                {
                    tasks.RemoveAt(taskListBox.SelectedIndex);
                }
                RefreshTasks();
            }
        }

        #endregion PlanPage

        #region LockPage

        private void InitializeFocus()
        {
            if (File.Exists(TCFile.WhiteAppLocation))
                whiteProcessBox.Text = File.ReadAllText(TCFile.WhiteAppLocation);
            if (File.Exists(TCFile.TempTimeFile))
            {
                MessageBox.Show("恢复屏保");
                StartLock(Password.unlockPasswordHash);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)//启动屏保程序
        {
            StartLock(Password.unlockPasswordHash, (int)timeBox.Value);
        }

        private void StartLock(string unlockPasswordHash, int minutes = 0)
        {
            LockHelper.StartLock(unlockPasswordHash, minutes);
            int index = dataGridView.Rows.Add();
            RefreshAndSaveData();
        }

        private void WhiteProcessBox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(TCFile.WhiteAppLocation, whiteProcessBox.Text);
        }

        #endregion LockPage

        #region DeepLockPage

        private void InitializeDeepFocus()
        {
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
                    LockHelper.ShowAndSave(deepFocusTime);
                    RefreshAndSaveData();
                }
            }
        }

        private void DeepStartButton_Click(object sender, EventArgs e)
        {
            LockHelper.StartDeepLock((int)deepTimeInput.Value);
        }

        #endregion DeepLockPage

        #region TitlePage

        private void AddTitleButton_Click(object sender, EventArgs e)
        {
            titleListBox.Items.Add(titleTextBox.Text);
            SaveTitles();
        }

        private void RemoveTitleButton_Click(object sender, EventArgs e)
        {
            if (CheckPassword() && CheckStop())
            {
                if (titleListBox.SelectedIndex >= 0)
                {
                    titleListBox.Items.RemoveAt(titleListBox.SelectedIndex);
                }
                SaveTitles();
            }
        }

        private void SaveTitles()
        {
            TCFile.SaveTitle(titleListBox);
        }

        private void InitTitles()
        {
            TCFile.ReadTitle(titleListBox);
        }

        #endregion TitlePage

        #region ProcessPage

        private void StartMonitor()
        {
            appController = new(usageBox, processMonitorTimer);
            if ((Directory.GetLastWriteTime(TCFile.TimeFileDirectory).ToString("yyyy-MM-dd")
                != DateTime.Now.ToString("yyyy-MM-dd"))
                && autoResetBox.Checked)
                appController.Reset();
            fileSaveTimer.Start();
        }

        private void FileSaveTimer_Tick(object sender, EventArgs e)
        {
            processMonitorTimer.Stop();
            appController.Save();
            processMonitorTimer.Start();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://icons8.com/icon/19614/icon");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (CheckPassword() && CheckStop())
            {
                appController.RemoveAll();
            }
        }

        private void AppAddButton_Click(object sender, EventArgs e)
        {
            TimeInput timeInput = new(appController);//打开进程限时控制窗口
            timeInput.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //检测密码设置
            if (CheckPassword() && CheckStop())
            {
                appController.Remove();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            appController.Refresh();
        }

        private void ProcessMonitorTimer_Tick(object sender, EventArgs e)
        {
            if(realTimeShutdowncheckBox.Checked)
            {
                CheckShutdown();
            }
            appController.Run();
            if (autoRefreshBox.Checked)
                appController.Refresh();
            if (Process.GetProcessesByName("TimeControlConsole").Length == 0)//检查保护程序状态
            {
                ProcessStartInfo process = new()
                {
                    FileName = "TimeControlConsole.exe"
                };
                Process.Start(process);
            }
            Process[] processes = Process.GetProcesses();
            //Title Management
            foreach (Process process in processes)
            {
                if (!string.IsNullOrWhiteSpace(process.MainWindowTitle))
                {
                    foreach (string str in titleListBox.Items)
                    {
                        if (process.MainWindowTitle.Contains(str)) process.Kill();
                    }
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                appController.Reset();
            }
        }

        #endregion ProcessPage

        #region ShutdownPage

        private void ShutdownSetButton_Click(object sender, EventArgs e)
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

        private void ShutdownRemoveButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(TCFile.ShutdownSpan))
                File.Delete(TCFile.ShutdownSpan);
        }

        private static void CheckShutdown()
        {
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
        }

        #endregion ShutdownPage

        #region ProtectPage

        #region Password

        private void InitializePassword()
        {
            if (File.Exists(TCFile.PassLocation))//加载密码哈希值
            {
                Password.unlockPasswordHash = File.ReadAllText(TCFile.PassLocation);
                PasswordSet();
            }
            else
                unlockPasswordRemoveButton.Enabled = false;
            isLoaded = true;
        }

        private void UnloackPasswordSetButton_Click(object sender, EventArgs e)//保存密码
        {
            Password.unlockPasswordHash = Password.ComputeHash(unlockPasswordBox.Text);//保存哈希值
            File.WriteAllText(TCFile.PassLocation, Password.unlockPasswordHash.ToString());//保存哈希值到文件
            PasswordSet();
        }

        private void UnlockPasswordRemoveButton_Click(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                File.Delete(TCFile.PassLocation);
                Password.unlockPasswordHash = "";
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

        private bool CheckPassword()//检测密码是否正确
        {
            if (!string.IsNullOrEmpty(Password.unlockPasswordHash))
            {
                PasswordInput passwordInput = new();
                if (passwordInput.ShowDialog() == DialogResult.OK)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }

        #endregion Password

        private void AddBootButton_Click(object sender, EventArgs e)
        {
            TaskSchedulerControl.AddBoot();
        }

        private void RemoveBootButton_Click(object sender, EventArgs e)
        {
            TaskSchedulerControl.RemoveBoot();
        }

        private bool CheckStop()
        {
            if (!isChangeable)
            {
                LockHelper.Interrupt();
                if (InterruptWindow.result == DialogResult.OK)
                {
                    return true;
                }
                else return false;
            }
            else return true;
        }

        private void StopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stopCheckBox.Checked)
            {
                stopCheckBox.Enabled = false;
            }
            SettingsChanged(sender, e);
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            if (CheckPassword() && CheckStop())
            {
                removeBootButton.Enabled = true;
                stopCheckBox.Enabled = true;
            }
        }

        private void DisableSet()
        {
            if (!string.IsNullOrWhiteSpace(Password.unlockPasswordHash))
            {
                removeBootButton.Enabled = false;
            }
            if (stopCheckBox.Checked)
            {
                stopCheckBox.Enabled = false;
                isChangeable = false;
            }
        }

        #endregion ProtectPage

        #region DataPage

        private void InitializeData()
        {
            if (File.Exists(TCFile.SavedData))
            {
                LockHelper.TimeData = TCFile.ReadTimeData();
                RefreshAndSaveData();
            }
            else
            {
                Directory.CreateDirectory(TCFile.SavedDataDir);
                LockHelper.TimeData = new() { GoalName = "FirstGoal" };
                RefreshAndSaveData();
            }
        }

        private void RefreshAndSaveData()
        {
            //刷新列表
            //普通屏保
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add(LockHelper.TimeData.LockTime, "普通屏保");
            //深度专注屏保
            dataGridView.Rows.Add(LockHelper.TimeData.DeepLockTime, "深度专注屏保");
            //更新进度
            ShowProgress();
            //保存
            TCFile.SaveTimeData(LockHelper.TimeData);
        }

        #endregion DataPage

        #region ProgressPage

        private void ShowProgress()
        {
            goalLabel.Text = LockHelper.TimeData.GoalName;
            TimeSpan timeSpan = LockHelper.TimeData.GetTimeSum();
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
                encourageLabel.Text = "恭喜通关！你可以通过新建目标来重新开始！";
                progressLabel.Visible = false;
                progressBar.Value = 100;
            }
        }

        #endregion ProgressPage

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
                Settings.Default.StopBeforeSetting = stopCheckBox.Checked;
                Settings.Default.RealTimeShutdown=realTimeShutdowncheckBox.Checked;
                Settings.Default.Save();
            }
        }

        private void InitializeSettings()
        {
            autoResetBox.Checked = Settings.Default.AutoReset;
            autoRefreshBox.Checked = Settings.Default.AutoRefresh;
            stopCheckBox.Checked = Settings.Default.StopBeforeSetting;
            realTimeShutdowncheckBox.Checked = Settings.Default.RealTimeShutdown;
            if (stopCheckBox.Checked)
            {
                isChangeable = false;
            }
        }

        private void DataDirButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", TCFile.BaseLocation);
        }

        private void GoalChangeButton_Click(object sender, EventArgs e)
        {
            GoalChangeWindow goalChangeWindow = new();
            goalChangeWindow.ShowDialog();
        }

        #endregion SettingPage
    }
}