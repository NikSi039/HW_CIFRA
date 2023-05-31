//
Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];

Random random = new();

for (int i = 0; i < n; i++)
{
    mas[i] = random.Next(-10, 11);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();

int s = 0;

foreach (int i in mas) s += i;
Console.WriteLine(s);

//LINQ

Console.WriteLine(mas.Sum());
Console.WriteLine(mas.Count());
Console.WriteLine(mas.Average());
Console.WriteLine(mas.Max());
Console.WriteLine(mas.Min());

//

int count = 0;
foreach (int item in mas) if (item % 2 == 0) count++;
int[] oddMas = new int[count];

int index = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] % 2 == 0)
    {
        oddMas[index++] = mas[i];
        Console.Write(mas[i] + " ");
    }
}
Console.WriteLine();

//LINQ

int[] masLinq = mas.Where(i => i % 2 == 0).ToArray();
foreach (int item in masLinq) Console.Write(item + " ");
Console.WriteLine();

double[] mas2 = mas.Select(i => Math.Sqrt(i)).ToArray();
foreach (double item in mas2) Console.Write(item + " ");
Console.WriteLine();

int[] indexMas = mas.Where((s, i) => i % 2 == 0).ToArray();
foreach (var item in indexMas) Console.Write(item + " ");
Console.WriteLine();

int sum = mas.Select(i => i * i).Sum();
Console.WriteLine(sum);

Console.ReadKey();