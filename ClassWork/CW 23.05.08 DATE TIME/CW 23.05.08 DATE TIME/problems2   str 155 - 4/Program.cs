namespace problems2___str_155___4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////2////////////

            Console.Write("Введите год правонарушения: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц правонарушения: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день правонарушения: ");
            int day = int.Parse(Console.ReadLine());

            DateOnly dayLow = new DateOnly(year, month, day);

            DateOnly now = DateOnly.FromDateTime(DateTime.Now);

            DateTime d1 = dayLow.ToDateTime(TimeOnly.MinValue);
            Console.WriteLine(d1);
            DateTime d2 = now.ToDateTime(TimeOnly.MaxValue);

            TimeSpan ts = d2 - d1;

            Console.WriteLine($"Прошло: {ts.Days / 365} лет," +
                $" {ts.Days / 30} месяцев," +
                $" {ts.Days % 30} дней");

            Console.ReadKey();
        }
    }
}