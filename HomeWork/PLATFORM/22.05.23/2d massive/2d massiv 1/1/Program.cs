double[,] array = new double[3, 3];
Random random = new();
bool _next = false;
bool _done = false;
int verNumber, gorNumber;

GetArray();

GetUserNumber();

Console.Clear();

GetNewArray();

Console.ReadKey();


// END


void GetArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() * 10;
            Console.Write($"{array[i, j]:F2}\t");
        }
        Console.WriteLine();
    }
}

int InputElementNumber(string massage, int n)
{
    int newNumber = 0;
    while (_next == false)
    {
        Console.Write($"Введите номер элемента по {massage}: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= array.GetLength(n))
            {
                newNumber = number;
                _next = true;
            }
            else Console.WriteLine("\nТакого элемента нет\n");
        }
        else Console.WriteLine("\nВведено некорректное значение\n");
    }
    _next = false;
    return newNumber;
}

void GetNewNumber()
{
    while (_next == false)
    {
        Console.Write("\nВведите новое значение элемента: ");
        if (double.TryParse(Console.ReadLine(), out double userNumber))
        {
            array[verNumber - 1, gorNumber - 1] = userNumber;
            _next = true;
        }
        else Console.WriteLine("\nВведено некорректное значение");
    }
    _next = false;
}

void GetNewArray()
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}\t");
        }
        Console.WriteLine();
    }
}

void IsAnoth()
{
    while (_next == false)
    {
        Console.WriteLine("\n1 - YES\n2 - NO");
        Console.Write("\nХотите заменить еще один элемент?");
        string answer = Console.ReadLine();
        switch (answer)
        {
            case "1":
                _next = true;
                break;
            case "2":
                _done = true;
                _next = true;
                break;
            default:
                Console.WriteLine("\nВведено некорректное значение");
                break;
        }
    }
    _next = false;
}

void GetUserNumber()
{
    while (_done == false)
    {
        Console.WriteLine("\nКакой элемент вы хотите заменить?\n");

        verNumber = InputElementNumber("вертикали", 0);

        gorNumber = InputElementNumber("горизонтали", 1);

        GetNewNumber();

        GetNewArray();

        IsAnoth();
    }
}