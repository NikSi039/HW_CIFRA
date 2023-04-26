namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //количество цифр натупального числа

            Console.WriteLine(Count(123));

            //end

            int Count(int n)
            {
                if (n < 10)
                {
                    return 1;
                }
                else
                {
                    return 1 + Count(n/10);
                }
            }

            Console.ReadKey();
        }
    }
}