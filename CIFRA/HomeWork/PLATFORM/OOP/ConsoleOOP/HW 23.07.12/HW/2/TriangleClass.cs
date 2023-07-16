using System;
namespace _2
{
    public class TriangleClass
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public void SetSideA(double a)
        {
            if (a > 0)
            {
                sideA = a;
            }
        }
        public void SetSideB(double b)
        {
            if (b > 0)
            {
                sideB = b;
            }
        }
        public void SetSideC(double c)
        {
            if (c > 0)
            {
                sideC = c;
            }
        }

        public double GetSideA()
        {
            return sideA;
        }
        public double GetSideB()
        {
            return sideB;
        }
        public double GetSideC()
        {
            return sideC;
        }

        public double GetPerimetr()
        {
            return sideA + sideB + sideC;
        }

        public double GetArea()
        {
            double semiPerimetr = (sideA + sideB + sideC) / 2;
            double p = semiPerimetr;

            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}

