/*class Single
{
    public void MethodA()
    {
        Console.WriteLine("Method A execution starts");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Running For Loop of Method A - " +i);
        }
    }

    public void MethodB()
    {
        Console.WriteLine("Method B execution starts");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Running For Loop of Method B - " + i);
            if (i == 5)
            {
                Console.WriteLine("Method B rest phase starts -----");
                Thread.Sleep(5000);
                Console.WriteLine("Method B rest phase ends -------");
            }
        }
    }

    public void MethodC()
    {
        Console.WriteLine("Method C execution starts");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Running For Loop of Method C - " + i);
        }
    }
    static void Main(string[] args)
    {
        Single s = new Single();    
        s.MethodA();
        s.MethodB();
        s.MethodC();
    }
}*/