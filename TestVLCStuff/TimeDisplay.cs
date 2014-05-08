using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrafficVideoSplitter
{
    class TimeDisplay
    {
        private TimeSpan time;

        public TimeDisplay()
        {
            time = new TimeSpan(0, 0, 0);
        }

        public TimeDisplay(double ms)
        {
            time = new TimeSpan(TimeSpan.FromMilliseconds(ms).Hours, TimeSpan.FromMilliseconds(ms).Minutes, TimeSpan.FromMilliseconds(ms).Seconds);
        }

        public TimeDisplay(TimeSpan ts)
        {
            time = ts;
        }

        public override string ToString()
        {
            return time.ToString();
        }
        public TimeSpan GetTimeSpan()
        {
            return time;
        }

        public static TimeDisplay operator +(TimeDisplay t1, TimeDisplay t2)
        {
            TimeSpan combined = t1.GetTimeSpan().Add(t2.GetTimeSpan());

            return new TimeDisplay(combined);
        }

        public static TimeDisplay operator -(TimeDisplay t1, TimeDisplay t2)
        {
            TimeSpan combined = t1.GetTimeSpan().Subtract(t2.GetTimeSpan());

            return new TimeDisplay(combined);
        }
    }
}
