using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 3, 4 };
            Console.WriteLine(Fold(arr, (a, b) => a + b));
            Console.WriteLine(Fold(arr, (a, b) => a * b));

            Console.WriteLine(Fold(arr, (a, b) => a + b, 0, 10));
            Console.WriteLine(Fold(arr, (a, b) => a * b, 0, 10));

            Console.WriteLine(Fold(arr, (a, b) => a + b.ToString(), 0, ""));
            Console.WriteLine();

            double[] arr2 = new double[] { 2.5, 2, 3, 4 };
            Console.WriteLine(Fold(arr2, (a, b) => a + b));
            Console.WriteLine(Fold(arr2, (a, b) => a * b));
                                      
            Console.WriteLine(Fold(arr2, (a, b) => a + b, 0, 10d));
            Console.WriteLine(Fold(arr2, (a, b) => a * b, 0, 10d));
                                      
            Console.WriteLine(Fold(arr2, (a, b) => a + b.ToString(), 0, ""));
            Console.WriteLine();

            decimal[] arr3 = new decimal[] { 2, 2.9m, 3.3m, 4 };
            Console.WriteLine(Fold(arr3, (a, b) => a + b));
            Console.WriteLine(Fold(arr3, (a, b) => a * b));
                                      
            Console.WriteLine(Fold(arr3, (a, b) => a + b, 0, 10m));
            Console.WriteLine(Fold(arr3, (a, b) => a * b, 0, 10m));
                                      
            Console.WriteLine(Fold(arr3, (a, b) => a + b.ToString(), 0, ""));
            Console.WriteLine();

            Console.ReadLine();
        }

        public static T Fold<T>(T[] arr, Func<T, T, T> func)
        {
            return Fold(arr, func, 1, arr[0]);
        }
        public static T2 Fold<T1, T2>(T1[] arr, Func<T2, T1, T2> func, int startPosition, T2 res)
        {
            for (int i = startPosition; i < arr.Length; i++)
                res = func(res, arr[i]);
            return res;
        }

    }
}
