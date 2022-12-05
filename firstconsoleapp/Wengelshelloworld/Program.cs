namespace Wengelshelloworld;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Wengel!");
        int x = Func(5);
        Console.WriteLine(x);
    }

    static int Func(int num)
    {
        return ++num;   
    }
}
