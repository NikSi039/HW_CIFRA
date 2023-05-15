using System.Text;

namespace CW_23._05._15_Files
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            // Синхронное
            
            // Чтение файла


            // 1 способ

            FileStream stream = null;

            try
            {
                stream = new FileStream ( "File.txt", FileMode.Open );

                byte[] buffer = new byte[1024];
                UTF8Encoding text = new UTF8Encoding(true);

                while (stream.Read ( buffer, 0, buffer.Length ) > 0)
                {
                    Console.WriteLine ( text.GetString ( buffer ) );
                }
            }
            catch (Exception e)
            {

                Console.WriteLine ( e.Message );
            }
            finally
            {
                stream.Close ();
            }


            // 2 способ - удобней


            void ReadFile ()
            {
                using (FileStream fs = new FileStream ( "File.txt", FileMode.Open ))
                {
                    byte[] buffer = new byte[1024];
                    UTF8Encoding text = new UTF8Encoding(true);

                    while (fs.Read ( buffer, 0, buffer.Length ) > 0)
                    {
                        Console.WriteLine ( text.GetString ( buffer ) );
                    }
                }
            }

            Console.ReadKey ();
        }
    }
}