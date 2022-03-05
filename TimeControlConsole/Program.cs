using System.Diagnostics;
while (true)
{
    if (Process.GetProcessesByName("TimeControl").Length==0)
    {
        ProcessStartInfo process = new();
        process.FileName = "TimeControl.exe";
        process.Arguments = "hide";
        Process.Start(process);
    }
    Thread.Sleep(1000);
}
