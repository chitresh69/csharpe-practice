//class Prop
//{
//    private string name = "hello";

//    public string Name
//    {
//        get { return name; }
//    }
//}

//class Access
//{
//    static void Main(string[] args)
//    {
//        Prop p1 = new Prop();
//        Console.WriteLine(p1.Name); // readonly
//    }
//}

//class Prop
//{
//    private string name = "hello";

//    public string Name
//    {
//        set { name = value; }
//    }
//}

//class Access
//{
//    static void Main(string[] args)
//    {
//        Prop p1 = new Prop();
//        p1.Name = "hey"; // writeonly
//    }
//}

//class Prop
//{
//    private string name = "hello";

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//}

/*class Access
{
    static void Main(string[] args)
    {
        Prop p1 = new Prop();
        Console.WriteLine(p1.Name); // readandwrite
        p1.Name = "hey";
        Console.WriteLine(p1.Name);
    }
}*/

//class Prop
//{
//    public string name{  get; set; } // automatic
//}

//class Access
//{
//    static void Main(string[] args)
//    {
//        Prop p = new Prop();
//        p.name = "test";
//        Console.WriteLine(p.name);
//    }
//}

/*class Prop
{
    private int _marks;

    public int Marks
    {
        get { return _marks; }
        set
        {
            if ((value < 0) || (value <= 100))
            {
                _marks = value;
            }
            else
            {
                throw new Exception("not a valid marks");
            }
        }

    }
}*/

//class Result
//{
//    static void Main(string[] args)
//    {
//        Prop p =new Prop();
//        p.Marks = 100;
//        Console.WriteLine(p.Marks);

//        p.Marks = 105;
//        Console.WriteLine(p.Marks); // throws error dur to logic
//    }
//}

//class Prop
//{
//    private string firstName = "chitresh";
//    private string lastName = "sahu";
//    public string FullName => firstName + " " + lastName; // singleliner
//}
//class Ans
//{
//    static void Main(string[] args)
//    {
//        Prop p =new Prop();
//        Console.WriteLine(p.FullName); 
//    }
//}

//class Prop
//{
//    private static int _code = 26480;

//    public static int Code
//    {
//        get { return _code; }
//        set { _code = value; }
//    }
//}

//class CallStatic
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(Prop.Code);
//    }
//}