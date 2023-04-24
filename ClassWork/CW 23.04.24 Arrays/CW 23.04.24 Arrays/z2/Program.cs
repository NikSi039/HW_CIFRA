namespace z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int[] newArray = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();













            Console.ReadKey();
        }
    }
}