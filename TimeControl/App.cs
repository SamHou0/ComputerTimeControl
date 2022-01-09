using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl
{
    internal class App
    {
        private string name;
        private string location;
        public string Name { get { return name; }}
        private int time;
        
        public string ReportApp()
        {
            return Name + " 已使用 " + time+" 秒！";
        }
        public App(string name, string location)
        {
            this.name = name;
            this.location = location;
            time = 0;
        }
        public void Run()
        {
            time++;
        }
    }
}
