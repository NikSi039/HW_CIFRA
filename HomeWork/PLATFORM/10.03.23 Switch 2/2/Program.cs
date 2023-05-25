Console.Write("1 - Chanel\n2 - Dior\n3 - Tom Ford\n4 - Gucci\n5 - Yves Saint Laurent");

Console.Write("\n\n\nВыберите аромат: ");
byte choose;

if (byte.TryParse(Console.ReadLine(), out choose))
{
    switch (choose)
    {
        case 1: Console.WriteLine("\nSuper"); break;
        case 2: Console.WriteLine("\nFantastic"); break;
        case 3: Console.WriteLine("\nMood"); break;
        case 4: Console.WriteLine("\nUnbelivable"); break;
        case 5: Console.WriteLine("\nGood"); break;
        default: Console.WriteLine("\nВведено некорректное значение"); break;
    }
}
else
{
    Console.WriteLine("\nВведено некорректное значение");
}

Console.ReadKey();