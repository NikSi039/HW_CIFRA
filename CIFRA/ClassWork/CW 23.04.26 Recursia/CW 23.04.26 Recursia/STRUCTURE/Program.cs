namespace STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            13.1.Фамилии и имена 25 учеников класса записаны в двух различных таблицах.
            //Напечатать фамилию и имя каждого ученика на отдельной строке.


            People man = new People();
            man.name = "Виктор";
            man.surename = "Перестукин";

            Console.WriteLine(man.name + " " + man.surename);

            //
            People superMan = new People() { name = "Артур", surename = "Худяков" };

            Console.WriteLine(superMan.name + " " + superMan.surename);


            //
            People[] peoples = new People[5];

            for (int i = 0; i < 5; i++)
            {
                peoples[i] = new People();
                Console.WriteLine($"Введите имя {i + 1} ученика");
                peoples[i].name = Console.ReadLine();
                Console.WriteLine($"Введите фамилию {i + 1} ученика");
                peoples[i].surename = Console.ReadLine();
            }

            foreach (People item in peoples)
            {
                Console.WriteLine(item.name + " " + item.surename);
            }

            Console.ReadKey();
        }

        struct People
        {
            public string name;
            public string surename;
        }
    }
}

