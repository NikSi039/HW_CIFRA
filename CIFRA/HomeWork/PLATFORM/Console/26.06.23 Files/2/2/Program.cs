Console.Write("Введите путь к файлу: ");
string userPath = Console.ReadLine()!;

if (File.Exists(userPath))
{
    Console.WriteLine("Файл существует ");

    FileInfo fileInfo = new FileInfo(userPath);
    Console.WriteLine(fileInfo.Length);
    Console.WriteLine(fileInfo.LastWriteTime);
    Console.WriteLine(fileInfo.Extension);
}

Console.ReadKey();
