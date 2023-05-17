namespace bufferedStream
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                string line;

                while ((line = sr.ReadLine())!=null)
                {
                    if (line.StartsWith("т"))
                    {
                        Console.WriteLine (line);
                    }
                }
            }

            Console.ReadKey ();

            //using (StreamReader sr = new StreamReader ( "text.txt" ))
            //{
            //    string line;

            //    while (( line = sr.ReadLine () ) != null)
            //    {
            //        if (line.lenght > 30)
            //        {
            //            Console.WriteLine ( line );
            //        }
            //    }
            //}


            using (StreamReader sr = new StreamReader ( "text.txt" ))
            {
                string line;

                while (( line = sr.ReadLine () ) != null)
                {
                    string[] mas = line.Split(' ');

                    if (mas.Length > 4)
                    {
                        Console.WriteLine (line);
                    }
                }
            }

            Console.ReadKey ();

            Console.Write ("Введите текст: ");
            string str = Console.ReadLine ();   

            using (StreamReader sr = new StreamReader ( "text.txt" ))
            {
                string line;

                while (( line = sr.ReadLine () ) != null)
                {
                    if (line.Contains(str))
                    {
                        Console.WriteLine ( line );
                    }
                }
            }
        }
    }
}