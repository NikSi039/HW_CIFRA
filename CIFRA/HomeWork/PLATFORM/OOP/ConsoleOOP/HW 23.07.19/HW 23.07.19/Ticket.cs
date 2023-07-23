using System;
using System.Net.Sockets;

namespace HW_23._07._19
{
    public class Ticket
    {
        private int ticketNumber;
        public int TicketNumber
        {
            get { return ticketNumber; }
            set { if (value > 0) this.ticketNumber = value; }
        }

        private string? ticketType;
        public string? TicketType { get; set; }

        private DateOnly datePurchase;
        public DateOnly DatePurchase { get; }

        public Ticket(int ticketNumber, string? ticketType,
            int year, int month, int day)
        {
            TicketNumber = ticketNumber;
            TicketType = ticketType;
            datePurchase = new DateOnly(year, month, day);
            DatePurchase = datePurchase;
        }
    }
}