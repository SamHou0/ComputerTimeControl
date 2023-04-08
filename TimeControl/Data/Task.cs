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
        public bool isDeepFocus;
        public DateTime startTime = new DateTime(0);
        public DateTime endTime;

        public bool IsDeepFocus
        { get { return IsFocus && isDeepFocus; } }

        public override string ToString()
        {
            return Name + " (" + Duration.TotalMinutes + "min)";
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>If the task is ended</returns>
        public bool RunTask()
        {
            bool res = false;
            startTime = DateTime.Now;
            if (IsFocus&&(!isDeepFocus))
            {
                LockHelper.StartLock(Password.unlockPasswordHash, (int)Duration.TotalMinutes);
                EndTask();
                res = true;
            }
            else if (IsDeepFocus)
            {
                LockHelper.StartDeepLock((int)Duration.TotalMinutes);
            }
            else
            {
                MessageBox.Show(
                    "任务已启动。该日程不需要启动任何计算机操作，请自行完成，预估时间", "提示"
                    + Duration + "min", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return res;
        }

        private string EndTaskString()
        {
            if (startTime == new DateTime(0))
            {
                return "任务已完成";
            }
            endTime = DateTime.Now;
            return ToString() + "(实际" + (endTime - startTime) + ")";
        }

        public void EndTask()
        {
            MessageBox.Show(EndTaskString(),
                "任务结束", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}