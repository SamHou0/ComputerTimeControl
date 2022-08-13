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
        private FileStream fileStream = new(TimeControlFile.TimeFile,
            FileMode.OpenOrCreate,
            FileAccess.ReadWrite, FileShare.None);
        private StreamWriter streamWriter;
        private ListBox listBox;
        private List<App> apps;
        private Timer timer;

        public AppController(ListBox listBox, Timer timer)
        {
            streamWriter = new(fileStream);
            this.listBox = listBox;
            apps = new List<App>();
            this.timer = timer;
            StreamReader streamReader = new(fileStream);
            int lineNumber = 1;
            string name = null;
            int time = 0;
            int timeLimit = 0;
            while (!streamReader.EndOfStream)//读取文件，添加进程
            {
                string line = streamReader.ReadLine();
                if (line == "//")
                {
                    if (timeLimit == 0)
                    {
                        App app = new(name, time, streamWriter);
                        app.SaveToFile();
                        apps.Add(app);

                    }
                    else
                    {
                        LimitedApp limitedApp = new LimitedApp(name, time, timeLimit, streamWriter);
                        limitedApp.SaveToFile();
                        apps.Add(limitedApp);
                    }

                    lineNumber = 1;
                    name = null;
                    time = 0;
                    timeLimit = 0;

                    continue;
                }
                else
                {
                    if (lineNumber == 1)
                        name = line;
                    else if (lineNumber == 2)
                        time = Convert.ToInt32(line);
                    else if (lineNumber == 3)
                        timeLimit = Convert.ToInt32(line);

                    lineNumber++;
                }
            }
            Refresh();
        }

        /// <summary>
        /// 刷新列表显示
        /// </summary>
        public void Refresh()
        {
            timer.Stop();
            listBox.Items.Clear();
            foreach (App app in apps)
            {
                listBox.Items.Add(app.ToString());
            }
            timer.Start();
        }
        /// <summary>
        /// 根据名称添加进程
        /// </summary>
        /// <param name="name">要添加的进程名称</param>
        public void AddByName(string name)
        {
            timer.Stop();
            apps.Add(new App(name, 0, streamWriter));
            Refresh();
        }
        /// <summary>
        /// 根据名称添加时间受限的进程
        /// </summary>
        /// <param name="name">进程名称</param>
        /// <param name="timeLimit">限制时长（秒）</param>
        public void AddByName(string name, int timeLimit)
        {
            timer.Stop();
            apps.Add(new LimitedApp(name, 0, timeLimit,streamWriter));
            Refresh();
        }
        /// <summary>
        /// 跟踪所有进程，增加一秒
        /// </summary>
        public void Run()
        {
            fileStream.SetLength(0);
            foreach (App app in apps)//计算进程时间
            {
                if (Process.GetProcessesByName(app.Name).Length != 0)
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
            timer.Stop();
            if (listBox.SelectedIndex >= 0)
                apps.RemoveAt(listBox.SelectedIndex);
            Refresh();
        }
        /// <summary>
        /// 删除所有监控
        /// </summary>
        public void RemoveAll()
        {
            timer.Stop();
            apps.Clear();
            Refresh();
        }
        /// <summary>
        /// 重设全部累计时间
        /// </summary>
        public void Reset()
        {
            timer.Stop();
            foreach (App app in apps)
            {
                app.Reset();
            }
            timer.Start();
        }
        /// <summary>
        /// 删除不在运行的项目
        /// </summary>
        public void RemoveStopped()
        {
            timer.Stop();
            for (int i = 0; i < apps.Count; i++)
            {
                if (apps[i].IsRunning()==false)
                    apps.RemoveAt(i);
            }
        }
    }
}
