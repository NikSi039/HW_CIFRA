// запись бинарного файла

using (BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate)))
{
    writer.Write("Tom");
    writer.Write(17);
    writer.Write("text");
}

using (BinaryReader reader = new BinaryReader(File.Open("file.dat", FileMode.Open)))
{
    string name = reader.ReadString();
    int age = reader.ReadInt32();
    string next = reader.ReadString();

    Console.WriteLine(name + " " + age + " " + next);
}

Console.ReadKey();
