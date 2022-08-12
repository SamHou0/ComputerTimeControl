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
        /// <summary>
        /// 创建一个新的输入窗口，并添加进程
        /// </summary>
        /// <param name="appController">进程列表控制器，用于添加进程</param>
        /// <param name="appName">需要添加进程的名称</param>
        public TimeInput(AppController appController, string appName)
        {
            InitializeComponent();
            this.appController = appController;
            this.appName = appName;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (timeSecondBox.Value == 0)
            {
                appController.AddByName(appName,0);
            }
            else if (timeSecondBox.Value == 1)
                appController.AddByName(appName);
            else
            {
                appController.AddByName(appName,TimeConvert.ToIntSeconds(Convert.ToInt32(timeMinuteBox.Value))+
                    Convert.ToInt32(timeSecondBox.Value));
            }
            Close();
        }
    }
}
