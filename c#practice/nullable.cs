//class NullableDemo
//{
//    static void Main(String[] args)
//    {
//        string ? a = null;
//        int ? b = null;
//        float ? c = null;
//        double ? d = null;
//        Nullable<int> n = null;
//        Console.WriteLine(a + b + c + d + n);
//    }
//}

//class NullPrint
//{
//    static void Main(string[] args)
//    {
//        int? a = null;
//        Console.WriteLine(a.GetValueOrDefault());

//        int? b = 123;
//        Console.WriteLine(b.GetValueOrDefault());

//        Nullable<float> c = null;
//        Console.WriteLine(c.GetValueOrDefault());
//    }
//}

//class NullDemo
//{
//    static void Main(string[] args)
//    {
//        Nullable<int> num = null;
//        Console.WriteLine(num.HasValue);

//        //Nullable<string> e = null; -- throws error

//        string? e = "hello"; // C# 8.0+ with nullable reference types enabled
//        string f = null; // Works, but a compiler warning if nullable reference types are enabled
//        Console.WriteLine(e);
//        Console.WriteLine(f);
//        Console.WriteLine(num.HasValue);
//    }
//}

