double yearSalary = 260548.56895;
Console.WriteLine(yearSalary);

double monthSalary = yearSalary / 12;
Console.WriteLine($"\n{monthSalary:F5}");

double tax = monthSalary * 13 / 100;

double netMonthSalary = monthSalary - tax;
Console.WriteLine($"\n{netMonthSalary:F5}");

Console.ReadKey();
