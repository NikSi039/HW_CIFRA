using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._19_Turniket
{
    internal class BusTurniket
    {
     
        public bool IsValid(DateOnly date, BusTicket ticket)
        {
            if (ticket.GetType()  == TypeOfTicket.разовый && ticket.IsTicketValid())
            {
                ticket.Print();
                Open(ticket);
                ticket.SetValid();

                return true;
            }
            else if (date <= ticket.GetSrok())
            {
                ticket.Print();
                Open(ticket);
                return true;
            }
            else
            {
                ticket.Print();
                ticket.SetValid();
                Open(ticket);
                return false;
            }
        }

       

        private void Open(BusTicket ticket)
        {
            if (ticket.IsTicketValid())
            {
                Console.WriteLine("Турникет открыт");
            }
            else
            {
                Console.WriteLine("Турникет закрыт - билет просрочен");
            }
        }
    }
}
