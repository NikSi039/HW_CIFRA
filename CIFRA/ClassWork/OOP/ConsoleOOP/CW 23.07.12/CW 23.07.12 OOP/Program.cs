using CW_23._07._12_OOP;

Rectangle rect = new Rectangle();

Console.Write("Введите ширину прямоугольника: ");
rect.setWidth(double.Parse(Console.ReadLine()!));

Console.Write("Введите высоту прямоугольника: ");
rect.setHeight(double.Parse(Console.ReadLine()!));

Console.WriteLine();
Console.WriteLine($"Ширина:{rect.getWidth()} Высота:{rect.getHeight()} " +
    $"Площадь прямоугольника: {rect.getArea():F2}");
Console.WriteLine($"Периметр прямоугольника: {rect.getPerimetr():F2}");

Console.ReadKey();