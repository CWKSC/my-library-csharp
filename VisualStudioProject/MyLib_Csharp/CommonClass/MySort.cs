using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MySort
    {
        public static T[] BubbleSort<T>(T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return result;
        }



        public static void Test()
        {
            int[] testArray = MyArray.GenerateRandIntArray(10);

            MyTest.TestExecutionTime(BubbleSort, testArray);

            MyArray.Print(testArray);
        }
    }
}
