using System;
namespace _4
{
    public class Ticket
    {
        private int ticketNumber;
        private string ticketType;
        private DateOnly datePurchase;

        public Ticket(int ticketNumber, string ticketType,
            int year, int month, int day)
        {
            this.ticketNumber = ticketNumber;
            this.ticketType = ticketType;
            this.datePurchase = new DateOnly(year, month, day);
        }

        public int getTicketNumber()
        {
            return ticketNumber;
        }
        public string getTicketType()
        {
            return ticketType;
        }
        public DateOnly getDatePurchase()
        {
            return datePurchase;
        }

        public void setTicketnumber(int number)
        {
            ticketNumber = number;
        }
        public void setTicketType(string type)
        {
            ticketType = type;
        }
    }
}

