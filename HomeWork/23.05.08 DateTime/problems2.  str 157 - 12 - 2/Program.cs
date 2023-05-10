namespace problems2.__str_157___12___2;
class Program
{
    static void Main(string[] args)
    {
        // 2.Написать программу электронного календаря,
        // которая для введенной даты рождения
        // выдаст сообщение о количестве оставшихся дней до дня рождения в этом году,
        // а в случае, если день рождения уже прошел, то количество дней прошедших после него

        int _year = 0, _month = 0, _day = 0;
        bool _needExit = false;

        Console.WriteLine("Введите дату вашего рождения: ");

        _year = DateInput(_year, 9999, 1, "год");
        Console.WriteLine($"Введен год: {_year}");

        _month = DateInput(_month, 12, 1, "месяц");
        Console.WriteLine($"Введен год: {_year}, месяц {_month}");

        _day = DateInput(_day, 31, 1, "день");
        Console.WriteLine($"Введен год: {_year}, месяц: {_month} и день: {_day}");

        DateTime dayOfBirthday = new DateTime(_year, _month, _day);
        PrintDate();

        DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        DateTime birthDayThisYear = new DateTime(DateTime.Now.Year, _month, _day);

        TimeSpan ts = birthDayThisYear - today;

        DaysToBirthday();

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

            Console.WriteLine("Введите дату вашего рождения:\n ");

            return date;
        }

        void PrintDate()
        {
            Console.Clear();
            Console.WriteLine($"Дата вашего рождения: {dayOfBirthday.ToString("dd.MM.yyyy")}\n");
        }

        void DaysToBirthday()
        {
            if (ts.Days > 0)
            {
                Console.WriteLine($"До дня вашего рождения осталось {ts.Days} дня");
            }
            else if (ts.Days < 0)
            {
                Console.WriteLine($"Со дня вашего рождения прошло {Math.Abs(ts.Days)} дня");
            }
            else
            {
                Console.WriteLine("Поздравляем! Сегодня ваш день рождения ");
            }
        }
    }
}

