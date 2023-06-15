// Сортировка по частям

Random r = new();

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + r.Next(10, 100)).ToArray();

foreach (int i in mas) Console.Write(i + " ");
Console.WriteLine("\n");

mas = StoogeSort(mas, 0, mas.Length - 1);

foreach (int i in mas) Console.Write(i + " ");

Console.ReadKey();


//END


void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

int[] StoogeSort(int[] mas, int startIndex, int endIndex)
{
    if (mas[startIndex] > mas[endIndex])
    {
        Swap(ref mas[startIndex], ref mas[endIndex]);
    }
    if (endIndex - startIndex > 1)
    {
        int len = (endIndex - startIndex + 1) / 3;
        StoogeSort(mas, startIndex, endIndex - len);
        StoogeSort(mas, startIndex + len, endIndex);
        StoogeSort(mas, startIndex, endIndex - len);
    }
    return mas;
}