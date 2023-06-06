//метод простой вставки 
Random r = new();

Console.Write("Введите размер массива:");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + r.Next(-10, 11)).ToArray();

foreach (int item in mas) Console.Write(item + " ");
Console.WriteLine();

for (int i = 1; i < mas.Length; i++)
{
    if (mas[i - 1] > mas[i])
    {
        int x = mas[i];
        int j = i - 1;
        while (j >= 0 && mas[j] > x)
        {
            mas[j + 1] = mas[j];
            j--;
        }
        mas[j + 1] = x;
    }
    foreach (int item in mas) Console.Write(item + " ");
    Console.WriteLine();
}

Console.ReadKey();