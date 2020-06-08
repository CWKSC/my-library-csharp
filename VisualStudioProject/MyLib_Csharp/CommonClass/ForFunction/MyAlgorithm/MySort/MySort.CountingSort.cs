using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public static partial class MyAlgorithm
    {

        /// <summary>[min, max]</summary>
        public static int[] CountingSort(this int[] array, int min, int max)
        {
            int[] result = (int[])array.Clone();
            int[] countArray = new int[max - min + 1];
            int absMin = Math.Abs(min);
            for (int i = 0; i < result.Length; i++)
            {
                ++countArray[result[i] + absMin];
            }

            int j = 0;
            int index = min;
            while (j < result.Length)
            {
                if (countArray[index + absMin] != 0)
                {
                    result[j] = index;
                    --countArray[index + absMin];
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
        /// <summary>[min, max]</summary>
        public static int[] CountingSort_Debug(this int[] array, int min, int max)
        {
            int[] result = (int[])array.Clone();
            int[] countArray = new int[max - min + 1];
            int absMin = Math.Abs(min);
            for (int i = 0; i < result.Length; i++)
            {
                ++countArray[result[i] + absMin];
            }

            int j = 0;
            int index = min;
            while (j < result.Length)
            {
                if (countArray[index + absMin] != 0)
                {
                    result[j] = index;
                    --countArray[index + absMin];
                }
                else
                {
                    ++index;
                    continue;
                }
                ++j;
            }
            result.Println();
            return result;
        }

    }
}
