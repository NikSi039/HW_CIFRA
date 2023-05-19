int[] myArray = { 5, 3, 2 };

int result = Sum(myArray);

Console.WriteLine(result);

Console.ReadKey();



static int Sum(int[] myArray, int i = 0)
{
    if (i >= myArray.Length)
    {
        return 0;
    }

    return myArray[i] + Sum(myArray, i + 1);
}
