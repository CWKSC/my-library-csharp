using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class AdvancedLooping
    {

        public static void FFor<T>(ref T[] variables,
            (Func<T> init, Func<T, bool> condition, Func<T, T> step)[] statements,
            Action<T[]> action)
        {
            bool[] inited = new bool[variables.Length];
            int current = -1;
            while (true)
            {
                current++;
                if (!inited[current])
                {
                    variables[current] = statements[current].init();
                    inited[current] = true;
                }
                while (!statements[current].condition(variables[current]))
                {
                    inited[current] = false;
                    current--;
                    if (current == -1) return;
                    variables[current] = statements[current].step(variables[current]);
                }
                if (current == statements.Length - 1)
                {
                    action(variables);
                    variables[current] = statements[current].step(variables[current]);
                    current--;
                }
            };
        }

        public static IEnumerable<T[]> FFor<T>((Func<T[], T> init, Func<T, bool> condition, Func<T, T> step)[] statements)
        {
            T[] variables = new T[statements.Length];
            bool[] inited = new bool[statements.Length];
            int current = -1;
            while (true)
            {
                current++;
                if (!inited[current])
                {
                    variables[current] = statements[current].init(variables);
                    inited[current] = true;
                }
                while (!statements[current].condition(variables[current]))
                {
                    inited[current] = false;
                    current--;
                    if (current == -1) yield break;
                    variables[current] = statements[current].step(variables[current]);
                }
                if (current == statements.Length - 1)
                {
                    yield return variables;
                    variables[current] = statements[current].step(variables[current]);
                    current--;
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
                int i = refer.Length - 1;
                while (true)
                {
                    if (indexs[i] < refer[i]) break;
                    if (i == 0) return refer;
                    indexs[i] = 0;
                    i--;
                    indexs[i]++;
                }
            };
        }


        public static IEnumerable<int[]> CombinationLoop_iter(this int[] refer) =>
            CallBack.CallBackToIEnumerable<int[]>(action => refer.CombinationLoop(action));






        //// nCr ////

        public static IEnumerable<int[]> NCR(int n, int r)
        {
            bool condition(int i) => i < n;
            static int step(int i) => i + 1;
            var forStatement = new (Func<int[], int> init, Func<int, bool> condition, Func<int, int> step)[r];
            forStatement[0] = (v => 0, condition, step);
            for (int i = 1; i < r; i++)
            {
                int index = i - 1;
                forStatement[i] = (v => v[index] + 1, condition, step);
            }
            return FFor(forStatement);
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


        public static IEnumerable<int[]> NPR(int n, int r)
        {
            IEnumerable<int[]> NCRList = NCR(n, r);
            IEnumerable<int[]> NPermutationList = NPermutation(r);
            foreach (var indexsNCR in NCRList)
            {
                foreach (var indexsNPermutation in NPermutationList)
                {
                    yield return indexsNCR.Select((ele, i) => indexsNCR[indexsNPermutation[i]]).ToArray();
                }
            }
        }

        public static IEnumerable<int[]> NPermutation(int n)
        {
            int[] zeroToN = Enumerable.Range(0, n).ToArray();

            List<int[]> ienumerable = new List<int[]>();
            Next_permutation(zeroToN, 0, n);

            void Next_permutation(int[] indexs, int start, int length)
            {
                if (start == length - 1)
                {
                    ienumerable.Add((int[])indexs.Clone());
                }
                else
                {
                    for (int i = start; i <= length - 1; i++)
                    {
                        int temp = indexs[start];
                        indexs[start] = indexs[i];
                        indexs[i] = temp;
                        Next_permutation(indexs, start + 1, length);
                        temp = indexs[start];
                        indexs[start] = indexs[i];
                        indexs[i] = temp;
                    }
                }
            }

            return ienumerable;
        }




    }
}
