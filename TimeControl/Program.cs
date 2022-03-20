using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
    }
}
