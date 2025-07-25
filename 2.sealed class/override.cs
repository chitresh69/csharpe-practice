/*class Base
{
    public virtual void M1()
    {
        Console.WriteLine("hey1");
    }

    public void M2()
    {
        Console.WriteLine("hello1");
    }

    public virtual void M3()
    {
        Console.WriteLine("hI1");
    }
}

class Derive : Base
{
    public override void M1()
    {
        Console.WriteLine("hello2");
    }

    //public override void M2()         //CANNOT OVERRIDE INHERITED METHOD 
    //{
    //    Console.WriteLine("hello2");
    //}

    public void M3()
    {
        Console.WriteLine("hI2");
    }
}

class Result
{
    static void Main(string[] args)
    {
        Base b = new Base();
        b.M1();
        b.M2();
        b.M3();

        Derive d = new Derive();
        d.M1();
        d.M2();                                //BASE METHOD WILL BE CALLED
        d.M3();
    }
}*/