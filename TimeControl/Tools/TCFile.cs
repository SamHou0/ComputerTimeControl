using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using TimeControl.AppControl;
using TimeControl.Data;

namespace TimeControl.Tools
{
    public static class TCFile
    {
        public static readonly string BaseLocation = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + "\\TimeControl";

        //密码
        public static readonly string PassLocation = BaseLocation + "\\TCPass.txt";//获取密码位置

        //计时
        public static readonly string TimeFileDirectory = BaseLocation
            + "\\TCTimeData";

        //日志
        public static readonly string LogFile = BaseLocation + "\\Log.txt";

        //屏保
        public static readonly string WhiteAppLocation = BaseLocation + "\\WhiteApp.txt";//应用白名单保存

        public static readonly string TempTimeFile = BaseLocation + "\\Temp.txt";
        public static readonly string NoteFile = BaseLocation + "\\Notes.txt";

        //深度屏保
        public static readonly string DeepTempTimeFile = BaseLocation + "DeepTemp.txt";

        //自动关机
        public static readonly string ShutdownSpan = BaseLocation + "\\Shutdown.txt";

        //数据显示
        public static readonly string SavedData = BaseLocation + "\\SavedData.xml";

        public static readonly string SavedDataDir = BaseLocation + "\\SavedData";

        public static string[] SavedDataFiles
        {
            get
            {
                return Directory.GetFiles(SavedDataDir);
            }
        }

        public static void SaveApps(List<App> apps)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(TimeFileDirectory);
            FileInfo[] files = directoryInfo.GetFiles();
            if (files.Length >= 10)
            {
                foreach (FileInfo file in files)
                    File.Delete(file.FullName);
            }
            using (StreamWriter sw = new StreamWriter(TimeFileDirectory +
                $"\\{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.xml"))
            {
                XmlSerializer xmlSerializer = new(typeof(List<AppInformation>));
                List<AppInformation> list = new List<AppInformation>();
                foreach (App app in apps)
                {
                    list.Add(app.appInformation);
                }
                xmlSerializer.Serialize(sw, list);
            }
        }

        public static List<App> ReadApps()
        {
            List<App> apps = new();
            FileInfo latestFile = GetLatestAppsFile();
            using (StreamReader sr = new StreamReader(latestFile.FullName))
            {
                XmlSerializer xmlSerializer = new(typeof(List<AppInformation>));
                List<AppInformation> infos = null;
                try
                {
                    infos = (List<AppInformation>)xmlSerializer.Deserialize(sr);
                }
                catch
                {
                    if (MessageBox.Show("可能发生了无效文件错误，是否尝试删除最新的一份配置文件并重启？", "错误",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        sr.Close();
                        File.Delete(GetLatestAppsFile().FullName);
                        Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\TimeControl.exe");
                        Environment.Exit(2);
                    }
                }
                foreach (AppInformation information in infos)
                {
                    if (information.timeLimit != 1)
                        apps.Add(new LimitedApp(information));
                    else
                        apps.Add(new App(information));
                }
            }
            return apps;
        }

        public static FileInfo GetLatestAppsFile()
        {
            DirectoryInfo directory = new DirectoryInfo(TimeFileDirectory);
            FileInfo latestFile = directory.GetFiles("*.xml")[0];
            //获取最新文件
            foreach (FileInfo file in directory.GetFiles("*.xml"))
            {
                if (latestFile.LastWriteTime < file.LastWriteTime)
                {
                    latestFile = file;
                }
            }
            return latestFile;
        }

        public static void SaveTimeData(TimeData time)
        {
            using (StreamWriter sw = new(SavedData))
            {
                XmlSerializer xmlSerializer = new(typeof(TimeData));
                xmlSerializer.Serialize(sw, time);
            }
        }

        public static TimeData ReadTimeData()
        {
            using (StreamReader sr = new(SavedData))
            {
                XmlSerializer xmlSerializer = new(typeof(TimeData));
                return (TimeData)xmlSerializer.Deserialize(sr);
            }
        }

        public static void ChangeGoal(string name)
        {
            foreach (string file in SavedDataFiles)
            {
                if (Path.GetFileNameWithoutExtension(file) == name)
                {
                    string currentName = ReadTimeData().GoalName;
                    File.Move(SavedData, SavedDataDir + "\\" + currentName + ".xml");
                    File.Move(file, SavedData);
                    return;
                }
            }
        }

        public static void AddGoal(TimeData timeData)
        {
            using (StreamWriter sw = new(SavedDataDir + "\\" + timeData.GoalName + ".xml"))
            {
                XmlSerializer xmlSerializer = new(typeof(TimeData));
                xmlSerializer.Serialize(sw, timeData);
            }
        }

        public static void RemoveGoal(string name)
        {
            File.Delete(SavedDataDir + "\\" + name + ".xml");
        }
    }
}