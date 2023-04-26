namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // локальные функции

            //             10.17. Найти значение выражения
            //            2 5! 3 8!
            //6! 4!
            //,
            //где n!означает факториал числа n(
            //n n! 1 2...
            //). (Определить функцию для
            //расчета факториала натурального числа.)

            Console.WriteLine(Func(2, 5, 3, 8, 6, 4));


            // end

            int Func(int a, int b, int c, int d, int e, int f)
            {
                return (a * Fact(b) + c * Fact(d)) / (Fact(e) + Fact(f));

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