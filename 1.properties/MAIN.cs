/*class Main1
{
    static void Main(string[] args)
    {
        //PartInt partInt = new PartInt();

        //PartStr partStr = new PartStr();

        //partStr.MethodA();



    }
}*/

class Parent
{
    public void MethodP()
    {
        Console.WriteLine("im parent class");
    }
}

interface Iparent1
{
    public void MethodI1()
    {
        Console.WriteLine("im parent interface");
    }
}

interface Iparent2
{
    public void MethodI2()
    {
        
    }
}

class Main1 : PartDemo
{
    static void Main(string[] args)
    {
        PartDemo P = new PartDemo();
        P.MethodP();
        P.MethodI1();
        P.MethodB();
    }
}