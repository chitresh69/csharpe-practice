class Program
{
    static readonly object lock1 = new object();
    static readonly object lock2 = new object();

    static void MethodA()
    {
        lock (lock1)
        {
            Console.WriteLine("Thread 1 using lock 1");
            Thread.Sleep(100);
            lock (lock2)
            {
                Console.WriteLine("Thread 1 using lock 2");
            }
        }
    }

    static void MethodB()
    {
        lock (lock2)
        {
            Console.WriteLine("Thread 2 using lock 2");
            Thread.Sleep(100);
            lock (lock1)
            {
                Console.WriteLine("Thread 2 using lock 1");
            }
        }
    }


    static void Main(string[] args)
    {
        Thread t1 = new Thread(MethodA);
        Thread t2 = new Thread(MethodB);

        t1.Start();
        t2.Start();

        t1.join();

    }
}