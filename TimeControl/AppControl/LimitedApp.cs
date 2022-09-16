using System.Diagnostics;
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
        /// 运行一次（一秒），并根据情况显示警告或关闭进程，然后保存到文件
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
        /// 返回时间受限进程的简要概述
        /// </summary>
        /// <returns>时间受限进程的简要概述</returns>
        public override string ToString()
        {
            return base.ToString() + " 进程时间限制为：" + TimeConvert.DescribeTime(appInformation.timeLimit);
        }

        /// <summary>
        /// 禁用掉该程序
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