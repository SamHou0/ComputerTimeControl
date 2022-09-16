﻿using Microsoft.Win32;

namespace BootHelper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            string path = Directory.GetCurrentDirectory() + "\\TimeControlConsole.exe";
            key.SetValue("TimeControl", path);
            if (args.Length > 0)
            {
                if (args[0] == "remove")
                {
                    key.DeleteValue("TimeControl");
                }
            }
        }
    }
}