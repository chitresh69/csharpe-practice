/*class GenericMethods
{
    public static void ShowArray<C>(C[] aar)
    {
        for (int i = 0; i < aar.Length; i++)
        {
            Console.WriteLine(aar[i]);
        }
    }

    public virtual void Compare<C, D>(C numa, C numb, D name1, D name2)
    {
        if (Equals(numa, numb) && Equals(name1, name2))
        {
            Console.WriteLine("both values match from both pairs");
        }
        else if (Equals(numa, numb))
        {
            Console.WriteLine("only first values match from both pairs");
        }
        else if (Equals(name1, name2))
        {
            Console.WriteLine("only second values match from both pairs");
        }
        else
        {
            Console.WriteLine("no values match");
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[5];
        nums[0] = 1;
        nums[1] = 2;
        nums[2] = 3;
        nums[3] = 4;
        nums[4] = 5;

        string[] name = {"aaa", "bbb", "ccc" , "ddd", "eee" };

        GenericMethods.ShowArray(nums);

        GenericMethods.ShowArray(name);

        //GenericMethods.ShowArray(name);

        GenericMethods gm = new GenericMethods();

        gm.Compare<int, string>(5, 5, "Chitresh", "Chitresh");
        gm.Compare(10, 10, "Alice", "Bob");
        gm.Compare(5, 6, "Tom", "Tom");
        gm.Compare(3, 3, "A", "A");
        gm.Compare(1, 2, "X", "Y");


    }
}*/