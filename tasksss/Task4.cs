using System.Collections;

class Collections
{
    static void Main(string[] args)
    {
        ArrayList al = new ArrayList();
        al.Add("aditya");
        al.Add("c");
        al.Add("chitu");
        al.Add("chitresh");
        al.Add("divya");
        al.Add("yana");

        ArrayList al2 = new ArrayList();
        al2.Add("aditya");
        al2.Add("chitu");
        al2.Add("chitresh");
        al2.Add("divya");
        al2.Add("yana");

        Console.WriteLine(al.Count);
        Console.WriteLine(al.ToString());
        //al.Clear();
        foreach (object obj in al)
        {
            Console.WriteLine(obj);
        }

        foreach (object obj in al)
        {
            if (obj.Equals("chitu")) Console.WriteLine(obj);
        }

        //Console.WriteLine(al2.Contains("c"));
        Console.WriteLine(al.Contains("c"));


    }
}