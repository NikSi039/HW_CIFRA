using System.IO;
using System.Text;

namespace sbornik_15._2
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            MyMethodWrite ();

            Console.ReadKey ();
        }

        async static void MyMethodWrite ()
        {
            Console.WriteLine ( "Введите текст: " );
            string text = Console.ReadLine ();

            using (FileStream f = new FileStream ( "File.txt", FileMode.OpenOrCreate ))
            {
                byte[] buffer = Encoding.Default.GetBytes (text + '\n');

                for (int i = 0; i < 5; i++)
                {
                    await f.WriteAsync ( buffer, 0, buffer.Length );
                }
                
            }
        }
    }
}