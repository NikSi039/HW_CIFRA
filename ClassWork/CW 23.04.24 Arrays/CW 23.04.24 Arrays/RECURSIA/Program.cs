namespace RECURSIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long Factorial(int n)
            {
                long F = 1;

                for (int i = 1; i <= n; i++)
                {
                    F *= i;
                }
                return F;
            }

            Console.WriteLine(Factorial(5));

            long RecFact(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * RecFact(n - 1);
                }
            }

            Console.WriteLine(RecFact(5));


            Console.ReadKey();  
        }
    }
}