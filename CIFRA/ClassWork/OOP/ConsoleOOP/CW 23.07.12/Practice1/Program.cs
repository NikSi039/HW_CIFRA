using Practice1;

Practice1Class pract = new Practice1Class();

Console.Write("Введите первое число: ");
pract.setValue1(int.Parse(Console.ReadLine()!));

Console.Write("Введите второе число: ");
pract.setValue2(int.Parse(Console.ReadLine()!));

Console.WriteLine($"Величина 1: {pract.getValue1()}");
Console.WriteLine($"Величина 2: {pract.getValue2()}");

Console.WriteLine($"Сумма: {pract.Sum()}");
Console.WriteLine($"Максимум: {pract.Max()}");

Console.ReadKey();