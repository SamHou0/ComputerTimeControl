using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TimeControl.Tools;

namespace TimeControl.AppControl
{
    public class AppController
    {
        private ListBox listBox;
        private List<App> apps;
        private Timer processMonitorTimer;
        private bool refreshable;

        public AppController(ListBox listBox, Timer timer)
        {
            refreshable = true;
            this.listBox = listBox;
            apps = new List<App>();
            processMonitorTimer = timer;
            if (Directory.Exists(TCFile.TimeFileDirectory))
            {
                apps = TCFile.ReadApps();
            }
            else
            {
                Directory.CreateDirectory(TCFile.TimeFileDirectory);
                Save();
            }
            Refresh();
        }

        /// <summary>
        /// Refresh the display of the list on the form.
        /// </summary>
        public void Refresh()
        {
            if (!refreshable)
            {
                processMonitorTimer.Start();
                return;
            }
            processMonitorTimer.Stop();
            listBox.Items.Clear();
            foreach (App app in apps)
            {
                listBox.Items.Add(app.ToString());
            }
            processMonitorTimer.Start();
            refreshable = false;
        }

        /// <summary>
        /// Add process by name.
        /// </summary>
        /// <param name="name">The name of the process</param>
        public void AddByName(string name, int restInterval)
        {
            processMonitorTimer.Stop();
            apps.Add(new App(name, 0, restInterval));
            Save();
            Refresh();
        }

        /// <summary>
        /// Add a limited process by name.
        /// </summary>
        /// <param name="name">The name of the process</param>
        /// <param name="timeLimit">The time limit of the process</param>
        public void AddByName(string name, int timeLimit, int restInterval)
        {
            processMonitorTimer.Stop();
            apps.Add(new LimitedApp(name, 0, timeLimit, restInterval));
            Save();
            Refresh();
        }

        /// <summary>
        /// Track all the processes and add 1 second to each running process.
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
            refreshable = true;
        }

        /// <summary>
        /// Remove the process selected in the listbox
        /// </summary>
        public void Remove()
        {
            if (listBox.SelectedIndex >= 0)
            {
                processMonitorTimer.Stop();
                apps.RemoveAt(listBox.SelectedIndex);
            }
            Save();
            Refresh();
        }

        /// <summary>
        /// Delete all the monitors.
        /// </summary>
        public void RemoveAll()
        {
            processMonitorTimer.Stop();
            apps.Clear();
            TCFile.SaveApps(apps);
            Refresh();
        }

        /// <summary>
        /// Reset all the apps' time.
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
            TCFile.SaveApps(apps);
        }
    }
}