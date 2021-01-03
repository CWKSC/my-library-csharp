using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib_Csharp_Beta.Algorithm
{
    public static partial class Sort
    {

        public static List<T> SortTwoSortedList<T>(List<T> A, List<T> B) where T : IComparable
        {
            int aLength = A.Count;
            int bLength = B.Count;
            if (aLength == 0) { return new List<T>(B); }
            if (bLength == 0) { return new List<T>(A); }
            List<T> result = new List<T>();
            while (true)
            {
                if (A[0].CompareTo(B[0]) < 0)
                {
                    result.Add(A[0]);
                    A.RemoveAt(0);
                }
                else
                {
                    result.Add(B[0]);
                    B.RemoveAt(0);
                }
                if (A.Count == 0)
                {
                    result.AddRange(B);
                    break;
                }
                else if (B.Count == 0)
                {
                    result.AddRange(A);
                    break;
                }
            }
            return result;
        }



        public static T[] SortNSortedArray<T>(params T[][] arrays) where T : IComparable
        {
            int length = arrays.Aggregate(0, (pre, ele) => pre + ele.Length);
            T[] result = new T[length];
            int[] indexs = arrays.Select((ele, i) => arrays[i].Length).ToArray();
            for (int i = length - 1; i >= 0; i--)
            {
                int k = 0;
                while (indexs[k] == 0) k++;
                int maxIndex = k;
                T max = arrays[k][indexs[k] - 1];
                for (int j = 1; j < arrays.Length; j++)
                {
                    if (indexs[j] == 0) continue;
                    if (arrays[j][indexs[j] - 1].CompareTo(max) > 0)
                    {
                        max = arrays[j][indexs[j] - 1];
                        maxIndex = j;
                    }
                }
                indexs[maxIndex]--;
                result[i] = max;
            }
            return result;
        }



    }
}
