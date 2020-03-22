using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MySort
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T[] BubbleSort<T>(T[] array) where T : IComparable
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

        public static T[] SelectionSort<T>(T[] array) where T : IComparable
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
            int[] testArray = MyArray.GenerateRandIntArray(10);

            MyArray.Println(testArray);
            MyArray.Println(MyTest.TestExecutionTime(BubbleSort, testArray));
            MyArray.Println(MyTest.TestExecutionTime(SelectionSort, testArray));

        }
    }
}
