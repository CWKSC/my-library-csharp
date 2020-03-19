using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyArray
    {

        public static int[] GenerateRandIntArray(int n)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(int.MinValue, int.MaxValue);
            }
            return result;
        }
    }
}
