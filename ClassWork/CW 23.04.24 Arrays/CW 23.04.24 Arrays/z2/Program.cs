namespace z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int[] newArray = new int[10];
            int[] res = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                    newArray[j] = array[i, j];
                }

                res[i] = newArray.Max();

                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (int item in res)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int maximum = int.MinValue;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);
                    Console.Write(array[i,j] + " ");

                    if (array[i,j] > maximum)
                    {
                        maximum = array[i, j];
                    }

                    res[i] = maximum;
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (int item in res)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}