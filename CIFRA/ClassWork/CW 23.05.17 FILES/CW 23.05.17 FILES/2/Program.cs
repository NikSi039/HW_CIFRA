// асинхронно

using (StreamReader sr = new StreamReader("text.txt"))
{
    // асинхронно весь текст

    string text = await sr.ReadToEndAsync();

    Console.WriteLine ( text );

    // асинхронно весь текст построчно

    string? line;

    while (( line = await sr.ReadLineAsync () ) != null)
    {
        Console.WriteLine ( line );
    }
}

Console.ReadKey ();


