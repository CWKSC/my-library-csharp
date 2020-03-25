using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
                for (int j = 1; j < result.Length - i; j++)
                {
                    if (result[j - 1].CompareTo(result[j]) > 0)
                    {
                        Swap(ref result[j - 1], ref result[j]);
                    }
                }
            }
            return result;
        }
        public static T[] BubbleSort_Debug<T>(this T[] array) where T : IComparable
        {
            int ifCount = 0, swapCount = 0;
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 1; j < result.Length - i; j++)
                {
                    MyArray.Println(result, Color.LightGreen, j - 1, j);
                    ifCount++;
                    if (result[j - 1].CompareTo(result[j]) > 0)
                    {
                        MyArray.Println(result, Color.Yellow, j - 1, j);
                        Swap(ref result[j - 1], ref result[j]);
                        MyArray.Println(result, Color.Red, j - 1, j);
                        swapCount++;
                    }
                }
            }
            Console.WriteLine("Check condition (Green) times: " + ifCount + ", Swap (Red) times: " + swapCount);
            return result;
        }


        public static T[] SelectionSort<T>(this T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < result.Length - i ; j++)
                {
                    if(result[j].CompareTo(result[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }
                Swap(ref result[maxIndex], ref result[result.Length - 1 - i]);
            }
            return result;
        }

        public static T[] SelectionSort_Debug<T>(this T[] array) where T : IComparable
        {
            int ifCount = 0, swapCount = 0;
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < result.Length - i; j++)
                {
                    MyArray.Println(result, Color.LightGreen, j, maxIndex);
                    ifCount++;
                    if (result[j].CompareTo(result[maxIndex]) > 0)
                    {
                        MyArray.Println(result, Color.Yellow, j, maxIndex);
                        maxIndex = j;
                    }
                }
                Swap(ref result[maxIndex], ref result[result.Length - 1 - i]);
                MyArray.Println(result, Color.Red, maxIndex, result.Length - 1 - i);
                swapCount++;
            }
            Console.WriteLine("Check condition (Green) times: " + ifCount + ", Swap (Red) times: " + swapCount);
            return result;
        }

        /// <summary>[min, max]</summary>
        public static int[] CountingSort(this int[] array, int min, int max)
        {
            int[] result = (int[])array.Clone();
            int[] countArray = new int[max - min + 1];
            int absMin = Math.Abs(min);
            for(int i = 0; i < result.Length; i++)
            {
                ++countArray[result[i] + absMin];
            }

            int j = 0;
            int index = min;
            while (j < result.Length)
            {
                if (countArray[index - absMin] != 0)
                {
                    result[j] = index;
                    --countArray[index - absMin];
                }
                else
                {
                    ++index;
                    continue;
                }
                ++j;
            }
            return result;
        }

        public static void PrintIsSorted_ascending<T>(this T[] array) where T : IComparable
        {
            if (IsSorted_ascending(array))
            {
                Console.WriteLine("Sorted (ascending)");
            }
            else
            {
                Console.WriteLine("Unsorted (ascending)");
            }
        }
        public static bool IsSorted_ascending<T>(this T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) == 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Test()
        {
            const int dataLength = 10;
            const int dataMin = 0;
            const int dataMax = 1000;
            int[] allRangeIntArray = MyArray.GenerateRandIntArray(dataLength);
            int[] inRangeIntArray = MyArray.GenerateRandIntArray(dataLength, dataMin, dataMax);

            MyTest.SetProcessPriority();
            MyTest.Warmup(allRangeIntArray.BubbleSort);

            // Sort Sample //
            //MyTest.TestExecutionTime(allRangeIntArray.BubbleSort).PrintIsSorted();
            //MyTest.TestExecutionTime(BubbleSort, allRangeIntArray).PrintIsSorted();
            //((Func<int[]>)allRangeIntArray.BubbleSort).TestExecutionTime().PrintIsSorted();

            // BubbleSort //
            MyTest.TestExecutionTime(BubbleSort_Debug, allRangeIntArray).PrintIsSorted_ascending();
            MyTest.TestExecutionTime(BubbleSort_Debug, inRangeIntArray).PrintIsSorted_ascending();
            Console.WriteLine();

            // SelectionSort //
            MyTest.TestExecutionTime(SelectionSort_Debug, allRangeIntArray).PrintIsSorted_ascending();
            MyTest.TestExecutionTime(SelectionSort_Debug, inRangeIntArray).PrintIsSorted_ascending();
            Console.WriteLine();

            // CountingSort //
            MyTest.TestExecutionTime(CountingSort, inRangeIntArray, dataMin, dataMax).PrintIsSorted_ascending();

        }
    }
}
