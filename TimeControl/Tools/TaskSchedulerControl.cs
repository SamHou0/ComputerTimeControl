using System.Diagnostics;
using System.Windows.Forms;
using TaskScheduler;
using System;
using Windows.Graphics.Printing3D;
using System.Runtime.CompilerServices;

namespace TimeControl.Tools
{
    public static class TaskSchedulerControl
    {
        public static void AddBoot()
        {
            try
            {
                TaskSchedulerClass taskScheduler = new();
                taskScheduler.Connect(null,null,null,null);
                //基本设置
                ITaskDefinition taskDefinition = taskScheduler.NewTask(0);
                taskDefinition.RegistrationInfo.Description = "TimeControlBoot";
                taskDefinition.RegistrationInfo.Author = "TimeControl";
                //触发器
                taskDefinition.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
                //运行内容
                IExecAction action=
                    (IExecAction)taskDefinition.Actions.Create
                    (_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
                action.Path=AppDomain.CurrentDomain.BaseDirectory + "\\TimeControlConsole.exe";
                //设置
                taskDefinition.Settings.ExecutionTimeLimit = "PT0S";
                taskDefinition.Settings.DisallowStartIfOnBatteries = false;
                taskDefinition.Settings.RunOnlyIfIdle = false;
                //管理员运行
                taskDefinition.Principal.RunLevel=_TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST;
                //注册
                ITaskFolder taskFolder = taskScheduler.GetFolder("\\");
                taskFolder.RegisterTaskDefinition("TimeControlBoot", taskDefinition,
                    (int)_TASK_CREATION.TASK_CREATE_OR_UPDATE, null, null,
                    _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN);
                //反馈
                MessageBox.Show("添加完毕。");
            }
            catch
            {
                MessageBox.Show(
                    "添加失败。必须在任务计划程序启动时才可添加！", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void RemoveBoot()
        {
            TaskSchedulerClass taskScheduler = new();
            taskScheduler.Connect();
            ITaskFolder taskFolder = taskScheduler.GetFolder("\\");
            try
            {
                taskFolder.DeleteTask("TimeControlBoot",0);
                MessageBox.Show("移除完毕。");
            }
            catch
            {
                MessageBox.Show(
                    "移除失败。可能没有找到任何相关任务！", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}