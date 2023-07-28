using Aabstract_Class;

Triangle figure = new Triangle("Треугольник",3,4,5);
Console.WriteLine(figure.Area2);
Console.WriteLine(figure);

TriangleColor figureColor = new TriangleColor("Треугольник", 9, 7, 13, "Красный");
Console.WriteLine(figureColor.Area2);
Console.WriteLine(figureColor);

//Console.WriteLine((figureColor as TriangleColor).Area2);

if (figureColor is TriangleColor)
{
    Console.WriteLine((figureColor as TriangleColor).Area2);
}



//Встроенные методы

int a = 6;
Console.WriteLine(a.ToString());
Console.WriteLine(a.Equals(8));
Console.WriteLine(a.GetType());
Console.WriteLine(a.GetHashCode());


