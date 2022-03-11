using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl
{
     public class ListController
    {
        private ListBox listBox;
        private List<App> apps;
        private Timer timer;

        public ListController(ListBox listBox,Timer timer)
        {
            this.listBox = listBox;
            apps = new List<App>();
            this.timer = timer;
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
            Process[] processes = Process.GetProcessesByName(name);
            try
            {
                foreach (Process process in processes)
                {
                    apps.Add(new App(process.ProcessName, process.MainModule.FileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Refresh();
        }
        /// <summary>
        /// 根据名称添加时间受限的进程
        /// </summary>
        /// <param name="name">进程名称</param>
        /// <param name="limitTime">限制时长（秒）</param>
        public void AddByName(string name,int limitTime)
        {
            timer.Stop();
            Process[] processes = Process.GetProcessesByName(name);
            try
            {
                foreach (Process process in processes)
                {
                    apps.Add(new LimitedApp(process.ProcessName, process.MainModule.FileName,limitTime));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Refresh();
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
                        LimitedApp limitedApp=app as LimitedApp;
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
    }
}
