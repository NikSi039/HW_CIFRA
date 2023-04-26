namespace Struct3
{
    internal class Program
    {
        struct People
        {
            public string surename;
            public string adress;
            public int telefonNumber;
        }

        static void Main(string[] args)
        {
            //            13.7.Известны фамилии, адреса и телефоны 25 - ти человек.
            //            Найти фамилии и адреса людей, чей телефон начинается с цифры 3.
            //
            //            Рассмотреть два случая:

            //            1) телефон задан в виде семизначного числа;
            //            2) телефон задан в виде, аналогичном следующему: 268–50–59


            People[] peoples = new People[5];

            for (int i = 0; i < 5; i++)
            {
                peoples[i] = new People();
                Console.WriteLine($"Введите название {i + 1} города");
                citys[i].name = Console.ReadLine();
                Console.WriteLine($"Введите название {i + 1} страны");
                citys[i].country = Console.ReadLine();
            }






        }
    }
}