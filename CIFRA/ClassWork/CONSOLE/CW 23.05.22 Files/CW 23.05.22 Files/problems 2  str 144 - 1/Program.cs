int count = 0;

using (BinaryWriter writer = new(File.Open("text.dat", FileMode.OpenOrCreate)))
{
    Random random = new();
    int n;

    do
    {
        n = random.Next(-10, 11);
        writer.Write(n);
        count++;
        Console.Write(n + " ");
    } while (n != 0);
    Console.WriteLine("\n");
}

int[] mas = new int[count];

using (BinaryReader reader = new(File.Open("text.dat", FileMode.Open)))
{
    for (int i = 0; i < count; i++)
    {
        mas[i] = reader.ReadInt32() * 2;
    }
}

using (BinaryWriter writer = new(File.Open("text.dat", FileMode.Open, FileAccess.Write)))
{
    foreach (int item in mas)
    {
        writer.Write(item);
    }
}

using (BinaryReader reader = new(File.Open("text.dat", FileMode.Open)))
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(reader.ReadInt32() + " ");
    }
    Console.WriteLine();
}

Console.ReadKey();