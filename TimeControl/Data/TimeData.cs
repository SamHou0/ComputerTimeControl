using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl.Data
{
    public class TimeData
    {
        public TimeSpan Time { get; set; }=new TimeSpan();
        public void AddTime(TimeSpan time)
        {
            Time += time;
        }
    }
}
