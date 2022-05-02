using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace TimeControl
{
    [Serializable]
    public class LimitedApp : App
    {
        private readonly int timeLimit;

        public LimitedApp(string name, int time, int timeLimit) : base(name, time)
        {
            this.timeLimit = timeLimit;
        }

        /// <summary>
        /// 运行一次（一秒），并根据情况显示警告或关闭进程
        /// </summary>
        public override void Run()
        {
            time++;
            if (time == timeLimit - 30)
            {
                LimitWarningWindow warningWindow = new(this);
                warningWindow.Show();
            }
            if (time >= timeLimit)
            {
                Ban();
            }
        }

        /// <summary>
        /// 返回时间受限进程的简要概述
        /// </summary>
        /// <returns>时间受限进程的简要概述</returns>
        public override string ToString()
        {
            return base.ToString() + "进程时间限制为：" + timeLimit + "秒";
        }

        /// <summary>
        /// 关闭掉该程序，并提前设置为完全禁用
        /// </summary>
        public void Ban()
        {
            Process[] processes = Process.GetProcessesByName(Name);
            foreach (Process process in processes)
            {
                process.Kill();
            }
            time = timeLimit;
        }
    }
}