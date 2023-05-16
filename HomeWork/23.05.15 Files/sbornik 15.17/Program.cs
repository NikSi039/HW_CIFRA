using System.Text;

namespace sbornik_15._17;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напечатать первую строку:\n");
        MyMethodReadA();
        Thread.Sleep(1000);
        
        Console.WriteLine("\n\n\nНапечатать пятую строку:");
        MyMethodReadB();
        Thread.Sleep(1000);

        Console.WriteLine("\n\n\nНапечатать первые 5 строк:\n");
        MyMethodReadV();
        Thread.Sleep(1000);

        Console.WriteLine("\n\n\nНапечатать строки с s1-й по s2-ю:\n");
        MyMethodReadG();
        Thread.Sleep(1000);

        Console.WriteLine("\n\n\nНапечатать весь файл:\n");
        MyMethodReadD();
        Thread.Sleep(1000);

        Console.ReadKey();
    }


    async static void MyMethodReadA()
    {
        using (FileStream f = new FileStream("File.txt", FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[f.Length];

            await f.ReadAsync(buffer, 0, buffer.Length);

            string text = Encoding.Default.GetString(buffer);

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                if (text[i] == '\n')
                {
                    break;
                }
            }
        }
    }

    async static void MyMethodReadB()
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

                if (count == 4)
                {
                    Console.Write(text[i]);
                }
            }
        }
    }

    async static void MyMethodReadV()
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

                if (count < 5)
                {
                    Console.Write(text[i]);
                }
            }
        }
    }

    async static void MyMethodReadG()
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

                if (count == 1 || count == 2)
                {
                    Console.Write(text[i]);
                }
            }
        }
    }

    async static void MyMethodReadD()
    {
        using (FileStream f = new FileStream("File.txt", FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[f.Length];

            await f.ReadAsync(buffer, 0, buffer.Length);

            string text = Encoding.Default.GetString(buffer);
            Console.WriteLine(text);
           
        }
    }
}

