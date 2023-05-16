namespace problems2._166_30;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество запланированных включений кондиционера на ближайшую неделю: ");
        int n = int.Parse(Console.ReadLine());

        Conditioner[] conditioners = new Conditioner[n];
        Random random = new Random();
        DateOnly _today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        for (int i = 0; i < n; i++)
        {
            GetDayStart(i);

            GetTimeStart(i);

            GetTempMode(i);

            GetTemperature(i);
        }



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
            conditioners[i].timeStart = new TimeOnly(random.Next(25), random.Next(61), random.Next(61));
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

