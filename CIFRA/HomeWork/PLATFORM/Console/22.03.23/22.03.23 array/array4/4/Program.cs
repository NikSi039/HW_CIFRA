double[] array1 = new double[5];
double[] array2 = new double[5];
double[] array3 = new double[5];
double[] array4 = new double[5];

Random random = new();
double[] srArArray1i2 = new double[5];
double[] srArArray3i4 = new double[5];

double[] prArray = new double[5];

for (int i = 0; i < 5; i++)
{
    array1[i] = random.Next(10, 100);
    array2[i] = random.Next(10, 100);
    array3[i] = random.Next(10, 100);
    array4[i] = random.Next(10, 100);
}

Console.Write("array1\t\t = ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{array1[i]}\t");
}

Console.Write("\narray2\t\t = ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{array2[i]}\t");
}

Console.Write("\n\nsrArArray1i2\t = ");
for (int i = 0; i < 5; i++)
{
    srArArray1i2[i] = (array1[i] + array2[i]) / 2;
    Console.Write($"{srArArray1i2[i]}\t");
}

Console.Write("\n\n\narray3\t\t = ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{array3[i]}\t");
}

Console.Write("\narray4\t\t = ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{array4[i]}\t");
}

Console.Write("\n\nsrArArray3i4\t = ");
for (int i = 0; i < 5; i++)
{
    srArArray3i4[i] = (array3[i] + array4[i]) / 2;
    Console.Write($"{srArArray3i4[i]}\t");
}

Console.Write("\n\n\n\n\nsrArArray1i2\t = ");
for (int i = 0; i < 5; i++)
{
    srArArray1i2[i] = (array1[i] + array2[i]) / 2;
    Console.Write($"{srArArray1i2[i]}\t");
}

Console.Write("\nsrArArray3i4\t = ");
for (int i = 0; i < 5; i++)
{
    srArArray3i4[i] = (array3[i] + array4[i]) / 2;
    Console.Write($"{srArArray3i4[i]}\t");
}

Console.Write("\n\nprArray\t\t = ");
for (int i = 0; i < 5; i++)
{
    prArray[i] = srArArray1i2[i] * srArArray3i4[i];
    Console.Write($"{prArray[i]}\t");
}

Console.ReadKey();