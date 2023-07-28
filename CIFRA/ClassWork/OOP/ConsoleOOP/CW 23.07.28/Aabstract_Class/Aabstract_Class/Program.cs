using Aabstract_Class;

Triangle figure = new Triangle("Треугольник",3,4,5);
Console.WriteLine(figure.Area2);
Console.WriteLine(figure.Print());

TriangleColor figureColor = new TriangleColor("Треугольник", 9, 7, 13, "Красный");
Console.WriteLine(figureColor.Area2);
Console.WriteLine(figureColor.Print());

//Console.WriteLine((figureColor as TriangleColor).Area2);

if (figureColor is TriangleColor)
{
    Console.WriteLine((figureColor as TriangleColor).Area2);
}