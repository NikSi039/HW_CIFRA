using System;
namespace HW_23._07._25_LiquidAlcohol
{
    public class Liquid
    {
        protected string? name;
        protected double density;

        public Liquid(string? name, double density)
        {
            this.name = name;
            this.density = density;
        }

        public virtual void PrintLiquidData()
        {
            Console.WriteLine($"Density of {name} = {density} kg/m°3");
        }
    }
}