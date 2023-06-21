// 2 - Directory


//Статический класс Directory предоставляет ряд методов
//для управления каталогами.

//Некоторые из этих методов:

//CreateDirectory(path): создает каталог по указанному пути path

//Delete(path): удаляет каталог по указанному пути path

//Exists(path): определяет, существует ли каталог по указанному пути path.
//Если существует, возвращается true, если не существует, то false

//GetCurrentDirectory(): получает путь к текущей папке

//GetDirectories(path): получает список подкаталогов в каталоге path

//GetFiles(path): получает список файлов в каталоге path

//GetFileSystemEntries(path): получает список подкаталогов
//и файлов в каталоге path

//Move(sourceDirName, destDirName): перемещает каталог

//GetParent(path): получение родительского каталога

//GetLastWriteTime(path): возвращает время последнего изменения каталога

//GetLastAccessTime(path): возвращает время последнего обращения к каталогу

//GetCreationTime(path): возвращает время создания каталога


string dirName = "C:\\";
// если папка существует
if (Directory.Exists(dirName))
{
    Console.WriteLine("Подкаталоги:");
    string[] dirs1 = Directory.GetDirectories(dirName);
    foreach (string s in dirs1)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();
    Console.WriteLine("Файлы:");
    string[] files1 = Directory.GetFiles(dirName);
    foreach (string s in files1)
    {
        Console.WriteLine(s);
    }
}

Console.ReadKey();


// Фильтрация папок и файлов

string[] dirs = Directory.GetDirectories(dirName, "books*.");

string[] files = Directory.GetFiles(dirName, "*.exe");

Console.ReadKey();


// Создание каталога

string path = @"C:\SomeDir";
string subpath = @"program\avalon";
if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
}
Directory.CreateDirectory($"{path}/{subpath}");

Console.ReadKey();


// Удаление каталога

string dirName1 = @"C:\SomeDir";
if (Directory.Exists(dirName))
{
    Directory.Delete(dirName1, true);
    Console.WriteLine("Каталог удален");
}
else
{
    Console.WriteLine("Каталог не существует");
}

Console.ReadKey();