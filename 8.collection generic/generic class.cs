/*class Example<T>
{
    int box;

    //public Example(int b)
    //{
    //    this.box = b;
    //}

    //public int getBox()
    //{
    //    return this.box;
    //}

    T box1;

    public Example(T b)
    {
        this.box1 = b;
    }

    public T GetBox()
    {
        return this.box1;
    }

    T _anyType;

    public T AnyType
    {
        set { this._anyType = value; }
        get { return this._anyType; }
    }

}


class Program
{
    static void Main(string[] args)
    {
        //Example e = new Example(100);
        //Console.WriteLine(e.getBox());

        //Example e1 = new Example("chitresh");
        //Console.WriteLine(e.getBox());
        //Console.WriteLine();

        Example<string> e = new Example<string>("chitresh");
        Console.WriteLine(e.GetBox());

        Example<int> e1 = new Example<int>(100);
        Console.WriteLine(e1.GetBox());


        e.AnyType = "chitresh property";
        e.AnyType = "123456";


    }
}
*/