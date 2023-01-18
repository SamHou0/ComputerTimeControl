using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl.Data
{
    public class TimeData
    {
        public string GoalName { get; set; } ="";
        public TimeSpan LockTime { get; set; }=new TimeSpan();
        public TimeSpan DeepLockTime { get; set; } = new TimeSpan();
        public void AddTime(TimeSpan time)
        {
            LockTime += time;
        }
        public void AddDeepTime(TimeSpan time)
        {
            DeepLockTime += time;
        }
        public TimeSpan GetTimeSum()
        {
            return LockTime + DeepLockTime;
        }
    }
}
