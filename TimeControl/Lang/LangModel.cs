using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl.Lang
{
    internal class LangName
    {
        public string InternalName;
        public string DisplayName;
    };

    internal class LangInfo
    {
        public string Contributer;
    }
    internal class LangModel
    {
        public LangInfo Info = new LangInfo
        { 
            Contributer = "SamHou0"
        };
        public LangName Name = new LangName
        {
            InternalName = "zh-cn",
            DisplayName = "中文（简体）"
        };
        public string TimeControl = "时间管理";
        public string planner = "打开日程编辑器";
        public string taskstart = "开始日程";
        public string taskend = "标记完成日程";
        public string plan = "日程计划";
        public string focus = "专注屏保";
        public string startlock = "启动屏保（分）";
        public string whitelistapps = "白名单应用路径（一行一个）";
        public string deepFocus = "深度专注";
        public string dfWarning = "启动屏保后，计算机将立刻关机，并在持续时间内开机时自动关闭。（必须设置开机启动）";
    };
}
