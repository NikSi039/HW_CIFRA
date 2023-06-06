namespace problems2._166_30;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество запланированных включений кондиционера на ближайшую неделю: ");
        int _count = int.Parse(Console.ReadLine());

        Conditioner[] conditioners = new Conditioner[_count];
        Random random = new Random();
        DateOnly _today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        for (int i = 0; i < _count; i++)
        {
            GetDayStart(i);

            GetTimeStart(i);

            GetTempMode(i);

            GetTemperature(i);
        }

        SortDate(_count);

        PrintInfo("", "Количествo оставшихся минут до начала включения\n\n");
        PrintCountInfo(_count);

        PrintInfo("на завтра", "\n\n");
        PrintTomorrowCountInfo(_count);

        Console.ReadKey();


        // END


        void GetTempMode(int i)
        {
            int t = random.Next(4);
            switch (t)
            {
                case 0:
                    conditioners[i].tempMode = Temp.Auto;
                    break;
                case 1:
                    conditioners[i].tempMode = Temp.Cooling;
                    break;
                case 2:
                    conditioners[i].tempMode = Temp.Fan;
                    break;
                case 3:
                    conditioners[i].tempMode = Temp.Heating;
                    break;
            }
        }

        void GetTemperature(int i)
        {
            if (conditioners[i].tempMode == Temp.Auto)
            {
                conditioners[i].temperature = random.Next(18, 30);
            }
            if (conditioners[i].tempMode == Temp.Cooling)
            {
                conditioners[i].temperature = random.Next(17, 21);
            }
            if (conditioners[i].tempMode == Temp.Fan)
            {
                conditioners[i].temperature = random.Next(20, 25);
            }
            if (conditioners[i].tempMode == Temp.Heating)
            {
                conditioners[i].temperature = random.Next(25, 32);
            }
        }

        void GetDayStart(int i)
        {
            conditioners[i].dayStart = _today.AddDays(random.Next(8));
        }

        void GetTimeStart(int i)
        {
            conditioners[i].timeStart = new TimeOnly(random.Next(24), random.Next(60), random.Next(60));
        }

        void SortDate(int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (conditioners[i].dayStart > conditioners[j].dayStart)
                    {
                        DateOnly temp = conditioners[i].dayStart;
                        conditioners[i].dayStart = conditioners[j].dayStart;
                        conditioners[j].dayStart = temp;
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (conditioners[i].dayStart == conditioners[j].dayStart &&
                        conditioners[i].timeStart > conditioners[j].timeStart)
                    {
                        TimeOnly temp = conditioners[i].timeStart;
                        conditioners[i].timeStart = conditioners[j].timeStart;
                        conditioners[j].timeStart = temp;
                    }
                }
            }
        }

        void PrintInfo(string massageDay, string massageMinut)
        {
            Console.Write($"\n\nCведения обо всех запланированных режимах " +
                $"включения кондиционера{massageDay}: ");
            Console.WriteLine($"\n\nДата включения\tВремя включения\tТемпературный режим\t" +
                $"Заданная температура воздуха\t {massageMinut}");
        }

        void PrintCountInfo(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"  {conditioners[i].dayStart.ToString("dd.MM.yyyy")}\t   " +
                    $" {conditioners[i].timeStart.ToString("HH:mm:ss")}\t" +
                    $"     {conditioners[i].tempMode}\t\t\t  {conditioners[i].temperature}\t");
            }
        }

        void PrintTomorrowCountInfo(int count)
        {
            bool isTomorrow = false;

            for (int i = 0; i < count; i++)
            {
               
                if ((conditioners[i].dayStart.Day - _today.Day) == 1)
                {
                    Console.WriteLine($"  {conditioners[i].dayStart.ToString("dd.MM.yyyy")}\t   " +
                    $" {conditioners[i].timeStart.ToString("HH:mm:ss")}\t" +
                    $"     {conditioners[i].tempMode}\t\t\t  {conditioners[i].temperature}\t");

                    isTomorrow = true;
                }
            }

            if (isTomorrow == false)
            {
                Console.Write("Включений кондиционера на завтра не запланировано!");
            }
        }
    }
}

struct Conditioner
{
    public DateOnly dayStart;
    public TimeOnly timeStart;
    public Temp tempMode;
    public int temperature;
}

enum Temp
{
    Cooling,
    Heating,
    Auto,
    Fan
}

