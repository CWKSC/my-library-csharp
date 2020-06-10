using MyLib_Csharp.CommonClass;
using System;
using System.Diagnostics.CodeAnalysis;
using static MyLib_Csharp.CommonClass.MyFunction;

namespace MyLib_Csharp
{
    class Program
    {

        public static void Main(string[] args)
        {
            //int[] A = { 1, 5, 9, 100, 101, 102, 103};
            //int[] B = { 2, 3, 4, 11, 54, 86};

            //A.Println().PrintIsSorted_ascending();
            //B.Println().PrintIsSorted_ascending();
            //MyAlgorithm.SortTwoSortedArray(A, B).Println().PrintIsSorted_ascending();
            MyAlgorithm.MySort.Test();

        }

    }

}
