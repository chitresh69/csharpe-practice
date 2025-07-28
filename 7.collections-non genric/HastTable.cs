using System;
using System.Collections;

class HTDemo
{
    static void Main(String[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add("first", 100);
        ht.Add("second", 200);
        ht.Add("third", 300);
        ht.Add("fourth", 400);
        ht.Add("fivth", 500);
        ht.Add("sixth", 600);
        ht.Add(6.5f, 500);
        ht.Add(7, 600);

        //Hashtable htnew = new Hashtable();   //not possible
        //htnew.Add(100);
        //htnew.Add(200);
        //htnew.Add("third");

        //Hashtable ht1 = new Hashtable();
        //ht1.Add("first", 100, "hello");


        Console.WriteLine(ht["fivth"]);

        //ht.Insert(2, 250);

        foreach (var h in ht)
            Console.WriteLine(h);

        foreach (object key in ht.Keys)
            Console.WriteLine(key);

        Console.WriteLine("third".GetHashCode());
        Console.WriteLine(500.GetHashCode());

        //foreach (object key in ht.Keys)
        //    Console.WriteLine(key + " - " + ht[key] + " - " + key.GetHashCode());

       /* PrintIndexAndKeysAndValues(ht);*/

        Console.WriteLine(ht.Count);
        Console.WriteLine();

    }

    /*public static void PrintIndexAndKeysAndValues(Hashtable myHT)
    {
        int i = 0;
        Console.WriteLine("\t-INDEX-\t-KEY-\t-VALUE-");
        foreach (DictionaryEntry de in myHT)
            Console.WriteLine($"\t[{i++}]:\t{de.Key}\t{de.Value}");
        Console.WriteLine();

    }*/

}