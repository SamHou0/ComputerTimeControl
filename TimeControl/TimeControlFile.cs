using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TimeControl
{
    public static class TimeControlFile
    {
        public static readonly string BaseLocation = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + "\\TimeControl";
        public static readonly string PassLocation = BaseLocation + "\\TCPass.txt";//获取密码位置
        public static readonly string TimeFileDirectory = BaseLocation
            + "\\TCTimeData";
        public static readonly string GameData = BaseLocation + "\\GameData.txt";
        public static readonly string LogFile = BaseLocation + "\\Log.txt";
        public static void SaveToXML(List<App> apps)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(TimeFileDirectory);
            FileInfo[] files = directoryInfo.GetFiles();
            if(files.Length>=10)
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
        public static List<App> ReadFromXML()
        {
            List<App> apps = new();
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
            using (StreamReader sr = new StreamReader(latestFile.FullName))
            {
                XmlSerializer xmlSerializer = new(typeof(List<AppInformation>));
                List<AppInformation> infos = (List<AppInformation>)xmlSerializer.Deserialize(sr);
                foreach (AppInformation information in infos)
                {
                    if (information.timeLimit != 0)
                        apps.Add(new LimitedApp(information));
                    else
                        apps.Add(new App(information));
                }
            }
            return apps;
        }
    }
}
