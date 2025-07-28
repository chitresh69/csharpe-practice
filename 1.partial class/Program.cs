using System.Globalization;

/*struct Hello1 //error
{
    private int _num = 10;
    public string Num { get; set; }

}

class Hello2
{static void Main(string[] args)
    {
        
        Console.WriteLine(hello.Num);
    }

}*/

/*struct Hello1
{
    private int _num = 10;
    public string Num { get; set; }

}

struct Hello2
{
    static void Main(string[] args)
    {
        Hello1 hello;
        Console.WriteLine(hello.Num);
    }

}*/

/*struct Hello1
{
    private int _num = 10;
    public int Num { get; set; }

    public Hello1() { }
    public int Num2 { get; set; }
    public int Num3 { get; set; }
    public int Num4 { get; set; }
    public int Num5 { get; set; }

}

class Hello2
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(hello.Num + hello.Num2 + hello.Num3 + hello.Num4 + hello.Num5);
    }

}*/

/*class EnumDemo
{
    enum Status
    {
        Ordered = 25,
        Dispatched,
        Shipped,
        delivery,
        cancelled
    }
    static void Main(string[] args)
    {
        //Status status = EnumDemo.Status.Ordered;
        //Console.WriteLine(status);

        foreach (Status state in Enum.GetValues(typeof(Status)))
        {
            Console.WriteLine((int)state + " is for " + state);
        }
    }
}*/