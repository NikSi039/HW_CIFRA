//11.19.Определить:

//а) сумму всех элементов массива;
//б) произведение всех элементов массива;
//в) сумму квадратов всех элементов массива;
//г) сумму шести первых элементов массива;
//д) сумму элементов массива с k1-го по k2-й
//(значения k1 и k2 вводятся с клавиатуры; k2 > k1);
//е) среднее арифметическое всех элементов массива;
//ж) среднее арифметическое элементов массива с s1-го по s2-й
//(значения s1 и s2 вводятся с клавиатуры; s2 > s1).

using System.Linq;
int n = 0;
n = InputNumber(n, "количество элементов массива");

int[] array = new int[n];
Random random = new();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine(array.Sum());
Console.WriteLine(array.Aggregate((x, y) => x * y));
Console.WriteLine(array.Select(i => i * i).Sum());
Console.WriteLine(array.Take(6).Sum());

int k1 = 0;
k1 = InputNumber(k1, "номер первого элемента массива");
int k2 = 0;
k2 = InputNumber(k2, "номер второго элемента массива");
Console.WriteLine(array.Where((s, i) => i >= k1 && i <= k2).Sum());

Console.WriteLine(array.Average());

int s1 = 0;
k1 = InputNumber(s1, "номер первого элемента массива");
int s2 = 0;
k2 = InputNumber(s2, "номер второго элемента массива");
Console.WriteLine(array.Where((s, i) => i >= s1 && i <= s2).Average());

Console.ReadKey();

int InputNumber(int number, string massage)
{
    Console.Write($"Введите {massage}: ");
    if (int.TryParse(Console.ReadLine(), out number)) ;
    else Console.WriteLine("Введено некорректное значение");
    return number;
}