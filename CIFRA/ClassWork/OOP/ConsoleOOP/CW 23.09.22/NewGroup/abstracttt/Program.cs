Client client = new Client("Alice", 500);
Employee employee = new Employee("Bob", "Manager");

client.Display();
employee.Display();

abstract class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine(Name);
    }
}

class Client : Person
{
    public int Sum { get; set; }
    public Client(string name, int sum) : base(name)
    {
        Sum = sum;
    }
}

class Employee : Person
{
    public string Position { get; set; }
    public Employee (string name,string position) : base (name)
    {
        Position = position;
    }
}