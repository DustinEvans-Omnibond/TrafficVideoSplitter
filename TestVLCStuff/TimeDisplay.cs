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

        public TimeDisplay(int hours, int minutes, int seconds)
        {
            time = new TimeSpan(hours, minutes, seconds);
        }

        public TimeDisplay(string hours, string minutes, string seconds)
        {
            time = new TimeSpan(Int32.Parse(hours), Int32.Parse(minutes), Int32.Parse(seconds));
        }

        public override string ToString()
        {
            return time.ToString();
        }

        public string ToString(char option)
        {
            string timeString = "";
            switch (Char.ToUpper(option))
            {
                case 'C':
                    string hours = time.Hours.ToString();
                    string minutes = time.Minutes.ToString();
                    string seconds = time.Seconds.ToString();
                    if (hours.Length < 2) hours = "0" + hours;
                    if (minutes.Length < 2) minutes = "0" + minutes;
                    if (seconds.Length < 2) seconds = "0" + seconds;
                    timeString = hours + minutes + seconds;
                break;

                default:
                    timeString = this.ToString();
                break;
            }

            return timeString;
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
