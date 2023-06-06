
// полная перезапись файла

Console.Write ("Введите строку: ");
string? text = Console.ReadLine ();

using (StreamWriter sw = new StreamWriter("text.txt", false))
{
    await sw.WriteAsync (text);   
}

// добавление в файл

string? add = Console.ReadLine ();

using (StreamWriter sw = new StreamWriter ( "text.txt", true ))
{
    await sw.WriteLineAsync ( add );
}
