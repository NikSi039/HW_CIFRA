﻿namespace functions
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            DateTime finishDateTime = new DateTime(2023,3,31,21,20,0);
            int _seconds = 0;
            DateTime _diffDateTime;  
            

            while (true)
            {
                Console.Clear ();
                _seconds = AddSeconds ( _seconds );
                Console.WriteLine ( $"Время: {GetHours ()} : {GetMinutes ( DateTime.Now )} : {GetSeconds (DateTime.Now)}" );
                Console.WriteLine ( "Секунды: " + _seconds );
                _diffDateTime =  new DateTime( finishDateTime.Ticks - DateTime.Now.Ticks);
                Console.WriteLine ( $"Время до конца пары:   { GetMinutes ( _diffDateTime )}  :  { GetSeconds ( _diffDateTime )}");
                Thread.Sleep ( 1000 );
            }

            Console.ReadLine ();

            // PROGRAMM END




            int AddSeconds ( int seconds )
            {
                return seconds + GetSeconds (DateTime.Now);
            }

            int GetSeconds (DateTime dateTimeParam)
            {
                return dateTimeParam.Second;
            }

            int GetMinutes  (DateTime dateTimeParam)
            {
                return dateTimeParam.Minute;
            }

            int GetHours ()
            {
                return DateTime.Now.Hour;
            }
        }
    }
}