using System;


namespace MyLib_Csharp.CommonClass
{
    public partial class MyAlgorithm
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static bool IsSorted<T>(this T[] array, Func<T, T, bool> compare) where T : IComparable
        {
            for (int i = 0; i != array.Length - 1; ++i) 
                if (compare(array[i], array[i + 1])) 
                    return false;
            return true;
        }

        public static bool IsSorted_ascending<T>(this T[] array) where T : IComparable =>
            array.IsSorted((pre, next) => pre.CompareTo(next) > 0);

        public static bool IsSorted_descending<T>(this T[] array) where T : IComparable =>
            array.IsSorted((pre, next) => pre.CompareTo(next) < 0);

        public static void PrintIsSorted_ascending<T>(this T[] array) where T : IComparable =>
            (IsSorted_ascending(array) ? "Sorted (descending)" : "Unsorted (descending)").Println();

        public static void PrintIsSorted_descending<T>(this T[] array) where T : IComparable =>
            (IsSorted_descending(array) ? "Sorted (descending)" : "Unsorted (descending)").Println();

    }

}
