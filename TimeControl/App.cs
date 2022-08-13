using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TimeControl
{
    public class App
    {
        private readonly string name;
        public string Name { get { return name; }}
        internal int time;
        internal StreamWriter streamWriter;

        /// <summary>
        /// 返回进程的简要概述
        /// </summary>
        /// <returns>进程的简要概述</returns>
        public override string ToString()
        {
            return Name + " 已使用 " + TimeConvert.DescribeTime(time);
        }
        public App(string name,int time,StreamWriter streamWriter)
        {
            this.time = time;
            this.streamWriter = streamWriter;
            this.name = name;
        }
        /// <summary>
        /// 仅供子类使用的构造函数
        /// </summary>
        internal App(string name,int time)
        {
            this.time = time;
            this.name = name;
        }
        /// <summary>
        /// 运行一次（一秒），并保存
        /// </summary>
        public virtual void Run()
        {
            time++;
            SaveToFile();
        }
        public virtual void SaveToFile()
        {
            streamWriter.WriteLine(Name);
            streamWriter.WriteLine(time);
            streamWriter.WriteLine("//");
            streamWriter.Flush();
        }
        /// <summary>
        /// 重设时间
        /// </summary>
        public void Reset()
        {
            time = 0;
        }
        public bool IsRunning()
        {
            Process[] processes=Process.GetProcessesByName(name);
            if (processes.Length>0)
                return true;
            return false;
        }
    }
}
