using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyArray
    {


        public static T[][] ToJagged<T>(this T[,] rectArray)
        {
            int row = rectArray.GetLength(0);
            int col = rectArray.GetLength(1);
            T[][] jaggedArray = new T[row][];
            jaggedArray.Map((ele, i) => ele = new T[col]);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    jaggedArray[i][j] = rectArray[i, j];
            return jaggedArray;
        }


        /// <summary>[min, max)</summary>
        public static int[] GenerateRandIntArray(int n, int min = int.MinValue, int max = int.MaxValue)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                result[i] = random.Next(min, max);
            return result;
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
