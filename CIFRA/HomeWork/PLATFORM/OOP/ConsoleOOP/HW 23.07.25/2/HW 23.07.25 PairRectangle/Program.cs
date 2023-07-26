//Создать класс Pair (пара чисел);

//определить методы изменения полей и вычисления произведения чисел.

//Определить производный класс Rectangle (прямоугольник) с полями-сторонами.

//Определить методы вычисления периметра и площади прямоугольника.

using HW_23._07._25_PairRectangle;

Pair pair = new Pair(10, 15);
Console.WriteLine(pair.Multiplication());

pair.ChangeNumbers(10, 10);
Console.WriteLine(pair.Multiplication());

Rectangle rectangle = new Rectangle(50, 40);
Console.WriteLine(rectangle.Area());
Console.WriteLine(rectangle.Perimetr());

Console.ReadKey();