/*using System.Reflection.Metadata;

class Tuples
{

    public (string Name, bool isValid) MethodA(string name) //tuple return type
    {
        if (name.Equals("Chitresh"))
        {
            Console.WriteLine("Authentic user");
            return ("hello Chitresh", true);
        }
        else {
            return (name, false);
        }
    }

    public (string Name, int age, double height) MethodB()  //tuple unpacking
    { 
        return ("chitu", 23, 5.7);
    }

    public void MethodC((string Name, int Age) person)
    {
        Console.WriteLine($"name is {person.Name} and age is {person.Age}");
    }


    static void Main(string[] args)
    {
        Tuples t = new Tuples();

        var Student = ("aditya", 23, 5.7);
        Console.WriteLine(Student.Item1);
        Console.WriteLine(Student.Item2);
        Console.WriteLine(Student.Item3);

        (string, int, double) Student1 = ("bina", 17, 5.6);
        Console.WriteLine(Student1.Item1);
        Console.WriteLine(Student1.Item2);
        Console.WriteLine(Student1.Item3);

        (String Name, int Age, double Height) Student2 = ("div", 22, 5.2);
        Console.WriteLine(Student2.Name);
        Console.WriteLine(Student2.Age);
        Console.WriteLine(Student2.Height);

        Student2.Age = 30;
        Console.WriteLine("new age is : " + Student2.Age);


        //var person1 = t.MethodA("Chitresh");
        var person1 = t.MethodA("chitresh");

        if (person1.isValid)
        {
            Console.WriteLine("Message - " + person1.Name);
        }
        else
        {
            Console.WriteLine(person1.Name + " is not a valid user");
        }

        (string mname, int mage, double mheight) = t.MethodB(); //tuple unpacking
        Console.WriteLine(mname + " " + mage + " " + mheight);

        (string nname, _, _) = t.MethodB();
        Console.WriteLine(nname);

        var myPerson = ("divya", 23);
        t.MethodC(myPerson);

        var old = Tuple.Create("yash", 1 , 2.3, 4.5f, 'C');
        Console.WriteLine(old);

        var New = (Name: "sanjay", Age: 30);
        Console.WriteLine(New.Name); // Clear and readable


        var myData = (101, 23, "chitresh",(1,2,3,4,5), 5.7, 66.55);
        Console.WriteLine(myData.Item4.Item2);
        Console.WriteLine(myData.Item6);
    } 
} */