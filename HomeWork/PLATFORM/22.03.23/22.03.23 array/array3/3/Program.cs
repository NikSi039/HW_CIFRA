int[] _array = new int[10];
bool _next = false;
int _userNumber;

for (int i = 0; i < _array.Length; i++)
{
    while (_next == false)
    {
        Console.Write("\nВведите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            _array[i] = number;
            _next = true;
        }
        else Console.WriteLine("\nВведено некорректное значение\n");
    }
    _next = false;
}

Array.Sort(_array);
Console.WriteLine();
for (int i = 0; i < _array.Length; i++)
{
    Console.Write(_array[i] + " ");
}

_next = false;
while (_next == false)
{
    Console.Write("\nВведите число: ");
    if (int.TryParse(Console.ReadLine(), out _userNumber))
    {
        if (Array.IndexOf(_array, _userNumber) == -1)
        {
            Console.Write("\nошибкa\n");
        }
        else
        {
            Console.Write(Array.IndexOf(_array, _userNumber));
            _next = true;
        }
    }
    else Console.WriteLine("\nВведено некорректное значение\n");
}

Console.ReadKey();