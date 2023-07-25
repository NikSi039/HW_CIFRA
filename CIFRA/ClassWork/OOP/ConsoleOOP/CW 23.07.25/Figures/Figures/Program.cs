using Figures;

Figure f = new Figure("Figure");
f.Display();

Rectangle r = new Rectangle("Rectangle", 2, 2, 8, 8);
r.Display();
Console.WriteLine();
Console.WriteLine(r.Area());

RectangleColor rc = new RectangleColor("RectangleColor", 2, 2, 10, 10, 1);
rc.Display();
