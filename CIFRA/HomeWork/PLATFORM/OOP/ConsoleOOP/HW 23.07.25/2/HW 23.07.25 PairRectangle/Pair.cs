using System;
namespace HW_23._07._25_PairRectangle
{
    public class Pair
    {
        protected int firstNumber;
        protected int secondNumber;

        public Pair(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public void ChangeNumbers(int number1, int number2)
        {
            firstNumber = number1;
            secondNumber = number2;
        }

        public double Multiplication()
        {
            return firstNumber * secondNumber;
        }
    }
}