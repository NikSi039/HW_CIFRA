//14.11.Дан типизированный файл, элементами которого являются числа. Напечатать:
//а) первый элемент;
//б) третий элемент;
//в) n - й элемент;
//г) последний элемент.


using (BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate)))
{
    Random random = new();
    int n;

    do
    {
        n = random.Next(-10, 11);
        writer.Write(n);
        Console.Write(n + " ");
    }
    while (n != 0);
}
Console.WriteLine();

using (BinaryReader reader = new BinaryReader(File.Open("file.dat", FileMode.Open)))
{
    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine());
    int count = 0;
    int last = 0;

    while (reader.PeekChar() > -1)
    {
        count++;

        last = reader.ReadInt32();
        if (count == 1) Console.WriteLine(last);
        if (count == 3) Console.WriteLine(last);
        if (count == n) Console.WriteLine(last);
    }
    Console.WriteLine(last);
}

Console.ReadKey();