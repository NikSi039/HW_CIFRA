// 3 - DirectoryInfo


//Основные методы класса DirectoryInfo:

//Create(): создает каталог

//CreateSubdirectory(path): создает подкаталог по указанному пути path

//Delete(): удаляет каталог

//GetDirectories(): получает список подкаталогов папки
//в виде массива DirectoryInfo

//GetFiles(): получает список файлов в папке в виде массива FileInfo

//MoveTo(destDirName): перемещает каталог


//Основные свойства класса DirectoryInfo:

//CreationTime: представляет время создания каталога

//LastAccessTime: представляет время последнего доступа к каталогу

//LastWriteTime: представляет время последнего изменения каталога

//Exists: определяет, существует ли каталог

//Parent: получение родительского каталога

//Root: получение корневого каталога

//Name: имя каталога

//FullName: полный путь к каталогу


// Получение списка файлов и подкаталогов

using System.IO;

string dirName = @"C:\Program Files";
 
var directory = new DirectoryInfo(dirName);

if (directory.Exists)
{
    Console.WriteLine("Подкаталоги:");
    DirectoryInfo[] dirs1 = directory.GetDirectories();
    foreach (DirectoryInfo dir in dirs1)
    {
        Console.WriteLine(dir.FullName);
    }
    Console.WriteLine();
    Console.WriteLine("Файлы:");
    FileInfo[] files1 = directory.GetFiles();
    foreach (FileInfo file in files1)
    {
        Console.WriteLine(file.FullName);
    }
}

Console.ReadKey();


// Фильтрация папок и файлов

var directory1 = new DirectoryInfo(dirName);
DirectoryInfo[] dirs = directory.GetDirectories("books*.");

var directory2 = new DirectoryInfo(dirName);
FileInfo[] files = directory.GetFiles("*.exe");

Console.ReadKey();


// Создание каталога

string path = @"C:\SomeDir";
string subpath = @"program\avalon";
DirectoryInfo dirInfo = new DirectoryInfo(path);
if (!dirInfo.Exists)
{
    dirInfo.Create();
}
dirInfo.CreateSubdirectory(subpath);

Console.ReadKey();


// Получение информации о каталоге

string dirName1 = "C:\\Program Files";

DirectoryInfo dirInfo1 = new DirectoryInfo(dirName1);

Console.WriteLine($"Название каталога: {dirInfo1.Name}");
Console.WriteLine($"Полное название каталога: {dirInfo1.FullName}");
Console.WriteLine($"Время создания каталога: {dirInfo1.CreationTime}");
Console.WriteLine($"Корневой каталог: {dirInfo1.Root}");

Console.ReadKey();


// Удаление каталога

string dirName2 = @"C:\SomeDir";

DirectoryInfo dirInfo2 = new DirectoryInfo(dirName2);
if (dirInfo2.Exists)
{
    dirInfo2.Delete(true);
    Console.WriteLine("Каталог удален");
}
else
{
    Console.WriteLine("Каталог не существует");
}

Console.ReadKey();


// Перемещение каталога

string oldPath = @"C:\SomeFolder";
string newPath = @"C:\SomeDir";
DirectoryInfo dirInfo3 = new DirectoryInfo(oldPath);
if (dirInfo3.Exists && !Directory.Exists(newPath))
{
    dirInfo3.MoveTo(newPath);
    // или так
    // Directory.Move(oldPath, newPath);
}

Console.ReadKey();