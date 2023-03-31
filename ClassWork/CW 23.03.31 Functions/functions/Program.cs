namespace functions
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            int _seconds = 0;

            while (true)
            {
                Console.Clear ();
                _seconds = AddSeconds ( _seconds );
                Console.WriteLine ( $"Время: {GetHours ()} : {GetMinutes ()} : {GetSeconds ()}" );
                Console.WriteLine ( $"Секунды: " + _seconds );
                Thread.Sleep ( 1000 );
            }



            Console.ReadLine ();

            // PROGRAMM END




            int AddSeconds ( int seconds )
            {
                return seconds + GetSeconds ();
            }

            int GetSeconds ()
            {
                return DateTime.Now.Second;
            }

            int GetMinutes ()
            {
                return DateTime.Now.Minute;
            }

            int GetHours ()
            {
                return DateTime.Now.Hour;
            }



        }
    }
}