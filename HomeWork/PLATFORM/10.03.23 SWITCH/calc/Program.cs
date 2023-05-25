float _number1;
float _number2;
float _result = 0;
int _operation;

Console.Write("Введите первое число: ");
_number1 = float.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
_number2 = float.Parse(Console.ReadLine());

Console.WriteLine("\nВыберете действие: \n\n1 - + \n2 - - \n3 - * \n4 - /");
_operation = int.Parse(Console.ReadLine());

switch (_operation)
{
    case 1:
        _result = _number1 + _number2;
        break;
    case 2:
        _result = _number1 - _number2;
        break;
    case 3:
        _result = _number1 * _number2;
        break;
    case 4:
        _result = _number1 / _number2;
        break;
    default:
        Console.WriteLine("Vibirete korrektnuu operaciu");
        break;
}

Console.WriteLine(_result);






Console.ReadKey();

