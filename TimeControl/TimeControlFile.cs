using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl
{
    internal class TimeControlFile
    {
        public static readonly string tcPassLocation = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + "\\TCPass.txt";//获取密码位置
        public static readonly string tcTimeFileLocation = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + "\\TCTimeData.txt";
    }
}
