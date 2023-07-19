using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._19_Svoistva
{
    internal class AutoMobile
    {
        public string Name { get;private set; }

        private double fuel;
        public double Fuel
        {
            get { return fuel; }
            set
            {
                if (value > 0)
                {
                    this.fuel = value;
                }
            }
        }
        private double rashod;
        public double Rashod
        {
            get { return rashod; }
            private set
            {
                if (value > 0)
                {
                    this.rashod = value;
                }
            }
        }

        public AutoMobile(string name, double fuel, double rasxod)
        {
            Name = name;
            Fuel = fuel;
            Rashod = rasxod;
        }

        public void Go(double km)
        {
            fuel -= (km * rashod / 100);
        }

        public double Total()
        {
            return (fuel / rashod) * 100;
        }

        public void Print()
        {
            Console.WriteLine($"{Total()}");
        }
    }
}
