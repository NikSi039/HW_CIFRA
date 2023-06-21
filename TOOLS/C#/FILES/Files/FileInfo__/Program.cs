// 1 - DriveInfo


//Этот класс имеет статический метод GetDrives(),
//который возвращает имена всех логических дисков компьютера.

//Также он предоставляет ряд полезных свойств:

//AvailableFreeSpace: указывает на объем доступного свободного
//места на диске в байтах

//DriveFormat: получает имя файловой системы

//DriveType: представляет тип диска

//IsReady: готов ли диск (например, DVD-диск может быть не вставлен
//в дисковод)

//Name: получает имя диска

//RootDirectory: возвращает корневой каталог диска

//TotalFreeSpace: получает общий объем свободного места на диске в байтах

//TotalSize: общий размер диска в байтах

//VolumeLabel: получает или устанавливает метку тома


DriveInfo[] drives = DriveInfo.GetDrives();

foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"Название: {drive.Name}");
    Console.WriteLine($"Тип: {drive.DriveType}");
    if (drive.IsReady)
    {
        Console.WriteLine($"Объем диска: {drive.TotalSize}");
        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
        Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
    }
    Console.WriteLine();
}

Console.ReadKey();