using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_HLAV
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public static Time operator ++(Time t)
        {
            t.second++;
            if (t.second == 60)
            {
                t.second = 0;
                t.minute++;
                if (t.minute == 60)
                {
                    t.minute = 0;
                    t.hour++;
                    if (t.hour == 24)
                    {
                        t.hour = 0;
                    }
                }
            }
            return t;
        }

        public static Time operator --(Time t)
        {
            t.second--;
            if (t.second == -1)
            {
                t.second = 59;
                t.minute--;
                if (t.minute == -1)
                {
                    t.minute = 59;
                    t.hour--;
                    if (t.hour == -1)
                    {
                        t.hour = 23;
                    }
                }
            }
            return t;
        }

        public static Time operator +(Time t, int s)
        {
            int totalSeconds = t.hour * 3600 + t.minute * 60 + t.second + s;
            int newHour = totalSeconds / 3600 % 24;
            int newMinute = totalSeconds / 60 % 60;
            int newSecond = totalSeconds % 60;
            return new Time(newHour, newMinute, newSecond);
        }

        public void Show()
        {
            Console.WriteLine("{0}:{1}:{2}", hour.ToString("D2"), minute.ToString("D2"), second.ToString("D2"));
        }

    }
}
