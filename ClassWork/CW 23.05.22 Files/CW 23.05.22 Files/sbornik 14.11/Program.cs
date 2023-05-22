//14.11.Дан типизированный файл, элементами которого являются числа. Напечатать:
//а) первый элемент;
//б) третий элемент;
//в) n - й элемент;
//г) последний элемент.


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
    int n = int.Parse(Console.ReadLine());
    int count = 0;
    int last = 0;

    while (reader.PeekChar() > -1)
    {
        count++;

        if (count == 1) Console.WriteLine(reader.ReadInt32());
        if (count == 3) Console.WriteLine(reader.ReadInt32());
        if (count == n) Console.WriteLine(reader.ReadInt32());
        last = reader.ReadInt32();
    }
    Console.WriteLine(last);
}

Console.ReadKey();