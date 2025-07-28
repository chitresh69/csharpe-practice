class Sealed
{
    private Sealed() {}
    public static void DoWork() {
        Console.WriteLine("hello");
    }
}

class Access
{
    static void DoWork() {
        Sealed.DoWork();
    }
}