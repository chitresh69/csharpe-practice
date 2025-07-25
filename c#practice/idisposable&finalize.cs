//class MyResource : IDisposable
//{
//    public void UseResource()
//    {
//        Console.WriteLine("Using resource...");
//    }

//    public void Dispose()
//    {
//        Console.WriteLine("Cleaning up using Dispose.");
//        // Free any unmanaged resources here
//        GC.SuppressFinalize(this); // Optional if Finalize is defined
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        using (MyResource res = new MyResource())
//        {
//            res.UseResource();
//        } // Dispose is called automatically here

//        Console.WriteLine("Resource cleaned up using 'using' block.");
//    }
//}

//using System;

//class MyResource
//{
//    public void UseResource()
//    {
//        Console.WriteLine("Using resource...");
//    }

//    // Finalizer
//    ~MyResource()
//    {
//        Console.WriteLine("Cleaning up using Finalize (Destructor).");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MyResource res = new MyResource();
//        res.UseResource();

//        res = null;
//        GC.Collect();       // Force garbage collection
//        GC.WaitForPendingFinalizers(); // Wait for finalizer to run

//        Console.WriteLine("Finalization done.");
//    }
//}

