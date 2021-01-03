using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class TestExecutionTime
    {
        public static void Test()
        {
            int[] list0 = GenerateRandIntArray(10000, 0, 10);
            List<int> list1 = GenerateRandIntArray(10000, 0, 10).ToList();
            List<int> list2 = GenerateRandIntArray(10000, 0, 10).ToList();
            List<int> list3 = GenerateRandIntArray(10000, 0, 10).ToList();
            int[] list4 = GenerateRandIntArray(10000, 0, 10);
            int[] list5 = GenerateRandIntArray(10000, 0, 10);

            Run(() =>
            {
                Array.Sort(list0);
            }, "Array Sort");

            Run(() =>
            {
                list1.Sort();
            }, "List Sort");

            Run(() =>
            {
                QuickSort(list2);
            }, "QuickSort");

            Run(() =>
            {
                list3.MySort();
            }, "MySort");

            Run(() =>
            {
                list4.SelectionSort();
            }, "SelectionSort");

            Run(() =>
            {
                list5.BubbleSort();
            }, "BubbleSort");

        }
    }
}
