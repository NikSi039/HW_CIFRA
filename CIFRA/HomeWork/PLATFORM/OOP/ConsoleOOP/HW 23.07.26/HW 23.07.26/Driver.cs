using System;
namespace HW_23._07._26
{
	public class Driver
	{
		public string? Name { get;private set; }
		public bool IsWorkingSuspention { get; set; }

        public Driver(string? name)
        {
            Name = name;
        }

        public void RepairRequest(Auto auto)
        {
            auto.IsRepairNeeded = true;
        }

        public void FlightDoneSucces(Flight flight, Auto auto)
        {
            flight.IsFlightDone = true;
            auto.IsRepairNeeded = false;

            Console.WriteLine($"Рейс {flight.FlightNumber} завершен успешно, " +
                $"состояние авто {auto.AutoNumber} в норме");
        } 
    }
}