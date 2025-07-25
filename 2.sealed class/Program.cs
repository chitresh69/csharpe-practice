/*class Sealedclass1
{
    public void methodA()
    {
        Console.WriteLine("the 1first method ");
    }

    public virtual void methodB()
    {
        Console.WriteLine("the 1second method ");
    }

    public virtual void methodC()
    {
        Console.WriteLine("the 1third mwethod ");
    }

    public virtual void methodD()
    {
        Console.WriteLine("the 1fourth method ");
    }
}

class SealedClass2 : Sealedclass1
{
    public new void methodA()
    {
        Console.WriteLine("the 2first method ");
    }

    public override void methodB()
    {
        Console.WriteLine("the 2second method ");
    }

    public override void methodC()
    {
        Console.WriteLine("the 2third mwethod ");
    }

    sealed public override void methodD()
    {
        Console.WriteLine("the 2fourth method ");
    }
}

class SealedClass3 : SealedClass2
{
    public new void methodA()
    {
        Console.WriteLine("the 3first method ");
    }

    public override void methodB()
    {
        Console.WriteLine("the 3second method ");
    }

    public override void methodC()
    {
        Console.WriteLine("the 3third mwethod ");
    }

    //public override void methodD()
    //{
    //    Console.WriteLine("the fourth mwethod ");
    //}

}

class Program
{
    static void Main(string[] args)
    {
        Sealedclass1 sc1 = new Sealedclass1();
        sc1.methodA();
        sc1.methodB();
        sc1.methodC();
        sc1.methodD();

        SealedClass2 sc2 = new SealedClass2();
        sc2.methodA();
        sc2.methodB();
        sc2.methodC();
        sc2.methodD();

        SealedClass3 sc3 = new SealedClass3();
        sc3.methodA();
        sc3.methodB();
        sc3.methodC();
        sc3.methodD();
    }
}*/