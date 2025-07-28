/*using System;
using System.Collections;

class Refe
{
    public static void MethodA()
    {
        Console.WriteLine("im method A");
    }
}
class ALDemo
{
    static void Main(String[] args)
    {
        ArrayList al = new ArrayList(5);
        al.Add(100);
        al.Add("hello");
        al.Add(300);
        al.Add(Refe.MethodA);

        Console.WriteLine(al.Capacity);

        al.Insert(2, 250);

        foreach (var obj in al)
        {
            Console.WriteLine(obj);
        }

        al.Remove(200);
        al.RemoveAt(2);

        foreach (object obj in al)
        {
            Console.WriteLine(obj);
        }
    }
}*/