using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._17_Constructor
{
    internal class Train
    {
        private string destination;
        private int number;
        private TimeOnly time;

        public Train(string destination, int number, int h, int m)
        {
            this.destination = destination;
            this.number = number;
            this.time = new TimeOnly(h,m);
        }

        public string Print()
        {
            return $"{destination} {number} {time.ToString()}";
        }

        public int getNumber()
        {
            return number;
        }

        public string getDestination()
        {
            return destination;
        }
    }
}
