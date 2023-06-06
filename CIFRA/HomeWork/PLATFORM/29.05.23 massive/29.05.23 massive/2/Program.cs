Random random = new();

int[][] numbers = new int[3][];
numbers[0] = new int[5];
numbers[1] = new int[10];
numbers[2] = new int[7];

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers[i].Length; j++)
    {
        numbers[i][j] = random.Next(1, 11);
        Console.Write($"{numbers[i][j]}\t");
    }
    Console.WriteLine();
}

Console.ReadKey();