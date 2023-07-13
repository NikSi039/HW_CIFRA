//string path = "/Users/programmirovanie/Desktop/newFolder";
//Directory.CreateDirectory(path);

Console.Write("Введите путь к файлу: ");
string userPath = Console.ReadLine()!;

Console.Write("Введите текст: ");
string text = Console.ReadLine()!;

File.WriteAllText(userPath, text);

Console.WriteLine("Файл успешно записан");

string readText = File.ReadAllText(userPath);
Console.WriteLine(readText);

Console.ReadKey();


