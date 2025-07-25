class Base
{
    public Base()
    {
       
            Console.WriteLine("im constructor");
       
    }

    public Base(string Name)
    {

        Console.WriteLine("im constructor of " + Name);

    }
}

class Demo
{
    static void Main(String[] args)
    {
        Console.WriteLine();
        Base b = new Base();

        var Base = new Base("chotu");
    }
}