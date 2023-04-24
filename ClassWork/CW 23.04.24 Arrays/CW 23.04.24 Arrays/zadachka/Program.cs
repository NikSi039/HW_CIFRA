// See https://aka.ms/new-console-template for more information

//11.162.Данные о росте 15 юношей класса, упорядоченные по убыванию, записаны в массиве.
//В начале учебного года в класс поступил новый ученик.
//Получить аналогичный массив, учитывающий рост нового ученика.

//Рассмотреть два возможных случая:
//1) известен порядковый номер нового ученика;
//2) известен рост нового ученика


int[] hight = new int[15];

Random random = new Random();   

for (int i = 0; i < 15; i++)
{
    hight[i] = random.Next(160,201);
}

Array.Sort(hight);
Array.Reverse(hight);

foreach (int item in hight)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n");


// зная рост ученика

Console.Write("Введите роcт нового ученика: ");

int n = int.Parse(Console.ReadLine());

int[] newHights = new int[16];

Array.Copy(hight, 0, newHights, 0, 15);
Array.Fill(newHights, n, 15, 1);
Array.Sort(newHights);
Array.Reverse(newHights);

Console.WriteLine("\n");

foreach (int item in newHights)
{
    Console.Write(item + " ");
}


// зная индекс ученика






Console.ReadKey();