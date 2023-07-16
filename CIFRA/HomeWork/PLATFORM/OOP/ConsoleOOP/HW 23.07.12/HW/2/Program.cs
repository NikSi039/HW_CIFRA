using _2;

TriangleClass triangle = new TriangleClass();

bool _next = false;
double a, b, c;

while (_next == false)
{
    triangle.SetSideA(GetLenght("первой"));
    triangle.SetSideB(GetLenght("второй"));
    triangle.SetSideC(GetLenght("третей"));

    a = triangle.GetSideA();
    b = triangle.GetSideB();
    c = triangle.GetSideC();

    if (a + b > c && a + c > b && b + c > a) _next = true;
    else Console.WriteLine("\nТреугольник с такими длинами сторон " +
        "не может существовать\n");
}

Console.WriteLine($"\nПериметр треугольника равен: {triangle.GetPerimetr()}");
Console.WriteLine($"\nПлощадь треугольника равна: {triangle.GetArea()}");

Console.ReadKey();


///END


double GetLenght(string message)
{
    bool next = false;
    double lenght = 0;

    while (next == false)
    {
        Console.Write($"Введите длину {message} стороны треугольника: ");

        if (double.TryParse(Console.ReadLine()!.Replace(",", "."), out lenght))
        {
            if (lenght > 0) next = true;
            else Console.WriteLine("Длина должна быть больше ноля\n");
        }
        else Console.WriteLine("Введено некорректное значение\n");
    }
    return lenght;
}