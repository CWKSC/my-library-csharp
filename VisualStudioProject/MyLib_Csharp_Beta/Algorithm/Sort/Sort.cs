using System;
using System.Collections.Generic;
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


    }
}
