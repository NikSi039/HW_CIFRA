using System.Linq;

int[][] numbers = new int[3][];
numbers[0] = new int[4];
numbers[1] = new int[6];
numbers[2] = new int[10];

Random random = new();

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers[i].Length; j++)
    {
        numbers[i][j] = random.Next(1, 11);
        Console.Write(numbers[i][j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < numbers.Length; i++) Console.WriteLine(numbers[i].Sum());

double avaregeNumber = (numbers[0].Average() + numbers[1].Average() + numbers[2].Average()) / 3;
Console.WriteLine($"{avaregeNumber:F2}");

Console.ReadKey();