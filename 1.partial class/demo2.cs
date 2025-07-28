/*public partial class PartDemo
{
    public int weight = 70;

    //static void Main(string[] args)
    //{
    //    int b = 100;
    //    Console.WriteLine(b);

    //    PartDemo part = new PartDemo();
    //    part.AgeAfter(100);

    //}


}*/

partial class PartDemo
{
    public void MethodB()
    {
        Console.WriteLine("hello im b");
    }

    public void MethodI1()
    {
        Console.WriteLine("im method i 2");
    }

   /* static void Main(string[] args) {
        Console.WriteLine("hello");
        PartDemo.MethodA();
        PartDemo.MethodB();
        PartDemo.MethodC();

        PartDemo partDemo = new PartDemo(); 
        partDemo.MethodP();

        

        //PartDemo.MethodI1();
    }*/
}