using System.Diagnostics;
using TimeControl.Data;
using TimeControl.Tools;
using TimeControl.Windows;

namespace TimeControl.AppControl
{
    public class LimitedApp : App
    {
        public LimitedApp(string name, int time, int timeLimit, int restInterval) :
            base(name, time, restInterval)
        {
            appInformation.timeLimit = timeLimit;
        }

        public LimitedApp(AppInformation appInformation) : base(appInformation)
        { }

        /// <summary>
        /// Add 1 second, show warning window if necessary and check rest.
        /// </summary>
        public override void Run()
        {
            appInformation.time++;
            if (appInformation.time == appInformation.timeLimit - 30)
            {
                LimitWarningWindow warningWindow = new(this);
                warningWindow.Show();
            }
            if (appInformation.time >= appInformation.timeLimit)
            {
                Ban();
            }
            CheckRest();
        }

        /// <summary>
        /// Return a simple description of the limited app.
        /// </summary>
        /// <returns>The description</returns>
        public override string ToString()
        {
            return base.ToString() + " 进程时间限制为：" + TimeConvert.DescribeTime(appInformation.timeLimit);
        }

        /// <summary>
        /// Set the app's time to limited time. This will also kill the process.
        /// </summary>
        public void Ban()
        {
            Process[] processes = Process.GetProcessesByName(appInformation.name);
            foreach (Process process in processes)
            {
                process.Kill();
            }
            appInformation.time = appInformation.timeLimit;
        }
    }
}