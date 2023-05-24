//14.5.Дан массив из двадцати вещественных чисел. Записать все числа массива 
//в типизированный файл в том же порядке.

using (BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate)))
{
    double[] mas = new double[20];
    Random random = new Random();

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = double.Parse($"{random.NextDouble() * 10:F2}");

        writer.Write(mas[i]);
    }
}

using (BinaryReader reader = new BinaryReader(File.Open("file.dat", FileMode.Open)))
{
    double[] from = new double[20];

    for (int i = 0; i < from.Length; i++)
    {
        from[i] = reader.ReadDouble();
        Console.Write(from[i] + " ");
    }
    Console.WriteLine();
}

Console.ReadKey();