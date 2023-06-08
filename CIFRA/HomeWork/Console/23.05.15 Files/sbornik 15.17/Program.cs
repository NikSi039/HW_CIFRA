using System.Text;

namespace sbornik_15._17;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напечатать первую строку:\n");
        MyMethodRead("lines", 0, 0);
        Thread.Sleep(1000);

        Console.WriteLine("\n\n\nНапечатать пятую строку:\n");
        MyMethodRead("lines", 4, 4);
        Thread.Sleep(1000);

        Console.WriteLine("\n\n\nНапечатать первые 5 строк:\n");
        MyMethodRead("toLines", 5, 5);
        Thread.Sleep(1000);

        Console.WriteLine("\n\n\nНапечатать строки с s1-й по s2-ю:\n");
        MyMethodRead("lines", 1, 2);
        Thread.Sleep(1000);

        Console.WriteLine("\n\n\nНапечатать весь файл:\n");
        MyMethodRead("allLines", 0, 0);
        Thread.Sleep(1000);

        Console.ReadKey();
    }


    async static void MyMethodRead(string str, int c1, int c2)
    {
        using (FileStream f = new FileStream("File.txt", FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[f.Length];

            await f.ReadAsync(buffer, 0, buffer.Length);

            string text = Encoding.Default.GetString(buffer);

            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    count++;
                }

                switch (str)
                {
                    case "lines":
                        if (count == c1 || count == c2)
                        {
                            Console.Write(text[i]);
                        }
                        break;
                    case "toLines":
                        if (count < c1)
                        {
                            Console.Write(text[i]);
                        }
                        break;
                    case "allLines":
                        Console.Write(text[i]);
                        break;
                }
            }
        }
    }
}

