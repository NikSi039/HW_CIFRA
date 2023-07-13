double _number1;
double _number2;
double _result = 0;
byte _operation;
string _exit;
bool _needExit = false;

while (_needExit == false)
{
    _number1 = InputNumber("первое");

    _number2 = InputNumber("второе");

    _operation = SelectOperation();

    GetResult();

    PrintResult();

    NeedExit();

    Console.Clear();
}

// END

double InputNumber(string massage)
{
    bool next = false;
    double number = 0;

    while (next == false)
    {
        Console.Write($"Введите {massage} число: ");
        if (double.TryParse(Console.ReadLine().Replace(",", "."), out number)) next = true;//При ошибке, поменять местами точку с запятой
        else Console.WriteLine("Введено некорректное значение\n");
    }
    return number;
}

byte SelectOperation()
{
    bool next = false;
    byte operation = 0;

    while (next == false)
    {
        Console.WriteLine("\n\n1 - \"+\" \n2 - \"-\" \n3 - \"*\" \n4 - \"/\"\n");
        Console.Write("\nВыберете действие: ");
        if (byte.TryParse(Console.ReadLine(), out operation)) ;
        if (operation >= 1 && operation <= 4) next = true;
        else Console.WriteLine("Введено некорректное значение\n");
    }
    return operation;
}

double GetResult()
{
    switch (_operation)
    {
        case 1: _result = _number1 + _number2; break;
        case 2: _result = _number1 - _number2; break;
        case 3: _result = _number1 * _number2; break;
        case 4: _result = _number1 / _number2; break;
        default: Console.WriteLine("Выберете корректное значение"); break;
    }
    return _result;
}

void PrintResult()
{
    Console.WriteLine($"\nРезультат: {_result}");
}

void NeedExit()
{
    Console.WriteLine("\n\n\n\n\nДля выхода нажмите EXIT");
    Console.Write("\nХотите продолжить?: ");
    _exit = Console.ReadLine().Trim().ToLower();

    if (_exit == "exit")
    {
        _needExit = true;
    }
}