
Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);

int[]mas = new int[n];

Random random = new();

for (int i = 0; i < n; i++)
{
    mas[i] = random.Next(-10,11);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();

int s = 0;

foreach (int i in mas)
{
    s += i;
}



Console.ReadKey();