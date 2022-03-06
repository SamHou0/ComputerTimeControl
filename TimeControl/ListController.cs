using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl
{
     internal class ListController
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


        public void Refresh()
        {
            timer.Stop();
            listBox.Items.Clear();
            foreach (App app in apps)
            {
                listBox.Items.Add(app.ReportApp());
            }
            timer.Start();
        }
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
        public void Run()
        {
            foreach (App app in apps)//计算进程时间
            {
                if (Process.GetProcessesByName(app.Name).Length != 0)
                { app.Run(); }
            }
            Refresh();
        }
        public void Remove()
        {
            timer.Stop();
            if (listBox.SelectedIndex >= 0)
                apps.RemoveAt(listBox.SelectedIndex);
            Refresh();
        }
    }
}
