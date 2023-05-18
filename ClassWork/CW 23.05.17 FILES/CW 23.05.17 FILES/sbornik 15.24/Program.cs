//15.24.Имеется текстовый файл. Переписать его строки в другой файл.
//Порядок строк во втором файле должен:

//а) совпадать с порядком строк в заданном файле;
//б) быть обратным по отношению к порядку строк в заданном файле.

using System.Text;

string? res = null;

using (StreamReader sr = new StreamReader("text.txt"))
{
    string? line;

    while ((line = await sr.ReadLineAsync())!= null)
    {
        res += line + '\n';
    }
}

Console.WriteLine (res);

using (StreamWriter sw = new StreamWriter("new.txt",false)) // без тру - перезапись
{
    await sw.WriteAsync (res);  
}

string[] mas = res.Split('\n');
string? revStr = null;

for (int i = mas.Length-1; i >= 0; i--)
{
    revStr += mas[i] + "\n";
}

using (StreamWriter sw = new StreamWriter ( "new.txt", true )) // без тру - перезапись
{
    await sw.WriteAsync ( revStr );
}
