string path = @"..\text.txt";
string newPath = @"..\newtext.txt";
string movePath = @"text.txt";
string destinationPath = @"dtext.txt";
string resPath = @"rtext.txt";

FileInfo fileInfo = new FileInfo(path);
FileInfo newInfo = new FileInfo(newPath);
FileInfo newInfo2 = new FileInfo(movePath);

if (fileInfo.Exists)
{
    Console.WriteLine("Имя файла: " + fileInfo.Name); // Информация о файле
    Console.WriteLine("Время создания: " + fileInfo.CreationTime);
    Console.WriteLine("Размер файла: " + fileInfo.Length);

    fileInfo.CopyTo(newPath, true); //  Скопировать файл

    fileInfo.MoveTo(movePath);    //  Перенести файл

    newInfo.Delete();   // Удаление файла
}

if (newInfo.Exists)
{
    Console.WriteLine("Имя файла: " + newInfo.Name);
    Console.WriteLine("Время создания: " + newInfo.CreationTime);
    Console.WriteLine("Размер файла: " + newInfo.Length);

    Console.WriteLine(newInfo.FullName);  //  Полное имя
    Console.WriteLine(newInfo.Directory);  //  Путь
    Console.WriteLine(newInfo.Attributes);  //  Атрибуты
    Console.WriteLine(newInfo.DirectoryName);
}

if (newInfo2.Exists)
{
    newInfo2.Replace(destinationPath, resPath, true);
}

Console.ReadKey();