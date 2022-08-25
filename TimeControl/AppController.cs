using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeControl
{
    public class AppController
    {
        private ListBox listBox;
        private List<App> apps;
        private Timer processMonitorTimer;

        public AppController(ListBox listBox, Timer timer)
        {
            this.listBox = listBox;
            apps = new List<App>();
            processMonitorTimer = timer;
            if (Directory.Exists(TimeControlFile.TimeFileDirectory))
            {
                apps = TimeControlFile.ReadFromXML();
            }
            else
            {
                Directory.CreateDirectory(TimeControlFile.TimeFileDirectory);
                Save();
            }
            Refresh();
        }

        /// <summary>
        /// 刷新列表显示
        /// </summary>
        public void Refresh()
        {
            processMonitorTimer.Stop();
            listBox.Items.Clear();
            foreach (App app in apps)
            {
                listBox.Items.Add(app.ToString());
            }
            processMonitorTimer.Start();
        }
        /// <summary>
        /// 根据名称添加进程
        /// </summary>
        /// <param name="name">要添加的进程名称</param>
        public void AddByName(string name, int restInterval)
        {
            processMonitorTimer.Stop();
            apps.Add(new App(name, 0, restInterval));
            Save();
            Refresh();
        }
        /// <summary>
        /// 根据名称添加时间受限的进程
        /// </summary>
        /// <param name="name">进程名称</param>
        /// <param name="timeLimit">限制时长（秒）</param>
        public void AddByName(string name, int timeLimit, int restInterval)
        {
            processMonitorTimer.Stop();
            apps.Add(new LimitedApp(name, 0, timeLimit, restInterval));
            Save();
            Refresh();
        }
        /// <summary>
        /// 跟踪所有进程，增加一秒
        /// </summary>
        public void Run()
        {
            foreach (App app in apps)//计算进程时间
            {
                if (Process.GetProcessesByName(app.appInformation.name).Length != 0)
                {
                    if (app is LimitedApp)
                    {
                        LimitedApp limitedApp = app as LimitedApp;
                        limitedApp.Run();
                    }
                    else
                        app.Run();
                }
            }
        }
        /// <summary>
        /// 移除所列表所选的进程
        /// </summary>
        public void Remove()
        {
            processMonitorTimer.Stop();
            if (listBox.SelectedIndex >= 0)
                apps.RemoveAt(listBox.SelectedIndex);
            Save();
            Refresh();
        }
        /// <summary>
        /// 删除所有监控
        /// </summary>
        public void RemoveAll()
        {
            processMonitorTimer.Stop();
            apps.Clear();
            TimeControlFile.SaveToXML(apps);
            Refresh();
        }
        /// <summary>
        /// 重设全部累计时间
        /// </summary>
        public void Reset()
        {
            processMonitorTimer.Stop();
            foreach (App app in apps)
            {
                app.Reset();
            }
            Refresh();
            Save();
            processMonitorTimer.Start();
        }
        public void Save()
        {
            TimeControlFile.SaveToXML(apps);
        }
    }
}
