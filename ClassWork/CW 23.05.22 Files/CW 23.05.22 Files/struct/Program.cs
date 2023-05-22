Console.Write("Введите количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine());

Person[] mas = new Person[n];

for (int i = 0; i < mas.Length; i++)
{
    mas[i].Name = Console.ReadLine();
    mas[i].Age = int.Parse(Console.ReadLine());
}

using(BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate)))
{
    foreach (Person p in mas)
    {
        writer.Write(p.Name);
        writer.Write(p.Age);
    }
}

using(BinaryReader reader = new BinaryReader(File.Open("file.dat", FileMode.Open)))
{
    while (reader.PeekChar()>-1)
    {
        Console.WriteLine(reader.ReadString() + " " + reader.ReadInt32());
    }
}





Console.ReadKey();

struct Person
{
    public string Name;
    public int Age;
}
