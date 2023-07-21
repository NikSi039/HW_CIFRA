using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._19_Turniket
{
    enum TypeOfTicket
    {
        разовый,
        проездной,
        социальнаяКарта,
        транспортнаяКарта
    }

    internal class BusTicket
    {
        private int number;
        private DateOnly srok;
        private TypeOfTicket type;
        private bool isValid;

        public BusTicket(int number, DateOnly srok, TypeOfTicket type, bool isValid)
        {
            this.number = number;
            this.srok = srok;
            this.type = type;
            this.isValid = isValid;
        }

        public int GetNumber()
        {
            return number;
        }
        public DateOnly GetSrok()
        {
            return srok;
        }
        public TypeOfTicket GetType()
        {
            return type;
        }
        public bool IsTicketValid()
        {
            return isValid;
        }

        public void SetValid()
        {
            isValid = false;
        }

        public void Print()
        {
            Console.WriteLine("Срок действия: " + this.srok +
                "Вид билета: " + this.type);
        }
    }
}