/*class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Task : Student
{
    static void Main(string[] args)
    {
        Student s1 = new Student()
        { Id = 103,Name = "Chitresh",Age = 23 };

        Student s2 = new Student()
        { Id = 105, Name = "Eshan", Age = 20 };

        Student s3 = new Student()
        { Id = 102, Name = "Bina" , Age = 22};

        Student s4 = new Student()
        { Id = 101, Name = "Aditya" , Age = 25};

        Student s5 = new Student()
        { Id = 104, Name = "Dev", Age = 21 };

        List<Student> students = new List<Student>() 
        { s1, s2, s3, s4, s5 };

        int index = 0;

        foreach (Student student in students)
        {
            //Console.WriteLine(student.Id +" - " +);
            Console.WriteLine($"Index {index} having Name {student.Name}");
            index++;
        }

        Console.WriteLine("---------------------------");

        SortedList<char, string> sl = new SortedList<char, string>();
        
        sl.Add('a', "apple");
        sl.Add('c', "cheese");
        sl.Add('b', "bun");
        sl.Add('A', "Almond");
        sl.Add('C', "Cerry");
        sl.Add('B', "Berry");
        

        foreach (KeyValuePair<char, string> food in sl)
        {
            Console.WriteLine($"Key: {food.Key}, Value: {food.Value}");
        }

        Console.WriteLine("---------------------------");

        List<char> li = new List<char>();

        List<string> names = new List<string>();
        names.Add("Chitresh Sahu");
        names.Add("Vikesh Kumar Gupta");

        foreach(string name in names)
        {
            Console.WriteLine(name);

            foreach(char ch in name)
            {
                Console.WriteLine(ch + " having ascii value : " +(int)ch);
            }
        }
    }
}*/