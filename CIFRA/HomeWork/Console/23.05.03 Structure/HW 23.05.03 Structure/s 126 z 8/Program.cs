using System.Text;

namespace s_126_z_8;
class Program
{
    //    Описать структуру с именем ZNAK, содержащую поля:

    //    Name - фамилия и имя,
    //    ZOD - знак зодиака,
    //    DATE - дата рождения(массив из трех чисел: год, месяц, число).

    //Написать программу, выполняющую:

    //- ввод с клавиатуры данных в массив MASS, состоящий из 10 элементов типа ZNAK,
    //записи должны быть упорядочены по дате дня рождения;

    //- вывод на экран информации о людях, родившихся под знаком зодиака,
    //наименование которых вводится с клавиатуры;

    //- если такого нет - выдать сообщение.

    struct NAME
    {
        public string surname;
        public string name;
    }

    struct DATE
    {
        public int year;
        public int month;
        public int number;
    }

    struct ZNAK
    {
        public NAME Name;
        public string ZOD;
        public DATE Date;
    }

    static void Main(string[] args)
    {
        ZNAK[] znaks = new ZNAK[10];
        string[] zods = { "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы",
            "Скорпион", "Змееносец", "Стрелец", "Козерог", "Водолей", "Рыбы" };
        string zod = "";
        bool needExit = false;
        bool isZod = false;

        Random random = new Random();

        for (int i = 0; i < znaks.Length; i++)
        {
            znaks[i] = new ZNAK();

            znaks[i].Name.surname = GetString(random.Next(5, 8));
            znaks[i].Name.name = GetString(random.Next(4, 6));

            znaks[i].ZOD = zods[random.Next(0, zods.Length)];

            znaks[i].Date.year = random.Next(1960, 2022);
            znaks[i].Date.month = random.Next(1, 13);
            znaks[i].Date.number = random.Next(1, 31);
        }

        for (int i = 0; i < znaks.Length; i++)
        {
            for (int j = i + 1; j < znaks.Length; j++)
            {
                if (znaks[i].Date.year < znaks[j].Date.year)
                {
                    ZNAK temp = znaks[i];
                    znaks[i] = znaks[j];
                    znaks[j] = temp;
                }
            }
        }

        while (needExit == false)
        {
            foreach (ZNAK item in znaks)
            {
                PrintInfo(item);
            }

            ReadZod();

            foreach (ZNAK item in znaks)
            {
                if (zod == item.ZOD.ToLower())
                {
                    PrintInfo(item);
                    isZod = true;
                }
            }

            WriteError();

            InsertCommand();
        }


        //END


        string GetString(int n)
        {
            StringBuilder str = new StringBuilder();

            str.Append((char)random.Next(1040, 1072));

            for (int i = 0; i < n; i++)
            {
                str.Append((char)random.Next(1072, 1104));
            }

            return str.ToString();
        }

        void PrintInfo(ZNAK item)
        {
            Console.WriteLine($"\n{item.Name.surname} {item.Name.name}\t\t{item.ZOD}\t\t" +
                    $"{item.Date.year} {item.Date.month} {item.Date.number}");
        }

        void InsertCommand()
        {
            Console.Write("\n\n\n\n\n1 - что бы повторить запрос\n2 - выход\n\nВыберите команду: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    break;
                case "2":
                    needExit = true;
                    break;
                default:
                    Console.WriteLine("\nВведена некорректная команда");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        void ReadZod()
        {
            Console.Write("\n\n\n\nВведите интересующий вас знак зодиака: ");
            zod = Console.ReadLine().Trim().ToLower();
        }

        void WriteError()
        {
            if (isZod == false)
            {
                Console.WriteLine($"\n\nЛюдей, родившихся под знаком зодиака \"{zod}\" нет");
            }
        }
    }
}