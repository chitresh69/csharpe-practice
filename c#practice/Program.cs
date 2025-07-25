//class Program
//{
//    static void Main()
//    { Console.WriteLine("c# is used for web apps, desktop apps, and game development!"); }
//}

//class Programs
//{
//    static void Main(string[] args)
//    {
//        int? numn = null;
//        if (numn.HasValue)
//            Console.WriteLine("yes");
//        else
//            Console.WriteLine("no");

//    }
//}

//class Programss
//{
//    static void Main(string[] args)
//    {
//        dynamic name = "chitu";
//        Console.WriteLine(name);
//        name = 19;
//        Console.WriteLine(name);
//    }
//}

//class Programsss
//{
//    static void Main(string[] args)
//    {
//        var name = "chitresh";
//        var age = 23;
//        Console.WriteLine(name + age);
//    }
//}

//class Programssss
//{
//    static void Main(string[] args)
//    {
//        int a = 12345;
//        double b = a; //Implicit conversion
//        Console.WriteLine(b);

//        float c = 123.45f;
//        int d = (int)c; //Explicit conversion
//        Console.WriteLine(d);

//        int num = Convert.ToInt32("12345");
//        Console.WriteLine(num);

//        int number = int.Parse("12345"); //numeric types only
//        Console.WriteLine(number);

//        object obj = "chitresh";
//        string name = obj as string;
//        Console.WriteLine(name);
//    }
//}

//using System.ComponentModel;

//class Programsssss
//{
//    static void Main(string[] args)
//    {
//        int day = 3;

//        switch (day)
//        {
//            case 1:
//                Console.WriteLine("MON");
//                break;
//            case 2:
//                Console.WriteLine("TUE");
//                break;
//            case 3:
//                Console.WriteLine("WED");
//                break;
//            case 4:
//                Console.WriteLine("THR");
//                break;
//            case 5:
//                Console.WriteLine("FRI");
//                break;
//            case 6:
//                Console.WriteLine("SAT");
//                break;
//            case 7:
//                Console.WriteLine("SUN");
//                break;
//            default:
//                Console.WriteLine("FUNDAY");
//                break;
//        }
//    }
//}

//class Programs
//{
//    static void StaticMethod(string name = "Random")
//    {
//        Console.WriteLine("hello, my name is " + name);
//    }
//    static void Main(string[] args)
//    {
//        void NormalMethod(int age)
//        {
//            Console.WriteLine("my current age is " +age);
//        }

//        Programs.StaticMethod("Chitresh");
//        NormalMethod(23);

//        Programs.StaticMethod(); //Optional parameter
//        NormalMethod(24);
//    }
//}

//using System.Runtime.CompilerServices;

//namespace Tools
//{
//    class Calculator
//    {

//            public int Addition(int a, int b) 
//            { 
//            return a + b;
//            }

//            public int Subtraction(int a, int b) 
//            {
//            return a - b;
//            }

//    }
//}

//class Program
//{
//    static int Square(int n)
//    {
//        return n * n;
//    }

//    String Name;
//    void SayHello(string msg)
//    {
//        Console.WriteLine(msg + Name);
//    }

//    static void Main(string[] args)
//    {
//        int result = Program.Square(Square(5));

//        Program p = new Program();
//        p.Name = "Chitu";
//        p.SayHello("Hello ");

//        Console.WriteLine(result);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int Sum(params int[] nums)
//        {
//            int total = 0;
//            foreach (int n in nums) { 
//            total += n;}
//            return total;
//        }

//        int result = Sum(1, 2, 3, 4, 5);

//        Console.WriteLine(result);
//    }
//}

//class Demo
//{
//    static void Main(string[] args)
//    {
//        dynamic num = 7;
//        num = "sikha";
//        num = 7;
//        Console.WriteLine(num);

//        string name = "chitresh";
//        name = "sikha";
//        Console.WriteLine(name);
//    }
//}