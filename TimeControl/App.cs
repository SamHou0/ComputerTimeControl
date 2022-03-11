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
        /// <summary>
        /// 返回进程的简要概述
        /// </summary>
        /// <returns>进程的简要概述</returns>
        public override string ToString()
        {
            return Name + " 已使用 " + time+" 秒！";
        }
        public App(string name, string location)
        {
            this.name = name;
            this.location = location;
            Reset();
        }
        /// <summary>
        /// 运行一次（一秒）
        /// </summary>
        public virtual void Run()
        {
            time++;
        }
        /// <summary>
        /// 重设时间
        /// </summary>
        public void Reset()
        {
            time = 0;
        }
    }
}
