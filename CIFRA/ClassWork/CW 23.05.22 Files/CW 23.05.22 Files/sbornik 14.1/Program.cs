//14.1.Создать типизированный файл и записать в него:
//а) число 500;
//б) число 4,5;
//в) слово Привет.



using (BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate)))
{
    writer.Write(500);
    writer.Write(4.5);
    writer.Write("Привет");
}

using (BinaryReader reader = new BinaryReader(File.Open("file.dat", FileMode.Open)))
{
    int age = reader.ReadInt32();
    double next = reader.ReadDouble();
    string name = reader.ReadString();

    Console.WriteLine(name + " " + age + " " + next);
}

Console.ReadKey();
