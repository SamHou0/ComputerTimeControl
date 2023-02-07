using System.Diagnostics;

namespace TimeControl.Tools
{
    internal static class SystemControl
    {
        public static void Shutdown()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                RedirectStandardInput = true
            };
            Process process = Process.Start(processStartInfo);
            process.StandardInput.WriteLine("shutdown -s -f -t 0");
        }
    }
}