using System;
namespace HW_23._07._26
{
	public class Dispetcher
	{
		public string? Name { get; set; }

		public void WorkSuspention(Driver driver)
		{
			driver.IsWorkingSuspention = true;
		}
		public void WorkPermit(Driver driver)
		{
			driver.IsWorkingSuspention = false;
		}

		public void ScheduleFlight(Flight flight)
		{
			if (flight.Driver!.IsWorkingSuspention == false &&
				flight.Auto!.IsRepairNeeded == false)
			{
				Console.WriteLine($"Рейс {flight.FlightNumber} успешно назначен");
			}
			if (flight.Driver!.IsWorkingSuspention == true)
			{
				Console.WriteLine($"Рейс {flight.FlightNumber} " +
					$"не может быть назначен, водитель {flight.Driver.Name} " +
					$"отстранен от работы");
			}
			if (flight.Auto!.IsRepairNeeded == true)
			{
				Console.WriteLine($"Рейс {flight.FlightNumber} " +
					$"не может быть назначен,  авто {flight.Auto.AutoNumber} " +
					$"требуется ремонт");
			}
		}	 
	}
}