using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Algorithm
{
    public static partial class Sort
    {

        public static void Test()
        {
            List<int> a = new List<int>(){ 1, 3, 7 };
            List<int> b = new List<int>() { 2, 4, 9, 15 };
            SortTwoSortedList(a, b).Println();

            int[] arr1 = new[] { 1, 3, 7, 8, 9 };
            int[] arr2 = new[] { 2, 3, 8, 11, 14 };
            int[] arr3 = new[] { 20, 30, 40 };
            int[] arr4 = new[] { 10, 25, 37, 42 };
            SortNSortedArray(arr1, arr2, arr3, arr4).Println();
        }

    }
}
