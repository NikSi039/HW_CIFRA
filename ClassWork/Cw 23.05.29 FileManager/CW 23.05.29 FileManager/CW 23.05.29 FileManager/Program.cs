while (true)
{
    string path = Environment.CurrentDirectory;
    Console.Write(path + ">");

    string? command = Console.ReadLine();
    string[] commands = command!.Split(' ');
    switch (commands[0])
    {
        case "help":
            Console.WriteLine("touch - создание файла touch file");
            Console.WriteLine("copy - копирование файла copy source destination");
            Console.WriteLine("move - перемещение файла move source destination");
            Console.WriteLine("delete - удаление файла delete file");
            break;
        case "touch":
           FileStream file = File.Create(@$"{path}\{commands[1]}");
            break;
        case "delete":
            FileInfo fileDel = new FileInfo(@$"{path}\{commands[1]}");
            if (fileDel.Exists) fileDel.Delete();
            else Console.WriteLine("Файл не существует");
            break;
        case "copy":
            FileInfo fileSource = new FileInfo(@$"{path}\{commands[1]}");
            if (fileSource.Exists) fileSource.CopyTo(@$"{path}\{commands[2]}",true);
            else Console.WriteLine("Файл не существует");
            break;
        case "move":
            FileInfo moveSource = new FileInfo(@$"{path}\{commands[1]}");
            if (moveSource.Exists) moveSource.MoveTo(@$"{path}\{commands[2]}", true);
            break;
        case "dir":
                DirectoryInfo dir = new DirectoryInfo(path);
                if (dir.Exists)
                {
                    foreach (DirectoryInfo s in dir.GetDirectories())
                    {
                        Console.WriteLine(s.Name);
                    }
                    foreach (FileInfo s in dir.GetFiles())
                    {
                        Console.WriteLine(s.Name + " " + s.Length + " " + s.CreationTime);
                    }
                }
                break;
        case "mkdir":
            DirectoryInfo dirinfo = new DirectoryInfo(@$"{path}\{commands[1]}");
            if(!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            break;
        
        default:
            break;
    }
}


