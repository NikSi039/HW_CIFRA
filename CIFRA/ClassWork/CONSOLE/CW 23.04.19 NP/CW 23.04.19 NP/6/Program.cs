namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            11.160.Вставить заданное число в массив целых чисел:
            //            а) после первого отрицательного элемента

            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Random random = new Random();

            int index = -1;
            bool b = false;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);

                Console.Write(array[i] + " ");

                if (b != true && array[i] < 0)
                {
                    b = true;
                    index = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine(index);

            Console.Write("Введите число: ");
            int m = int.Parse(Console.ReadLine());

            int[] result = new int[n +1];

            b = false;

            for (int i = 0; i < result.Length; i++)
            {
                if (i == index)
                {
                    result[i] = array[i];
                    result[++i] = m;
                    b = true;
                }
                else
                {
                    if (b == false)
                    {
                        result[i] = array[i];
                    }
                    else
                    {
                        result[i] = array[i - 1];
                    }
                }
            }

            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}