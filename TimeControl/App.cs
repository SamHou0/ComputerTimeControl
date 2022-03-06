using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl
{
    public class App
    {
        private string name;
        private string location;
        public string Name { get { return name; }}
        internal int time;
        
        public string ReportApp()
        {
            return Name + " 已使用 " + time+" 秒！";
        }
        public App(string name, string location)
        {
            this.name = name;
            this.location = location;
            Reset();
        }
        public virtual void Run()//运行一次（一秒）
        {
            time++;
        }
        public void Reset()//重设时间
        {
            time = 0;
        }
    }
}
