namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int temp = array[2];
            array[2] = array[5];
            array[5] = temp;

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}