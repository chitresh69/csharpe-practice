/*public delegate void RectDelegate(int x, int y);

class Rectangle
{
    public void GetArea(int width, int length)
    {
        Console.WriteLine("area of rectangle is : " + width * length);
    }

    public void GetPerimeter(int width, int length)
    {
        Console.WriteLine("perimeter of rectangle is : " + 2 * (width + length));
    }

    public void GetADD(int a, int b)
    {
        Console.WriteLine("addition of numbers is : " + (a + b));
    }
    public void GetSUB(int a, int b)
    {
        Console.WriteLine("subtraction of numbers : " + (a - b));
    }

    public void GetMULTI(int a, int b)
    {
        Console.WriteLine("multiple of numbers : " + a * b);
    }

    public void GetDIV(int a, int b)
    {
        Console.WriteLine("division of numbers : " + a / b);
    }

    static void Main(string[] args)
    {
        Rectangle r = new Rectangle();

        //RectDelegate obj = new RectDelegate(r.GetArea);
        //obj(10, 20);
        //obj.Invoke(10, 20);

        RectDelegate obj = r.GetArea;
        obj += r.GetPerimeter;

        RectDelegate obj1 = r.GetADD;
        obj1 += r.GetSUB;
        obj1 += r.GetMULTI;
        obj1 += r.GetDIV;

        obj.Invoke(10, 20);
        obj1.Invoke(100, 20);

        //RectDelegate obj = r.GetArea;
        //obj += r.GetPerimeter;


        //the method should be non value returing and non output parameter for multicast delegates
    }
}*/