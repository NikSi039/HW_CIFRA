namespace _2;
class Program
{
    struct Day
    {
        public string date;
        public int year;
        public int temperature;
    }

    static void Main(string[] args)
    {
        Day[,] days = new Day[10, 32];
        int year = 2013;

        Random random = new Random();

        for (int i = 0; i < days.GetLength(0); i++)
        {
            int currentDayJuly = 15;
            int currentDayAugust = 1;

            for (int j = 0; j < days.GetLength(1); j++)
            {
                days[i, j] = new Day();
                days[i, j].year = year;
                days[i, j].temperature = random.Next(15, 35);

                if (j < 17)
                {
                    days[i, j].date = (currentDayJuly + " июля").ToString();
                    currentDayJuly++;
                }
                else
                {
                    days[i, j].date = (currentDayAugust + " августа").ToString();
                    currentDayAugust++;
                }

                Console.Write(days[i, j].temperature + " ");
                //Console.Write(days[i, j].date + " ");
                //Console.Write(days[i, j].year + " ");
            }

            year++;

            Console.WriteLine();
        }

        string[,] maxTemps = new string[1, 7];
        int max = 0;
        int temp = 0;
        string maxTemp = "";
        string maxDate = "";

        for (int i = 0; i < days.GetLength(0); i++)
        {
            for (int j = 0; j < days.GetLength(1) - 7; j++)
            {
                temp = days[i, j].temperature + days[i, j + 1].temperature + days[i, j + 2].temperature + days[i, j + 3].temperature + days[i, j + 4].temperature + days[i, j + 5].temperature + days[i, j + 6].temperature;

                if (max < temp)
                {
                    max = temp;
                    maxTemp = max.ToString();
                    maxDate = days[i, j].date + days[i, j].year;
                }
            }
        }

        //Console.WriteLine($"\nmaxTemp + " " + maxDate);

        Console.WriteLine($"\nСамые теплые 7 дней за последние 10 лет были:\nc {maxDate} по\nсуммарная температура составила {maxTemp}\nили средняя температура в день ");












        Console.ReadKey();
    }
}

