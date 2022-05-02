using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl
{
    public partial class TimeInput : Form
    {
        private AppController appController;
        private readonly string appName;
        private Timer timer;
        private ListBox listBox;

        /// <summary>
        /// 创建一个新的输入窗口，并添加进程
        /// </summary>
        /// <param name="appController">进程列表控制器，用于添加进程</param>
        /// <param name="appName">需要添加进程的名称</param>
        public TimeInput(AppController appController, string appName, Timer timer, ListBox listBox)
        {
            InitializeComponent();
            this.appController = appController;
            this.appName = appName;
            this.timer = timer;
            this.listBox = listBox;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (timeBox.Value == 0)
            {
                appController.AddByName(appName, timer, listBox);
            }
            else
            {
                appController.AddByName(appName, Convert.ToInt32(timeBox.Value), timer, listBox);
            }
            Close();
        }
    }
}