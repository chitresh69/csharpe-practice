public delegate void Adelegate(int x);

/*class Anonymous
{
    static void Main(string[] args)
    {
        Adelegate ad = delegate (int x)
        {

            x += 10;
            Console.WriteLine(x);
        };

        Console.WriteLine(ad);

        ad.Invoke(10);
    }
}*/

class Lambda
{
    static void Main(string[] args)
    {

        Adelegate a = (Num) =>
        {
            Num += 10;
            Console.WriteLine(Num);
};

        a.Invoke(121);
    }
}