namespace zadacha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2015, 6, 18);
            DateTime d2 = new DateTime(2021, 11, 24);

            Console.WriteLine((int)d2.Subtract(d1).TotalDays/365);

            Console.ReadKey();
        }
    }
}