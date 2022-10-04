using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TimeControl.Tools;
using TimeControl.Windows;

namespace TimeControl
{
    internal static class Program
    {
        static IntPtr nowDesktop;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            nowDesktop = Dllimport.GetThreadDesktop(Dllimport.GetCurrentThreadId());
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
            Application.ThreadException += ExceptionHandler;
            AppDomain.CurrentDomain.UnhandledException += ExceptionHandler;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlPanel(hide));
        }

        private static void ExceptionHandler(object sender, EventArgs e) => CatchException(e);

        private static void CatchException(EventArgs e)
        {
            Exception ex;
            if (e is ThreadExceptionEventArgs)
            {
                ThreadExceptionEventArgs args = e as ThreadExceptionEventArgs;
                ex = args.Exception;
            }
            else if (e is UnhandledExceptionEventArgs)
            {
                UnhandledExceptionEventArgs args = e as UnhandledExceptionEventArgs;
                ex = args.ExceptionObject as Exception;
            }
            else
                ex = new Exception("未知错误，无法处理！");
            Dllimport.SwitchDesktop(nowDesktop);
            File.Delete(TimeControlFile.TempTimeFile);
            File.AppendAllText(TimeControlFile.LogFile, DateTime.Now.ToString() + Environment.NewLine + "===Error==="
                + Environment.NewLine);
            File.AppendAllText(TimeControlFile.LogFile, ex.ToString() + Environment.NewLine);
            if (ex is InvalidOperationException)
            {
            }
            MessageBox.Show(ex.Message + Environment.NewLine + "以上为错误消息，已保存到" + TimeControlFile.LogFile
                + "，请反馈此问题到项目主页Issue。保护程序已暂时关闭。", "TimeControl发生错误",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            Process.Start("explorer.exe", "https://gitee.com/Sam-Hou/ComputerTimeControl/issues");
            //关闭保护进程
            Process[] processes = Process.GetProcessesByName("TimeControlConsole");
            foreach (Process process in processes)
                process.Kill();
            Environment.Exit(1);
        }
    }
}