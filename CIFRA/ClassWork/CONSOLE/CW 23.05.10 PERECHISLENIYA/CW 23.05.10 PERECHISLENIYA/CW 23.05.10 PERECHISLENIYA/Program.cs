namespace CW_23._05._10_PERECHISLENIYA
{
    enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------1---------");

            Operation op;

            op = Operation.Add;
            Console.WriteLine(op);

            op = Operation.Multiply;
            Console.WriteLine((int)op);

            Console.WriteLine("--------------2----------");

            Console.Write("Введте первое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введте второе число: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(MathOperation(a, b, Operation.Add));
            Console.WriteLine(MathOperation(a, b, Operation.Subtract));
            Console.WriteLine(MathOperation(a, b, Operation.Multiply));
            Console.WriteLine(MathOperation(a, b, Operation.Divide));

            for (Operation i = Operation.Add; i <= Operation.Divide; i++)
            {
                Console.WriteLine((int)i + " " + i);
            }

            Console.ReadKey();


            //END


            double MathOperation(double x, double y, Operation op)
            {
                double result = 0;

                switch (op)
                {
                    case Operation.Add: result = x + y; break;
                    case Operation.Subtract: result = x - y; break;
                    case Operation.Multiply: result = x * y; break;
                    case Operation.Divide: result = x / y; break;
                }
                return result;
            }
        }
    }
}