//15.20.Имеется текстовый файл.

//       б) Найти номер самой длинной строки.
//       Если таких строк несколько, то найти номер одной из них.

using (StreamReader sr = new StreamReader ( "text.txt" ))
{
    string? line;
    string max = "";
    int count = 0;
    int maxCount = 0;

    while (( line = await sr.ReadLineAsync () ) != null)
    {
        count++;

        if (line.Length > max.Length)
        {
            max = line;
            maxCount = count;
        }
    }

    Console.WriteLine(max);
    Console.WriteLine(maxCount);
}

Console.ReadKey ();
