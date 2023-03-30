internal class Program
{
    private static void Main(string[] args)
    {
        new ConstructorTest();
        Console.WriteLine("Hello, World!");
    }
}

public class ConstructorTest
{
    public int i = 1;

    public ConstructorTest()
    {
        Console.WriteLine($"i is {i}");
    }
}

// use the debugger to walk through how a constructor works
// it is a method called when a new instance of a class is created
// always will have same name as class and no return