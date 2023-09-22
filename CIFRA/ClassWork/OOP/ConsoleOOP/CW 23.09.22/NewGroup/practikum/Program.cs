






abstract class Figure
{
    private string name;

    public Figure(string name)
    {
        this.name = name;
    }


    public string Name {get;set;}

    public abstract double Area2 { get; set; }

    public abstract double Area();

    public virtual void Print()
    {
        Console.WriteLine(Name);
    }
}


class Triangle : Figure
{
    private double a, b, c;

    public Triangle
}