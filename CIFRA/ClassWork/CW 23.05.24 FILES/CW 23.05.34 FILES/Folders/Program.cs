// Вывести все файлы по указанному пути

DriveInfo[] drives = DriveInfo.GetDrives();

foreach (DriveInfo drive in drives)
{
    Console.WriteLine(drive.Name);
    Console.WriteLine(drive.DriveType);

    if (drive.IsReady)
    {
        Console.WriteLine(drive.TotalSize);
        Console.WriteLine(drive.TotalFreeSpace);
        Console.WriteLine(drive.VolumeLabel);
    }
}

