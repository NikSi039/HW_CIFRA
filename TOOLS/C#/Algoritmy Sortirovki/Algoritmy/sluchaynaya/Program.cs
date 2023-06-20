// 8 - Случайная

Random random = new();

Console.Write("Введите размер массива:");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + random.Next(10, 100)).ToArray();

foreach (int i in mas) Console.Write(i + " ");
Console.WriteLine();

 mas = BogoSort(mas);

foreach (int i in mas) Console.Write(i + " ");

Console.ReadKey();


// END


int[] BogoSort(int[] mas)
{
	while (!IsSorted(mas))
	{
		mas = RandomPermulation(mas);
	}
	return mas;
}


// Проверка упорядоченности
bool IsSorted(int[] mas)
{
	for (int i = 0; i < mas.Length - 1; i++)
	{
		if (mas[i] > mas[i + 1])
		{
			return false;
		}
	}
	return true;
}

// Перемешивание элементов
int[] RandomPermulation(int[] mas)
{
	Random random = new();	
	int n = mas.Length;

	while (n > 1)
	{
		n--;
		int i = random.Next(n + 1);
		int temp = mas[i];
		mas[i] = mas[n];
		mas[n] = temp;	
	}
	return mas;
}