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


// Сортировка методом простой вставки



Console.ReadLine();
