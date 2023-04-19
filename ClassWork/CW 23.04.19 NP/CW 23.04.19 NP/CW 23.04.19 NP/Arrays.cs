namespace CW_23._04._19_NP
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            int[] massive = new int[12];

            Random random = new Random();

            int s = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(10, 100);
                Console.Write(massive[i] + " ");
                s+= massive[i];
            }
            Console.WriteLine();
            Console.WriteLine($"S = {s}");







            Console.ReadLine();
        }
    }
}