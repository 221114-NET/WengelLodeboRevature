namespace hello_world;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(func(6));
        
    }

    static int func(int x )
    {
       return  ++x;
    }


}


