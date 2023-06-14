// Shela

Random random = new();

Console.Write("Введите размер массива:");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + random.Next(10, 100)).ToArray();

foreach (int i in mas) Console.Write(i + " ");
Console.WriteLine();

mas = ShellSort(mas);

foreach (int i in mas) Console.Write(i + " ");

Console.ReadKey();


// END


int[] ShellSort(int[] mas)
{
    int d = mas.Length / 2;

    while (d >= 1)
    {
        for (int i = d; i < mas.Length; i++)
        {
            int j = i;
            while ((j >= d) && (mas[j-d] > mas[j]))
            {
                Swap(ref mas[j], ref mas[j - d]);
                j = j - d;

            }
        }
        d = d / 2;
    }
    return mas;
}


void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
