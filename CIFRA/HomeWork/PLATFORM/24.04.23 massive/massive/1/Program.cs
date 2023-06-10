using System.Net.Http.Headers;

Random random = new();

int[,] _array1 = GetArray("Первый");
int[,] _array2 = GetArray("Второй");

int[,] _sumArray = SumArray(_array1, _array2);

MaxValueSumArray(_sumArray);

Console.ReadKey();


// END


int[,] GetArray(string massage)
{
    Console.WriteLine($"{massage} массив:\n");
    int[,] array = new int[4, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-50, 51);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
    return array;
}

int[,] SumArray(int[,] array1, int[,] array2)
{
    Console.WriteLine("Массив суммы двух предыдущих:\n");
    int[,] sumArray = new int[4, 4];
    for (int i = 0; i < sumArray.GetLength(0); i++)
    {
        for (int j = 0; j < sumArray.GetLength(1); j++)
        {
            sumArray[i, j] = array1[i, j] + array2[i, j];
            Console.Write(sumArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
    return sumArray;
}

int MaxValueSumArray(int[,] array)
{
    int maxValue = int.MinValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (maxValue < array[i, j]) maxValue = array[i, j];
        }
    }
    Console.WriteLine($"Максимальное значение суммирующего массива: {maxValue}");
    return maxValue;
}