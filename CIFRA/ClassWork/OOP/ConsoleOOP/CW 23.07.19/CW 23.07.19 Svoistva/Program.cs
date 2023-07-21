using CW_23._07._19_Svoistva;

AutoMobile auto = new AutoMobile("Mercedes", 50, 12);

Console.WriteLine($"Автомобиль: {auto.Name} поехал");

int km = 0;
while (auto.Fuel > 0)
{
    auto.Go(km);
    if (auto.Fuel <= 0) break;
    Console.WriteLine($"Осталось топлива: {auto.Fuel:F1} литров");
    Console.WriteLine($"Запас топлива на {auto.Total():F2} км");
    km += 10;
}

Console.ReadKey();