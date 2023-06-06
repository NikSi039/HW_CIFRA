namespace sbornik_15._19__2
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            using (StreamReader sr = new StreamReader ( "text.txt" ))
            {
                string line;
                int count = 0;

                // синхронно

                while (( line = sr.ReadLine () ) != null)
                {
                    string[] mas = line.Split ('и');

                    if (mas.Length == 6)
                    {
                        count++;
                    }
                }

                Console.WriteLine ( count );
            }

            Console.ReadKey ();
        }
    }
}