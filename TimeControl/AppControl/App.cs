using System.Diagnostics;
using System.Windows.Forms;
using TimeControl.Data;
using TimeControl.Tools;

namespace TimeControl.AppControl
{
    public class App
    {
        public AppInformation appInformation = new();
        internal int tempTime = 0;

        /// <summary>
        /// Returns a simple description of the app
        /// </summary>
        /// <returns>description</returns>
        public override string ToString()
        {
            return appInformation.name + " 已使用：" + TimeConvert.DescribeTime(appInformation.time);
        }

        public App(string name, int time, int restInterval)
        {
            appInformation.time = time;
            appInformation.name = name;
            appInformation.restInterval = restInterval;
            appInformation.timeLimit = 1;//Set to 1 if unlimited
        }

        public App(AppInformation appInformation)
        {
            this.appInformation = appInformation;
        }

        /// <summary>
        /// Add 1 second to the app's time and check rest.
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
        /// Rest app's time.
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