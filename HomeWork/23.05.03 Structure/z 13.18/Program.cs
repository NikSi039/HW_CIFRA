using System.Text;

namespace z_13._18;
class Program
{
         //13.18. Даны названия 20 стран и частей света,
         //в которых они находятся.
         //Определить, есть ли среди них страны,
         //находящиеся в Африке или в Азии.
         //В случае положительного ответа напечатать их названия.

    struct Country
    {
        public string country;
        public string partOfTheWorld;
    }

    static void Main(string[] args)
    {
        Country[] countries = new Country[20];
        string[] partOfTheWorlds = { "Европа", "Азия", "Африка", "Америка", "Австралия и Океания" };

        Random random = new Random();

        for (int i = 0; i < countries.Length; i++)
        {
            countries[i] = new Country();
            countries[i].country = GetString(random.Next(4, 10));
            countries[i].partOfTheWorld = partOfTheWorlds[random.Next(0, partOfTheWorlds.Length)];

            Console.WriteLine(countries[i].country + "," + countries[i].partOfTheWorld);
            Console.WriteLine();
        }

        Console.WriteLine("\nСписок стран, находящихся в Африке или в Азии: \n");

        foreach (Country item in countries)
        {
            if (item.partOfTheWorld == "Африка" || item.partOfTheWorld == "Азия")
            {
                Console.Write(item.country + " | ");
            }
        }

        Console.ReadKey();


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
    }
}

   

