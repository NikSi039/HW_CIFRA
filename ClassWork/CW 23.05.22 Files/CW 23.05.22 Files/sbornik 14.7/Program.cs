//14.7.Дана последовательность целых чисел, оканчивающаяся нулем. Записать все 
//числа последовательности в типизированный файл.

using (BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate)))
{
    Random random = new Random();
    int n = 0;

    do
    {
        n = random.Next(-10, 11);
        writer.Write(n);
    }
    while (n != 0);
}

using (BinaryReader reader = new BinaryReader(File.Open("file.dat", FileMode.Open)))
{
    int n;

    do
    {
        n = reader.ReadInt32();
        Console.Write(n + " ");
    }
    while (n != 0);
}

Console.ReadKey();