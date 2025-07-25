//class TernaryParameter
//{
//    static void Main(string[] args)
//    {
//        int a = 5;
//        int b = -5;

//        string result = ((a + b) > a) ? "yes correct" : "try again";
//        Console.WriteLine(result);

//        float? c = null;

//        var output = (c.HasValue) ? "has value" : "null value";
//        Console.WriteLine(output);
//    }
//}

//using System.Data;

//class OptionalParameter
//{
//    static public void Data(string name, int age = 25, string school = "kps", string college = "sstc")
//    {
//        Console.WriteLine($"my name is {name} of age {age} and studied from {school} school and my college is {college}");
//    }
//    static void Main(string[] args)
//    {
//        Data("allu", 18, "dps", "iit");
//        Data("bina", 23, "st. joseph");
//        Data("chitu", 23);
//        Data("div", school : "cps"); //without parameter name we cannot skip the values;
//        Data("e", college: "nit");
//    }
//}
