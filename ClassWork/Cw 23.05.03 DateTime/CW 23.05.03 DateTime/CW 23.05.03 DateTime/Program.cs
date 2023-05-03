namespace CW_23._05._03_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();

            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine(DateTime.Now);

            DateTime dateTime1 = new DateTime(2015, 12, 21);
            Console.WriteLine(dateTime1);

            DateTime dateTime2 = new DateTime(2017, 6, 15, 12, 45, 25);
            Console.WriteLine(dateTime2);

            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
                    











            Console.ReadKey();
        }
    }
}