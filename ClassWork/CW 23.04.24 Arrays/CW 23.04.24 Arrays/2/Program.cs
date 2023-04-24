namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сортировка массивов

            // Сортировка классами ARRAY

            int[] massive = new int[10];

            Random random = new Random();

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(10, 100);
                Console.Write(massive[i] + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < massive.Length - 1; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)
                {
                    if (massive[i] > massive[j])   //massive[i] < massive[j] ---- сортировка по убыванию
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


            //

            //Array.Clear(massive, 0, massive.Length);

            //Array.Reverse(massive);

            //Array.Sort(massive);

            //Array.Sort(massive, 0, 8);

            //Array.Fill(massive, 5);

            //Array.Fill(massive, 5, 0, 5);



            //Array.BinarySearch(massive, 56);  // производится строго в отсортированном массиве

            //foreach (int item in massive)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine(Array.BinarySearch(massive, 56));




            int[] massive2 = new int[10];

            //Array.ConstrainedCopy(massive, 3, massive2, 3, 4);

            //Array.Copy(massive, massive2, 6);    

            //Console.WriteLine();

            //foreach (int item in massive2)
            //{
            //    Console.Write(item + " ");
            //}

            Console.WriteLine();

            //Array.IndexOf(massive2, 45);
            //Array.LastIndexOf(massive2, 45);

            foreach (int item in massive)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write(Array.IndexOf(massive2, 45));


            Console.ReadKey();
        }
    }
}