using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class AdvancedLooping
    {


        public static void FFor(
            (dynamic variable, Func<dynamic, bool> condition, Func<dynamic, dynamic> step)[] statements,
            Action<dynamic[]> action)
        {
            dynamic[] result = new dynamic[statements.Length];
            for (int i = 0; i < statements.Length; i++)
            {
                result[i] = statements[i].variable;
            }
            while (true)
            {
                action(result);
                result[^1] = statements[^1].step(result[^1]);
                for (int i = statements.Length - 1; i >= 0; i--)
                {
                    if (statements[i].condition(result[i])) break;
                    if (i == 0) return;
                    result[i] = statements[i].variable;
                    result[i - 1] = statements[i - 1].step(result[i - 1]);
                }
            };
        }


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


        public static IEnumerable<int[]> CombinationLoop_iter(this int[] refer) =>
            CallBack.CallBackToIEnumerable<int[]>(action => refer.CombinationLoop(action));



        //// nCr ////

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



        // it not nCr, it is sum of nCr
        [Obsolete]
        public static T[] Loop_nCr<T>(this T[] array, int r, Action<T[]> action)
        {
            (1, array.Length).Loop(nn =>
                r.ToRepeatArray(nn).CombinationLoop(i_s =>
                    action(Builder.BuildArray<T>(i_s.Length, ele =>
                        i_s.Loop(i => ele[i] = array[i])
                    ))
                )
            );
            return array;
        }

        // Sum of nCr //
        public static void Loop_nCr_Sum(this int n, int r, Action<int[]> action)
        {
            (1, r).Loop(nn => 
                n.ToRepeatArray(nn).CombinationLoop(action));
        }



        //// nPr ////

        public static T[] Loop_nP2<T>(this T[] array, Action<T, T> action) =>
            array.Loop((ele1, _) => 
                array.Loop((ele2, __) => 
                    action(ele1, ele2)));

        public static T[] Loop_nP3<T>(this T[] array, Action<T, T, T> action) =>
            array.Loop((ele1, _) =>
                array.Loop((ele2, __) =>
                    array.Loop((ele3, ___) => 
                        action(ele1, ele2, ele3))));

        [Obsolete]
        public static void Loop_nPr_loop<T>(this T[] array, T[] result, List<T> list, int r)
        {
            array.Loop((ele, _) =>
            {
                list.Add(ele);
                if (r == 0)
                {
                    result = list.ToArray();
                    list.Clear();
                    return;
                }
                Loop_nPr_loop(array, result, list, r - 1);
            });
        }

        [Obsolete]
        public static void Loop_nPr<T>(this T[] array, int r, Action<T[]> action)
        {
            List<T> list = new List<T>();
            T[] result = new T[r];
            array.Loop((ele, _) =>
            {
                array.Loop_nPr_loop(result, list, r);
                action(result);
            });
            // QWQ 
        }


    }
}
