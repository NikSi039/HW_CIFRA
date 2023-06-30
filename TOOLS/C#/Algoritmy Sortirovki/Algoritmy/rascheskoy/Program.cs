// 12 - rascheskoy

Random random = new();

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
mas = mas.Select(i => i + random.Next(10, 100)).ToArray();

foreach (int i in mas) Console.Write(i + " ");
Console.WriteLine("\n");

mas = CombSort(mas);

foreach (int i in mas) Console.Write(i + " ");

Console.ReadKey();


// END


int[] CombSort(int[] mas)
{
    int arrayLenght = mas.Length;
    int currentStep = mas.Length - 1;

    while (currentStep > 1)
    {
        for (int i = 0; i + currentStep < mas.Length; i++)
        {
            if (mas[i] > mas[i + currentStep])
            {
                Swap(ref mas[i], ref mas[i + currentStep]);
            }
        }
        currentStep = GenNextStep(currentStep);
    }

    for (int i = 1; i < arrayLenght; i++)
    {
        bool SwapFlag = false;
        for (int j = 0; j < arrayLenght - i; j++)
        {
            if (mas[j] > mas[j + 1])
            {
                Swap(ref mas[j], ref mas[j + 1]);
                SwapFlag = true;
            }
        }

        if (!SwapFlag) break;
    }
    return mas;
}

// Метод генерации следующего шага
int GenNextStep(int s)
{
    s *= 1000 / 1247;
    return s > 1 ? s : 1;
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}