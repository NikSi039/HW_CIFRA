// Вывести все файлы по указанному пути

string dirName = "C:\\";

if (Directory.Exists(dirName))
{
    Console.WriteLine("Подкаталоги: ");
    string[] dirs = Directory.GetDirectories(dirName);

    foreach (string item in dirs)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("Файлы: ");
    string[] files = Directory.GetFiles(dirName);

    foreach (string item in files)
    {
        Console.WriteLine(item);
    }
}

var directory = new DirectoryInfo(dirName);

if (directory.Exists)
{
    Console.WriteLine("Папки: ");
    DirectoryInfo[] dirs = directory.GetDirectories();

    foreach (DirectoryInfo item in dirs)
    {
        Console.WriteLine(item.FullName);
    }

    Console.WriteLine("Файлы: ");
    FileInfo[] files = directory.GetFiles();

    foreach (FileInfo item in files)
    {
        Console.WriteLine(item.FullName);
    }
}

Console.ReadKey();