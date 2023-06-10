Console.WriteLine(GetAverage());

Console.ReadKey();

//END

double GetAverage()
{
    Random random = new();

    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-99, 100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("\n");

    double average = array.Average();
    return average;
}