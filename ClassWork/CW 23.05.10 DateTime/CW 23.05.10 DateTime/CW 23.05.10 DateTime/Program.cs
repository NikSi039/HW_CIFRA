using System.Text;

namespace CW_23._05._10_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // problems2 str 160  - 1

            Console.Write("Введите количество сеансов: ");
            int n = int.Parse(Console.ReadLine());

            Seanse[] seanses = new Seanse[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите позывной: ");
                seanses[i].name = Console.ReadLine();

                Console.Write("Введите позывной: ");
                seanses[i].frequency = double.Parse(Console.ReadLine());

                Console.Write("Введите дату: ");
                seanses[i].data = DateOnly.Parse(Console.ReadLine());

                Console.Write("Введите начало сеанса: ");
                seanses[i].start = TimeOnly.Parse(Console.ReadLine());

                Console.Write("Введите время окончания сеанса: ");
                seanses[i].end = TimeOnly.Parse(Console.ReadLine());

                Console.Write("Введите количество преданных групп: ");
                seanses[i].count = int.Parse(Console.ReadLine());

                seanses[i].mas = new string[seanses[i].count];

                for (int j = 0; j < seanses[i].mas.Length; j++)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append((char)random.Next(60, 85) + "" + (char)random.Next(60, 85) +
                       "" + (char)random.Next(60, 85) + "" + (char)random.Next(60, 85) +
                       "" + (char)random.Next(60, 85));

                    seanses[i].mas[j] = sb.ToString();

                    Console.WriteLine(seanses[i].mas[j]);
                }
            }

            Console.WriteLine("Информация о скорости передачи групп: ");

            for (int i = 0; i < n; i++)
            {
                int m1 = seanses[i].start.Hour * 60 + seanses[i].start.Minute;
                int m2 = seanses[i].start.Hour * 60 + seanses[i].start.Minute;

                Console.WriteLine($"Сеанс {i + 1}:" +
                    $"{(double)seanses[i].count / (m2 - m1):F2}");
            }

            Console.WriteLine("Информация о выходе радистов на связь");

            Console.Write("Введите дату: ");
            DateOnly data = DateOnly.Parse(Console.ReadLine());

            Console.Write("Введите начала: ");
            TimeOnly timeStart = TimeOnly.Parse(Console.ReadLine());

            Console.Write("Введите окончания: ");
            TimeOnly timeFinish = TimeOnly.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (seanses[i].data.Equals(data) && timeStart < seanses[i].start 
                    && timeFinish > seanses[i].end )
                {
                    Console.WriteLine(seanses[i].start + "-" + seanses[i].end);
                }
            }

            Console.ReadKey();
        }
    }

    struct Seanse
    {
        public string name;
        public double frequency;
        public DateOnly data;
        public TimeOnly start;
        public TimeOnly end;
        public int count;
        public string[] mas;
    }
}