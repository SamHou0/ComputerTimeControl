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
        public override void Run()//运行一次（一秒）
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
        public void Ban()//禁用掉该程序
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
