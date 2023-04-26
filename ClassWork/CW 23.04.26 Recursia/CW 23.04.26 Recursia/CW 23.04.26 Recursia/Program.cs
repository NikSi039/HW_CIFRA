namespace CW_23._04._26_Recursia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // сумма цифр натурального числа

            Console.WriteLine(Sum(37));
   
            
            //end
            
           int Sum(int n)
            {
                if (n < 10)
                {
                    return n;
                }
                else
                {
                    return n % 10 + Sum(n / 10);
                }
            }

            Console.ReadKey();
        }
    }
}