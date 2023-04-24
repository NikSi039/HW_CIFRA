namespace _2d_Massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            12.99.В зрительном зале 25 рядов, в каждом из которых по 36 мест(кресел).
            //            Информация о проданных билетах хранится в двумерном массиве,
            //            номера строк которого соответствуют номерам рядов, а номера столбцов — номерам мест.
            //            Если билет на то или иное место продан,
            //            то соответствующий элемент массива имеет значение 1,
            //            в противном случае — 0.
            //
            //            Определить:
            //            а) на какой ряд продано больше всего билетов;
            //            б) на какой ряд продано меньше всего билетов.

            //            Обе задачи решить двумя способами:

            //            1) с использованием дополнительного одномерного массива;
            //            2) без использования дополнительного одномерного массива.

            int[,] array = new int[25, 36];
            //int[] newArray = new int[36];
            int max = int.MinValue;
            int index = -1;

            Random random = new Random();

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = random.Next(2);
            //        Console.Write(array[i,j] + " ");

            //        newArray[i] = array[i, j];
            //    }
            //    int sum = newArray.Sum();

            //    if (sum > max)
            //    {
            //        max = sum;
            //        index = i;
            //    }

            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("max = " + index);





            for (int i = 0; i < array.GetLength(0); i++)
            {
                int s = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(2);
                    Console.Write(array[i, j] + " ");
                    s += array[i, j];
                }

                if (s > max)
                {
                    max = s;
                    index = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("max = " + index);

            Console.ReadKey();
        }
    }
}