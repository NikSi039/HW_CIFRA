using System.Runtime.CompilerServices;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.2.Рассчитать значение у, определив и использовав необходимую функцию:

            Console.WriteLine($"{Serial(10):F2}");


            //end

            double Serial(int n)
            {
                double s = 0;
                
                for (int i = 1; i <= n; i++)
                {
                    s += (i + Math.Sin(i))/Power(3,i); 
                }

                return s;
                
                int Power(int basa,int m)
                {
                    if (m == 0)
                    {
                        return 1;
                    }
                    else if (m == 1)
                    {
                        return basa;
                    }
                    else
                    {
                        return basa * Power(basa, m-1);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}