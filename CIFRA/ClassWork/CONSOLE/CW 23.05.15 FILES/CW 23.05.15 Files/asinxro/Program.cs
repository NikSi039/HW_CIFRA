using System.Text;

namespace asinxro
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            MyMethodWrite ();

            MyMethodRead ();

            Console.ReadKey ();
        }


        // END


        async static void MyMethodWrite ()
        {
            // Запись

            Console.WriteLine ( "Введите текст: " );
            string text = Console.ReadLine ();

            using (FileStream fstream = new FileStream ( "File.txt", FileMode.OpenOrCreate ))
            {
                byte[] buffer = Encoding.Default.GetBytes (text);

                await fstream.WriteAsync ( buffer, 0, buffer.Length );
            }
        }

        async static void MyMethodRead ()
        {
            // Чтение

            using (FileStream fstream = new FileStream ( "File.txt", FileMode.Open ))
            {
                byte[] buffer = new byte[fstream.Length];

                await fstream.ReadAsync ( buffer, 0, buffer.Length );

                string readText = Encoding.Default.GetString (buffer);
                Console.WriteLine ( readText );
            }
        }
    }
}