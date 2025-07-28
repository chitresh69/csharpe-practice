/*public record FirstRec
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


class Result
{
    static void Main(string[] args)
    {
        FirstRec f1 = new FirstRec()
        {
            FirstName = "chitresh",
            LastName = "sahu"
        };
        Console.WriteLine(f1);

    }
}*/

public record FirstRec
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class FirstCls
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


class Result
{
    static void Main(string[] args)
    {
        FirstRec f1 = new FirstRec()
        {
            FirstName = "chitresh",
            LastName = "sahu"
        };
        Console.WriteLine(f1);

        FirstRec f2 = new FirstRec();
        f2.FirstName = "chotu";
        f2.LastName = f1.LastName;

        Console.WriteLine(f1);

        FirstCls fc1 = new FirstCls()
        {
            FirstName = "chitresh"
        };

        Console.WriteLine(fc1.FirstName);

        //FirstCls fc2 = fc1 with { FirstName = "chotu"};
        //Console.WriteLine(fc2.FirstName);
    }
}