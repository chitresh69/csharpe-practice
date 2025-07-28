/*
public delegate void Addnum(int x, int y);

public delegate string Sayhello(string str);

class Program
{
    public void AddNums(int a, int b)
    {
        Console.WriteLine(a + b);
        Console.WriteLine(a + b + 1);
        Console.WriteLine(a + b + 2);
    }

    public static string SayHello(string name)
    {
        return "hello" + name;
    }

    static void Main(string[] args)
    {
        //Program p = new Program();
        //p.AddNums(15, 30);

        //string s = Program.SayHello("chitresh");
        //Console.WriteLine(s);

        Program p = new Program();
        Addnum ad = new Addnum(p.AddNums);

        ad(10, 25);

        Sayhello sh = new Sayhello(Program.SayHello);     //with classname
        Sayhello sh2 = new Sayhello(SayHello);           //without classname

        Console.WriteLine(sh("chitresh"));
        Console.WriteLine(sh2("chitu"));


        ad.Invoke(100, 250);
        Console.WriteLine(sh.Invoke("chitresh"));
        Console.WriteLine(sh2.Invoke("chitu"));
    }
}*/