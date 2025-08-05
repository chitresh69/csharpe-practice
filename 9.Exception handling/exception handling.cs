using System.Buffers.Text;
using System.Data;

class ExcepHandling
{

    public static void Main()
    {

        int x = 0;
        int div = 0;

        try
        {
            div = 100 / x;
            Console.WriteLine("This line will not execute");
            //throw new DivideByZeroException("Invalid Division");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Exception occured");
            Console.WriteLine(ex.InnerException);
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Source: " + ex.Source);
            Console.WriteLine("helplink: " + ex.HelpLink);
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
            Console.WriteLine("Data: " + ex.Data);

            Console.WriteLine(ex.ToString());
            Exception root = ex.GetBaseException();
            Console.WriteLine("Root Cause: " + root.Message);
            Console.WriteLine("Hash Code: " + ex.GetHashCode());
            Exception baseEx = ex.GetBaseException();
            Console.WriteLine("Base Exception: " + baseEx.Message);
            Console.WriteLine("Type: " + ex.GetType());
            Console.WriteLine(ex.ToString());
            //throw;
        }

        finally
        {
            Console.WriteLine("Finally Block");
        }
        Console.WriteLine($"Result is {div}");


        //int Number1, Number2, Result;



        //try
        //{
        //    Console.WriteLine("Enter First Number");
        //    Number1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter Second Number");
        //    Number2 = int.Parse(Console.ReadLine());
        //    Result = Number1 / Number2;
        //    Console.WriteLine($"Result: {Result}");
        //}

        //catch (DivideByZeroException forzero)
        //{
        //    Console.WriteLine("Second Number Should Not Be Zero");
        //}

        //catch (FormatException forformat)
        //{
        //    Console.WriteLine("Enter Only Integer Numbers");
        //}

        //catch (Exception ex)
        //{
        //    Console.WriteLine("Generic Catch Block...");
        //}


        //try
        //{
        //    SomeMethod();
        //}


        //catch (Exception)
        //{
        //    Console.WriteLine("Exception Caught");
        //}

        //Console.ReadKey();

        //int Number1, Number2, Result;

        //try
        //{
        //    Console.WriteLine("Enter First Number:");
        //    Number1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter Second Number:");
        //    Number2 = int.Parse(Console.ReadLine());
        //    if (Number2 % 2 == 1)
        //    {
        //        throw new OddNumException();
        //    }
        //    Result = Number1 / Number2;
        //    Console.WriteLine(Result);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Message: {ex.Message}");
        //    Console.WriteLine($"HelpLink: {ex.HelpLink}");
        //    Console.WriteLine($"Source: {ex.Source}");
        //    Console.WriteLine($"StackTrace: {ex.StackTrace}");
        //    Console.WriteLine($"inner exception : {ex.InnerException}");



        //    Exception root = ex.GetBaseException();
        //    Console.WriteLine("Root Cause: " + root.Message);
        //    Console.WriteLine("Hash Code: " + ex.GetHashCode());
        //    Console.WriteLine("Summary : " + ex.ToString());
        //}

        //Console.WriteLine("End of the Program");
        //Console.ReadKey();

    }

    static void SomeMethod()
    {
        try
        {
            Console.WriteLine("Inside SomeMethod");
            int num1 = 10, num2 = 0;
            int result = num1 / num2; //Exception will be thrown here
            Console.WriteLine($"Result: {result}");
        }
        finally
        {
            Console.WriteLine("SomeMethod finally Block");
        }
    }

}