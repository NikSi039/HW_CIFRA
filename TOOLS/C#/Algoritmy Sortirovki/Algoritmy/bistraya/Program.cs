// Bistraya


Random random = new();

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + random.Next(10, 100)).ToArray();

foreach (int i in mas) Console.Write(i + " ");
Console.WriteLine("\n");

mas = QuickSortAll(mas);

foreach (int i in mas) Console.Write(i + " ");

Console.ReadKey();


// END


int Partition(int[]mas, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;
	for (int i = minIndex; i < maxIndex; i++)
	{
		if (mas[i] < mas[maxIndex])
		{
			pivot++;
			Swap(ref mas[pivot], ref mas[i]);
		}
	}
		pivot++;
		Swap(ref mas[pivot], ref mas[maxIndex]);
		return pivot;
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

int[] QuickSort(int[] mas, int minIndex, int maxIndex)
{
	if (minIndex >= maxIndex)
	{
		return mas;
	}

	int pivot = Partition(mas, minIndex, maxIndex);
	QuickSort(mas, minIndex, pivot - 1);
	QuickSort(mas, pivot + 1, maxIndex);
	return mas;
}

int[] QuickSortAll(int[] mas)
{
	return QuickSort(mas, 0, mas.Length - 1);
}