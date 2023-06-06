namespace CW_23._04._24_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сортировка массивов

            // Сортировка обменом

            int[] massive = new int[10];

            Random random = new Random();

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(10, 100);
                Console.Write(massive[i] + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < massive.Length-1; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)
                {
                    if (massive[i]> massive[j])   //massive[i] < massive[j] ---- сортировка по убыванию
                    {
                        int temp = massive[i];
                        massive[i] = massive[j];
                        massive[j] = temp;
                    }
                }
            }

            foreach (int item in massive)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();  
        }
    }
}