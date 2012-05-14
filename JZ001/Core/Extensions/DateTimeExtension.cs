using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Geekors.GWP7.Core.Extensions
{
    public static class DateTimeExtension
    {

        /// <summary>
        /// Convert timestamp to Utc date time.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ToUtcDateTime(this double value)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(value);
        }

        /// <summary>
        /// Convert datetime to timestamp of Unix.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Double ToTimestamp(this DateTime value)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = value - origin;
            return Math.Floor(diff.TotalSeconds);
        }
    }
}
