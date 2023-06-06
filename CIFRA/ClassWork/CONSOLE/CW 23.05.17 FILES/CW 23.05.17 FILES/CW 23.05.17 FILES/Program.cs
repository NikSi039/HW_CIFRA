using System.Text;

namespace CW_23._05._17_FILES
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            // Seek() - позволяет управлять положением курсора потока,
            // начиная с которого производится чтение и запись.

            // Применяется для параметра offset и позиция в файле.

            // Позиция описывается тремя значениями:

            //  SeekOrigin.Begin - начало файла.
            //  SeekOrigin.End - конец файла.
            //  SeekOrigin.Current - текущая позиция в файле.

            string text = "Hello, world";

            using (FileStream fstream = new FileStream ( "text.txt", FileMode.OpenOrCreate ))
            {
                byte[] buffer = Encoding.Default.GetBytes ( text );
                fstream.Write ( buffer, 0, buffer.Length );
            }
            MyMethodSeek ();
            Thread.Sleep ( 1000 );

            MyMethod ();

            Console.ReadKey ();
        }

        static async void MyMethodSeek ()
        {
            using (FileStream fileStream = new FileStream ( "text.txt", FileMode.Open ))
            {
                fileStream.Seek ( -5, SeekOrigin.End );
                byte[] buffer = new byte[5];
                await fileStream.ReadAsync ( buffer, 0, buffer.Length );
                string textFromFile = Encoding.Default.GetString ( buffer );
                Console.WriteLine ( textFromFile );
            }
        }

        static async void MyMethod ()
        {
            using (FileStream fileStream = new FileStream ( "text.txt", FileMode.Open ))
            {
                fileStream.Seek ( -5, SeekOrigin.End );
                byte[] input = Encoding.Default.GetBytes("house");

                await fileStream.WriteAsync ( input, 0, input.Length );
            }
        }
    }
}