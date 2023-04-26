namespace Struc2
{
    internal class Program
    {
        struct City
        {
            public string name;
            public string country;
        }

        static void Main(string[] args)
        {
            //            13.3.Даны названия 26 городов и стран, в которых они находятся. Среди них есть
            //города, находящиеся в Италии. Напечатать их названия


            City[] citys = new City[5];

            for (int i = 0; i < 5; i++)
            {
                citys[i] = new City();
                Console.WriteLine($"Введите название {i + 1} города");
                citys[i].name = Console.ReadLine();
                Console.WriteLine($"Введите название {i + 1} страны");
                citys[i].country = Console.ReadLine();
            }

            Console.WriteLine("Города, находящиеся в Италии: ");

            foreach (City item in citys)
            {
                if (item.country == "Италия")
                {
                    Console.WriteLine(item.name);
                }
            }

            Console.ReadKey();
        }
    }
}