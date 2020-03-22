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
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length - 1; j++)
                {
                    if (result[j].CompareTo(result[j + 1]) == 1)
                    {
                        T temp = result[j + 1];
                        result[j + 1] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }

        public static void A(float[] a)
        {

        }


        public static void Test()
        {
            int[] testArray = MyArray.GenerateRandIntArray(10);

            MyArray.Println(testArray);
            MyArray.Print(MyTest.TestExecutionTime(BubbleSort, testArray));
            
        }
    }
}
