using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FoldSomething(new int[] { 2, 2, 3, 4 }, 10);
            FoldSomething(new double[] { 2.5, 2, 3, 4 }, 10);
            FoldSomething(new decimal[] { 2, 2.9m, 3.3m, 4 }, 10);

            Console.ReadLine();
        }

        private static void FoldSomething<T>(T[] arr, T startNumber)
        {
            Console.WriteLine(Fold(arr, (a, b) => AddValues(a, b)));
            Console.WriteLine(Fold(arr, (a, b) => MultiplyValues(a, b)));
            Console.WriteLine(Fold(arr, (a, b) => AddValues(a, b), 0, startNumber));
            Console.WriteLine(Fold(arr, (a, b) => MultiplyValues(a, b), 0, startNumber));

            Console.WriteLine(Fold(arr, (a, b) => a + b.ToString(), 0, ""));
            Console.WriteLine();
        }

        public static T Fold<T>(T[] arr, Func<T, T, T> func)
        {
            return Fold(arr, func, 1, arr[0]);
        }
        public static T2 Fold<T1, T2>(T1[] arr, Func<T2, T1, T2> func, int startPosition, T2 result)
        {
            for (int i = startPosition; i < arr.Length; i++)
                result = func(result, arr[i]);
            return result;
        }

        public static T1 AddValues<T1, T2>(T1 x, T2 y)
        {
            dynamic tx = x;
            dynamic ty = y;
            return tx + ty;
        }
        public static T1 MultiplyValues<T1, T2>(T1 x, T2 y)
        {
            dynamic tx = x;
            dynamic ty = y;
            return tx * ty;
        }

    }
}
