using System.Globalization;

namespace DateMy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////// DateOnly


            DateOnly d1 = new DateOnly();
            Console.WriteLine(d1);

            DateOnly d2 = new DateOnly(2023, 5, 8);
            Console.WriteLine(d2);

            DateOnly d3 = new DateOnly(2023, 5, 8, new JulianCalendar());
            Console.WriteLine(d3);

            DateOnly now = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Console.WriteLine(now);

            // свойства

            Console.WriteLine(now.Day);
            Console.WriteLine(now.DayNumber); // количество дней с начала нашей эры
            Console.WriteLine(now.DayOfWeek);
            Console.WriteLine(now.DayOfYear);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Year);

            Console.WriteLine(DateOnly.MaxValue);
            Console.WriteLine(DateOnly.MinValue);

            // методы

            Console.WriteLine(now.AddDays(20));
            Console.WriteLine(now.AddMonths(5));
            Console.WriteLine(now.AddYears(3));

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());

            // статические методы

            DateOnly d4 = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(d4);

            DateOnly d5 = DateOnly.FromDayNumber(300);
            Console.WriteLine(d5);

            DateOnly d6 = DateOnly.Parse("8.05.2023");
            Console.WriteLine(d6);


            DateOnly d8 = new DateOnly();
            DateOnly.TryParse("8.05.2023", out d8);
            Console.WriteLine(d8);

            //DateOnly d9 = new DateOnly();
            //DateOnly.TryParseExact("8.05.2023",String.Format("dd.MM.yy"), out d9);
            //Console.WriteLine(d9);

            Console.ReadKey();
        }
    }
}