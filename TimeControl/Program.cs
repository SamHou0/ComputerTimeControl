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
                    MessageBox.Show("���ܷ������ļ��������鱣����ļ��Ƿ���Ч��ɾ�������ļ���","����",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                MessageBox.Show(ex.Message+Environment.NewLine+"����Ϊ������Ϣ���ѱ��浽"+TimeControlFile.LogFile
                    + "���뷴�������⵽��Ŀ��ҳIssue��������������ʱ�رա�", "TimeControl��������",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                Process.Start("explorer.exe", "https://gitee.com/Sam-Hou/ComputerTimeControl/issues");
                //�رձ�������
                Process[] processes = Process.GetProcessesByName("TimeControlConsole");
                foreach (Process process in processes)
                    process.Kill();
            }
        }
    }
}
