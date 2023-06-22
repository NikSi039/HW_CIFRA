// 3 - BinaryWriter и BinaryReader


//BinaryWriter


//Основные методы класса BinaryWriter

//Close(): закрывает поток и освобождает ресурсы

//Flush(): очищает буфер, дописывая из него оставшиеся данные в файл

//Seek(): устанавливает позицию в потоке

//Write(): записывает данные в поток.



string path = "person.dat";

// создаем объект BinaryWriter
using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
{
    // записываем в файл строку
    writer.Write("Tom");
    // записываем в файл число int
    writer.Write(37);
    Console.WriteLine("File has been written");
}



//Подобным образом можно сохранять более сложные данные.
//Например, сохраним в файл массив объектов:


string path1 = "people.dat";

// массив для записи
Person[] people =
{
    new Person("Tom", 37),
    new Person("Bob", 41)
};

using (BinaryWriter writer = new BinaryWriter(File.Open(path1, FileMode.OpenOrCreate)))
{
    // записываем в файл значение каждого свойства объекта
    foreach (Person person in people)
    {
        writer.Write(person.Name);
        writer.Write(person.Age);
    }
    Console.WriteLine("File has been written");
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}



// BinaryReader


//Основные методы класса BinaryReader


//Close(): закрывает поток и освобождает ресурсы

//ReadBoolean(): считывает значение bool и перемещает указатель на один байт

//ReadByte(): считывает один байт и перемещает указатель на один байт

//ReadChar(): считывает значение char, то есть один символ,
//и перемещает указатель на столько байтов, сколько занимает символ
//в текущей кодировке

//ReadDecimal(): считывает значение decimal и перемещает
//указатель на 16 байт

//ReadDouble(): считывает значение double и перемещает указатель на 8 байт

//ReadInt16(): считывает значение short и перемещает указатель на 2 байта

//ReadInt32(): считывает значение int и перемещает указатель на 4 байта

//ReadInt64(): считывает значение long и перемещает указатель на 8 байт

//ReadSingle(): считывает значение float и перемещает указатель на 4 байта

//ReadString(): считывает значение string. Каждая строка предваряется
//значением длины строки, которое представляет 7-битное целое число


using (BinaryReader reader = new BinaryReader(File.Open("person.dat", FileMode.Open)))
{
    // считываем из файла строку
    string name = reader.ReadString();
    // считываем из файла число 
    int age = reader.ReadInt32();
    Console.WriteLine($"Name: {name}  Age: {age}");
}


//

// список для считываемых данных
List<Person> people = new List<Person>();

// создаем объект BinaryWriter
using (BinaryReader reader = new BinaryReader(File.Open("people.dat", FileMode.Open)))
{
    // пока не достигнут конец файла
    // считываем каждое значение из файла
    while (reader.PeekChar() > -1)
    {
        string name = reader.ReadString();
        int age = reader.ReadInt32();
        // по считанным данным создаем объект Person и добавляем в список
        people.Add(new Person(name, age));
    }
}
// выводим содержимое списка people на консоль
foreach (Person person in people)
{
    Console.WriteLine($"Name: {person.Name}  Age: {person.Age}");
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}