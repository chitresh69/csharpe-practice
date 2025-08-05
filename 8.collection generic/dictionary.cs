using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

class Dictionary
{
    static void Main(string[] args)
    {

        Dictionary<int, string> di = new Dictionary<int, string>();
        di.Add(1, "allu");
        di.Add(2, "bhalu");
        di.Add(3, "chitu");
        di.Add(4, "div");
        di.Add(5, "A");
        int currentCapacity = di.EnsureCapacity(1);
        Console.WriteLine(currentCapacity);

        Console.WriteLine(di.Count);

        Console.WriteLine();

        Console.WriteLine(di.Comparer);


        if (di.ContainsKey(4)) { Console.WriteLine("trueeeee"); }


        Console.WriteLine(di.ContainsKey(5));

        Console.WriteLine(di.ContainsValue("chitu"));


        SortedList<int, string> sl = new SortedList<int, string> 
        {
        { 1, "One"},
        { 3, "Three"},
        { 2, "Two"}
        };


    }
}