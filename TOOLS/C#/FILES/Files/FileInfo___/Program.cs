// 4 - FileInfo


//Некоторые полезные методы и свойства класса FileInfo:

//CopyTo(path): копирует файл в новое место по указанному пути path

//Create(): создает файл

//Delete(): удаляет файл

//MoveTo(destFileName): перемещает файл в новое место

//Свойство Directory: получает родительский каталог в виде
//объекта DirectoryInfo

//Свойство DirectoryName: получает полный путь к родительскому каталогу

//Свойство Exists: указывает, существует ли файл

//Свойство Length: получает размер файла

//Свойство Extension: получает расширение файла

//Свойство Name: получает имя файла

//Свойство FullName: получает полное имя файла


// Для создания объекта FileInfo применяется конструктор,
// который получает в качестве параметра путь к файлу:

FileInfo fileInf = new FileInfo(@"C:\app\content.txt");


// Пути к файлам

// абсолютные пути
string path1 = @"C:\Users\eugene\Documents\content.txt";  // для Windows
string path2 = "C:\\Users\\eugene\\Documents\\content.txt";  // для Windows
string path3 = "/Users/eugene/Documents/content.txt";  // для MacOS/Linux

// относительные пути
string path4 = "MyDir\\content.txt";  // для Windows
string path5 = "MyDir/content.txt";  // для MacOS/Linux


// Получение информации о файле

string path = @"C:\Users\eugene\Documents\content.txt";
// string path = "/Users/eugene/Documents/content.txt";  // для MacOS/Linux
FileInfo fileInfo = new FileInfo(path);
if (fileInfo.Exists)
{
    Console.WriteLine($"Имя файла: {fileInfo.Name}");
    Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
    Console.WriteLine($"Размер: {fileInfo.Length}");
}


// Удаление файла

string path6 = @"C:\app\content.txt";
FileInfo fileInf1 = new FileInfo(path6);
if (fileInf1.Exists)
{
    fileInf1.Delete();
    // альтернатива с помощью класса File
    // File.Delete(path);
}


// Перемещение файла

string path7 = @"C:\OldDir\content.txt";
string newPath = @"C:\NewDir\index.txt";
FileInfo fileInf2 = new FileInfo(path7);
if (fileInf2.Exists)
{
    fileInf2.MoveTo(newPath);
    // альтернатива с помощью класса File
    // File.Move(path, newPath);
}


// Копирование файла

string path8 = @"C:\OldDir\content.txt";
string newPath1 = @"C:\NewDir\index2.txt";
FileInfo fileInf3 = new FileInfo(path8);
if (fileInf3.Exists)
{
    fileInf3.CopyTo(newPath1, true);
    // альтернатива с помощью класса File
    // File.Copy(path, newPath, true);
}