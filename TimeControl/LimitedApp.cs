using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace TimeControl
{
    public class LimitedApp : App
    {
        private int timeLimit;
        public LimitedApp(string name, string location,int timeLimit) : base(name, location)
        {
            this.timeLimit = timeLimit;
        }
        /// <summary>
        /// 运行一次（一秒），并根据情况显示警告或关闭进程
        /// </summary>
        public override void Run()
        {
            base.Run();
            if (time == timeLimit - 30)
            {
                LimitWarningWindow warningWindow = new(this);
                warningWindow.Show();
            }
            if (time>=timeLimit)
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
        /// 禁用掉该程序
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
