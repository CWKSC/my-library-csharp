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
            List<int> b = new List<int>() { 2, 4, 9 };
            SortTwoSortedList(a, b).Println();
        }

    }
}
