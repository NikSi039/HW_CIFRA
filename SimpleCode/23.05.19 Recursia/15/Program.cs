int[] myArray = { 5, 3, 2 };
PrintArray(myArray);

Console.ReadKey();



static void PrintArray(int[] myArray, int i = 0)
{
    if (i < myArray.Length)
    {
        Console.WriteLine(myArray[i]);

        PrintArray(myArray, i + 1);
    }
}
