//using System;

//public class Task2
//{
//    public (int max, int min) MethodA(int[] arr)
//    {
//        int max = arr[0];
//        int min = arr[0];

//        foreach (int num in arr)
//        {
//            if (num < min)
//            {
//                min = num;
//            }
//            else if (num > max)
//            {
//                max = num;
//            }
//        }

//        return (max, min);
//    }

//    public static void Main(string[] args)
//    {
//        Task2 t = new Task2();
//        int[] arr = { 10, 12, 8, 20, 14, 6, 16, 18 };
//        var result = t.MethodA(arr);

//        Console.WriteLine("Max: " + result.max);
//        Console.WriteLine("Min: " + result.min);
//    }
//}