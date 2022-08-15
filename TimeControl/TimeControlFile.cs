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
        public static readonly string TimeFile = BaseLocation
            + "\\TCTimeData.xml";
        public static FileStream FileStream;//使用前请先init
        public static readonly string GameData = BaseLocation + "GameData.txt";
        public static void SaveToXML(List<App> apps)
        {
            StreamWriter sw = new StreamWriter(FileStream);
            XmlSerializer xmlSerializer = new(typeof(List<AppInformation>));
            List<AppInformation> list = new List<AppInformation>();
            foreach (App app in apps)
            {
                list.Add(app.appInformation);
            }
            xmlSerializer.Serialize(sw, list);
        }
        public static List<App> ReadFromXML()
        {
            List<App> apps = new();
            StreamReader sr = new StreamReader(FileStream);
            XmlSerializer xmlSerializer = new(typeof(List<AppInformation>));
            List<AppInformation> infos = (List<AppInformation>)xmlSerializer.Deserialize(sr);
            foreach (AppInformation information in infos)
            {
                if (information.timeLimit != 0)
                    apps.Add(new LimitedApp(information));
                else
                    apps.Add(new App(information));
            }
            return apps;
        }
        public static void init()
        {
            FileStream = new(TimeFile,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite, FileShare.None);
        }
    }
}
