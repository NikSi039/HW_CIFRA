namespace _13._18
{
    internal class Program
    {
        struct Contry
        {
            public string contry;
            public string partOfWorld;
        }

        static void Main(string[] args)
        {
            //Даны названия 20 стран и частей света, в которых они находятся.
            //Определить, есть ли среди них страны, находящиеся в Африке или Азии.
            //В случае положительного ответа напечатать их названия,

            Contry[] contries = new Contry[20];

            Random rand = new Random(); 

            for (int i = 0; i < contries.Length; i++)
            {
                contries[i] = new Contry();


            }
















            Console.ReadKey();
        }
    }
}