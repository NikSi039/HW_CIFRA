Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

int[] mas = new int[n];

Random random = new Random();

mas = mas.Select(i => i + random.Next(-10, 11)).ToArray();

foreach (int item in mas)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// Алгоритм методом выбора

for (int i = 0; i < mas.Length - 1; i++)
{
    int nMin = i;
    for (int j = i + 1; j < mas.Length; j++)
    {
        if (mas[j] < mas[nMin])
        {
            nMin = j;
        }
    }
    if (nMin != i)
    {
        int c = mas[i];
        mas[i] = mas[nMin];
        mas[nMin] = c;
    }
    foreach (int item in mas)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

foreach (int item in mas)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.ReadLine(); 