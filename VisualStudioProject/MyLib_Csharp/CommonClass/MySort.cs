using System;
using System.Collections.Generic;
using System.Text;

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
            int[] testArray = MyArray.GenerateRandIntArray(10);

            MyTest.Warmup(() => testArray.BubbleSort());

            ((Func<int[]>)testArray.BubbleSort).TestExecutionTime().Println();
            MyArray.Println(((Func<int[]>)testArray.BubbleSort).TestExecutionTime());
            MyArray.Println(MyTest.TestExecutionTime(testArray.BubbleSort));
            MyArray.Println(MyTest.TestExecutionTime(BubbleSort, testArray));

            Console.WriteLine();

            MyArray.Println(MyTest.TestExecutionTime(BubbleSort, testArray));
            MyArray.Println(MyTest.TestExecutionTime(testArray.BubbleSort));
            MyArray.Println(((Func<int[]>)testArray.BubbleSort).TestExecutionTime());
            ((Func<int[]>)testArray.BubbleSort).TestExecutionTime().Println();

            Console.WriteLine();


            ((Func<int[]>)testArray.BubbleSort).TestExecutionTime(100);

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                MyTest.TestExecutionTime(testArray.BubbleSort);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                MyTest.TestExecutionTime(BubbleSort, testArray);
            }

            MyArray.Println(MyTest.TestExecutionTime(testArray.SelectionSort));
            MyArray.Println(MyTest.TestExecutionTime(SelectionSort, testArray));

        }
    }
}
