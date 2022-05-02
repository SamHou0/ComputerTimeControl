using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimeControl
{
    [Serializable]
    public class App
    {
        private readonly string name;

        public string Name
        { get { return name; } }

        internal int time;

        /// <summary>
        /// 返回进程的简要概述
        /// </summary>
        /// <returns>进程的简要概述</returns>
        public override string ToString()
        {
            return Name + " 已使用 " + time + " 秒！";
        }

        public App(string name, int time)
        {
            this.time = time;
            this.name = name;
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