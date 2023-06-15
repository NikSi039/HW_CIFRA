// 1 - pusirkovaya 

int[] mas = new int[10];
Random random = new();

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine("\n");

for (int i = 0; i < mas.Length - 1; i++)
{
    for (int j = i + 1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
        {
            int temp = mas[i];
            mas[i] = mas[j];
            mas[j] = temp;
        }
    }
}

foreach (int item in mas) Console.Write(item + " ");
Console.WriteLine();

Console.ReadKey();