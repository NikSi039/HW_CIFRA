﻿namespace CW_23._05._08_DATE_TIME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Настройка форматов времени и даты

            // d - день месяца от 1 до 31
            // dd - день месяца от 1 до 31. К одноразрядным числам в начале добавляется 0
            // ddd - Сокращенное название дня недели
            // dddd - Полное название дня недели

            // f/ffffffff - Представляет собой миллисекунды.
            // Количество f символов указывает на число разрядов в миллисекундах

            // g - Период или эра

            // h - часы в виде от 1 до 12
            // hh - часы в виде от 1 до 12. Часы с одной цифрой дополняются нулем
            // H - часы в виде от 0 до 23
            // HH - часы в виде от 0 до 23. Часы с одной цифрой дополняются нулем

            // K - часовой пояс

            // m - минуты от нуля до 59
            // mm - минуты от 0 до 59. Минуты с одной цифрой дополняются нулем

            // M - месяц от 1 до 12
            // MM - месяц от 1 до 12. Месяц с одной цифрой дополняется нулем
            // MMM - сокращенное название месяца
            // MMMM - Полное название месяца

            // s - секунды от 0 до 59
            // ss - секунды от 0 до 59. Секунды с одной цифрой дополняются нулем

            // t - первые символы в обозначениях AM и PM

            // y - год с одной или двух цифр
            // yy - год с одной или двух цифр. Год с одной цифрой дополняется нулем
            // yyy - год из трех цифр
            // yyyy - год из четырех цифр
            // yyyyy - год из пяти цифр

            // z - смещение в часах относительно времени UTC
            // zz - смещение в часах относительно времени UTC.
            // Год с одной цифрой дополняется нулем
       

            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine(now.ToString("dd.MM.yyyy"));
            Console.WriteLine(now.ToString("dd.MM.yyyy HH:mm:ss"));

            Console.ReadKey();
        }
    }
}