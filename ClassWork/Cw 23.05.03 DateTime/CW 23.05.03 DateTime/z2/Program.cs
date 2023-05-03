namespace z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d3 = new DateTime(2023, 4, 1);
            DateTime d4 = new DateTime(2023, 3, 1);

            int hours = d3.Subtract(d4).Hours;
            int count = int.Parse(Console.ReadLine());
            int pay = int.Parse(Console.ReadLine());

            double sum = ((hours / (24.0 / 6)) * count * pay) + (hours / (24.0 / 10)) * count * pay * 0.7) +(hours / (24.0 / 8)) * count * pay * 0.4);










            Console.ReadKey();
        }
    }
}