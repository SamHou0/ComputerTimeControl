using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl
{
    internal class TimeControlFile
    {
        public static readonly string BaseLocation = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + "\\TimeControl";
        public static readonly string PassLocation =BaseLocation + "\\TCPass.txt";//获取密码位置
        public static readonly string TimeFile = BaseLocation
            + "\\TCTimeData.txt";
        public static readonly string GameData = BaseLocation + "GameData.txt";
    }
}
