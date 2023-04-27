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



















        Console.ReadKey();
    }
}

