namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random random = new Random();

            int min = int.MaxValue; 

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
                Console.Write(array[i] + " ");

                if (array[i] < min )
                {
                    min = array[i];
                }
            }

            Console.WriteLine();

            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min)
                {
                    index = i;
                }
            }

            int temp = array[0];
            array[0] = array[index];
            array[index] = temp;    

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.ReadKey();  
        }
    }
}