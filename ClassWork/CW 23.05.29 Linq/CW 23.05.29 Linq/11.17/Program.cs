//11.17.Дан массив.Все его элементы:

//а) увеличить в 2 раза;
//б) уменьшить на число А;
//в) разделить на первый элемент.


Console.Write("Введите количество элементов массива: ");
if (int.TryParse(Console.ReadLine(), out int n)) ;
else Console.WriteLine("Введено некорректное значение");

int[] array = new int[n];
Random random = new();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int[] arrayA = array.Select(i => i * 2).ToArray();
foreach (int item in arrayA) Console.Write(item + " ");
Console.WriteLine();

Console.Write("Введите число: ");
if (int.TryParse(Console.ReadLine(), out int A)) ;
else Console.WriteLine("Введено некорректное значение");
int[] arrayB = array.Select(i => i - A).ToArray();
foreach (int item in arrayB) Console.Write(item + " ");
Console.WriteLine();

int[] arrayC = array.Select(i => i / array[0]).ToArray();
foreach (int item in arrayC) Console.Write(item + " ");
Console.WriteLine();

Console.ReadKey();
