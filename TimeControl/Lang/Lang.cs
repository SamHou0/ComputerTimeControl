using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store;

namespace TimeControl.Lang
{
    internal static class App
    {
        private static LangModel[] src =
        {
            new LangModel(),

            new LangModel
            {
                Info = new LangInfo {
                Contributer = "GreatHuang2007"},
                Name = new LangName{
                InternalName = "en",
                DisplayName = "English"},
                TimeControl = "Computer Time Control",
                planner = "Schedule Editor",
                taskstart = "Start selected task",
                taskend = "Mark selected as completed",
                plan = "Schedule",
                focus = "Focus",
                startlock = "Unlock in minutes",
                whitelistapps = "Path of the programs wished to use (Line by line)",
                deepFocus = "Deep focus",
                dfWarning = "ONCE you click the Unlock button, your device will IMMEDIATELY SHUTDOWN. And during the time you set, you computer will automatically shutdown if this program is included in Windows scheduled tasks list."
            }
        };

        private static LangModel Current = src[1];

        public static List<LangName> getLangList()
        {
            List<LangName> res = new List<LangName>();
            foreach (LangModel i in src)
                res.Add(i.Name);
            return res;
        }

        public static LangModel getCurrent() { return Current; }

        public static void setCurrent(LangModel i) { Current = i; }
    }
}
