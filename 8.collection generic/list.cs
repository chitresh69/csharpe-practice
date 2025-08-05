/*using System.ComponentModel.Design;

class List
{
    static void Main(string[] args)
    {
        List<string> li = new List<string>();
        li.Add("a");
        li.Add("b");
        li.Add("c");
        li.Add("d");
        li.Add("e");
        li.Add("f");
        li.Add("g");
        li.Add("h");
        li.Add("i");

        List<string> lis = new List<string>();
        lis.Add("a");
        lis.Add("c");
        lis.Add("e");
        lis.Add("g");

        Console.WriteLine(li.Capacity);

        li.Capacity = 20;
        Console.WriteLine(li.Capacity);

        Console.WriteLine(li.Contains("a")); ;

        Console.WriteLine(li.Count);

        li.AddRange(lis);

        //foreach (string s in li)
        //{
        //    Console.Write(s);
        //}

        Console.WriteLine();

        li.Insert(0, "z");

        //foreach (string s in li)
        //{
        //    Console.Write(s);
        //}

        li.InsertRange(1, lis);

        //foreach (string s in li)
        //{
        //    Console.Write(s);
        //}

        li.Remove("a");
        li.RemoveAt(0);

        //foreach (string s in li)
        //{
        //    Console.Write(s);
        //}

        //if (li.Exists(s => s == "h")
        //    {
        //    Console.WriteLine("yes it has");
        //}
        //else { Console.WriteLine("no, dont have it");
        //} }

        li.RemoveAll(s => s == "g"); //lambda condition

        //foreach (string s in li)
        //{
        //    Console.Write(s);
        //}

        li.RemoveRange(0, 2);

        li.Reverse();

        foreach (string s in li)
        {
            Console.Write(s);
        }

        Console.WriteLine();

        Console.WriteLine(li.IndexOf("h"));

        Console.WriteLine(li.LastIndexOf("c"));

        li.Sort();
        foreach (string s in li)
        {
            Console.Write(s);
        }

        Console.WriteLine(li.Find(li => li == "c"));

        Console.WriteLine(li.FindLastIndex(li => li == "c"));


        Console.WriteLine(li.FindAll(li => li == "c"));

        Console.WriteLine(li.FindIndex(li => li == "c"));

        string[] arr = li.ToArray();
        foreach (string s in arr)
        {
            Console.WriteLine(s);
        }

        List<string> list = li.ToList();
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }

    }
}*/