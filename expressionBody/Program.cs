namespace expressionBody;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Example E = new Example("wengel");
        E.PrintNameAndAge();

        E.Age = 28;
        E.PrintNameAndAge();
    }
}

class Example
{
    string _name;
    int _age;

    public Example(string name) => _name = name;

    public string Name => _name;

    public int Age 
    {
        get => _age;
        set => _age = value;
    }

    public void PrintNameAndAge() => Console.WriteLine($"{Name} is {Age} years old.");
    
}