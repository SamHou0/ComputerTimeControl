using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.AppControl
{
    public class App
    {
        public AppInformation appInformation = new();
        internal int tempTime = 0;
        /// <summary>
        /// 返回进程的简要概述
        /// </summary>
        /// <returns>进程的简要概述</returns>
        public override string ToString()
        {
            return appInformation.name + " 已使用：" + TimeConvert.DescribeTime(appInformation.time);
        }
        public App(string name, int time, int restInterval)
        {
            appInformation.time = time;
            appInformation.name = name;
            appInformation.restInterval = restInterval;
        }
        public App(AppInformation appInformation)
        {
            this.appInformation = appInformation;
        }

        /// <summary>
        /// 运行一次（一秒），并保存
        /// </summary>
        public virtual void Run()
        {
            appInformation.time++;
            CheckRest();
        }
        internal void CheckRest()
        {
            tempTime++;
            if (tempTime >= appInformation.restInterval && appInformation.restInterval != 0)
            {
                tempTime = 0;
                MessageBox.Show(appInformation.name + "休息时间已到，暂停休息一下吧。", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 重设时间
        /// </summary>
        public void Reset()
        {
            appInformation.time = 0;
        }
        public bool IsRunning()
        {
            Process[] processes = Process.GetProcessesByName(appInformation.name);
            if (processes.Length > 0)
                return true;
            return false;
        }
    }
}
