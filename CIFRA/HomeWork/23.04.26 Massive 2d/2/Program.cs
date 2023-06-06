namespace _2;
class Program
{
    //12.110.В Москве самыми теплыми являются дни с 15 июля по 15 августа.
    //Для проведения музыкального фестиваля
    //необходимо выбрать 7 следующих подряд дней этого периода,
    //которые были наиболее теплыми за последние 10 лет
    //(данные каждого года о температуре воздуха в указанный период имеются).

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

        WriteDate();

        for (int i = 0; i < days.GetLength(0); i++)
        {
            int currentDayJuly = 15;
            int currentDayAugust = 1;

            Console.Write(year + "\t");

            for (int j = 0; j < days.GetLength(1); j++)
            {
                days[i, j] = new Day();
                days[i, j].year = year;
                days[i, j].temperature = random.Next(15, 35);

                if (j < 17)
                {
                    days[i, j].date = currentDayJuly + " июля";
                    currentDayJuly++;
                }
                else
                {
                    days[i, j].date = currentDayAugust + " августа";
                    currentDayAugust++;
                }

                Console.Write(days[i, j].temperature + " ");
            }

            year++;

            Console.WriteLine();
        }

        int temp = 0;
        int maxTemp = 0;
        double averageTemp = 0;
        string maxDate = "";

        for (int i = 0; i < days.GetLength(0); i++)
        {
            for (int j = 0; j < days.GetLength(1) - 7; j++)
            {
                int n = 0;

                while (n < 7)
                {
                    temp += days[i, j + n].temperature;

                    n++;
                }

                if (maxTemp <= temp)
                {
                    maxTemp = temp;
                    averageTemp = maxTemp / 7.0;
                    maxDate = days[i, j].date + " " + days[i, j].year;
                }

                temp = 0;
            }
        }

        WriteResult();

        Console.ReadKey();


        //end


        void WriteDate()
        {
            Console.WriteLine("\t\t\t\tИЮЛЬ" + "\t\t\t\t\tАВГУСТ\n");
            Console.WriteLine("\t15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31" +
                " 01 02 03 04 05 06 07 08 09 10 11 12 13 14 15\n");
        }

        void WriteResult()
        {
            Console.Write($"\nСамая теплая неделя за последние 10 лет началась c {maxDate} ");
            Console.Write($"\n\nCуммарная температура составила: {maxTemp} Град Цельсия");
            Console.Write($"\n\nCредняя температура в день:  {averageTemp:F1} Град Цельсия");
        }
    }
}

