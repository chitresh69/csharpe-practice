/*public partial class PartDemo
{
   public string a = "hello";
}

class Program
{
    //static void Main(string[] args)
    //{
    //    PartDemo P = new PartDemo();
    //    P.AgeAfter(18);
    //    Console.WriteLine(P.a);
    //    Console.WriteLine(P.weight);
    //}


}*/

partial class PartDemo : Parent, Iparent1, Iparent2
{
    static void MethodC()
    {
        Console.WriteLine("hello im c");
    }
}