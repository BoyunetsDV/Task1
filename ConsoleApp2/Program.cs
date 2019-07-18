using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(Fold(arr, (a, b) => a + b));
            Console.WriteLine(Fold(arr, (a, b) => a * b));

            Console.WriteLine(Fold(arr, (a, b) => a + b, 10));
            Console.WriteLine(Fold(arr, (a, b) => a * b, 10));

            Console.WriteLine(Fold(arr, (a, b) => a + b.ToString(),""));

            Console.ReadLine();
        }

        public static T Fold<T>(T[] arr, Func<T, T, T> func)
        {
            return Fold<T, T>(arr, func, arr[0]);
        }
        public static T2 Fold<T1,T2>(T1[] arr, Func<T2, T1, T2> func, T2 res)
        {
            for (int i = 0; i < arr.Length; i++)
                res = func(res, arr[i]);
            return res;
        }

    }
}
