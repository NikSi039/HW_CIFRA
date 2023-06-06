namespace Struct3
{
    internal class Program
    {
        struct PhoneBookDigital
        {
            public string surename;
            public string adress;
            public long phone;
        }

        struct PhoneBookString
        {
            public string surename;
            public string adress;
            public string phone;
        }

        static void Main(string[] args)
        {
            //            13.7.Известны фамилии, адреса и телефоны 25 - ти человек.
            //            Найти фамилии и адреса людей, чей телефон начинается с цифры 3.
            //
            //            Рассмотреть два случая:

            //            1) телефон задан в виде семизначного числа;
            //            2) телефон задан в виде, аналогичном следующему: 268–50–59


            //1

            PhoneBookDigital[] phoneBookDigitals = new PhoneBookDigital[5];

            for (int i = 0; i < phoneBookDigitals.Length; i++)
            {
                Console.Write("Введите фамилию: ");
                phoneBookDigitals[i].surename = Console.ReadLine();
                Console.Write("Введите адрес: ");
                phoneBookDigitals[i].adress = Console.ReadLine();
                Console.Write("Введите телефон: ");
                phoneBookDigitals[i].phone = long.Parse(Console.ReadLine());
            }

            foreach (PhoneBookDigital item in phoneBookDigitals)
            {
                if (item.phone / 1000000 == 3)
                {
                    Console.WriteLine(item.surename + " " + item.adress + "" + item.phone);
                }
            }

            Console.WriteLine("\n\n\n");


            //2

            PhoneBookString[] phoneBookStrings = new PhoneBookString[3];

            for (int i = 0; i < phoneBookStrings.Length; i++)
            {
                Console.Write("Введите фамилию: ");
                phoneBookStrings[i].surename = Console.ReadLine();
                Console.Write("Введите адрес: ");
                phoneBookStrings[i].adress = Console.ReadLine();
                Console.Write("Введите телефон: ");
                phoneBookStrings[i].phone = Console.ReadLine();
            }

            foreach (PhoneBookString item in phoneBookStrings)
            {
                if (item.phone.StartsWith("3"))
                {
                    Console.WriteLine(item.surename + " " + item.adress + "" + item.phone);
                }
            }

            Console.ReadKey();
        }
    }
}