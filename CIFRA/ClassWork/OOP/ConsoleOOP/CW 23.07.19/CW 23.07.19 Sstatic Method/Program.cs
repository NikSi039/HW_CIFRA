using CW_23._07._19_Sstatic_Method;

Console.Write("Введите количество точек: ");
int n = int.Parse(Console.ReadLine()!);

int i = 1;
while (i <= n)
{
    Console.Write("Введите координату x: ");
    double x = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите координату y: ");
    double y = double.Parse(Console.ReadLine()!);

    Point point = new Point { X = x, Y = y };
    Point.OurPoints.Add(point);
    Point.Count++;
    i++;
}
Console.WriteLine(Point.Count);

Console.ReadKey();