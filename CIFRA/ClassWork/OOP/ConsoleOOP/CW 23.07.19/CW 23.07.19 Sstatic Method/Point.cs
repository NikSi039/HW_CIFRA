using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._19_Sstatic_Method
{
    internal class Point
    {
        public static int Count { get; set; }
        public static List<Point> OurPoints = new List<Point>();
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public static double LenghtPoints()
        {
            double lenght = 0;
            if (Count > 1)
            {
                for (int i = 1; i < OurPoints.Count; i++)
                {
                    lenght += Math.Sqrt((OurPoints[i].X - OurPoints[i - 1].X)
                        * (OurPoints[i].X - OurPoints[i - 1].X) +
                        (OurPoints[i].Y - OurPoints[i - 1].Y) * (OurPoints[i].Y
                        - OurPoints[i - 1].Y));
                }
            }
            return lenght;
        }
    }
}