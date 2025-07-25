/*public delegate void CallBack(string result);

public class Worker
{
    public void DoWork(CallBack callback)
    {
        Console.WriteLine("Work started...");
        Thread.Sleep(1000);


        
        callback("Work completed!");
    }
    public static void ShowResult(string message)
    {
        Console.WriteLine("Callback: " + message);
    }

    //public static void ShowResult1(string message)
    //{
    //    Console.WriteLine("Callback: " + message);
    //}

    public static void Main()
    {
        Worker w = new Worker();

        
        w.DoWork(ShowResult);
    }
}
*/

/*using System.Reflection;

public delegate string CallBack(string a);

public delegate string CallBack1(int a, int b);

public class Worker
{
    public static string DoWork( string str, CallBack cb)
    {
        Console.WriteLine("Work started...");
        Thread.Sleep(1000);

        return cb(str);
    }
    public static string ShowResult(string message)
    {
        return "Callback: " + message;
    }

   // public static int MethodA(int a, int b, CallBack1 MethodB)
   // {
   //     int x = a;
   //     int y = b;

   //     Console.WriteLine("A = " + x);
   //     Console.WriteLine("B = " + y);

   //     x = x + y;
   //     y = y + y;

   //     Console.WriteLine("A = " + x);
   //     Console.WriteLine("B = " + y);

   //     return MethodB(x, y);

   // }

   //public static void MethodB(int x, int y)
   // {
   //     return x * y;
   // }

    public static void Main()
    {
        string answer = Worker.DoWork("work done", ShowResult);
        Console.WriteLine(answer);
    }
}

*/


/*public delegate string CallBack(string name);

class MainClass
{
    public static void Method1(string name, CallBack callback)
    {
        Console.WriteLine("hello im method one");

        string Result = callback(name);

        Console.WriteLine(Result);
    }

    public string Method2(string name)
    {
        return "my name is " + name;
    } 
    static void Main(string[] args)
    {
        MainClass m = new MainClass();

        MainClass.Method1("chitresh sahu" , m.Method2);
    }
}*/