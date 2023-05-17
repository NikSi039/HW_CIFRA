using (StreamReader sr = new StreamReader ( "text.txt" ))
{
    string? line;
    string max;

    while (( line = await sr.ReadLineAsync () ) != null)
    {
        if (true)
        {

        }
    }
}

Console.ReadKey ();
