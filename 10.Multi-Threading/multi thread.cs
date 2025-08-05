/*class Single
{
    public void MethodA()
    {
        Console.WriteLine("Method A execution starts");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Running For Loop of Method A - " + i +" " +Thread.CurrentThread.Name);
        }
        Console.WriteLine("Method A execution ends");
    }

    public void MethodB()
    {
        Console.WriteLine("Method B execution starts");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Running For Loop of Method B - " + i +" " +Thread.CurrentThread.Name);
            if (i == 5)
            {
                Console.WriteLine("Method B rest phase starts -----");
                Thread.Sleep(5000);
                Console.WriteLine("Method B rest phase ends -------");
            }
        }
        Console.WriteLine("Method B execution ends");
    }

    public void MethodC()
    {
        Console.WriteLine("Method C execution starts");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Running For Loop of Method C - " + i + " " +Thread.CurrentThread.Name);
        }
        Console.WriteLine("Method C execution ends");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("----- Main Thread is started ------");

        Single s = new Single();

        Thread t1 = new Thread(s.MethodA)
        {
            Name = "thread one"
        };

        Thread t2 = new Thread(s.MethodB)
        {
            Name = "thread two"
        };

        Thread t3 = new Thread(s.MethodC)
        {
            Name = "thread three"
        };

        t1.Start();
        t2.Start();
        t3.Start();

        Console.WriteLine("----- Main Thread is exited ------");


        //s.MethodA();
        //s.MethodB();
        //s.MethodC();
    }
}*/