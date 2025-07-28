using System.Collections;
using System.Security.Cryptography;

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

        ArrayList al3 = new ArrayList();

        Hashtable ht1 = new Hashtable();
        ht1.Add(101, "Chitresh");
        ht1.Add(102, "sahu");
        ht1.Add(103, 23);
        ht1.Add(104, "b.tech");
        ht1.Add(105, "raipur");

        Hashtable ht2 = new Hashtable();
        ht2.Add(101, "Ravi");
        ht2.Add(102, "kumar");
        ht2.Add(103, 30);
        ht2.Add(104, "b.com");
        ht2.Add(105, "dehli");

        Hashtable ht3 = new Hashtable();
        ht3.Add(101, "aditya");
        ht3.Add(102, "patel");
        ht3.Add(103, 25);
        ht3.Add(104, "b.sc");
        ht3.Add(105, "pune");

        al3.Add(ht1);
        al3.Add(ht2);
        al3.Add(ht3);

        foreach (Hashtable ht in al3)
        {
            Console.Write(101 + " ");
            Console.Write(102 + " ");
            Console.Write(103 + " ");
            Console.Write(104 + " ");
            Console.WriteLine(105 + " ");
        }

        Console.WriteLine(al3);
        Console.WriteLine("----------------------------------------------------------------- ");

        Hashtable hash = new Hashtable();

        ArrayList names = new ArrayList();
        names.Add("chitresh");
        names.Add("ravi");
        names.Add("aditya");
        names.Add("divya");
        names.Add("yash");

        ArrayList age = new ArrayList();
        age.Add(23);
        age.Add(20);
        age.Add(30);
        age.Add(22);
        age.Add(24);

        ArrayList city = new ArrayList();
        city.Add("raipur");
        city.Add("dehli");
        city.Add("mumbai");
        city.Add("pune");
        city.Add("bhilai");

        hash["Names"] = names;
        hash["ages"] = age;
        hash["cities"] = city;

        Console.WriteLine("Names :");

        foreach (string name in (ArrayList)hash["Names"])
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Ages :");

        foreach (int ag in (ArrayList)hash["ages"])
        {
            Console.WriteLine(ag);
        }

        Console.WriteLine("Cities :");

        foreach (string cit in (ArrayList)hash["cities"])
        {
            Console.WriteLine(cit);
        }
    }
}