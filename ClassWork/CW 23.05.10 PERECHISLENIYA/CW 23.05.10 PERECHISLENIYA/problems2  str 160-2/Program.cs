namespace problems2__str_160_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество сотрудников: ");
            int n = int.Parse(Console.ReadLine());

            Employer[] employers = new Employer[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите табельный номер: ");
                employers[i].number = int.Parse(Console.ReadLine());

                Console.Write("Введите ФИО: ");
                employers[i].fio = Console.ReadLine();

                Console.Write("Введите дату рождения: ");
                employers[i].birthday = DateOnly.Parse(Console.ReadLine());

                Console.Write("Введите пол: 1-мужской, 2-женский");
                int p = int.Parse(Console.ReadLine());

                switch (p)
                {
                    case 1:
                        employers[i].pol = Pol.Мужской; break;
                    case 2:
                        employers[i].pol = Pol.Женский; break;
                    default:
                        Console.WriteLine("Выбрано некорректное значение"); break;
                }

                Console.Write("Введите дату поступления на работу: ");
                employers[i].start = DateOnly.Parse(Console.ReadLine());

                Console.Write("Введите должность: 1 - директор, 2 - бухгалтер, " +
                    "3 - менеджер, 4 - кладовщик, 5 - дворник ");
                int d = int.Parse(Console.ReadLine());

                switch (d)
                {
                    case 1:
                        employers[i].position = Position.Директор; break;
                    case 2:
                        employers[i].position = Position.Бухгалтер; break;
                    case 3:
                        employers[i].position = Position.Менеджер; break;   
                    case 4:
                        employers[i].position = Position.Кладовщик; break;
                    case 5:
                        employers[i].position = Position.Дворник; break;
                }

                Console.Write("Введите сумму заработной платы: ");
                employers[i].salary = decimal.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ФИО:" + employers[i].fio);

                int dayNow = DateTime.Now.Subtract(DateTime.MinValue).Days;
                DateTime start = DateTime.Parse(employers[i].start.ToString());
                int dayStart = start.Subtract(DateTime.MinValue).Days;  
                Console.WriteLine("Количество отработанных дней:" + (dayNow - dayStart));
            }

            Console.ReadKey();
        }
    }

    enum Pol
    {
        Мужской,
        Женский
    };

    enum Position
    {
        Директор,
        Бухгалтер,
        Менеджер,
        Кладовщик,
        Дворник
    };

    struct Employer
    {
        public int number;
        public string fio;
        public DateOnly birthday;
        public Pol pol;
        public DateOnly start;
        public Position position;
        public decimal salary;
    }
}