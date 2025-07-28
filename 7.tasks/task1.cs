/*static partial class PartialClass
{
    public static partial void MethodA()
    {
        Console.WriteLine("hello im methodA of partial class");
    }
}*/

/*class Task
{
    public virtual void MethodA()
    {
        Console.WriteLine("method A invoked");
    }

    public virtual void MethodB()
    {
        Console.WriteLine("method B invoked");
    }

    public void MethodC()
    {
        Console.WriteLine("method C invoked");
    }

    protected virtual void MethodD()
    {
        Console.WriteLine("method D invoked");
    }
}

class Derived : Task
{
    public override void MethodA()
    {
        Console.WriteLine("method A2 invoked");
    }

    public void MethodB() //hides method
    {
        Console.WriteLine("method B2 invoked");
    }

    //public override void MethodC()  //hides method
    //{
    //    Console.WriteLine("method C2 invoked");
    //}

     public void MethodDNEW()
    {
        Console.WriteLine("method D NEW invoked");
        //MethodD();
    }

    //protected virtual void MethodD()
    //{
    //    Console.WriteLine("method D invoked");
    //}
}


class Test
{
    public virtual void MethodA()
    {
        Console.WriteLine("method A3 invoked");
    }

    //protected virtual void MethodB()
    //{
    //    Console.WriteLine("method B3 invoked");
    //}

    internal void MethodC()
    {
        Console.WriteLine("method C3 invoked");
    }
}
class MainClass : Task
{
    static void Main(string[] args)
    {
        Task t = new Task();
        t.MethodA();
        t.MethodB();
        t.MethodC();
        //t.MethodDNEW(); can't be call in this class
 
        Derived d = new Derived();
        d.MethodA();
        d.MethodB();
        d.MethodC();

        Test test = new Test();
        test.MethodA();
        //test.MethodB();
        test.MethodC();

        MainClass mc = new MainClass();
        mc.MethodD();
    }
}*/