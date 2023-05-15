using System.Text;

namespace write
{
    internal class Program
    {
        static void Main ( string[] args )
        {
           // Синхронно
            
            // Запись в файл

            Console.Write ( "Введите текст:" );
            string text = Console.ReadLine();

            using (FileStream fstream = new FileStream ( "File.txt", FileMode.Create, FileAccess.Write ))
            {
                byte[] buffer = Encoding.Default.GetBytes (text);

                fstream.Write ( buffer, 0, buffer.Length );
            }
        }
    }
}