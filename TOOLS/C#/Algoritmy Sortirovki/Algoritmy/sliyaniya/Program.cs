// 9 - Сортировка слиянием

Random random = new();

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + random.Next(10, 100)).ToArray();

foreach (int i in mas) Console.Write(i + " ");
Console.WriteLine("\n");

mas = MergeSortMas(mas);

foreach (int i in mas) Console.Write(i + " ");

Console.ReadKey();


// END


int[] MergeSort(int[] mas, int lowIndex, int hightIndex)
{
    if (lowIndex < hightIndex)
    {
        int middleIndex = (lowIndex + hightIndex) / 2;
        MergeSort(mas, lowIndex, middleIndex);
        MergeSort(mas, middleIndex + 1, hightIndex);
        Merge(mas, lowIndex, middleIndex, hightIndex);
    }
    return mas;
}

int[] MergeSortMas(int[] mas)
{
    return MergeSort(mas, 0, mas.Length - 1);
}

// метод слияния массивов
void Merge(int[] mas, int lowIndex, int middleIndex, int hightIndex)
{
    int left = lowIndex;
    int right = middleIndex + 1;
    int[] tempMas = new int[hightIndex - lowIndex + 1];
    int index = 0;

    while ((left <= middleIndex) && (right <= hightIndex))
    {
        if (mas[left] <= mas[right])
        {
            tempMas[index] = mas[left];
            left++;
        }
        else
        {
            tempMas[index] = mas[right];
            right++;
        }
        index++;
    }

    for (int i = left; i <= middleIndex; i++)
    {
        tempMas[index] = mas[i];
        index++;
    }
    for (int i = right; i <= hightIndex; i++)
    {
        tempMas[index] = mas[i];
        index++;
    }
    for (int i = 0; i < tempMas.Length; i++)
    {
        mas[lowIndex + i] = tempMas[i];
    }
}