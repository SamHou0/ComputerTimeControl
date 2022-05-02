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
    [Serializable]
    public class AppController
    {
        private List<App> apps;

        public AppController(ListBox listBox, Timer timer)
        {
            apps = new List<App>();
            Refresh(timer, listBox);
        }

        /// <summary>
        /// 刷新列表显示
        /// </summary>
        public void Refresh(Timer timer, ListBox listBox)
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
        public void AddByName(string name, Timer timer, ListBox listBox)
        {
            timer.Stop();
            Process[] processes = Process.GetProcessesByName(name);
            try
            {
                foreach (Process process in processes)
                {
                    apps.Add(new App(process.ProcessName, 0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh(timer, listBox);
        }

        /// <summary>
        /// 根据名称添加时间受限的进程
        /// </summary>
        /// <param name="name">进程名称</param>
        /// <param name="limitTime">限制时长（秒）</param>
        public void AddByName(string name, int limitTime, Timer timer, ListBox listBox)
        {
            timer.Stop();
            Process[] processes = Process.GetProcessesByName(name);
            try
            {
                foreach (Process process in processes)
                {
                    apps.Add(new LimitedApp(process.ProcessName, 0, limitTime));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh(timer, listBox);
        }

        /// <summary>
        /// 跟踪所有进程，增加一秒
        /// </summary>
        public void Run()
        {
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
        public void Remove(Timer timer, ListBox listBox)
        {
            timer.Stop();
            if (listBox.SelectedIndex >= 0)
                apps.RemoveAt(listBox.SelectedIndex);
            Refresh(timer, listBox);
        }

        /// <summary>
        /// 删除所有监控
        /// </summary>
        public void RemoveAll(Timer timer, ListBox listBox)
        {
            timer.Stop();
            apps.Clear();
            Refresh(timer, listBox);
        }

        public void ResetAll(Timer timer, ListBox listBox)
        {
            foreach (App app in apps)
                app.Reset();
            Refresh(timer, listBox);
        }
    }
}