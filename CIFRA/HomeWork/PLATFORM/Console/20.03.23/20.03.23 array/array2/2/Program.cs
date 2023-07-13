int[] array = new int[10];
int count = 0;
Random random = new();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(10, 100);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine(count);

Console.ReadKey();