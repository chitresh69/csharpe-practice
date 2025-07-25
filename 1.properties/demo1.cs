/*public partial class PartDemo
{
    public void AgeAfter(int Age)
    {
        Console.WriteLine("my age after 20 years will be " + (Age + 20));
    }

    static void Main(string[] args)
    {
        int b = 100;
        Console.WriteLine(b);

        PartDemo part = new PartDemo();
        part.AgeAfter(100);

    }
}
*/

partial class PartDemo 
{
    static void MethodA()
    {
        Console.WriteLine("hello im a");
    }
}