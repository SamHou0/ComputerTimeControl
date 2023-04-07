using System;
using System.IO;
using System.Windows.Forms;
using TimeControl.Windows;

namespace TimeControl.Tools
{
    internal class LockHelper
    {
        public static void StartLock(string unlockPasswordHash, int minutes)
        {
            IntPtr nowDesktop = Dllimport.GetThreadDesktop(Dllimport.GetCurrentThreadId());
            IntPtr newDesktop = Dllimport.CreateDesktop("Lock", null, null, 0, Dllimport.ACCESS_MASK.GENERIC_ALL, IntPtr.Zero);
            Dllimport.SwitchDesktop(newDesktop);
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                Dllimport.SetThreadDesktop(newDesktop);
                Lock _lock;
                if (minutes != 0)
                    _lock = new(minutes, unlockPasswordHash);
                else
                    _lock = new(unlockPasswordHash);
                Application.Run(_lock);
            }).Wait();
            Dllimport.SwitchDesktop(nowDesktop);
            Dllimport.CloseDesktop(newDesktop);
        }

        public static void Interrupt()
        {
            IntPtr nowDesktop = Dllimport.GetThreadDesktop(Dllimport.GetCurrentThreadId());
            IntPtr newDesktop = Dllimport.CreateDesktop("Lock", null, null, 0, Dllimport.ACCESS_MASK.GENERIC_ALL, IntPtr.Zero);
            Dllimport.SwitchDesktop(newDesktop);
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                Dllimport.SetThreadDesktop(newDesktop);
                InterruptWindow interruptWindow = new InterruptWindow();
                Application.Run(interruptWindow);
            }).Wait();
            Dllimport.SwitchDesktop(nowDesktop);
            Dllimport.CloseDesktop(newDesktop);
        }

        public static void StartDeepLock(int minutes)
        {
            TimeSpan deepTime = new(0, minutes, 0);
            File.WriteAllText(TCFile.DeepTempTimeFile, DateTime.Now + Environment.NewLine + deepTime);
            SystemControl.Shutdown();
            Application.Exit();
        }
    }
}