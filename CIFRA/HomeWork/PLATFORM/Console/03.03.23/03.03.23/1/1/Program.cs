int userNumber;
int sum = 0;
int coutBigNumber = 0;
int countSmallNumber = 0;
int minValue = int.MaxValue;
int maxValue = int.MinValue;
bool next = false;

for (int i = 0; i < 10; i++)
{
    while (next == false)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out userNumber))
        {
            sum += userNumber;
            if (userNumber > 10) coutBigNumber++;
            if (userNumber < 10) countSmallNumber++;
            if (userNumber < minValue) minValue = userNumber;
            if (userNumber > maxValue) maxValue = userNumber;
            next = true;
        }
        else Console.WriteLine("Введено некорректное значение");
    }
    next = false;
}

Console.WriteLine(sum);
Console.WriteLine(coutBigNumber);
Console.WriteLine(countSmallNumber);
Console.WriteLine(sum / 10);
Console.WriteLine(minValue);
Console.WriteLine(maxValue);

Console.ReadKey();