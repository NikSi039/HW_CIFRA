using System.Text;

namespace CW_23._05._03_Struct
{
    struct MyDate
    {
        public int month;
        public int year;
    }

    struct Employer
    {
        public string name;
        public string surname;
        public string lastname;
        public string adress;
        public MyDate date;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employer[] peoples = new Employer[5];

            Random random = new Random();

            for (int i = 0; i < peoples.Length; i++)
            {
                peoples[i] = new Employer();
                peoples[i].name = GetString(random.Next(5, 15));
                Console.WriteLine(peoples[i].name);
                peoples[i].surname = GetString(random.Next(5, 15));
                Console.WriteLine(peoples[i].surname);
                peoples[i].lastname = GetString(random.Next(5, 15));
                Console.WriteLine(peoples[i].lastname);
                peoples[i].adress = GetString(random.Next(10, 50));
                MyDate myDate = new MyDate();
                myDate.month = random.Next(1, 13);
                myDate.year = random.Next(2010, 2023);
                peoples[i].date = myDate;
                Console.WriteLine(peoples[i].date.month + "." + peoples[i].date.year);
                Console.WriteLine();
            }

            Console.Write("Введите текущий год: ");
            int year = int.Parse(Console.ReadLine());

            foreach (Employer item in peoples)
            {
                if (year - item.date.year > 3)
                {
                    Console.WriteLine("\n" + item.name + "\n" + item.surname + "\n" + item.lastname + "\n" + item.adress + "\n");
                }
            }


            Console.ReadKey();

            //end


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
        }
    }
}