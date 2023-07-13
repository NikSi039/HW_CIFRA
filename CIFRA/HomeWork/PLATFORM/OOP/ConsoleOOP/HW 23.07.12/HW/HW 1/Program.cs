using HW_1;

UserTime userTime = new UserTime();

Console.Write("Введите часы: ");
userTime.setHours(insertNumber());

Console.Write("Введите минуты: ");
userTime.setMinutes(insertNumber());

Console.Write("Введите секунды: ");
userTime.setSeconds(insertNumber());

Console.WriteLine();
userTime.printTime();

Console.ReadKey();


//END


int insertNumber()
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        return number;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
        return 0;
    }
}