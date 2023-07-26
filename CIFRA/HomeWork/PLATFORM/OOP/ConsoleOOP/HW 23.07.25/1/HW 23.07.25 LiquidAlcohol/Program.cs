//Создать класс Liquid (жидкость), имеющий поля названия и плотности.

//Определить методы переназначения и изменения плотности.

//Создать производный класс Alcohol (спирт), имеющий крепость.

//Определить методы переназначения и изменения крепости.

using HW_23._07._25_LiquidAlcohol;

Liquid liquid = new Liquid("Water", 997);
liquid.PrintLiquidData();

Alcohol alcohol = new Alcohol("Whiskey", 953, 50);
alcohol.PrintLiquidData();

Console.ReadKey();