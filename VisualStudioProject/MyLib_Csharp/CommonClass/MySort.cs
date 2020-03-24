using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MyLib_Csharp.CommonClass
{
    public static class MySort
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T[] BubbleSort<T>(this T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j].CompareTo(result[j+1]) > 0)
                    {
                        Swap(ref result[j], ref result[j + 1]);
                    }
                }
            }
            return result;
        }

        public static T[] SelectionSort<T>(this T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < array.Length - i; j++)
                {
                    if(result[j].CompareTo(array[maxIndex]) == 1)
                    {
                        maxIndex = j;
                    }
                }
                Swap(ref result[maxIndex], ref result[array.Length - 1 - i]);
            }
            return result;
        }


        public static void Test()
        {
            int[] testArray = MyArray.GenerateRandIntArray(10000);

            MyTest.SetProcessPriority();
            MyTest.Warmup(testArray.BubbleSort);

            // BubbleSort //
            ((Func<int[]>)testArray.BubbleSort).TestExecutionTime();
            Console.WriteLine();

            MyTest.TestExecutionTime(testArray.BubbleSort);
            Console.WriteLine();

            MyTest.TestExecutionTime(BubbleSort, testArray);
            Console.WriteLine();

            // SelectionSort //
            ((Func<int[]>)testArray.SelectionSort).TestExecutionTime();
            Console.WriteLine();

            MyTest.TestExecutionTime(testArray.SelectionSort);
            Console.WriteLine();

            MyTest.TestExecutionTime(SelectionSort, testArray);
            Console.WriteLine();


        }
    }
}
