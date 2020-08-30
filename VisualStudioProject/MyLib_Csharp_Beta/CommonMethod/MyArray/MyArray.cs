using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyArray
    {



        /// <summary>[min, max)</summary>
        public static int[] GenerateRandIntArray(int n, int min = int.MinValue, int max = int.MaxValue)
        {
            int[] result = new int[n];
            Random random = new Random();
            return result.Map((_, __) => random.Next(min, max));
        }

        /// <summary>[min, max)</summary>
        public static int[,] GenerateRandInt2dArray(int row, int col, int min = int.MinValue, int max = int.MaxValue)
        {
            int[,] result = new int[row, col];
            Random random = new Random();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    result[i, j] = random.Next(min, max);
            return result;
        }



    }
}
