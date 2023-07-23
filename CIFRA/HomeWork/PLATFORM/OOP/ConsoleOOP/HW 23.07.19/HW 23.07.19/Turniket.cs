using System;
namespace HW_23._07._19
{
	public class Turniket
	{
        DateOnly today = new DateOnly(DateTime.Now.Year, DateTime.Now.Month,
           DateTime.Now.Day);
        bool _isValid;

        private Ticket ticket;

        public Turniket()
        {
            Console.Write("\n\nВведите номер билета: ");
            int number = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\n\n1 - Разовый\n2 - Проездной на 30 дней\n" +
                "3 - Социальная карта\n4 - Транспортная карта на 365 дней");
            Console.Write("\nДля выбора типа билета, введите его номер из списка: ");
            string n1 = Console.ReadLine()!;
            string? ticketType = "";
            switch (n1)
            {
                case "1": ticketType = "day"; break;
                case "2": ticketType = "month"; break;
                case "3": ticketType = "social"; break;
                case "4": ticketType = "transport"; break;
                default:
                    Console.WriteLine("Введено некорректное значение");
                    break;
            }

            Console.Write("\n\nВведите год покупки билета: ");
            int y = int.Parse(Console.ReadLine()!);

            Console.Write("\nВведите номер месяца покупки билета: ");
            int m = int.Parse(Console.ReadLine()!);

            Console.Write("\nВведите номер дня покупки билета: ");
            int d = int.Parse(Console.ReadLine()!);

            this.ticket = new Ticket(number, ticketType, y, m, d);
        }

        public void GetValiditiAndTicketType()
        {
            int srok;
            switch (ticket.TicketType)
            {
                case "day":
                    srok = 1;
                    Console.WriteLine($"\n\nРазовый билет\n " +
                        $"Срок действия: {srok} день "); break;
                case "month":
                    srok = 30;
                    Console.WriteLine($"\n\nПроездной билет\n " +
                        $"Срок действия: {srok} дней"); break;
                case "social":
                    srok = int.MaxValue;
                    Console.WriteLine($"\n\nСоциальная карта\n " +
                        $"Срок действия: бессрочен "); break;
                case "transport":
                    srok = 365;
                    Console.WriteLine($"\n\nТранспортная карта\n " +
                        $"Срок действия: {srok} дней"); break;
            }
        }

        public void IsValid()
        {
            _isValid = false;
            switch (ticket.TicketType)
            {
                case "day":
                    if (ticket.DatePurchase == today)
                    {
                        Console.WriteLine($"\n\n\nБилет номер " +
                            $"{ticket.TicketNumber} годен");
                        _isValid = true;
                    }
                    else Console.WriteLine($"\n\n\nБилет номер " +
                        $"{ticket.TicketNumber} просрочен"); break;
                case "month":
                    if (ticket.DatePurchase > today.AddDays(-30))
                    {
                        Console.WriteLine($"\n\n\nБилет номер " +
                            $"{ticket.TicketNumber} годен");
                        _isValid = true;
                    }
                    else Console.WriteLine($"\n\n\nБилет номер " +
                        $"{ticket.TicketNumber} просрочен"); break;
                case "social":
                    Console.WriteLine($"\n\n\nБилет номер " +
                        $"{ticket.TicketNumber} годен");
                    _isValid = true; break;
                case "transport":
                    if (ticket.DatePurchase > today.AddYears(-1))
                    {
                        Console.WriteLine($"\n\n\nБилет номер " +
                            $"{ticket.TicketNumber} годен");
                        _isValid = true;
                    }
                    else Console.WriteLine($"\n\n\nБилет номер " +
                        $"{ticket.TicketNumber} просрочен"); break;
            }
        }

        public void TurniketIsOpen()
        {
            if (_isValid == true) Console.WriteLine("\n\n\nТурникет открыт");
            else Console.WriteLine("\n\n\nТурникет закрыт – билет просрочен");
        }
    }
}