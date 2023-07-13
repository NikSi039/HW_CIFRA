int _sum = 0;

Console.Write("Введите числа через запятую: ");
string numbersString = Console.ReadLine()!;

string[] array = numbersString.Split(',');

for (int i = 0; i < array.Length; i++)
{
    _sum += int.Parse(array[i]);
}

Console.WriteLine(_sum);

Console.ReadKey();