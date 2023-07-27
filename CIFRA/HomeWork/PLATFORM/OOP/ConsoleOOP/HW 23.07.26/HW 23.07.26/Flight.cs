using System;
namespace HW_23._07._26
{
	public class Flight
	{
		public int FlightNumber { get; private set; }
		public Driver? Driver { get; private set; }
		public Auto? Auto { get; private set; }
		public bool IsFlightDone { get; set; }

        public Flight(int flightNumber, Driver? driver, Auto? auto)
        {
            FlightNumber = flightNumber;
            Driver = driver;
            Auto = auto;
        } 
    }
}