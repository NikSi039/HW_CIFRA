using System;
namespace HW_1
{
    internal class UserTime
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int getHours()
        {
            return hours;
        }
        public int getMinutes()
        {
            return minutes;
        }
        public int getSeconds()
        {
            return seconds;
        }

        public void setHours(int h)
        {
            if (h >= 0 && h < 24) hours = h;
            else Console.WriteLine("Введено некорректное значение");

        }
        public void setMinutes(int m)
        {
            if (m >= 0 && m < 60) minutes = m;
            else Console.WriteLine("Введено некорректное значение");
        }
        public void setSeconds(int s)
        {
            if (s >= 0 && s < 60) seconds = s;
            else Console.WriteLine("Введено некорректное значение");
        }

        public void printTime()
        {
            Console.WriteLine($"Установленное время: " +
                $"{getHours()}:{getMinutes()}:{getSeconds()}");
        }
    }
}

