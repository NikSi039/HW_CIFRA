namespace problems2__________str_155___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("///////////1/////////////////////////");

            //Console.Write("Введите год, месяц, день первой даты: ");
            //int year1 = int.Parse(Console.ReadLine());
            //int month1 = int.Parse(Console.ReadLine());
            //int day1 = int.Parse(Console.ReadLine());
            //DateTime d1 = new(year1, month1, day1);

            //Console.Write("Введите год, месяц, день второй даты: ");
            //int year2 = int.Parse(Console.ReadLine());
            //int month2 = int.Parse(Console.ReadLine());
            //int day2 = int.Parse(Console.ReadLine());
            //DateTime d2 = new(year2, month2, day2);

            //if (d1 > d2)
            //{
            //    Console.WriteLine($"Дата {d1} больше, чем дата {d2}");
            //}
            //else if (d1 < d2)
            //{
            //    Console.WriteLine($"Дата {d1} меньше, чем дата {d2}");
            //}
            //else
            //{
            //    Console.WriteLine("Равны");
            //}

            //Console.WriteLine(d1.AddDays(1));



            Console.WriteLine("////////////2///////////////");


            Console.WriteLine("Введите время запуска батареи: ");

            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            DateTime d = new(year, month, day, hour, minutes, seconds);

            Console.Write("Введите задекларированное время работы: ");
            int h = int.Parse(Console.ReadLine());

            if (DateTime.Now.Subtract(d).Hours < h)
            {
                Console.WriteLine($"Количество часов работы {DateTime.Now.Subtract(d).Hours}, " +
                    $"до полного разряда {60*h - DateTime.Now.Subtract(d).TotalMinutes} минут");

                Console.WriteLine($"Количество часов работы {DateTime.Now.Subtract(d).Hours}, " +
                   $"до полного разряда {(h - DateTime.Now.Subtract(d).Hours - 1)} :" +
                   $" {(60 -DateTime.Now.Subtract(d).Minutes)} : " +
                   $"{(60 - DateTime.Now.Subtract(d).Seconds)}");
            }

            Console.ReadKey();
        }
    }
}