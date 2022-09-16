using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using TimeControl.Tools;
using TimeControl.Windows;

namespace TimeControl
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            IntPtr nowDesktop = Dllimport.GetThreadDesktop(Dllimport.GetCurrentThreadId());
            try
            {
                bool hide = false;
                if (args.Length > 0)
                {
                    if (args[0] == "hide")
                    {
                        hide = true;
                    }
                }
                Process[] processes = Process.GetProcessesByName("TimeControl");
                if (processes.Length > 1)
                {
                    if (MessageBox.Show(
                        "当前已经启动TimeControl，不能启动多个实例，是否要重新启动？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        foreach (Process process in processes)
                        {
                            if (process.Id != Environment.ProcessId)
                                process.Kill();
                        }
                    }
                    else
                        return;
                }
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ControlPanel(hide));
            }
            catch(Exception ex)
            {
                Dllimport.SwitchDesktop(nowDesktop);
                File.Delete(TimeControlFile.TempTimeFile);
                File.AppendAllText(TimeControlFile.LogFile, DateTime.Now.ToString() + Environment.NewLine + "===Error==="
                    + Environment.NewLine);
                File.AppendAllText(TimeControlFile.LogFile, ex.ToString() + Environment.NewLine);
                if (ex is InvalidOperationException)
                {
                    MessageBox.Show("可能发生了文件错误，请检查保存的文件是否有效或删除配置文件。","错误",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                MessageBox.Show(ex.Message+Environment.NewLine+"以上为错误消息，已保存到"+TimeControlFile.LogFile
                    + "，请反馈此问题到项目主页Issue。保护程序已暂时关闭。", "TimeControl发生错误",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                Process.Start("explorer.exe", "https://gitee.com/Sam-Hou/ComputerTimeControl/issues");
                //关闭保护进程
                Process[] processes = Process.GetProcessesByName("TimeControlConsole");
                foreach (Process process in processes)
                    process.Kill();
            }
        }
    }
}
