using System;
namespace HW_23._07._25_PairRectangle
{
    public class Rectangle : Pair
    {
        public Rectangle(int firstNumber, int secondNumber)
            : base(firstNumber, secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perimetr()
        {
            return 2 * (firstNumber + secondNumber);
        }

        public double Area()
        {
            return firstNumber * secondNumber;
        }
    }
}