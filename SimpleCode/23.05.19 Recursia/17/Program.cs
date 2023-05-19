int myValue = 561;

int result = Foo(myValue);

Console.WriteLine(result);

Console.ReadKey();



static int Foo(int value)
{
    if (value < 10)
    {
        return value;
    }

    return value % 10 + Foo(value / 10);
}

