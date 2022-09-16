using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TimeControl.AppControl;
using TimeControl.Tools;

namespace TimeControl.Windows
{
    public partial class TimeInput : Form
    {
        private AppController appController;
        /// <summary>
        /// 创建一个新的输入窗口，并添加进程
        /// </summary>
        /// <param name="appController">进程列表控制器，用于添加进程</param>
        public TimeInput(AppController appController)
        {
            InitializeComponent();
            this.appController = appController;
            Process[] processes=Process.GetProcesses();
            foreach (Process process in processes)
            {
                if(!string.IsNullOrEmpty( process.MainWindowTitle))
                    processBox.Items.Add(process.ProcessName);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(processBox.SelectedIndex<0)
            {
                MessageBox.Show("请选择一个进程","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string appName = processBox.Items[processBox.SelectedIndex].ToString();
            if (appName.ToLower() == "timecontrol" ||
                appName.ToLower() == "timecontrolconsole")
            {
                MessageBox.Show("不能为本程序添加监控！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int restInterval= TimeConvert.ToIntSeconds(Convert.ToInt32(restMinuteBox.Value))+Convert.ToInt32(restSecondBox.Value);
            if (timeSecondBox.Value == 0&&timeMinuteBox.Value==0)
            {
                appController.AddByName(appName,0,restInterval);
            }
            else if (timeSecondBox.Value == 1&&timeMinuteBox.Value==0)
                appController.AddByName(appName,restInterval);
            else
            {
                appController.AddByName(appName,TimeConvert.ToIntSeconds(Convert.ToInt32(timeMinuteBox.Value))+
                    Convert.ToInt32(timeSecondBox.Value),restInterval);
            }
            Close();
        }

        private void addProcessButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(processInputBox.Text))
            {
                processBox.Items.Add(processInputBox.Text);
            }
        }
    }
}
