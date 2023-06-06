//15.29.Имеется текстовый файл.
//
//Все четные строки этого файла записать во второй файл,
//а нечетные — в третий файл.
//
//Порядок следования строк сохраняется.

using (StreamReader sr = new StreamReader("text.txt"))
{
    string? line;
    int count = 0;

    while ((line = await sr.ReadLineAsync()) != null)
    {
        count++;
        line = line + "\n";

        if (count % 2 == 0)
        {
            using (StreamWriter sr2 = new StreamWriter("newText1",true))
            {
                await sr2.WriteAsync(line);
            }
        }
        else
        {
            using (StreamWriter sr3 = new StreamWriter("newText2",true))
            {
                await sr3.WriteAsync(line);
            }
        }
    }
}