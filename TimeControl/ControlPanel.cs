using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace TimeControl
{
    public partial class ControlPanel : Form
    {
        bool closable = false;
        List<App> appList = new List<App>();
        #region Dllimport

        [Flags]
        public enum ACCESS_MASK : uint
        {
            DELETE = 0x00010000,
            READ_CONTROL = 0x00020000,
            WRITE_DAC = 0x00040000,
            WRITE_OWNER = 0x00080000,
            SYNCHRONIZE = 0x00100000,

            STANDARD_RIGHTS_REQUIRED = 0x000F0000,

            STANDARD_RIGHTS_READ = 0x00020000,
            STANDARD_RIGHTS_WRITE = 0x00020000,
            STANDARD_RIGHTS_EXECUTE = 0x00020000,

            STANDARD_RIGHTS_ALL = 0x001F0000,

            SPECIFIC_RIGHTS_ALL = 0x0000FFFF,

            ACCESS_SYSTEM_SECURITY = 0x01000000,

            MAXIMUM_ALLOWED = 0x02000000,

            GENERIC_READ = 0x80000000,
            GENERIC_WRITE = 0x40000000,
            GENERIC_EXECUTE = 0x20000000,
            GENERIC_ALL = 0x10000000,

            DESKTOP_READOBJECTS = 0x00000001,
            DESKTOP_CREATEWINDOW = 0x00000002,
            DESKTOP_CREATEMENU = 0x00000004,
            DESKTOP_HOOKCONTROL = 0x00000008,
            DESKTOP_JOURNALRECORD = 0x00000010,
            DESKTOP_JOURNALPLAYBACK = 0x00000020,
            DESKTOP_ENUMERATE = 0x00000040,
            DESKTOP_WRITEOBJECTS = 0x00000080,
            DESKTOP_SWITCHDESKTOP = 0x00000100,

            WINSTA_ENUMDESKTOPS = 0x00000001,
            WINSTA_READATTRIBUTES = 0x00000002,
            WINSTA_ACCESSCLIPBOARD = 0x00000004,
            WINSTA_CREATEDESKTOP = 0x00000008,
            WINSTA_WRITEATTRIBUTES = 0x00000010,
            WINSTA_ACCESSGLOBALATOMS = 0x00000020,
            WINSTA_EXITWINDOWS = 0x00000040,
            WINSTA_ENUMERATE = 0x00000100,
            WINSTA_READSCREEN = 0x00000200,

            WINSTA_ALL_ACCESS = 0x0000037F
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public int bInheritHandle;
        }

        [DllImport("kernel32.dll")]
        private static extern uint GetCurrentThreadId();

        [DllImport("user32.dll", EntryPoint = "CreateDesktop", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr CreateDesktop(
            [MarshalAs(UnmanagedType.LPWStr)] string desktopName,
            [MarshalAs(UnmanagedType.LPWStr)] string device, // must be null.
            [MarshalAs(UnmanagedType.LPWStr)] string deviceMode, // must be null,
            [MarshalAs(UnmanagedType.U4)] int flags, // use 0
            [MarshalAs(UnmanagedType.U4)] ACCESS_MASK accessMask,
            [MarshalAs(UnmanagedType.LPStruct)] SECURITY_ATTRIBUTES attributes);

        [DllImport("user32.dll", EntryPoint = "CreateDesktop", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr CreateDesktop(
            [MarshalAs(UnmanagedType.LPWStr)] string desktopName,
            [MarshalAs(UnmanagedType.LPWStr)] string device, // must be null.
            [MarshalAs(UnmanagedType.LPWStr)] string deviceMode, // must be null,
            [MarshalAs(UnmanagedType.U4)] int flags, // use 0
            [MarshalAs(UnmanagedType.U4)] ACCESS_MASK accessMask,
            IntPtr attributes);

        [DllImport("user32.dll", EntryPoint = "CloseDesktop", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseDesktop(IntPtr handle);

        [DllImport("user32.dll")]
        public static extern bool SwitchDesktop(IntPtr hDesktop);


        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetThreadDesktop(IntPtr hDesktop);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetThreadDesktop(uint dwThreadId);
        #endregion
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            IntPtr nowDesktop = GetThreadDesktop(GetCurrentThreadId());
            IntPtr newDesktop = CreateDesktop("Lock", null, null, 0, ACCESS_MASK.GENERIC_ALL, IntPtr.Zero);
            SwitchDesktop(newDesktop);
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                SetThreadDesktop(newDesktop);
                Lock _lock = new Lock(Convert.ToInt32(timeBox.Value), unlockPasswordBox.Text);
                Application.Run(_lock);
            }).Wait();
            SwitchDesktop(nowDesktop);
            CloseDesktop(newDesktop);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closable)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closable = true;
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://icons8.com/icon/19614/icon");
        }

        private void backgroundProcessMonitor_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                foreach (App app in appList)//计算进程时间
                {
                    if (Process.GetProcessesByName(app.Name).Length != 0)
                    { app.Run(); }
                }
                Thread.Sleep(1000);
            }
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            backgroundProcessMonitor.RunWorkerAsync();
        }
        
        private void appAddButton_Click(object sender, EventArgs e)//添加打开的窗口
        {
            appList.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (!string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    appList.Add(new App(process.ProcessName, process.MainModule.FileName));
                }
            }
            ListBoxController.Refresh(usageBox, appList);
        }

        private void removeButton_Click(object sender, EventArgs e)//移除所有的已添加窗口
        {
            appList.Clear();
            ListBoxController.Refresh(usageBox, appList);
        }

        private void refreshButton_Click(object sender, EventArgs e)//重新获取所有软件所用时间
        {
            ListBoxController.Refresh(usageBox, appList);
        }
    }
}
