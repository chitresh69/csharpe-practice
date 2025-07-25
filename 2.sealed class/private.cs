using System.Runtime.Intrinsics.Arm;

class Demo1
{
    public void MethodA()
    {
        Console.WriteLine("method of demo1");
    }

    private class DemoPvt{
        //protected void MethodB()
        //{
        //    Console.WriteLine("method of pvt class ");
        //}

        internal void MethodB1()
        {
            Console.WriteLine("method of pvt class ");
        }

        public void MethodB2()
        {
            Console.WriteLine("method of pvt class ");
        }

        //static void MethodB3()
        //{
        //    Console.WriteLine("method of pvt class ");
        //}
    }

    public class DemoPub
    {
        static void Main(string[] args)
        {
            //DemoPvt dp = new DemoPvt();
            //DemoPvt.MethodB();

            DemoPvt dp = new DemoPvt();
            dp.MethodB1();
            dp.MethodB2();

            //DemoPvt.MethodB3();

        }

    }
}