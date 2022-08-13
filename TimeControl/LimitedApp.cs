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
    public class LimitedApp : App
    {
        private readonly int timeLimit;
        
        public LimitedApp(string name,int time,int timeLimit,StreamWriter streamWriter) : base(name,time)
        {
            this.timeLimit = timeLimit;
            this.streamWriter = streamWriter;
        }
        /// <summary>
        /// 运行一次（一秒），并根据情况显示警告或关闭进程，然后保存到文件
        /// </summary>
        public override void Run()
        {
            time++;
            if (time == timeLimit - 30)
            {
                LimitWarningWindow warningWindow = new(this);
                warningWindow.Show();
            }
            if (time>=timeLimit)
            {
                Ban();
            }
            SaveToFile();
        }
        public override void SaveToFile()
        {
            streamWriter.WriteLine(Name);
            streamWriter.WriteLine(time);
            streamWriter.WriteLine(timeLimit);
            streamWriter.WriteLine("//");
            streamWriter.Flush();
        }
        /// <summary>
        /// 返回时间受限进程的简要概述
        /// </summary>
        /// <returns>时间受限进程的简要概述</returns>
        public override string ToString()
        {
            return base.ToString() + "进程时间限制为：" +TimeConvert.DescribeTime(timeLimit);
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
