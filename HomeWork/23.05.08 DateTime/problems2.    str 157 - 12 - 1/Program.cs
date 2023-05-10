namespace problems2.____str_157___12___1;
class Program
{
    static void Main(string[] args)
    {
        // 1.Ввести дату и определить номер дня недели,
        // к которому она принадлежит (1 - понедельник).

        int _year = 0,_month = 0,_day = 0;
        bool _needExit = false;

        _year = DateInput(_year, 9999, 1, "год");
        Console.WriteLine($"Введен год: {_year}");

        _month = DateInput(_month, 12, 1, "месяц");
        Console.WriteLine($"Введен год: {_year}, месяц {_month}");

        _day = DateInput(_day, 31, 1, "день");
        Console.WriteLine($"Введен год: {_year}, месяц: {_month} и день: {_day}");

        DateTime today = new DateTime(_year, _month, _day);
        PrintDate();

        DayOfWeekNumberPrint();

        Console.ReadKey();


        // END


        int DateInput(int date, int max, int min, string massage)
        {
            while (_needExit == false)
            {
                Console.Write($"\nВведите {massage}: ");

                if (int.TryParse(Console.ReadLine(), out date))
                {
                    if (date > max)
                    {
                        Console.WriteLine($"\nВведите {massage} поменьше");
                    }
                    else if (date < min)
                    {
                        Console.WriteLine($"\nВведите {massage} побольше");
                    }
                    else
                    {
                        _needExit = true;
                    }
                }
                else
                {
                    Console.WriteLine("\nВведите корректное значение");
                }
            }
            _needExit = false;

            Console.Clear();

            return date;
        }

        void PrintDate()
        {
            Console.Clear();
            Console.WriteLine($"Вы ввели дату: {today.ToString("dd.MM.yyyy")}\n");
        }

        void DayOfWeekNumberPrint()
        {
            Console.Write("\nНомер дня недели этой даты: ");

            switch (today.DayOfWeek.ToString())
            {
                case "Monday":
                    Console.Write("1 - Понедельник");
                    break;
                case "Tuesday":
                    Console.Write("2 - Вторник");
                    break;
                case "Wednesday":
                    Console.Write("3 - Среда");
                    break;
                case "Thursday":
                    Console.Write("4 - Четверг");
                    break;
                case "Friday":
                    Console.Write("5 - Пятница");
                    break;
                case "Saturday":
                    Console.Write("6 - Суббота");
                    break;
                case "Sunday":
                    Console.Write("7 - Воскресенье");
                    break;
            }
        }
    }
}

