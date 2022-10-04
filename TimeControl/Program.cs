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
                    "��ǰ�Ѿ�����TimeControl�������������ʵ�����Ƿ�Ҫ����������",
                "��ʾ",
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
                ex = new Exception("δ֪�����޷�����");
            Dllimport.SwitchDesktop(nowDesktop);
            File.Delete(TimeControlFile.TempTimeFile);
            File.AppendAllText(TimeControlFile.LogFile, DateTime.Now.ToString() + Environment.NewLine + "===Error==="
                + Environment.NewLine);
            File.AppendAllText(TimeControlFile.LogFile, ex.ToString() + Environment.NewLine);
            if (ex is InvalidOperationException)
            {
            }
            MessageBox.Show(ex.Message + Environment.NewLine + "����Ϊ������Ϣ���ѱ��浽" + TimeControlFile.LogFile
                + "���뷴�������⵽��Ŀ��ҳIssue��������������ʱ�رա�", "TimeControl��������",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            Process.Start("explorer.exe", "https://gitee.com/Sam-Hou/ComputerTimeControl/issues");
            //�رձ�������
            Process[] processes = Process.GetProcessesByName("TimeControlConsole");
            foreach (Process process in processes)
                process.Kill();
            Environment.Exit(1);
        }
    }
}