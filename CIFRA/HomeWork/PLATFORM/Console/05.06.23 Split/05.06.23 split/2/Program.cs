Console.Write("Напишите предложение: ");
string sentence = Console.ReadLine()!;

string[] array = sentence.Split(' ', ',');

Console.WriteLine(array.Length);

Console.ReadKey();