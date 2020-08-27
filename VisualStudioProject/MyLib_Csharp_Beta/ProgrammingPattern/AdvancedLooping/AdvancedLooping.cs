using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class AdvancedLooping
    {


        public static int[] CombinationLoop(this int[] refer, Action<int[]> action)
        {
            int[] indexs = new int[refer.Length];
            while (true)
            {
                action(indexs);
#pragma warning disable IDE0056 // 使用索引運算子 // for version < C# 8
                indexs[indexs.Length - 1]++;
#pragma warning restore IDE0056 // 使用索引運算子
                for (int i = refer.Length - 1; i >= 0; i--)
                {
                    if (indexs[i] < refer[i]) break;
                    if (i == 0) return refer;
                    indexs[i] = 0;
                    indexs[i - 1]++;
                }
            };
        }


        public static int Loop_nC2<T>(this T[] array, Action<T, T> action) =>
            array.Length.Loop(i =>
                (i + 1, array.Length - 1).Loop(j =>
                    action(array[i], array[j])));
        public static int Loop_nC3<T>(this T[] array, Action<T, T, T> action) =>
            array.Length.Loop(i =>
                (i + 1, array.Length - 1).Loop(j =>
                    (j + 1, array.Length - 1).Loop(k =>
                        action(array[i], array[j], array[k]))));
        public static int Loop_nC4<T>(this T[] array, Action<T, T, T, T> action) =>
            array.Length.Loop(i =>
                (i + 1, array.Length - 1).Loop(j =>
                    (j + 1, array.Length - 1).Loop(k =>
                        (k + 1, array.Length - 1).Loop(l => 
                            action(array[i], array[j], array[k], array[l])))));

        public static void Loop_nCr<T>(this T[] array, int r, Action<T[]> action)
        {
            // OWO
        }

        public static T[] Loop_nP2<T>(this T[] array, Action<T, T> action) =>
            array.Loop((ele1, _) => 
                array.Loop((ele2, __) => 
                    action(ele1, ele2)));

        public static T[] Loop_nP3<T>(this T[] array, Action<T, T, T> action) =>
            array.Loop((ele1, _) =>
                array.Loop((ele2, __) =>
                    array.Loop((ele3, ___) => 
                        action(ele1, ele2, ele3))));

        public static void Loop_nPr<T>(this T[] array, int r, Action<T[]> action)
        {
            // QWQ 
        }


    }
}
