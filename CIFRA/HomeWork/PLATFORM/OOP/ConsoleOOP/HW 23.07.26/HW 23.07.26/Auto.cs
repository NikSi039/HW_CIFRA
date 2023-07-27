using System;
namespace HW_23._07._26
{
	public class Auto
	{
		public int AutoNumber { get;private set; }
		public bool IsRepairNeeded { get; set; }

        public Auto(int autoNumber)
        {
            AutoNumber = autoNumber;
        }
    }
}