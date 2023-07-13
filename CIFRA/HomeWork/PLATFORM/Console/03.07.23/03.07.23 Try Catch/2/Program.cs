Console.Write("Введите числа через пробел: ");
string userInput = Console.ReadLine()!;

string[] userNumbers = userInput.Split(new char[] { ' ' },
    StringSplitOptions.RemoveEmptyEntries);

int[] numbers = new int[userNumbers.Length];

for (int i = 0; i < userNumbers.Length; i++)
{
    try
    {
        numbers[i] = int.Parse(userNumbers[i]);
    }
    catch (Exception ex)
    {
        numbers[i] = 0;
    }
}

int sum = numbers.Sum();
Console.Write("Сумма чисел: " + sum);

Console.ReadKey();