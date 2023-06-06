namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            11.154.Удалить из массива, в котором все элементы различны,
            //            максимальный и минимальный элементы.

            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Random random = new Random();

            int count = 0;

            while (count < n)
            {
                int a = random.Next(-10, 11);
                bool b = false;

                for (int i = 0; i <= count; i++)
                {
                    if (array[i] == a)
                    {
                        b = true;
                    }

                }
                if (b == false)
                {
                    array[count] = a;
                    count++;
                }
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int max = array[0], min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            int[] result = new int[n - 2];
            int j = 0;  

            for (int i = 0; i < n; i++)
            {
                if (array[i] != max && array[i] != min)
                {
                    result[j++] = array[i];
                }
            }

            foreach (int i in result)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.ReadLine(); 
        }
    }
}