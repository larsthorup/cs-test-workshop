using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLib
{
    public static class TimeSpanExtension
    {
        public static string ToDisplayString(this TimeSpan timeSpan)
        {
            if (timeSpan < TimeSpan.FromSeconds(5))
            {
                return "now";
            }
            else if (timeSpan < TimeSpan.FromMinutes(1))
            {
                return string.Format("{0} seconds ago", timeSpan.Seconds.ToString());
            }
            else if (timeSpan < TimeSpan.FromHours(1))
            {
                return string.Format("{0} minutes ago", timeSpan.Minutes.ToString());
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
