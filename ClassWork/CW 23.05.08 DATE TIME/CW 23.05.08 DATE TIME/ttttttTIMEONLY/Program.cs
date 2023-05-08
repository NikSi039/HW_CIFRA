namespace ttttttTIMEONLY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TimeOnly

            // Время в диапазоне от 00.00.00 до 23.59.599999999

            TimeOnly t1 = new TimeOnly();
            Console.WriteLine(t1);

            TimeOnly t2 = new TimeOnly(4,30);
            Console.WriteLine(t2);

            TimeOnly t3 = new TimeOnly(4, 30, 50);
            Console.WriteLine(t3);

            // Свойства

            TimeOnly nowTime = new TimeOnly(DateTime.Now.Hour,
                DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);

            Console.WriteLine(nowTime.Hour);
            Console.WriteLine(nowTime.Minute);
            Console.WriteLine(nowTime.Second);
            Console.WriteLine(nowTime.Millisecond);
            Console.WriteLine(nowTime.Ticks);

            Console.WriteLine(TimeOnly.MaxValue);
            Console.WriteLine(TimeOnly.MinValue);

            // Методы

            Console.WriteLine(nowTime.AddHours(5));
            Console.WriteLine(nowTime.AddMinutes(230));
            Console.WriteLine(nowTime.Add(new TimeSpan(4,4,34,23,23)));

            Console.WriteLine(nowTime.ToLongTimeString());
            Console.WriteLine(nowTime.ToShortTimeString());

            // Статические методы

            TimeOnly t4 = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(t4);

            TimeOnly t5 = TimeOnly.FromTimeSpan(new TimeSpan(5,6,23));
            Console.WriteLine(t5);

            Console.WriteLine(TimeOnly.Parse("12:12:45"));

            Console.ReadKey();
        }
    }
}