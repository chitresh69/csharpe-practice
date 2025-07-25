using System;
using System.Runtime.InteropServices;

//class ArrayPractice
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 1, 3, 5, 6, 7, 23, 54, 2, 98, 764, 0, 4 };

//        Console.WriteLine("LENGTH = " + numbers.Length);

//        Array.Sort(numbers);
//        Console.WriteLine("SORTED = " + string.Join(", ", numbers));

//        Array.Reverse(numbers);
//        Console.WriteLine("REVERSED = " + string.Join(", ", numbers));

//        Console.WriteLine("INDEX OF 54 = " + Array.IndexOf(numbers, 54));

//        int[] copy = new int[4];
//        Array.Copy(numbers, copy, 4);
//        Console.WriteLine("COPIED = " + string.Join(", ", copy));

//        if (Array.Exists(numbers, n => n > 25))
//            Console.WriteLine("EXISTS: Number > 25 found");

//        Console.WriteLine("FIND > 25 = " + Array.Find(numbers, x => x > 25));

//        Array.Clear(numbers, 0, 2);
//        Console.WriteLine("AFTER CLEAR = " + string.Join(", ", numbers));
//    }


//class OopsPillar1
//{
//    private string name;
//    private int age;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { 
//        if(value >= 0) age = value;
//        }
//    }
//    static void Main(string[] args)
//    {
//        OopsPillar1 O1 = new OopsPillar1();
//        O1.name = "Chitresh";
//        O1.age = 23;

//        Console.WriteLine("Name is " + O1.name + " and my age is " + O1.age);

//    }
//}

//class BaseClass
//{
//    public string brand = "Tata";

//    public void Horn()
//    {
//        System.Console.WriteLine("peep peep");
//    }
//}

//class ChildClass : BaseClass
//{
//    public string modalName = "Avania";
//}

//class ResultClass
//{
//    static void Main(string[] args)
//    {
//        ChildClass c1=new ChildClass();
//        c1.Horn();

//        Console.WriteLine("My car name is " + c1.modalName + " which is from the brand " + c1.brand);
            
//    }
//}


//class Animal
//{
//    public void AnimalSound()
//    {
//        Console.WriteLine("animal makes a sound");
//    }
//}

//class Dog : Animal
//{
//    public void AnimalSound()
//    {
//        Console.WriteLine("dog barks");
//    }
//}
 
//class Cat : Animal
//{
//    public void AnimalSound()
//    {
//        Console.WriteLine("cat meow");
//    }
//}


//class Sound
//{
//    static void Main(string[] args)
//    {
//        Dog d = new Dog();
//        d.AnimalSound();

//        Cat c = new Cat();
//        c.AnimalSound();
//    }
//}

//class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public double Add(double a, double b)
//    {
//        return a + b;
//    }

//    public string Add(string a, string b)
//    {
//        return a + b;
//    }

//    public void Add(String a)
//    {
//        Console.WriteLine("This is the example of method " + a);
//    }

//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        calculator.Add("overloading");
//        Console.WriteLine(calculator.Add(5, 10));
//        Console.WriteLine(calculator.Add(1.3579, 2.4680));
//        Console.WriteLine(calculator.Add("Chitresh", "Sahu"));
//    }
//}

//abstract class Animal
//{
//    public abstract void MakeSound();

//    public void EatingFood()
//    {
//        Console.WriteLine("eating.....");
//    }

//}

//class Lion : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("roaring");
//    }
//}

//class Elephant : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("groles");
//    }
//}

//class Result
//{
//    static void Main(string[] args)
//    {
//        Animal mySher = new Lion();
//        mySher.MakeSound();
//        mySher.EatingFood();
//        Animal myHati = new Elephant();
//        myHati.MakeSound();

//        Lion l = new Lion();
//        l.MakeSound();
//        l.EatingFood();

//        Elephant e = new Elephant();
//        e.MakeSound();
//        e.EatingFood();
//    }
//}

//interface IShape
//{
//    double GetArea();
//}

//class Circle : IShape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public double GetArea()
//    {
//        return Math.PI * Radius * Radius;
//    }

//    static void Main(string[] args)
//    {
//        IShape shape = new Circle(5.0);
//        Console.WriteLine("Area of Circle is : " + shape.GetArea());
//    }
//}