using System.Diagnostics;

namespace TimeControl.Tools
{
    public static class Command
    {
        public static void RunCommand(string command)
        {
            ProcessStartInfo info = new();
            info.FileName = "cmd.exe";
            info.CreateNoWindow = true;
            info.RedirectStandardInput = true;
            Process process = Process.Start(info);
            process.StandardInput.WriteLine(command);
            process.StandardInput.WriteLine("exit");
        }

        public static void RunCommand(string[] commands)
        {
            foreach (string command in commands)
            {
                RunCommand(command);
            }
        }
    }
}