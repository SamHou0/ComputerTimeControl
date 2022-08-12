using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl
{
    static class TimeConvert
    {
        /// <summary>
        /// 获取时间的字符串介绍
        /// </summary>
        public static string DescribeTime(int seconds) =>
            $"{ToIntMinutes(seconds)}分{GetExtraSeconds(seconds)}秒";
        /// <summary>
        /// 舍去剩余的秒数，返回整时间分钟数
        /// </summary>
        public static int ToIntMinutes(int seconds)=>Convert.ToInt32(seconds / 60);
        /// <summary>
        /// 获取除去整数分后剩余的秒数
        /// </summary>
        public static int GetExtraSeconds(int seconds)=> Convert.ToInt32(seconds %60);
        /// <summary>
        /// 分钟转秒
        /// </summary>
        public static int ToIntSeconds(int minutes) => Convert.ToInt32(minutes * 60);
    }
}
