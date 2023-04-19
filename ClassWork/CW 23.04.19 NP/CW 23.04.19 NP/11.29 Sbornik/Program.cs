namespace _11._29_Sbornik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан массив целых чисел. Выяснить:
            //а) верно ли, что сумма элементов массива есть четное число;
            //б) верно ли, что сумма квадратов элементов массива есть пятизначное число.

            int[] array = new int[10];

            Random random = new Random();

            int sum = 0;
            double sumPow = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                Console.Write(array[i] + " ");           
                sumPow += Math.Pow(sum, 2);
                sum += array[i];

            }

            Console.WriteLine();
            Console.WriteLine(sum);
            Console.WriteLine(sumPow);

            if (sum % 2 == 0)
            {
                Console.WriteLine("Сумма элементов массива есть четное число");
            }
            else
            {
                Console.WriteLine("Сумма элементов массива есть нечетное число");
            }

            if (sumPow >= 10000 && sumPow < 100000)
            {
                Console.WriteLine("Cумма квадратов элементов массива есть пятизначное число");
            }
            else
            {
                Console.WriteLine("Cумма квадратов элементов массива есть не пятизначное число");   
            }





            Console.ReadKey();
        }
    }
}