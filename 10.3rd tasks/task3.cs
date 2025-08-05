using System.Diagnostics;

class TaskClass
{
    public void MethodSum()
    {
        int a = 5, b = 6;
        for(int i = 0; i < 100000000; i++)
        {

        }
        Console.WriteLine(a + b);
    }

    public void MethodExit()
    {
        Console.WriteLine("method is completed after calculation only");
    }

    public void MethodNew()
    {
        Console.WriteLine("called by b");
    }

    public void MethodPool(object state)
    {
        Console.WriteLine("Hello from the thread pool.");
    }

    public void MethodPool2(object state)
    {
        Thread t = Thread.CurrentThread;

        Console.WriteLine($"Backgroung thread - {t.IsBackground}, Thread pool - {t.IsThreadPoolThread}, Thread ID - {t.ManagedThreadId}");
    }

    public void MethodLast()
    {
        Thread t = Thread.CurrentThread;

        Console.WriteLine("last method starts ---");
        Console.WriteLine($"Backgroung thread - {t.IsBackground}, Thread pool - {t.IsThreadPoolThread}, Thread ID - {t.ManagedThreadId}");
        Console.WriteLine("last method ends ---");

    }

    static void Main(string[] args)
    {
        TaskClass t = new TaskClass();

        var b = new Thread(t.MethodNew);


        Thread t1 = new Thread(t.MethodSum);
        Thread t2 = new Thread(t.MethodExit);
        t1.Start();
        b.Start();
        t1.Join();
        t2.Start();

        //t2.Abort();

        //var b = new Thread();


        ThreadPool.QueueUserWorkItem(t.MethodPool);

        Thread t3 = new Thread(t.MethodLast);
        t3.Start();
        Console.WriteLine("-------------------");
        t3.Join();


        Stopwatch sw = Stopwatch.StartNew();    
        sw.Start();
        for (int i = 0; i < 10; i++)
        {
            ThreadPool.QueueUserWorkItem(t.MethodPool2);
            
        }
        sw.Stop();
        string sw1 = sw.ElapsedTicks.ToString();


        sw.Reset();
        sw.Start();
        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(t.MethodLast);
            thread.Start();
        }
        sw.Stop();
        string sw2 = sw.ElapsedTicks.ToString();


        Console.WriteLine("Time consumed by MethodWithThreadPool is : " + sw1);
        Console.WriteLine("Time consumed by MethodWithThreadPool is : " + sw2);
        Console.WriteLine($"ThreadPool.ThreadCount: {ThreadPool.ThreadCount}");
        Console.WriteLine($"ThreadPool.CompletedWorkItemCount: {ThreadPool.CompletedWorkItemCount}");
        Console.WriteLine($"ThreadPool.PendingWorkItemCount: {ThreadPool.PendingWorkItemCount}");


        var cts = new CancellationTokenSource();
        Thread worker = new Thread(() => DoWork(cts.Token));
        worker.Start();

        Console.WriteLine("Press any key to cancel...");
        Console.ReadKey();

        cts.Cancel(); // Signal cancellation
        worker.Join(); // Wait for thread to finish

        Console.WriteLine("Thread terminated gracefully.");
    }

    static void DoWork(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            Console.WriteLine("Working...");
            Thread.Sleep(500); // Simulate work
        }

        Console.WriteLine("Cleaned up and exiting thread.");
    }
}
