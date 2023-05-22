//14.2.Создать типизированный файл и записать в него:
//а) 5 одинаковых целых чисел;
//б) 5 одинаковых вещественных чисел;
//в) 5 одинаковых слов.
//Записываемые числа и слова вводятся с клавиатуры.


using (BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate)))
{
    for (int i = 0; i < 5; i++)
    {
        writer.Write(int.Parse(Console.ReadLine()));
    }
}

using (BinaryReader reader = new BinaryReader(File.Open("file.dat", FileMode.Open)))
{
    for (int i = 0; i < 5; i++)
    {
        int d = reader.ReadInt32();
        Console.Write(d + " ");
    }
    Console.WriteLine();
}

Console.ReadKey();

