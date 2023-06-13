// 6 - blinnaya

Random random = new();

Console.Write("Введите размер массива:");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + random.Next(10, 100)).ToArray();

foreach (int i in mas) Console.Write(i + " ");
Console.WriteLine();

mas = PancakeSort(mas);

foreach (int i in mas) Console.Write(i + " ");

Console.ReadKey();


//END


int IndexOfMax(int[] mas, int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        if (mas[i] > mas[result]) result = i;
    }
    return result;
}

void Flip(int[] mas, int end)
{
    for (var start = 0; start < end; start++, end--)
    {
        int temp = mas[start];
        mas[start] = mas[end];
        mas[end] = temp;
    }
}

int[] PancakeSort(int[] mas)
{
    for (int i = mas.Length - 1; i >= 0; i--)
    {
        int maxIndex = IndexOfMax(mas, i);
        if (maxIndex != i)
        {
            Flip(mas, maxIndex);
            Flip(mas, i);
        }
    }
    return mas;
}