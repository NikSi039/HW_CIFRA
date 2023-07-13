using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("\n" + Sum());

Console.ReadKey();

// END

double Sum()
{
    double firstValue = GetNumber("первое");
    double secondValue = GetNumber("второе");

    return firstValue + secondValue;
}

double GetNumber(string massage)
{
    bool next = false;
    double number = 0;

    while (next == false)
    {
        Console.Write($"Введите {massage} число: ");
        if (double.TryParse(Console.ReadLine().Replace(",", "."), out number))
        {
            next = true;
        }
        else Console.WriteLine("\nВведите корректное значение");
    }
    return number;
}