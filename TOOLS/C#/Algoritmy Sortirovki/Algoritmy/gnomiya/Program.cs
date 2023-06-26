// gnomiya


Random random = new();

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + random.Next(10, 100)).ToArray();

foreach (int i in mas) Console.Write(i + " ");
Console.WriteLine("\n");

mas = GnomeSort(mas);

foreach (int i in mas) Console.Write(i + " ");

Console.ReadKey();


// END


int[] GnomeSort(int[] mas)
{
    int index = 1;
    int nextIndex = index + 1;

    while (index < mas.Length)
    {
        if (mas[index - 1] < mas[index])
        {
            index = nextIndex;
            nextIndex++;
        }
        else
        {
            Swap(ref mas[index - 1], ref mas[index]);
            index--;
            if (index == 0)
            {
                index = nextIndex;
                nextIndex++;
            }
        }
    }
    return mas;
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}