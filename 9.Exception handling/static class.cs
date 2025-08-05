/*static class StatClass
{
    public static void Test3(this Program p, int i)
    {
        Console.WriteLine("Method3 : " + i);
    }

    public static long Factorial(this Int32 x)
    {
        if (x == 1)
            return 1;

        if (x == 2)
            return 2;

        else
            return x * Factorial(x - 1);
    }

    public static string ToPerfect(this String OldStr) 
    {
        if (OldStr.Trim().Length > 0)
        {
            String NewStr = null;
            OldStr = OldStr.ToLower();
            string[] sarr = OldStr.Split(' ');
            foreach (string s in sarr) 
            {
                char[] carr = s.ToCharArray();
                carr[0] = Char.ToUpper(carr[0]);
                if(NewStr == null)
                    NewStr = new string(carr);
                else
                    NewStr = " " + new string(carr);
            }
            return NewStr;
        }
        return OldStr;
    }
}*/