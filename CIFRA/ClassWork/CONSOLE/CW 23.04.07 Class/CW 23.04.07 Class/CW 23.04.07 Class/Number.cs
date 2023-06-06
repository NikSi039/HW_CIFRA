using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._04._07_Class
{
    public class Number
    {
        public int Value = 1;
        public string Text = "None";

        public void ReadValue()
        {
            Console.WriteLine("Введите число: ");
            int input = int.Parse(Console.ReadLine());
            Value = input;
        }

        public void ReadText()
        {
            Console.WriteLine("Введите текст");
            Text = Console.ReadLine();
        }






    }
}
