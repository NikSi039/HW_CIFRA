using System;
namespace HW_23._07._25_LiquidAlcohol
{
	public class Alcohol: Liquid
	{
        protected int strenght;

        public Alcohol(string? name, double density,int strenght)
            :base(name,density)
        {
            this.strenght = strenght;
        }

        public override void PrintLiquidData()
        {
            Console.WriteLine();
            base.PrintLiquidData();
            Console.WriteLine($"Strenght of {name} = {strenght} %");
        }
    }
}