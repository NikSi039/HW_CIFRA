using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peregruzka
{
    internal class Timee
    {
        private int hour;
        public int Hour
        {
            get { return hour; }
            set
            {
                if (value >= 0 && value < 24) hour = value;
            }
        }

        private int minute;
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value >= 0 && value < 60) minute = value;
            }
        }

        public Timee(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public string PrintTime()
        {
            string h = "", m = "";

            if (hour < 10) h = "0" + hour;
            else h = hour.ToString();
            if (minute < 10) m = "0" + minute;
            else m = minute.ToString();

            return $"{h}:{m}";
        }

        public static Timee operator +(Timee a, Timee b)
        {
            int h = a.Hour + b.Hour;
            int m = a.Minute + b.Minute;

            if (m >= 60)
            {
                h++;
                m = m - 60;
            }
            return new Timee(h, m);
        }

        public static Timee operator +(Timee a, int hours)
        {
            int h = a.hour + hours % 24;

            if (h >= 24) h -= 24;

            return new Timee(h, a.minute);
        }

        public static Timee operator -(Timee a, Timee b)
        {
            int h = a.Hour - b.Hour;
            int m = a.Minute - b.Minute;

            if (m < 0)
            {
                h--;
                m = m + 60;
            }
            return new Timee(h, m);
        }

        public static bool operator ==(Timee a, Timee b)
        {
            return a.Hour == b.Hour && a.Minute == b.Minute;
        }

        public static bool operator !=(Timee a, Timee b)
        {
            return a.Hour != b.Hour || a.Minute != b.Minute;
        }

        public static bool operator >(Timee a, Timee b)
        {
            if (a.Hour > b.Hour) return true;
            else if (a.Hour == b.Hour && a.Minute > b.Minute) return true;
            else return false;
        }

        public static bool operator <(Timee a, Timee b)
        {
            if (a.Hour < b.Hour) return true;
            else if (a.Hour == b.Hour && a.Minute < b.Minute) return true;
            else return false;
        }
    }
}