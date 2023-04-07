using System;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.Data
{
    public class Task
    {
        public Task()
        { }

        public Task(string name, TimeSpan duration, bool isFocus, bool isDeepFocus)
        {
            Name = name;
            Duration = duration;
            IsFocus = isFocus;
            this.isDeepFocus = isDeepFocus;
        }

        public string Name;
        public TimeSpan Duration;
        public bool IsFocus;
        private bool isDeepFocus;
        private DateTime startTime = new DateTime(0);
        private DateTime endTime;
        public bool IsDeepFocus
        { get { return IsFocus && isDeepFocus; } }

        public override string ToString()
        {
            return Name + " (" + Duration.Minutes + "min)";
        }

        public void RunTask()
        {
            startTime = DateTime.Now;
            if (IsFocus)
            {
                LockHelper.StartLock(Password.unlockPasswordHash, (int)Duration.TotalMinutes);
            }
            else if (IsDeepFocus)
            {
                LockHelper.StartDeepLock((int)Duration.TotalMinutes);
            }
            else
            {
                MessageBox.Show(
                    "任务已启动。该日程不需要启动任何计算机操作，请自行完成，预估时间" + Duration + "min");
            }
        }

        public string EndTask()
        {
            if (startTime == new DateTime(0))
            {
                return "任务已完成";
            }
            endTime = DateTime.Now;
            return ToString() + "(实际" + (endTime - startTime) + ")";
        }
    }
}