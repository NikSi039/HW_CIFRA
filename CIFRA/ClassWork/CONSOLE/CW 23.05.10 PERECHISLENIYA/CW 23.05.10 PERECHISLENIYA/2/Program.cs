namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] color = { "красный", "желтый", "красный", "красный", "красный", "красно - зеленый" };

            apple i;

            for ( i = apple.Jonathan; i <= apple.McIntosh; i++)
            {
                Console.WriteLine(i + " имеет значение" + (int)i);
            }
            Console.WriteLine();

            for ( i = apple.Jonathan; i <= apple.McIntosh; i++)
            {
                Console.WriteLine("Цвет сорта " + i + "-" + color[(int)i]);
            }

            Console.ReadKey();
        }
    }

    enum apple 
    {
        Jonathan, GoldenDel, RedDel, Winsap, Cortland, McIntosh
    };

}