namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{SumReal(10):F2}");

            //end

            double SumReal(int n)
            {
                double s = 0;

                for (int i = 1; i <= n; i++)
                {
                    s += (i + 3.0)/Fact(i);
                }

                return s;

                int Fact(int n)
                {
                    if (n == 0 || n == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return n * Fact(n - 1);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}